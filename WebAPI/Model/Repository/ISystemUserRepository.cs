using System;
using System.Collections.Generic;

namespace WebAPI.Model.Repository
{
    public interface ISystemUserRepository : IGenericRepository<SystemUser>
    {
        IEnumerable<SystemUser> GetAll();
        SystemUser GetById(string id);
        SystemUser GetWithDetails(string id);
    }
}
