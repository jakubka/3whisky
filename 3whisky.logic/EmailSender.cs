using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _3whisky.logic
{
    public interface IEmailConfiguration
    {
        string SmtpHost { get; }
        int SmtpPort { get; }
        string SmtpUsername { get; }
        string SmtpPassword { get; }
        string SenderAddress { get; }
    }

    public interface IEmailSender
    {
        void SendEmail(string recipient, string subject, string body);
        void SendEmail(List<string> recipients, string subject, string body);
    }

    internal class EmailSender : IEmailSender
    {
        private readonly IEmailConfiguration _emailConfiguration;

        public EmailSender(IEmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }

        public void SendEmail(string recipient, string subject, string body)
        {
            SendEmail(new List<string>() { recipient }, subject, body);
        }


        public void SendEmail(List<string> recipients, string subject, string body)
        {
            using (SmtpClient client = new SmtpClient(_emailConfiguration.SmtpHost, _emailConfiguration.SmtpPort))
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);

                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress(_emailConfiguration.SenderAddress),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                };

                foreach (var recipient in recipients)
                {
                    mailMessage.To.Add(recipient);
                }
            
                client.Send(mailMessage);
            }
        }
    }
}