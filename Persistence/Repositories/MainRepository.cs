using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using StoreAplication.Interfaces.Repository;
using StoreAplication.Model;

namespace Persistence.Repositories
{
    public class MainRepository : IMainRepository
    {
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