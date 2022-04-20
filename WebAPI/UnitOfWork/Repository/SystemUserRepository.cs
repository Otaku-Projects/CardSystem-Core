using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DataContext;

namespace WebAPI.Model.Repository
{
    public class SystemUserRepository : GenericRepository<SystemUser>, ISystemUserRepository
    {
        public SystemUserRepository(CoreDataContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public IEnumerable<SystemUser> GetAll()
        {
            return FindAll()
                .OrderBy(ow => ow.UserName)
                .ToList();
        }

        public SystemUser GetById(string id)
        {
            return this.FindByCondition(systemUser => systemUser.Id.Equals(id))
                .FirstOrDefault();
        }

        public SystemUser GetWithDetails(string id)
        {
            // using include or theninclude will create circular reference.
            // JSON cannot handle circular reference
            return this.FindByCondition(systemUser => systemUser.Id.Equals(id))
                .Include(systemUser => systemUser.SystemUserRoleList)
                .ThenInclude(r => r.Role)
                .FirstOrDefault();
        }
    }
}
