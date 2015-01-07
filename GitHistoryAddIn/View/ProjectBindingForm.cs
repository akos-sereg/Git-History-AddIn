using GitHistoryAddIn.Controller;
using GitHistoryAddIn.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GitHistoryAddIn.View
{
    public partial class ProjectBindingForm : Form
    {
        #region Fields

        private GitProjectBinding _originalBinding;

        private GitProjectBinding _projectBinding;

        private BindingStore _bindingStore;

        #endregion

        #region Properties

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
                    this.gitProjectAuthor.Text = _projectBinding.ProjectAuthor;
                    this.gitProjectName.Text = _projectBinding.ProjectName;
                    this.solutionTextBox.Text = _projectBinding.Solution;
                }
            }
        }

        #endregion

        #region Constructors

        public ProjectBindingForm(GitProjectBinding projectBinding, BindingStore bindingStore)
        {
            this._bindingStore = bindingStore;
            this._originalBinding = projectBinding;

            if (projectBinding == null)
            {
                throw new ArgumentException("Project Binding instance can not be null");
            }

            InitializeComponent();
            PopulateExistingBindings();
        }

        #endregion

        #region Initialize

        private void PopulateExistingBindings()
        {
            List<GitProjectBinding> bindings = _bindingStore.GetBindings();

            this.existingBindings.Rows.Clear();

            bindings.ForEach(x => {
                this.existingBindings.Rows.Add(x.GitUsername, x.GitPassword, x.ProjectAuthor, x.ProjectName, x.Solution);
            });
        }

        #endregion

        #region UI Events
        
        private void okButton_Click(object sender, EventArgs e)
        {
            ProjectBinding.GitUsername = gitUsername.Text;
            ProjectBinding.GitPassword = gitPassword.Text;
            ProjectBinding.ProjectAuthor = gitProjectAuthor.Text;
            ProjectBinding.ProjectName = gitProjectName.Text;
            ProjectBinding.Solution = solutionTextBox.Text;

            if (ProjectBinding.IsValid)
            {
                _bindingStore.Store(ProjectBinding);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void existingBindings_SelectionChanged(object sender, EventArgs e)
        {
            GitProjectBinding selectedBinding = this.GetSelectedBinding();

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

        private void ProjectBindingForm_Load(object sender, EventArgs e)
        {
            ProjectBinding = this._originalBinding;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GitProjectBinding selectedBinding = this.GetSelectedBinding();

            if (selectedBinding != null)
            {
                this._bindingStore.Remove(selectedBinding);
                MessageBox.Show(string.Format("Binding for solution {0} has been removed", selectedBinding.Solution), "Remove Binding", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.PopulateExistingBindings();
            }
            else
            {
                MessageBox.Show("There is no binding selected", "Remove Binding", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateTestFilepath()
        {
            testFilePathLabel.Text = string.Format("http://github.com/{0}/{1}/{2}.sln", this.gitProjectAuthor.Text, this.gitProjectName.Text, this.solutionTextBox.Text);
        }

        private void gitProjectAuthor_TextChanged(object sender, EventArgs e)
        {
            UpdateTestFilepath();
        }

        private void gitProjectName_TextChanged(object sender, EventArgs e)
        {
            UpdateTestFilepath();
        }

        private void solutionTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTestFilepath();
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Get selected binding from Grid
        /// </summary>
        private GitProjectBinding GetSelectedBinding()
        {
            GitProjectBinding selectedBinding = null;
            if (this.existingBindings.SelectedRows != null && this.existingBindings.SelectedRows.Count == 1)
            {
                selectedBinding = new GitProjectBinding
                {
                    GitUsername = (string)this.existingBindings.SelectedRows[0].Cells[0].Value,
                    GitPassword = (string)this.existingBindings.SelectedRows[0].Cells[1].Value,
                    ProjectAuthor = (string)this.existingBindings.SelectedRows[0].Cells[2].Value,
                    ProjectName = (string)this.existingBindings.SelectedRows[0].Cells[3].Value,
                    Solution = (string)this.existingBindings.SelectedRows[0].Cells[4].Value
                };
            }

            return selectedBinding;
        }

        #endregion
    }
}
