using WebAPI.DataContext;

namespace WebAPI.Model.Repository
{
    public class EmployeeEmergencyContactRepository : RepositoryBase<EmployeeEmergencyContact>, IEmployeeEmergencyContactRepository
    {
        public EmployeeEmergencyContactRepository(CoreDataContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
