﻿using System.Data.Entity;
using StoreAplication.Model;

namespace Persistence
{
    public class StoreAplicationContext : DbContext
    {
        public StoreAplicationContext() : base("StoreAplicationContext")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
