using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Threading.Tasks;
using WebAPI.DataContext;
using WebAPI.Model;
using WebAPI.Model.Repository;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace WebAPI.Repository
{
    public class UnitOfWork : IDisposable
    {
        private CoreDataContext context;
        private GenericRepository<ApplicationFunction> applicationFunctionRepository;
        private GenericRepository<ApplicationFunctionGroup> applicationFunctionGrouopRepository;

        public UnitOfWork(CoreDataContext context, GenericRepository<ApplicationFunction> applicationFunctionRepository, GenericRepository<ApplicationFunctionGroup> applicationFunctionGrouopRepository, bool disposed)
        {
            this.context = context;
            this.applicationFunctionRepository = applicationFunctionRepository;
            this.applicationFunctionGrouopRepository = applicationFunctionGrouopRepository;
            this.disposed = disposed;
        }

        public GenericRepository<ApplicationFunction> ApplicationFunctionRepository
        {
            get
            {
                return applicationFunctionRepository;
            }
        }

        public GenericRepository<ApplicationFunctionGroup> ApplicationFunctionGrouopRepository
        {
            get
            {
                return applicationFunctionGrouopRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}