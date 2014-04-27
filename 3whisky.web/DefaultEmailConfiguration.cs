using _3whisky.configuration;
using _3whisky.logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace _3whisky.web
{
    internal class DefaultEmailConfiguration : IEmailConfiguration
    {
        public string SmtpHost
        {
            get { return "smtp.zoho.com"; }
        }

        public int SmtpPort
        {
            get { return 465; }
        }

        public string SmtpUsername
        {
            get { return "info@3whisky.cz"; }
        }

        public string SmtpPassword
        {
            get { return "4uO8A257MhAe1dRv37qq"; }
        }

        public string SenderAddress
        {
            get { return "info@3whisky.cz"; }
        }
    }
}