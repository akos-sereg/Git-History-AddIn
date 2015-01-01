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
            this.button1 = new System.Windows.Forms.Button();
            this.calendarView1 = new ContributionGraph.CalendarView();
            this.gitProjectBindingLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendarView1
            // 
            this.calendarView1.BackColor = System.Drawing.Color.White;
            this.calendarView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendarView1.ColorProvider = discreteWeightedColorProvider2;
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
            this.gitProjectBindingLink.Location = new System.Drawing.Point(9, 18);
            this.gitProjectBindingLink.Name = "gitProjectBindingLink";
            this.gitProjectBindingLink.Size = new System.Drawing.Size(90, 13);
            this.gitProjectBindingLink.TabIndex = 3;
            this.gitProjectBindingLink.TabStop = true;
            this.gitProjectBindingLink.Text = "Project Binding ...";
            this.gitProjectBindingLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitProjectBindingLink_LinkClicked);
            // 
            // GitHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gitProjectBindingLink);
            this.Controls.Add(this.calendarView1);
            this.Controls.Add(this.button1);
            this.Name = "GitHistory";
            this.Size = new System.Drawing.Size(822, 208);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ContributionGraph.CalendarView calendarView1;
        private System.Windows.Forms.LinkLabel gitProjectBindingLink;
    }
}