using System;
using System.Collections.Generic;

namespace WebAPI.Model.Repository
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(long employeeId);
        Employee GetWithDetails(long employeeId);
    }
}
