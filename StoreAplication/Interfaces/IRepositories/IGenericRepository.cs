using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using StoreAplication.Model;

namespace StoreAplication.Interfaces.Repository
{
    public interface IGenericRepository<T> : IDisposable where T : BaseModel
    {
        void Add(T entity);
        T GetSingleById(int id);
        T GetSingle(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
    }
}