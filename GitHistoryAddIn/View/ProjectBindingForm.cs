using GitHistoryAddIn.Controller;
using GitHistoryAddIn.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GitHistoryAddIn.View
{
    public partial class ProjectBindingForm : Form
    {
        private GitProjectBinding _projectBinding;

        private BindingStore _bindingStore;

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
                    this.solutionTextBox.Text = _projectBinding.Solution;
                }
            }
        }

        public ProjectBindingForm(GitProjectBinding projectBinding, BindingStore bindingStore)
        {
            this._bindingStore = bindingStore;

            if (projectBinding == null)
            {
                throw new ArgumentException("Project Binding instance can not be null");
            }

            InitializeComponent();

            ProjectBinding = projectBinding;

            PopulateExistingBindings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectBinding.GitUsername = gitUsername.Text;
            ProjectBinding.GitPassword = gitPassword.Text;
            ProjectBinding.ProjectName = gitProjectName.Text;
            ProjectBinding.Solution = solutionTextBox.Text;

            if (ProjectBinding.IsValid)
            {
                _bindingStore.Store(ProjectBinding);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void PopulateExistingBindings()
        {
            List<GitProjectBinding> bindings = _bindingStore.GetBindings();

            this.existingBindings.Rows.Clear();

            bindings.ForEach(x => {
                this.existingBindings.Rows.Add(x.GitUsername, x.GitPassword, x.ProjectName, x.Solution);
            });
        }

        private void existingBindings_SelectionChanged(object sender, EventArgs e)
        {
            GitProjectBinding selectedBinding = null;
            if (this.existingBindings.SelectedRows != null && this.existingBindings.SelectedRows.Count == 1)
            {
                selectedBinding = new GitProjectBinding { 
                    GitUsername = (string)this.existingBindings.SelectedRows[0].Cells[0].Value,
                    GitPassword = (string)this.existingBindings.SelectedRows[0].Cells[1].Value,
                    ProjectName = (string)this.existingBindings.SelectedRows[0].Cells[2].Value,
                    Solution = (string)this.existingBindings.SelectedRows[0].Cells[3].Value
                };
            }

            if (selectedBinding != null)
            {
                this.ProjectBinding = selectedBinding;
            }
        }

        private void ProjectBindingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            this.ProjectBinding = null;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
