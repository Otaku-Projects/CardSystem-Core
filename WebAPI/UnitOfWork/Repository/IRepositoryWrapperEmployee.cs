namespace WebAPI.Model.Repository
{
    public interface IRepositoryWrapperEmployee
    {
        IEmployeeRepository Employee { get; }
        IEmployeeEmergencyContactRepository EmployeeEmergencyContact { get; }
        void Save();
    }
}
