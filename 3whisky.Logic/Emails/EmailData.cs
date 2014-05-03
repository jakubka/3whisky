using System.Collections.Generic;

namespace Whisky.Logic.Emails
{
    public class EmailData
    {
        public EmailData()
        {
            RecipientAddresses = new List<string>();
        }


        public List<string> RecipientAddresses
        {
            get;
            set;
        }


        public string SenderAddress
        {
            get;
            set;
        }


        public string Subject
        {
            get;
            set;
        }


        public string HtmlBody
        {
            get;
            set;
        }
    }
}