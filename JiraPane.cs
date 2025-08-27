using System;
using System.Linq;
using Atlassian.Jira;
using System.Windows.Forms;
using System.Windows.Input;


namespace Jira_Ticket_Creator
{
    public partial class JiraPane : UserControl
    {

        private JiraHelper jira;

        public JiraPane()
        {
            InitializeComponent();
            jira = new JiraHelper();
        }

        public void LoadMail(string subject, string sender, string body)
        {
            Subject.Text = subject;
            Body.Text = body;
        }

        private async void SearchInJira()
        {
            var lbl = new Label { Text = "Searching...", AutoSize = true };
            SearchResults.Controls.Add(lbl);
         
            var issues = await jira.GetIssuesBySummaryFromDateAsync(Subject.Text, DateTime.Now.AddDays(-7));

            this.Invoke((Action)(() =>
            {
                SearchResults.Controls.Clear();

                if (issues.Length == 0)
                {
                    lbl.Text = "No Jira issues found.";
                    SearchResults.Controls.Add(lbl);
                    return;
                }

                lbl.Text = $"Got {issues.Length} issues";
                SearchResults.Controls.Add(lbl);

                foreach (var issue in issues)
                {
                    var panel = new Panel
                    {
                        Width = SearchResults.ClientSize.Width - 25,
                        Height = 60,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(5)
                    };

                    var label = new Label
                    {
                        Text = $"{issue.Key.Value}: {issue.Summary}",
                        AutoSize = true,
                        Location = new System.Drawing.Point(5, 5)
                    };

                    var btn = new Button
                    {
                        Text = "Open",
                        AutoSize = true,
                        Location = new System.Drawing.Point(5, 30)
                    };
                    btn.Click += (s, e) =>
                    {
                        System.Diagnostics.Process.Start(
                            $"https://sdp.i.mercedes-benz.com/jira/browse/{issue.Key.Value}");
                    };

                    panel.Controls.Add(label);
                    panel.Controls.Add(btn);

                    SearchResults.Controls.Add(panel);
                }
            }));
        }

        private async void NewIssue_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating Jira issue: " + ex.Message);
            }
        }

        private void Subject_TextChanged(object sender, EventArgs e)
        {
            SearchInJira();
        }

        private void Labels_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
