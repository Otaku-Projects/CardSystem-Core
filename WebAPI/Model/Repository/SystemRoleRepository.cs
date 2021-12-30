using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DataContext;

namespace WebAPI.Model.Repository
{
    public class SystemRoleRepository : RepositoryBase<SystemRole>, ISystemRoleRepository
    {
        public SystemRoleRepository(CoreDataContext repositoryContext)
            : base(repositoryContext)
        {
        }

        //public IEnumerable<SystemRole> GetAll()
        //{
        //    return FindAll()
        //        .OrderBy(ow => ow.DisplayName)
        //        .ToList();
        //}

        //public SystemRole GetById(string id)
        //{
        //    return this.FindByCondition(systemUser => systemUser.Id.Equals(id))
        //        .FirstOrDefault();
        //}

    }
}
