using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools;

namespace Jira_Ticket_Creator
{

    public partial class ThisAddIn
    {
        private CustomTaskPane panel;
        private JiraPane jiraPane;
        private Outlook.Explorer explorer;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            explorer = Application.ActiveExplorer();
            explorer.SelectionChange += Explorer_SelectionChange;

            jiraPane = new JiraPane();
            panel = CustomTaskPanes.Add(jiraPane, "Jira", explorer);
            panel.Visible = true;

            UpdatePaneWithCurrentMail();
        }

        private void Explorer_SelectionChange()
        {
            UpdatePaneWithCurrentMail();
        }

        private void UpdatePaneWithCurrentMail()
        {
            if (explorer.Selection.Count > 0 && explorer.Selection[1] is Outlook.MailItem mail)
            {
                jiraPane.LoadMail(mail.Subject, mail.SenderName, mail.Body);
            }
            else
            {
                jiraPane.LoadMail("(no mail selected)", "", "");
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
    }


}
