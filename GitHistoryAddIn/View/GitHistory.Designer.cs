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
            this.avatarImage = new System.Windows.Forms.PictureBox();
            this.titleTextArea = new System.Windows.Forms.RichTextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.commitsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calendarView1 = new ContributionGraph.CalendarView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gitProjectBindingLink
            // 
            this.gitProjectBindingLink.AutoSize = true;
            this.gitProjectBindingLink.Location = new System.Drawing.Point(683, 14);
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
            this.fileNameLabel.Location = new System.Drawing.Point(9, 14);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(27, 13);
            this.fileNameLabel.TabIndex = 4;
            this.fileNameLabel.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.avatarImage);
            this.groupBox1.Controls.Add(this.titleTextArea);
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
            // titleTextArea
            // 
            this.titleTextArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextArea.Location = new System.Drawing.Point(97, 44);
            this.titleTextArea.Name = "titleTextArea";
            this.titleTextArea.ReadOnly = true;
            this.titleTextArea.Size = new System.Drawing.Size(407, 72);
            this.titleTextArea.TabIndex = 5;
            this.titleTextArea.Text = "";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(133, 22);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(27, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 22);
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
            this.commitsComboBox.Location = new System.Drawing.Point(831, 14);
            this.commitsComboBox.Name = "commitsComboBox";
            this.commitsComboBox.Size = new System.Drawing.Size(469, 21);
            this.commitsComboBox.TabIndex = 6;
            this.commitsComboBox.SelectedIndexChanged += new System.EventHandler(this.commitsComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(779, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Commits";
            // 
            // calendarView1
            // 
            this.calendarView1.BackColor = System.Drawing.Color.White;
            this.calendarView1.ColorProvider = discreteWeightedColorProvider2;
            this.calendarView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarView1.DataSource = null;
            this.calendarView1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.calendarView1.DefaultColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.calendarView1.DisplayedWeeks = 53;
            this.calendarView1.EndDate = new System.DateTime(2014, 12, 26, 14, 1, 47, 52);
            this.calendarView1.Location = new System.Drawing.Point(12, 41);
            this.calendarView1.MaximumSize = new System.Drawing.Size(761, 131);
            this.calendarView1.MinimumSize = new System.Drawing.Size(761, 131);
            this.calendarView1.Name = "calendarView1";
            this.calendarView1.Size = new System.Drawing.Size(761, 131);
            this.calendarView1.TabIndex = 2;
            // 
            // GitHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox titleTextArea;
        private System.Windows.Forms.PictureBox avatarImage;
    }
}