using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Model.Repository
{
    public interface IEmployeeEmergencyContactRepository : IGenericRepository<EmployeeEmergencyContact>
    {
        public IEnumerable<EmployeeEmergencyContact> LinkingWithEmployee(Guid employeeId)
        {
            return FindByCondition(a => a.EmployeeId.Equals(employeeId)).ToList();
        }
    }
}
