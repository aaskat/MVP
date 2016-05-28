using System.Data.Entity;
using StoreAplication.Models;

namespace StoreAplication
{
    public class StoreAplicationContext : DbContext
    {
        public StoreAplicationContext() : base("StoreAplicationContext")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
