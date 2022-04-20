using System.Collections.Generic;
using System.Linq;
using WebAPI.DataContext;
using WebAPI.Model.Repository;

namespace WebAPI.Model.DataManager
{
    public class EmployeeManager : IDataRepository<Employee>
    {
        readonly CoreDataContext _dbContext;
        public EmployeeManager(CoreDataContext context)
        {
            _dbContext = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _dbContext.Employee.ToList();
        }
        public Employee Get(long id)
        {
            return _dbContext.Employee
                  .FirstOrDefault(e => e.Id == id);
        }
        public void Add(Employee entity)
        {
            _dbContext.Employee.Add(entity);
            _dbContext.SaveChanges();
        }
        public void Update(Employee employee, Employee entity)
        {
            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.Email = entity.Email;
            employee.DateOfBirth = entity.DateOfBirth;
            employee.PhoneNumber = entity.PhoneNumber;
            _dbContext.SaveChanges();
        }
        public void Delete(Employee employee)
        {
            _dbContext.Employee.Remove(employee);
            _dbContext.SaveChanges();
        }
    }
}
