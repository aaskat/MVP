using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using StoreAplication.Interfaces.IRepositories;
using StoreAplication.Models;

namespace StoreAplication.Repositories
{
    public class MainRepository : IMainRepository
    {
        protected StoreAplicationContext Context;
        protected DbSet<Product> DbSet;

        public MainRepository(StoreAplicationContext context)
        {
            Context = context;
            DbSet = context.Set<Product>();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return  DbSet.Where(x => x.IsDeleted == false);
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Product GetSingle(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Product GetSingleById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}