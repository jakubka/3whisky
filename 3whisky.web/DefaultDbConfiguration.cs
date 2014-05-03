using System.Configuration;

using Whisky.Db;

namespace Whisky.Web
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