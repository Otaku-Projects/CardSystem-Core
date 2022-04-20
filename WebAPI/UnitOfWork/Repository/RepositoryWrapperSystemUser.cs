using WebAPI.DataContext;

namespace WebAPI.Model.Repository
{
    public class RepositoryWrapperSystemUser : IRepositoryWrapperSystemUser
    {
        private CoreDataContext _repoContext;

        private ISystemUserRepository _systemUser;
        private ISystemRoleRepository _systemRole;
        public ISystemUserRepository SystemUser
        {
            get
            {
                if (_systemUser == null)
                {
                    _systemUser = new SystemUserRepository(_repoContext);
                }
                return _systemUser;
            }
        }
        public ISystemRoleRepository SystemRole
        {
            get
            {
                if (_systemRole == null)
                {
                    _systemRole = new SystemRoleRepository(_repoContext);
                }
                return _systemRole;
            }
        }
        public RepositoryWrapperSystemUser(CoreDataContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
