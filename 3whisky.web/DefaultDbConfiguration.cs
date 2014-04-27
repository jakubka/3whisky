using _3whisky.configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace _3whisky.web
{
    internal class DefaultDbConfiguration : IDbConfiguration
    {
        public string ConnectionString
        {
            get 
            {
                string connStr = ConfigurationManager.ConnectionStrings["AzureConnectionString"].ConnectionString;

                return connStr;
            }
        }
    }
}