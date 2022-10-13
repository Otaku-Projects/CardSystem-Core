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
    public class UnitOfWork : IUnitOfWork
    {
        public CoreDataContext context { get; }
        public IRepositoryWrapperEmployee RepositoryWrapperEmployee { get; }
        public IEmployeeRepository EmployeeRepository { get; }
        public IEmployeeEmergencyContactRepository EmergencyContactRepository { get; }
        public UnitOfWork(CoreDataContext context, IRepositoryWrapperEmployee repositoryWrapperEmployee, IEmployeeRepository employeeRepository, IEmployeeEmergencyContactRepository emergencyContactRepository)
        {
            this.context = context;
            RepositoryWrapperEmployee = repositoryWrapperEmployee;
            EmployeeRepository = employeeRepository;
            EmergencyContactRepository = emergencyContactRepository;
            this.disposed = false;
        }

        public void Save()
        {
            context.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }

        public bool disposed { get; set; }


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

        void IUnitOfWork.CreateTransaction()
        {
            throw new NotImplementedException();
        }

        void IUnitOfWork.Commit()
        {
            throw new NotImplementedException();
        }

        void IUnitOfWork.Rollback()
        {
            throw new NotImplementedException();
        }
    }
}