using Microsoft.EntityFrameworkCore;

namespace Istagrow.Models
{
    public class Datastore : DbContext
    {
        public static string ConnectionString = 
            "User ID=dgwbfqnjljiezt;" +
            "Password=191f7dd4c7cbfc00d915fe3c0dbf8546c21e3620630db2e1515a480b4fdbab59;" +
            "Host=ec2-54-227-245-146.compute-1.amazonaws.com;" +
            "Port=5432;" +
            "Database=do5pgdtun3a5m;" +
            "Pooling=true;" +
            "Use SSL Stream=True;" +
            "SSL Mode=Require;" +
            "TrustServerCertificate=True;";

        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(ConnectionString);
    }
}
