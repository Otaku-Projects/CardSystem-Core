using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace WebAPI.Model.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> FindAll();
        T FindById(object id);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
