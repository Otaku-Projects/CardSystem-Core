using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DataContext;

namespace WebAPI.Model.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CoreDataContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public IQueryable<Employee> GetAll()
        {
            return this.GenericGetAll()
                .OrderBy(ow => ow.FullName);
        }

        public Employee GetById(long employeeId)
        {
            return this.GenericFindByCondition(employee => employee.Id.Equals(employeeId))
                .FirstOrDefault();
        }

        public Employee GetWithDetails(long employeeId)
        {
            // EF 5.0
            return this.GenericFindByCondition(employee => employee.Id.Equals(employeeId))
                .Include(emergencyContact => emergencyContact.EmergencyContactList)
                .ThenInclude(e => e.Employee)
                .FirstOrDefault();

            // EF 6.0
            //return this.GenericFindByCondition(employee => employee.Id.Equals(employeeId))
            //    .Include(x => x.EmergencyContactList.Select(y => y.Employee))
            //    .First();

        }
    }
}
