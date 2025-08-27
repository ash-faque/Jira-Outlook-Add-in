using System;
using System.Linq;
using Atlassian.Jira;
using System.Threading.Tasks;


namespace Jira_Ticket_Creator
{
    internal class JiraHelper
    {

        private readonly Jira _jira;

        public JiraHelper()
        {
            string url = Environment.GetEnvironmentVariable("JIRA_URL");
            string user = Environment.GetEnvironmentVariable("JIRA_USER");
            string pass = Environment.GetEnvironmentVariable("JIRA_PASSWORD");
            _jira = Jira.CreateRestClient(url, user, pass);
        }

        public async Task<Issue[]> GetIssuesBySummaryFromDateAsync(
            string summary,
            DateTime? sinceDate = null,
            int startAt = 0,
            int maxPerPage = 100,
            string epicKey = "NEST-284")
        {
            if (string.IsNullOrWhiteSpace(summary))
                throw new ArgumentException("No summary provided for searching issue.", nameof(summary));

            string sinceDateStr = sinceDate?.ToString("yyyy-MM-dd HH:mm");
            string jql = $"\"Epic Link\" = {epicKey} AND summary ~ \"{summary}\" ORDER BY created DESC";

            try
            {
                var issues = await _jira.Issues.GetIssuesFromJqlAsync(jql, maxPerPage, startAt);
                return issues.ToArray();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"JQL query failed: {ex.Message}");
                return Array.Empty<Issue>();
            }
        }
    }


}
