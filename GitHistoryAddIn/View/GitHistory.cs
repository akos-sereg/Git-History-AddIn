using ContributionGraph.Model;
using GitHistoryAddIn.Controller;
using GitHistoryAddIn.Model;
using GitHubSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHistoryAddIn.View
{
    public partial class GitHistory : UserControl
    {
        public delegate void ProcessCommits(List<CommitModel> commits);

        public GitProjectBinding _projectBinding;

        public BindingStore _bindingStore = new BindingStore();

        private string _solutionName;
        public string SolutionName {
            get
            {
                return this._solutionName;
            }
            set
            {
                this._solutionName = value;
                this.AutoBind();
            }
        }

        private GitItem _selectedGitItem;
        public GitItem SelectedGitItem
        {
            get
            {
                return _selectedGitItem;
            }
            set
            {
                this._selectedGitItem = value;

                if (_selectedGitItem != null)
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(Properties.Resources));
                    if (_selectedGitItem.Type == GitItem.GitItemType.SourceCode)
                    {
                        this.gitItemIcon.Image = ((System.Drawing.Image)(resources.GetObject("SourceIcon")));
                    }
                    else if (_selectedGitItem.Type == GitItem.GitItemType.Project)
                    {
                        this.gitItemIcon.Image = ((System.Drawing.Image)(resources.GetObject("ProjectIcon")));
                    }
                    else if (_selectedGitItem.Type == GitItem.GitItemType.Folder)
                    {
                        this.gitItemIcon.Image = ((System.Drawing.Image)(resources.GetObject("FolderIcon")));
                    }
                }
            }
        }

        public GitHistory()
        {
            InitializeComponent();

            this.calendarView1.OnContributionSelected += (contrib) => { 
                this.commitsComboBox.Items.Clear();
                if (contrib != null && contrib.Commits != null)
                {
                    this.commitsComboBox.Items.AddRange(contrib.Commits.ToArray());

                    if (this.commitsComboBox.Items.Count > 0)
                    {
                        this.commitsComboBox.SelectedIndex = 0;
                    }

                    this.commitsLabel.Text = string.Format("Commits ({0})", contrib.Commits.Count);
                }
            };
        }

        public void LoadHistory()
        {
            if (_projectBinding == null || !_projectBinding.IsValid)
            {
                this.fileNameLabel.ForeColor = Color.DarkRed;
                this.fileNameLabel.Text = "Project Binding is not set";
                return;
            }

            if (this.SelectedGitItem != null && !string.IsNullOrEmpty(this.SelectedGitItem.Path))
            {
                new GitClient().GetCommits(_projectBinding, this.SelectedGitItem.Path, OnCommitsReturned);
            }
        }

        public void OnCommitsReturned(List<CommitModel> commits)
        {
            ContributionList data = new ContributionList();

            commits.ForEach(x =>  { 
                data.Add(new Commit {
                    Date = DateTime.Parse(x.Commit.Committer.Date.ToString("yyyy-MM-dd HH:mm:ss")), 
                    Author = x.Committer.Login, 
                    Title = x.Commit.Message,
                    AvatarUrl = x.Committer.AvatarUrl
                });
            });

            this.calendarView1.DataSource = data;
            this.fileNameLabel.Text = this.SelectedGitItem.Path;
            this.fileNameLabel.ForeColor = Color.Black;

            // Reset Commit details
            this.commitsComboBox.Items.Clear();
            this.authorLabel.Text = string.Empty;
            this.dateLabel.Text = string.Empty;
            this.titleTextArea.Text = string.Empty;
            this.avatarImage.Image = null;
            this.commitsLabel.Text = "Commits";
        }

        public void AutoBind()
        {
            if (this._projectBinding != null && this._projectBinding.IsValid)
            {
                // Auto binding already complete
                return;
            }

            List<GitProjectBinding> binding = this._bindingStore.GetBindings();
            GitProjectBinding matchingBinding = binding.FirstOrDefault(x => x.Solution == this.SolutionName);

            if (matchingBinding != null)
            {
                this._projectBinding = matchingBinding;

                this.fileNameLabel.ForeColor = Color.Black;
                this.fileNameLabel.Text = string.Format("Auto-bind to Git Project {0}", matchingBinding.ProjectName);
            }
            else
            {
                this.fileNameLabel.ForeColor = Color.DarkRed;
                this.fileNameLabel.Text = "Could not auto-bind solution: " + (this.SolutionName == null ? "Unknown Solution" : this.SolutionName);
            }
        }

        private void gitProjectBindingLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this._projectBinding == null)
            {
                this._projectBinding = new GitProjectBinding();
            }

            if (string.IsNullOrEmpty(this._projectBinding.Solution))
            {
                this._projectBinding.Solution = this.SolutionName;
            }

            ProjectBindingForm bindingForm = new ProjectBindingForm(this._projectBinding, this._bindingStore);
            bindingForm.ShowDialog();

            _projectBinding = bindingForm.ProjectBinding;

            LoadHistory();
        }

        private void commitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Commit selectedCommit = null;
            if (this.commitsComboBox.SelectedItem != null)
            {
                selectedCommit = (Commit)this.commitsComboBox.SelectedItem;
            }

            if (selectedCommit == null)
            {
                return;
            }

            this.authorLabel.Text = selectedCommit.Author;
            this.dateLabel.Text = selectedCommit.Date.ToString("yyyy-MM-dd HH:mm:ss");
            this.titleTextArea.Text = selectedCommit.Title;
            this.avatarImage.Load(selectedCommit.AvatarUrl);
        }
    }
}
