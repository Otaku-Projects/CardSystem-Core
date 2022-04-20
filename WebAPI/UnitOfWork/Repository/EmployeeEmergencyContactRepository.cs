using WebAPI.DataContext;

namespace WebAPI.Model.Repository
{
    public class EmployeeEmergencyContactRepository : GenericRepository<EmployeeEmergencyContact>, IEmployeeEmergencyContactRepository
    {
        public EmployeeEmergencyContactRepository(CoreDataContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
