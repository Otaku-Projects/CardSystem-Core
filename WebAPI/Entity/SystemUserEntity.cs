using System;
using System.Collections.Generic;
using WebAPI.Model;

namespace WebAPI.Entity
{
    // DTO or Data Transfer Object
    /*** 
     * DTO serves the purpose to transfer data from the server to the client.
     * 
     * we can use the model class to fetch the data from the database (returns a list of Employee objects) 
     * and also to return that result to the client.
     * 
     * And that is not a good practice.
     * 
     * A much better practice is to have a model class to fetch the data from the database and to have a DTO class to return that result to the client.
     * */
    public class SystemUserEntity
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public IEnumerable<SystemUserRole> SystemUserRoleList { get; set; }
        //public IEnumerable<SystemRole> SystemRoleList { get; set; }
    }
}
