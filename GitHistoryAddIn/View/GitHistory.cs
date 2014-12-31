using ContributionGraph.Model;
using GitHistoryAddIn.Controller;
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
    public partial class GitHistory : Form
    {
        public delegate void ProcessCommits(List<CommitModel> commits);

        private string _projectName;

        public GitHistory(string projectName)
        {
            this._projectName = projectName;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GitClient client = new GitClient();
            client.GetCommits(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, OnCommitsReturned);
        }

        public void OnCommitsReturned(List<CommitModel> commits)
        {
            ContributionList data = new ContributionList();

            commits.ForEach(x =>  { 
                data.Add(new ContributionItem { Date = DateTime.Parse(x.Commit.Committer.Date.ToString("yyyy-MM-dd")), ContributionCount = 1, Subject = x.Commit.Message });
            });

            this.calendarView1.DataSource = data;
        }
    }
}
