using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    /**
     * You can inspect the properties directly from the Identity API Source Code
     * https://github.com/dotnet/aspnetcore/tree/main/src/Identity/Extensions.Stores/src
     * 
     * The Microsoft.AspNetCore.Identity namespace contains the Entity Models of the Identity API.
     * They are:
        IdentityRole
        IdentityRoleClaim
        IdentityUser
        IdentityUserClaim
        IdentityUserLogin
        IdentityUserRole
        IdentityUserToken
     * */

    public class SystemUser : IdentityUser
    {
        /**
         * need to specify the type of Id, 
         * the Identify API by default uses string type for Id 
         * and stores GUID values in it.
         * */
        public override string Id { get; set; }

        public ICollection<SystemUserRole> SystemUserRoleList { get; set; }
        //public ICollection<SystemUserRole> SystemUserRoleList { get; set; }

        public SystemUser() : base()
        {

        }
        public SystemUser(string userName) : base(userName)
        {

        }
    }
}
