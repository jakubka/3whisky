using System.Data.Entity;

using Whisky.Db.Entities;

namespace Whisky.Db
{
    internal class Context : DbContext
    {
        // for migrations purposes
        public Context() : base("Data Source=tcp:ea9v7l0wm9.database.windows.net,1433;Initial Catalog=3whisky;User Id=whiskyuser@ea9v7l0wm9;Password=rsJ1rtq0GnPpgiOdypGC;")
        {
        }

        public Context(IDbConfiguration configuration)
            : base(configuration.ConnectionString)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; } 
    }
}
