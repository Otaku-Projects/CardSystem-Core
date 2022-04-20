using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using WebAPI.DataContext;
using WebAPI.UnitOfWork;

namespace WebAPI.Model.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T>, IDisposable where T : class
    {
        public CoreDataContext _context = null;
        private IDbSet<T> _entities;
        private string _errorMessage = string.Empty;
        private bool _isDisposed;

        //public GenericRepository(IUnitOfWork<CoreDataContext> unitOfWork)
        //    : this(unitOfWork.Context)
        //{
        //}
        public GenericRepository(CoreDataContext context)
        {
            _isDisposed = false;
            _context = context;
        }

        public IQueryable<T> FindAll()
        {
            // select with checking the soft-delete flag if it exists

            return this._context.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            // select with checking the soft-delete flag if it exists

            //return this._context.Set<T>().Where(expression).AsNoTracking();
            return this._context.Set<T>().Where(expression);
        }
        public T FindById(object id)
        {
            // select with checking the soft-delete flag if it exists

            return this._context.Set<T>().AsNoTracking().FirstOrDefault();
        }

        public void Create(T entity)
        {
            // set the createDate, createUser fields if exists

            this._context.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            // update the updateDate, updateUser fields if exists

            this._context.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            // update the flag to provide soft-delete if the flag exists

            this._context.Set<T>().Remove(entity);
        }
        public void Dispose()
        {
            if (this._context != null)
                this._context.Dispose();
            _isDisposed = true;
        }
    }
}
