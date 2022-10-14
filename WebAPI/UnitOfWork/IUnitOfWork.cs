
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WebAPI.DataContext;
using WebAPI.Model.Repository;

namespace WebAPI.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        public CoreDataContext context { get; }
        public IRepositoryWrapperEmployee RepositoryWrapperEmployee { get; }
        public IEmployeeRepository EmployeeRepository { get; }
        public IEmployeeEmergencyContactRepository EmergencyContactRepository { get; }

        void CreateTransaction();
        void Commit();
        void Rollback();
        void Save();
        Task SaveAsync();
        void Dispose(); 
    }
}
