using System.Net;
using System.Net.Mail;

namespace Whisky.Logic.Emails
{
    internal class SmtpEmailSender : IEmailSender
    {
        private readonly ISmtpConfiguration mSmtpConfiguration;

        public SmtpEmailSender(ISmtpConfiguration smtpConfiguration)
        {
            mSmtpConfiguration = smtpConfiguration;
        }
        
        public void SendEmail(EmailData emailData)
        {
            using (SmtpClient client = new SmtpClient(mSmtpConfiguration.SmtpHost, mSmtpConfiguration.SmtpPort))
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(mSmtpConfiguration.SmtpUsername, mSmtpConfiguration.SmtpPassword);

                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress(emailData.SenderAddress),
                    Subject = emailData.Subject,
                    Body = emailData.HtmlBody,
                    IsBodyHtml = true,
                };

                foreach (var recipient in emailData.RecipientAddresses)
                {
                    mailMessage.To.Add(recipient);
                }
            
                client.Send(mailMessage);
            }
        }
    }
}