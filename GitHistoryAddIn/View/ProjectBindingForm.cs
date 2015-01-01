using GitHistoryAddIn.Model;
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
    public partial class ProjectBindingForm : Form
    {
        private GitProjectBinding _projectBinding;
        public GitProjectBinding ProjectBinding
        {
            get
            {
                return _projectBinding;
            }
            set
            {
                _projectBinding = value;
                if (_projectBinding != null) 
                {
                    this.gitUsername.Text = _projectBinding.GitUsername;
                    this.gitPassword.Text = _projectBinding.GitPassword;
                    this.gitProjectName.Text = _projectBinding.ProjectName;
                }
            }
        }

        public ProjectBindingForm(GitProjectBinding projectBinding)
        {
            InitializeComponent();

            ProjectBinding = projectBinding;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectBinding = new GitProjectBinding { 
                GitUsername = gitUsername.Text, 
                GitPassword = gitPassword.Text, 
                ProjectName = gitProjectName.Text };

            this.Close();
        }
    }
}
