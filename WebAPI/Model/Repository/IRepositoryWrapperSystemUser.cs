namespace WebAPI.Model.Repository
{
    public interface IRepositoryWrapperSystemUser
    {
        ISystemUserRepository SystemUser { get; }
        ISystemRoleRepository SystemRole { get; }
        void Save();
    }
}
