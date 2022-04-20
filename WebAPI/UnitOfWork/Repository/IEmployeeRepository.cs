using System;
using System.Collections.Generic;

namespace WebAPI.Model.Repository
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Employee GetById(long employeeId);
        Employee GetWithDetails(long employeeId);
    }
}
