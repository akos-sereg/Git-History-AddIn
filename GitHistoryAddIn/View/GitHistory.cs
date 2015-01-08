using ContributionGraph.Model;
using GitHistoryAddIn.Controller;
using GitHistoryAddIn.Model;
using Octokit;
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

        #region Properties

        public bool RefreshOnWindowActivation
        {
            get
            {
                return this.refreshOnWindowActivation.Checked;
            }
        }

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

        #endregion

        #region Constructors

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

        #endregion

        #region Feature - Load History

        public delegate void ProcessCommits(IReadOnlyList<GitHubCommit> commits);

        public delegate void ProcessCommitsError(Exception error);

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
                new GitClient(_projectBinding).GetCommits(this.SelectedGitItem.Path, this.OnCommitsReturned, this.OnCommitsFetchingError);
            }
        }

        public void OnCommitsReturned(IReadOnlyList<GitHubCommit> commits)
        {
            ContributionList data = new ContributionList();

            commits.ToList().ForEach(x =>  {
                data.Add(new ContributionGraph.Model.Commit
                {
                    Date = DateTime.Parse(x.Commit.Committer.Date.ToString("yyyy-MM-dd HH:mm:ss")),
                    Author = x.Committer.Login,
                    Title = x.Commit.Message,
                    AvatarUrl = x.Committer.AvatarUrl,
                    Sha = x.Sha
                });
            });

            this.calendarView1.DataSource = data;
            this.fileNameLabel.Text = this.SelectedGitItem.Path;
            this.fileNameLabel.ForeColor = Color.Black;

            // Reset Commit details
            this.commitsComboBox.Items.Clear();
            this.authorLabel.Text = string.Empty;
            this.dateLabel.Text = string.Empty;
            this.avatarImage.Image = null;
            this.commitsLabel.Text = "Commits";
            this.fileList.Items.Clear();
        }

        public void OnCommitsFetchingError(Exception error)
        {
            MessageBox.Show(string.Format("Commits could not be fetched from GitHub: {0}", error.Message), "Commit Fetching error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Feature - Binding
        
        public delegate void BindingValidationComplete(bool bindingIsValid, string testPath, GitProjectBinding binding);

        public delegate void BindingValidationError(Exception error);

        public BindingStore _bindingStore = new BindingStore();

        public GitProjectBinding _projectBinding;

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

            if (bindingForm.ProjectBinding != null)
            {
                if (!bindingForm.ProjectBinding.IsValid)
                {
                    MessageBox.Show("All GitHub parameters (user, password, author, project) should be provided, as well as local solution name", 
                        "Invalid Binding", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    new GitClient(bindingForm.ProjectBinding).ValidateBinding(this.OnBindingValidationComplete, this.OnBindingValidationError);
                }
            }
        }

        private void OnBindingValidationComplete(bool isBindingValid, string testPath, GitProjectBinding binding)
        {
            if (isBindingValid)
            {
                this._projectBinding = binding;
                this._bindingStore.Store(binding, true); // We know for sure that this solution binding works, force saving.
                this.LoadHistory();
            }
            else
            {
                if (MessageBox.Show(string.Format("Git project binding does not seem to be correct, {0} file is not available "
                    + "in {1}'s repository {2}. Do you want to use the binding anyway?", testPath, binding.ProjectAuthor, binding.ProjectName), 
                    "Binding Validation",
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    this._projectBinding = binding;
                    this.LoadHistory();
                }
            }
        }

        private void OnBindingValidationError(Exception error)
        {
            MessageBox.Show(string.Format("Binding validation error: {0}", error.Message), "Binding Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Feature - Load Commit

        public delegate void GetCommitReturned(GitHubCommit commit);

        public delegate void GetCommitError(Exception error);

        private void LoadCommit(string commitSha)
        {
            new GitClient(this._projectBinding).GetCommit(commitSha,
                // On success
                commit => {
                    this.fileList.Items.Clear();
                    commit.Files.ToList().ForEach(file => this.fileList.Items.Add(file.Filename));

                    this.additionCountLabel.Text = string.Format("+{0}", commit.Files.Sum(file => file.Additions));
                    this.deletionCountLabel.Text = string.Format("-{0}", commit.Files.Sum(file => file.Deletions));
                    this.changeCountLabel.Text = Convert.ToString(commit.Files.Sum(file => file.Changes));
                },
                // On error
                error => {
                    MessageBox.Show(string.Format("Error occured while loading commit details: {0}", error.Message), "Loading commit details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                });
        }

        #endregion

        #region UI Event Handlers

        private void commitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContributionGraph.Model.Commit selectedCommit = null;
            if (this.commitsComboBox.SelectedItem != null)
            {
                selectedCommit = (ContributionGraph.Model.Commit)this.commitsComboBox.SelectedItem;
            }

            if (selectedCommit == null)
            {
                return;
            }

            this.authorLabel.Text = selectedCommit.Author;
            this.dateLabel.Text = selectedCommit.Date.ToString("yyyy-MM-dd HH:mm:ss");
            this.avatarImage.Load(selectedCommit.AvatarUrl);

            LoadCommit(selectedCommit.Sha);
        }

        #endregion
    }
}
