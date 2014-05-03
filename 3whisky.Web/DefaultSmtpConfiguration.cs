using Whisky.Logic.Emails;

namespace Whisky.Web
{
    internal class DefaultSmtpConfiguration : ISmtpConfiguration
    {
        public string SmtpHost
        {
            get { return "smtp.zoho.com"; }
        }

        public int SmtpPort
        {
            get { return 587; }
        }

        public string SmtpUsername
        {
            get { return "info@3whisky.cz"; }
        }

        public string SmtpPassword
        {
            get { return "4uO8A257MhAe1dRv37qq"; }
        }
    }
}