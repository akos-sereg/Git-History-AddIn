namespace GitHistoryAddIn.View
{
    partial class GitHistory
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
            ContributionGraph.Controller.DiscreteWeightedColorProvider discreteWeightedColorProvider2 = new ContributionGraph.Controller.DiscreteWeightedColorProvider();
            this.gitProjectBindingLink = new System.Windows.Forms.LinkLabel();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileList = new System.Windows.Forms.ListBox();
            this.avatarImage = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.commitsComboBox = new System.Windows.Forms.ComboBox();
            this.commitsLabel = new System.Windows.Forms.Label();
            this.calendarView1 = new ContributionGraph.CalendarView();
            this.gitItemIcon = new System.Windows.Forms.PictureBox();
            this.refreshOnWindowActivation = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitItemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // gitProjectBindingLink
            // 
            this.gitProjectBindingLink.AutoSize = true;
            this.gitProjectBindingLink.Location = new System.Drawing.Point(683, 17);
            this.gitProjectBindingLink.Name = "gitProjectBindingLink";
            this.gitProjectBindingLink.Size = new System.Drawing.Size(90, 13);
            this.gitProjectBindingLink.TabIndex = 3;
            this.gitProjectBindingLink.TabStop = true;
            this.gitProjectBindingLink.Text = "Project Binding ...";
            this.gitProjectBindingLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitProjectBindingLink_LinkClicked);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(34, 14);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(27, 13);
            this.fileNameLabel.TabIndex = 4;
            this.fileNameLabel.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fileList);
            this.groupBox1.Controls.Add(this.avatarImage);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.authorLabel);
            this.groupBox1.Location = new System.Drawing.Point(779, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commit Details";
            // 
            // fileList
            // 
            this.fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(97, 44);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(406, 69);
            this.fileList.TabIndex = 7;
            // 
            // avatarImage
            // 
            this.avatarImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avatarImage.Location = new System.Drawing.Point(15, 44);
            this.avatarImage.Name = "avatarImage";
            this.avatarImage.Size = new System.Drawing.Size(76, 72);
            this.avatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarImage.TabIndex = 6;
            this.avatarImage.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(387, 16);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(27, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "N/A";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(12, 22);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(30, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "N/A";
            // 
            // commitsComboBox
            // 
            this.commitsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commitsComboBox.FormattingEnabled = true;
            this.commitsComboBox.Location = new System.Drawing.Point(876, 14);
            this.commitsComboBox.Name = "commitsComboBox";
            this.commitsComboBox.Size = new System.Drawing.Size(424, 21);
            this.commitsComboBox.TabIndex = 6;
            this.commitsComboBox.SelectedIndexChanged += new System.EventHandler(this.commitsComboBox_SelectedIndexChanged);
            // 
            // commitsLabel
            // 
            this.commitsLabel.AutoSize = true;
            this.commitsLabel.Location = new System.Drawing.Point(785, 17);
            this.commitsLabel.Name = "commitsLabel";
            this.commitsLabel.Size = new System.Drawing.Size(46, 13);
            this.commitsLabel.TabIndex = 6;
            this.commitsLabel.Text = "Commits";
            // 
            // calendarView1
            // 
            this.calendarView1.BackColor = System.Drawing.Color.White;
            this.calendarView1.CellSize = 12;
            this.calendarView1.ColorProvider = discreteWeightedColorProvider2;
            this.calendarView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarView1.DataSource = null;
            this.calendarView1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.calendarView1.DefaultColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.calendarView1.DisplayedWeeks = 53;
            this.calendarView1.EndDate = new System.DateTime(2015, 1, 8, 20, 25, 9, 307);
            this.calendarView1.Location = new System.Drawing.Point(12, 41);
            this.calendarView1.MaximumSize = new System.Drawing.Size(761, 131);
            this.calendarView1.MinimumSize = new System.Drawing.Size(761, 131);
            this.calendarView1.Name = "calendarView1";
            this.calendarView1.Size = new System.Drawing.Size(761, 131);
            this.calendarView1.TabIndex = 2;
            // 
            // gitItemIcon
            // 
            this.gitItemIcon.Location = new System.Drawing.Point(12, 12);
            this.gitItemIcon.Name = "gitItemIcon";
            this.gitItemIcon.Size = new System.Drawing.Size(16, 16);
            this.gitItemIcon.TabIndex = 7;
            this.gitItemIcon.TabStop = false;
            // 
            // refreshOnWindowActivation
            // 
            this.refreshOnWindowActivation.AutoSize = true;
            this.refreshOnWindowActivation.Location = new System.Drawing.Point(494, 16);
            this.refreshOnWindowActivation.Name = "refreshOnWindowActivation";
            this.refreshOnWindowActivation.Size = new System.Drawing.Size(166, 17);
            this.refreshOnWindowActivation.TabIndex = 8;
            this.refreshOnWindowActivation.Text = "Refresh on window activation";
            this.refreshOnWindowActivation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Change list:";
            // 
            // GitHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshOnWindowActivation);
            this.Controls.Add(this.gitItemIcon);
            this.Controls.Add(this.commitsLabel);
            this.Controls.Add(this.commitsComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.gitProjectBindingLink);
            this.Controls.Add(this.calendarView1);
            this.Name = "GitHistory";
            this.Size = new System.Drawing.Size(1317, 208);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitItemIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContributionGraph.CalendarView calendarView1;
        private System.Windows.Forms.LinkLabel gitProjectBindingLink;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox commitsComboBox;
        private System.Windows.Forms.Label commitsLabel;
        private System.Windows.Forms.PictureBox avatarImage;
        private System.Windows.Forms.PictureBox gitItemIcon;
        private System.Windows.Forms.CheckBox refreshOnWindowActivation;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Label label1;
    }
}