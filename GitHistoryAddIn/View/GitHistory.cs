using ContributionGraph.Model;
using GitHistoryAddIn.Controller;
using GitHistoryAddIn.Model;
using GitHubSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private string _sourceCodePath;
        public string SourceCodePath
        {
            get
            {
                return _sourceCodePath;
            }
            set
            {
                _sourceCodePath = value;
                this.fileNameLabel.Text = _sourceCodePath;
            }
        }

        public GitHistory()
        {
            InitializeComponent();
        }

        public void LoadHistory()
        {
            if (_projectBinding == null)
            {
                ProjectBindingForm bindingForm = new ProjectBindingForm();
                bindingForm.ShowDialog();

                _projectBinding = bindingForm.ProjectBinding;
            }

            if (_projectBinding != null)
            {
                new GitClient().GetCommits(_projectBinding.GitUsername, _projectBinding.GitPassword, _projectBinding.ProjectName, SourceCodePath, OnCommitsReturned);
            }
        }

        public void OnCommitsReturned(List<CommitModel> commits)
        {
            ContributionList data = new ContributionList();

            commits.ForEach(x =>  { 
                data.Add(new ContributionItem { Date = DateTime.Parse(x.Commit.Committer.Date.ToString("yyyy-MM-dd")), ContributionCount = 1, Subject = x.Commit.Message });
            });

            this.calendarView1.DataSource = data;
        }

        private void gitProjectBindingLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProjectBindingForm bindingForm = new ProjectBindingForm();
            bindingForm.ShowDialog();

            _projectBinding = bindingForm.ProjectBinding;
        }
    }
}
