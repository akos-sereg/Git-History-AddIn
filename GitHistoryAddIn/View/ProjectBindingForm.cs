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
        public GitProjectBinding ProjectBinding;

        public ProjectBindingForm()
        {
            InitializeComponent();
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
