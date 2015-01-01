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
            ContributionGraph.Controller.DiscreteWeightedColorProvider discreteWeightedColorProvider1 = new ContributionGraph.Controller.DiscreteWeightedColorProvider();
            this.calendarView1 = new ContributionGraph.CalendarView();
            this.gitProjectBindingLink = new System.Windows.Forms.LinkLabel();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calendarView1
            // 
            this.calendarView1.BackColor = System.Drawing.Color.White;
            this.calendarView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendarView1.ColorProvider = discreteWeightedColorProvider1;
            this.calendarView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarView1.DataSource = null;
            this.calendarView1.DisplayedWeeks = 53;
            this.calendarView1.EndDate = new System.DateTime(2014, 12, 26, 14, 1, 47, 52);
            this.calendarView1.Location = new System.Drawing.Point(12, 41);
            this.calendarView1.MaximumSize = new System.Drawing.Size(761, 131);
            this.calendarView1.MinimumSize = new System.Drawing.Size(761, 131);
            this.calendarView1.Name = "calendarView1";
            this.calendarView1.Size = new System.Drawing.Size(761, 131);
            this.calendarView1.TabIndex = 2;
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
            // GitHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.gitProjectBindingLink);
            this.Controls.Add(this.calendarView1);
            this.Name = "GitHistory";
            this.Size = new System.Drawing.Size(822, 208);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContributionGraph.CalendarView calendarView1;
        private System.Windows.Forms.LinkLabel gitProjectBindingLink;
        private System.Windows.Forms.Label fileNameLabel;
    }
}