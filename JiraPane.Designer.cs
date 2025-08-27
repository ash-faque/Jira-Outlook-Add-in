namespace Jira_Ticket_Creator
{
    partial class JiraPane
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
            this.Main = new System.Windows.Forms.GroupBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.SearchResults = new System.Windows.Forms.FlowLayoutPanel();
            this.Body = new System.Windows.Forms.RichTextBox();
            this.Labels = new System.Windows.Forms.FlowLayoutPanel();
            this.NewIssue = new System.Windows.Forms.Button();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.Subject);
            this.Main.Controls.Add(this.SearchResults);
            this.Main.Controls.Add(this.Body);
            this.Main.Controls.Add(this.Labels);
            this.Main.Controls.Add(this.NewIssue);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(300, 800);
            this.Main.TabIndex = 0;
            this.Main.TabStop = false;
            // 
            // Subject
            // 
            this.Subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Subject.BackColor = System.Drawing.Color.Gainsboro;
            this.Subject.Location = new System.Drawing.Point(6, 16);
            this.Subject.Multiline = true;
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(287, 55);
            this.Subject.TabIndex = 15;
            this.Subject.Text = "Subject";
            this.Subject.TextChanged += new System.EventHandler(this.Subject_TextChanged);
            // 
            // SearchResults
            // 
            this.SearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResults.BackColor = System.Drawing.Color.Goldenrod;
            this.SearchResults.Location = new System.Drawing.Point(6, 77);
            this.SearchResults.MinimumSize = new System.Drawing.Size(0, 200);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(287, 243);
            this.SearchResults.TabIndex = 16;
            // 
            // Body
            // 
            this.Body.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Body.BackColor = System.Drawing.Color.Silver;
            this.Body.Location = new System.Drawing.Point(6, 326);
            this.Body.MinimumSize = new System.Drawing.Size(0, 400);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(287, 400);
            this.Body.TabIndex = 17;
            this.Body.Text = "Description";
            // 
            // Labels
            // 
            this.Labels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Labels.BackColor = System.Drawing.Color.IndianRed;
            this.Labels.Location = new System.Drawing.Point(6, 632);
            this.Labels.MinimumSize = new System.Drawing.Size(0, 100);
            this.Labels.Name = "Labels";
            this.Labels.Size = new System.Drawing.Size(287, 119);
            this.Labels.TabIndex = 18;
            this.Labels.Paint += new System.Windows.Forms.PaintEventHandler(this.Labels_Paint);
            // 
            // NewIssue
            // 
            this.NewIssue.AutoSize = true;
            this.NewIssue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewIssue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewIssue.Location = new System.Drawing.Point(3, 757);
            this.NewIssue.MaximumSize = new System.Drawing.Size(0, 40);
            this.NewIssue.MinimumSize = new System.Drawing.Size(200, 40);
            this.NewIssue.Name = "NewIssue";
            this.NewIssue.Size = new System.Drawing.Size(294, 40);
            this.NewIssue.TabIndex = 14;
            this.NewIssue.Text = "New Issue";
            this.NewIssue.UseVisualStyleBackColor = true;
            // 
            // JiraPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.Main);
            this.Font = new System.Drawing.Font("Iosevka Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(300, 800);
            this.Name = "JiraPane";
            this.Size = new System.Drawing.Size(300, 800);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Main;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.FlowLayoutPanel SearchResults;
        private System.Windows.Forms.RichTextBox Body;
        private System.Windows.Forms.FlowLayoutPanel Labels;
        private System.Windows.Forms.Button NewIssue;
    }
}