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
        public IEnumerable<Employee> GetAll()
        {
            return FindAll()
                .OrderBy(ow => ow.FullName)
                .ToList();
        }

        public Employee GetById(long employeeId)
        {
            return this.FindByCondition(employee => employee.EmployeeId.Equals(employeeId))
                .FirstOrDefault();
        }

        public Employee GetWithDetails(long employeeId)
        {
            return this.FindByCondition(employee => employee.EmployeeId.Equals(employeeId))
                .Include(emergencyContact => emergencyContact.EmergencyContactList).ThenInclude(e=>e.EmergencyContactId)
                .FirstOrDefault();
        }
    }
}
