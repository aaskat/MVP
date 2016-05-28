using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using StoreAplication.Interfaces.IRepositories;
using StoreAplication.Models;

namespace Persistence.Repositories
{
    public class MainRepository : IMainRepository
    {
        protected StoreAplicationContext _context;
        protected DbSet<Product> _dbSet;

        public MainRepository(StoreAplicationContext context, DbSet<Product> dbSet)
        {
            _context = context;
            _dbSet = context.Set<Product>();
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
            throw new NotImplementedException();
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