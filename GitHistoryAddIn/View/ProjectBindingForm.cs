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
                    this.solutionLabel.Text = _projectBinding.Solution;
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

            if (ProjectBinding.IsValid)
            {
                _bindingStore.Store(ProjectBinding);
            }

            this.Close();
        }

        private void PopulateExistingBindings()
        {
            List<GitProjectBinding> bindings = _bindingStore.GetBindings();

            this.existingBindings.Rows.Clear();

            bindings.ForEach(x => {
                this.existingBindings.Rows.Add(x.GitUsername, x.ProjectName, x.Solution);
            });
        }
    }
}
