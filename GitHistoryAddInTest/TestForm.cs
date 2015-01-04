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

namespace GitHistoryAddInTest
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.gitHistory1.SelectedGitItem = new GitItem { Path = textBox1.Text, Type = GitItem.GitItemType.SourceCode };
            this.gitHistory1.LoadHistory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gitHistory1.SolutionName = solutionName.Text;
        }
    }
}
