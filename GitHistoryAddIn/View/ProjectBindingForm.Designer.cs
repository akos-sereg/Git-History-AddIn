namespace GitHistoryAddIn.View
{
    partial class ProjectBindingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gitProjectAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gitPassword = new System.Windows.Forms.TextBox();
            this.gitUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gitProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.existingBindings = new System.Windows.Forms.DataGridView();
            this.gridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.solutionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.testFilePathLabel = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectAuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingBindings)).BeginInit();
            this.gridContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gitProjectAuthor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gitPassword);
            this.groupBox1.Controls.Add(this.gitUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gitProjectName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Git";
            // 
            // gitProjectAuthor
            // 
            this.gitProjectAuthor.Location = new System.Drawing.Point(96, 74);
            this.gitProjectAuthor.Name = "gitProjectAuthor";
            this.gitProjectAuthor.Size = new System.Drawing.Size(163, 20);
            this.gitProjectAuthor.TabIndex = 4;
            this.gitProjectAuthor.TextChanged += new System.EventHandler(this.gitProjectAuthor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Project Author";
            // 
            // gitPassword
            // 
            this.gitPassword.Location = new System.Drawing.Point(96, 48);
            this.gitPassword.Name = "gitPassword";
            this.gitPassword.PasswordChar = '*';
            this.gitPassword.Size = new System.Drawing.Size(163, 20);
            this.gitPassword.TabIndex = 3;
            // 
            // gitUsername
            // 
            this.gitUsername.Location = new System.Drawing.Point(96, 24);
            this.gitUsername.Name = "gitUsername";
            this.gitUsername.Size = new System.Drawing.Size(163, 20);
            this.gitUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // gitProjectName
            // 
            this.gitProjectName.Location = new System.Drawing.Point(96, 99);
            this.gitProjectName.Name = "gitProjectName";
            this.gitProjectName.Size = new System.Drawing.Size(163, 20);
            this.gitProjectName.TabIndex = 5;
            this.gitProjectName.TextChanged += new System.EventHandler(this.gitProjectName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Project Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(223, 156);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // existingBindings
            // 
            this.existingBindings.AllowUserToAddRows = false;
            this.existingBindings.AllowUserToDeleteRows = false;
            this.existingBindings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.existingBindings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.existingBindings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.projectAuthorColumn,
            this.Column1,
            this.Column2});
            this.existingBindings.ContextMenuStrip = this.gridContextMenu;
            this.existingBindings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.existingBindings.Location = new System.Drawing.Point(317, 12);
            this.existingBindings.Name = "existingBindings";
            this.existingBindings.RowHeadersVisible = false;
            this.existingBindings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.existingBindings.Size = new System.Drawing.Size(441, 167);
            this.existingBindings.TabIndex = 0;
            this.existingBindings.SelectionChanged += new System.EventHandler(this.existingBindings_SelectionChanged);
            // 
            // gridContextMenu
            // 
            this.gridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.gridContextMenu.Name = "gridContextMenu";
            this.gridContextMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Local Solution";
            // 
            // solutionTextBox
            // 
            this.solutionTextBox.Location = new System.Drawing.Point(108, 158);
            this.solutionTextBox.Name = "solutionTextBox";
            this.solutionTextBox.Size = new System.Drawing.Size(109, 20);
            this.solutionTextBox.TabIndex = 6;
            this.solutionTextBox.TextChanged += new System.EventHandler(this.solutionTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Test file path:";
            // 
            // testFilePathLabel
            // 
            this.testFilePathLabel.AutoSize = true;
            this.testFilePathLabel.Location = new System.Drawing.Point(95, 195);
            this.testFilePathLabel.Name = "testFilePathLabel";
            this.testFilePathLabel.Size = new System.Drawing.Size(27, 13);
            this.testFilePathLabel.TabIndex = 8;
            this.testFilePathLabel.Text = "N/A";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Git Username";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Git Password";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // projectAuthorColumn
            // 
            this.projectAuthorColumn.HeaderText = "Git Project Author";
            this.projectAuthorColumn.Name = "projectAuthorColumn";
            this.projectAuthorColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Git Project Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Solution Name";
            this.Column2.Name = "Column2";
            // 
            // ProjectBindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 227);
            this.Controls.Add(this.testFilePathLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.solutionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.existingBindings);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProjectBindingForm";
            this.Text = "Git Project Binding";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectBindingForm_FormClosed);
            this.Load += new System.EventHandler(this.ProjectBindingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingBindings)).EndInit();
            this.gridContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gitUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gitPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gitProjectName;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridView existingBindings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox solutionTextBox;
        private System.Windows.Forms.TextBox gitProjectAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip gridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label testFilePathLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectAuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}