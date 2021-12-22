using WebAPI.DataContext;

namespace WebAPI.Model.Repository
{
    public class RepositoryWrapperEmployee : IRepositoryWrapperEmployee
    {
        private CoreDataContext _repoContext;

        private IEmployeeRepository _employee;
        private IEmployeeEmergencyContactRepository _emergencyContact;
        public IEmployeeRepository Employee
        {
            get
            {
                if (_employee == null)
                {
                    _employee = new EmployeeRepository(_repoContext);
                }
                return _employee;
            }
        }
        public IEmployeeEmergencyContactRepository EmployeeEmergencyContact
        {
            get
            {
                if (_emergencyContact == null)
                {
                    _emergencyContact = new EmployeeEmergencyContactRepository(_repoContext);
                }
                return _emergencyContact;
            }
        }
        public RepositoryWrapperEmployee(CoreDataContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
