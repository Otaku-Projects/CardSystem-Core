using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class SystemRole : IdentityRole
    {
        public override string Id { get; set; }

        public override string Name { get; set; }

        public string DisplayName { get; set; }

        public ICollection<SystemUserRole> SystemUserRoleList { get; set; }

        public ApplicationSystem ApplicationSystem { get; set; }
        public List<ApplicationFunction> ApplicationFunctionsList { get; set; }

        public SystemRole() : base()
        {
        }
        public SystemRole(string roleName) : base(roleName)
        {
        }
    }
}
