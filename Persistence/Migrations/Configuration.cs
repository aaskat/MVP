using System.Linq;
using StoreAplication.Model;

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
            var product = new Product
            {
                Name = "Aplle",
                Cost = 45
            };
            context.Products.Add(product);
        }
    }
}
