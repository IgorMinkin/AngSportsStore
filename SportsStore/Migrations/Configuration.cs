using SportsStore.Data.Entities;

namespace SportsStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.SportsStoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.SportsStoreDbContext context)
        {
            context.Products.AddOrUpdate(
                p => p.Name,
                new Product {Name = "Bowling Bowl", Category = "Bowling", Description = "The bowling bowl", Price = 20.25M},
                new Product { Name = "Soccer Ball", Category = "Soccer", Description = "The soccer ball", Price = 30.25M },
                new Product { Name = "Kayak", Category = "Watersports", Description = "A boat for one person", Price = 275M },
                new Product { Name = "Lifejacket", Category = "Watersports", Description = "Protective and fashionable", Price = 48.95M });
        }
    }
}
