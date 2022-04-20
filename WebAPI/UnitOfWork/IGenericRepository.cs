using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace WebAPI.Model.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GenericGetAll();
        T GenericFindById(object id);
        IQueryable<T> GenericFindByCondition(Expression<Func<T, bool>> expression);
        void GenericCreate(T entity);
        void GenericUpdate(T entity);
        void GenericDelete(T entity);
    }
}
