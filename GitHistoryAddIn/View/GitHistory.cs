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

        public string SourceCodePath { get; set; }

        public GitHistory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GitClient client = new GitClient();

            if (_projectBinding == null)
            {
                ProjectBindingForm bindingForm = new ProjectBindingForm();
                bindingForm.ShowDialog();

                _projectBinding = bindingForm.ProjectBinding;
            }

            if (_projectBinding != null)
            {
                client.GetCommits(_projectBinding.GitUsername, _projectBinding.GitPassword, _projectBinding.ProjectName, SourceCodePath, OnCommitsReturned);
            }
        }

        public void LoadHistory()
        {
            GitClient client = new GitClient();
            client.GetCommits(_projectBinding.GitUsername, _projectBinding.GitPassword, _projectBinding.ProjectName, SourceCodePath, OnCommitsReturned);
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
