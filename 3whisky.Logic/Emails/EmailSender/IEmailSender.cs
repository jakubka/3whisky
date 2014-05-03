namespace Whisky.Logic.Emails
{
    public interface IEmailSender
    {
        void SendEmail(EmailData emailData);
    }
}