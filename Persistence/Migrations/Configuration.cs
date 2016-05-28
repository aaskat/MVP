using System.Collections.Generic;
using System.Linq;
using StoreAplication.Models;

namespace Persistence.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Persistence.StoreAplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StoreAplicationContext context)
        {
            if (!context.Products.Any())
            {
                SeedProduct(context);
            }
        }

        private void SeedProduct(StoreAplicationContext context)
        {
            var products = new List<Product>()
            {
                new Product
                {
                    Name = "Apple",
                    Cost = 45,
                    Amount = 100
                },
                new Product
                {
                    Name = "Apricot",
                    Cost = 45,
                    Amount = 100
                },
                new Product
                {
                    Name = "Cherry",
                    Cost = 45,
                    Amount = 10
                },
                new Product
                {
                    Name = "Strawberries",
                    Cost = 50,
                    Amount = 100
                },
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
        }
    }
}
