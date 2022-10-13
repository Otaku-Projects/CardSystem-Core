using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DataContext;

namespace WebAPI.Model.Repository
{
    public class SystemUserRepository : IdentityRepository<SystemUser>, ISystemUserRepository
    {
        public SystemUserRepository(CoreDataContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public IEnumerable<SystemUser> GetAll()
        {
            return GetAll()
                .OrderBy(ow => ow.UserName)
                .ToList();
        }

        public SystemUser GetById(string id)
        {
            return this.GenericFindByCondition(systemUser => systemUser.Id.Equals(id))
                .FirstOrDefault();
        }

        public SystemUser GetWithDetails(string id)
        {
            return this.GenericFindByCondition(systemUser => systemUser.Id.Equals(id))
                .Include(systemUser => systemUser.SystemUserRoleList)
                .ThenInclude(r => r.Role)
                .FirstOrDefault();
        }
    }
}
