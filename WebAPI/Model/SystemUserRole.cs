using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class SystemUserRole : IdentityUserRole<string>
    {
        //public override string UserId { get => base.UserId; set => base.UserId = value; }
        //public override string RoleId { get => base.UserId; set => base.UserId = value; }

        //[NotMapped]
        //public virtual SystemUser User { get; set; }

        //[NotMapped]
        //public virtual SystemRole Role { get; set; }

        //public override string UserId { get; set; }
        //public override string RoleId { get; set; }

        public virtual SystemUser User { get; set; }
        public virtual SystemRole Role { get; set; }
    }
}
