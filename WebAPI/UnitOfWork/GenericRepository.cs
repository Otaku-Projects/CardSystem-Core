﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using WebAPI.DataContext;
using WebAPI.Repository;

namespace WebAPI.Model.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T>, IDisposable where T : BaseModel
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
        protected virtual IDbSet<T> Entities
        {
            get { return _entities ?? (_entities = (IDbSet<T>)_context.Set<T>()); }
        }

        public IQueryable<T> GenericGetAll()
        {
            // select with checking the soft-delete flag if it exists

            return this._context.Set<T>().AsNoTracking();
        }
        public IQueryable<T> GenericFindByCondition(Expression<Func<T, bool>> expression)
        {
            // select with checking the soft-delete flag if it exists

            //return this._context.Set<T>().Where(expression).AsNoTracking();
            return this._context.Set<T>().Where(expression);
        }
        public T GenericFindById(object id)
        {
            // select with checking the soft-delete flag if it exists

            return this._context.Set<T>().AsNoTracking().FirstOrDefault();
        }

        public void GenericCreate(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");
                Entities.Add(entity);
                if (this._context == null || _isDisposed)
                {
                    //this._context = new CoreDataContext();
                }
                else
                {
                    // set the createDate, createUser fields if exists
                    var universalTime = DateTime.Now.ToUniversalTime();

                    entity.CreatedDate = entity.UpdatedDate = universalTime;
                    entity.UpdatedBy = entity.CreatedBy;
                    entity.IsActive = true;

                    this._context.Set<T>().Add(entity);
                }
                //Context.SaveChanges(); commented out call to SaveChanges as Context save changes will be 
                //called with Unit of work
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                    foreach (var validationError in validationErrors.ValidationErrors)
                        _errorMessage += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                throw new Exception(_errorMessage, dbEx);
            }


        }
        public void GenericUpdate(T entity)
        {
            // update the updateDate, updateUser fields if exists
            //this._context.Set<T>().Update(entity);
            entity.UpdatedDate = DateTime.Now.ToUniversalTime();

            this._context.Set<T>().Attach(entity);
            //this._entities.Attach(entity);
            this._context.Entry(entity).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        }
        public void GenericDelete(T entity)
        {
            this.GenericSoftDelete(entity);
        }
        public void GenericSoftDelete(T entity)
        {
            // update the flag to provide soft-delete if the flag exists
            entity.IsActive = false;
            this.GenericUpdate(entity);
        }
        public void GenericHardDelete(T entity)
        {
            entity.UpdatedDate = DateTime.Now.ToUniversalTime();
            this._context.Set<T>().Remove(entity);
        }

        public void Save()
        {
            this._context.SaveChanges();
        }

        public void Dispose()
        {
            if (this._context != null)
                this._context.Dispose();

            GC.SuppressFinalize(this);

            _isDisposed = true;
        }
    }
}
