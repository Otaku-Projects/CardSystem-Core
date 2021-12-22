using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEmergencyContact> EmployeeEmergencyContact { get; set; }

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

            //modelBuilder.Entity<Employee>().HasData(new Employee
            //{ 
            //    EmployeeId = Guid.NewGuid().ToString(),
            //    FirstName = "Peter",
            //    LastName = "Pan"
            //}, new Employee
            //{
            //    FirstName = "Chan",
            //    LastName = "Tai Men"
            //}
            //    );

            //modelBuilder.Configurations.Add(new DepartmentTypeConfiguration());

            // generate dummy data
            modelBuilder.Entity<Employee>().Property(f => f.EmployeeId).ValueGeneratedOnAdd();
            modelBuilder.Entity<EmployeeEmergencyContact>().Property(f => f.EmergencyContactId).ValueGeneratedOnAdd();

            //modelBuilder.Entity<Employee>().Property(p => p.EmployeeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


        }
    }
}
