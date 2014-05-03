namespace Whisky.Logic.Emails
{
    public interface ISmtpConfiguration
    {
        string SmtpHost { get; }
        int SmtpPort { get; }
        string SmtpUsername { get; }
        string SmtpPassword { get; }
    }
}