using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SportsStore.Data.Entities;
using SportsStore.Properties;

namespace SportsStore.Data
{
    public class SportsStoreDbContext : DbContext 
    {
        public SportsStoreDbContext(string connectionString) : base(connectionString)
        {}

        public DbSet<Product> Products { get; set; } 
    }

    public class SportsStoreDbContextFactory : IDbContextFactory<SportsStoreDbContext>
    {
        public SportsStoreDbContext Create()
        {
            return new SportsStoreDbContext(Settings.Default.ConnectionString);
        }
    }
}