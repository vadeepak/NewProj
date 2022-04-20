using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace ASPPP
{
    public class Logger
    {
        public static void Log(Exception exception)
        {
            // Create an instance of StringBuilder. This class is in System.Text namespace
            StringBuilder sbExceptionMessage = new StringBuilder();
            sbExceptionMessage.Append("Exception Type" + Environment.NewLine);
            // Get the exception type
            sbExceptionMessage.Append(exception.GetType().Name);
            // Environment.NewLine writes new line character - \n
            sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);
            sbExceptionMessage.Append("Message" + Environment.NewLine);
            // Get the exception message
            sbExceptionMessage.Append(exception.Message + Environment.NewLine + Environment.NewLine);
            sbExceptionMessage.Append("Stack Trace" + Environment.NewLine);
            // Get the exception stack trace
            sbExceptionMessage.Append(exception.StackTrace + Environment.NewLine + Environment.NewLine);

            // Retrieve inner exception if any
            Exception innerException = exception.InnerException;

            // If inner exception exists
            while (innerException != null)
            {
                sbExceptionMessage.Append("Exception Type" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.GetType().Name);
                sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Message" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.Message + Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Stack Trace" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.StackTrace + Environment.NewLine + Environment.NewLine);

                // Retrieve inner exception if any
                innerException = innerException.InnerException;
            }
            // If the Event log source exists
            if (EventLog.SourceExists("TestLogs"))
            {
                // Create an instance of the eventlog
                EventLog log = new EventLog("Testing");
                // set the source for the eventlog
                log.Source = "TestLogs";
                // Write the exception details to the event log as an error
                log.WriteEntry(sbExceptionMessage.ToString(), EventLogEntryType.Error);
            }
            string sendEmail = ConfigurationManager.AppSettings["SendEmail"];
            if (sendEmail.ToLower() == "true")
            {
                SendEmail(sbExceptionMessage.ToString());
            }
        }

        public static void SendEmail(string emailbody)
        {
            // Specify the from and to email address
            MailMessage mailMessage = new MailMessage
                ("vnarasimhadeepak@gmail.com", "vnarasimhadeepak@gmail.com");
            // Specify the email body
            mailMessage.Body = emailbody;
            // Specify the email Subject
            mailMessage.Subject = "Exception";

            // No need to specify the SMTP settings as these 
            // are already specified in web.config
            SmtpClient smtpClient = new SmtpClient();
            // Finall send the email message using Send() method
            smtpClient.Send(mailMessage);
        }
    }
}