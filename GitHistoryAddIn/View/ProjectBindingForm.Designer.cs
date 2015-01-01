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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gitUsername = new System.Windows.Forms.TextBox();
            this.gitPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gitProjectName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gitPassword);
            this.groupBox1.Controls.Add(this.gitUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Git Credentials";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // gitUsername
            // 
            this.gitUsername.Location = new System.Drawing.Point(80, 24);
            this.gitUsername.Name = "gitUsername";
            this.gitUsername.Size = new System.Drawing.Size(179, 20);
            this.gitUsername.TabIndex = 2;
            // 
            // gitPassword
            // 
            this.gitPassword.Location = new System.Drawing.Point(80, 48);
            this.gitPassword.Name = "gitPassword";
            this.gitPassword.PasswordChar = '*';
            this.gitPassword.Size = new System.Drawing.Size(179, 20);
            this.gitPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Project";
            // 
            // gitProjectName
            // 
            this.gitProjectName.Location = new System.Drawing.Point(92, 112);
            this.gitProjectName.Name = "gitProjectName";
            this.gitProjectName.Size = new System.Drawing.Size(206, 20);
            this.gitProjectName.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProjectBindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gitProjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProjectBindingForm";
            this.Text = "Git Project Binding";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
    }
}