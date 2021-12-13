using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class SystemUserRole : IdentityRole
    {
        public override string Id { get; set; }

        [Column("RoleName")]
        public override string Name { get; set; }

        public string DisplayName { get; set; }

        public ApplicationSystem Application { get; set; }
        public List<ApplicationFunction> Functions { get; set; }
    }
}
