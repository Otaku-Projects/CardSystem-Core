using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;

namespace WebAPI.DataContext
{
    public class CoreDataContext : IdentityDbContext<SystemUser, SystemUserRole, string>
    {
        public CoreDataContext(DbContextOptions<CoreDataContext> options)
            : base(options)
        {
        }
        //public DbSet<ApplicationSystem> Applications { get; set; }
        //public DbSet<ApplicationFunction> Functions { get; set; }
        //public DbSet<FunctionGroup> FunctionGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.CreateDevDummyData(builder);

            //Rename
            builder.Entity<SystemUser>(entity => { entity.ToTable(name: "Users"); });
            builder.Entity<SystemUserRole>(entity => { entity.ToTable(name: "Roles"); });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
                    //in case you chagned the TKey type
                    entity.HasKey(key => new { key.UserId, key.RoleId });
            });

            //    builder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaims"); });
            //    builder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLogins"); });
            //    builder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaims"); });
            //    builder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokens"); });
        }

        public void CreateDevDummyData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SystemUser>().HasData(new SystemUser
            {
                UserName = "Admin"
            }, new SystemUser
            {
                UserName = "Tester"
            }, new SystemUser
            {
                UserName = "Demo"
            });
        }
    }
}
