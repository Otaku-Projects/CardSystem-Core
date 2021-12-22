using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using WebAPI.DataContext;

namespace WebAPI.Model.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected CoreDataContext CoreDataContext { get; set; }
        public RepositoryBase(CoreDataContext repositoryContext)
        {
            this.CoreDataContext = repositoryContext;
        }
        public IQueryable<T> FindAll()
        {
            return this.CoreDataContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            //return this.CoreDataContext.Set<T>().Where(expression).AsNoTracking();
            return this.CoreDataContext.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            this.CoreDataContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            this.CoreDataContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            this.CoreDataContext.Set<T>().Remove(entity);
        }
    }
}
