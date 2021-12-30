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
    public class CoreDataContext : IdentityDbContext<SystemUser, SystemRole, string, IdentityUserClaim<string>,
        SystemUserRole, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>
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
            builder.Entity<SystemUser>(entity => { 
                entity.ToTable(name: "Users");


                // The relationships between User and other entity types
                // Note that these relationships are configured with no navigation properties

                //// Each User can have many UserClaims
                //entity.HasMany<TUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

                //// Each User can have many UserLogins
                //entity.HasMany<TUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

                //// Each User can have many UserTokens
                //entity.HasMany<TUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

                //// Each User can have many entries in the UserRole join table
                //entity.HasMany<SystemUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

                entity.HasMany(u => u.SystemUserRoleList)
                 .WithOne(ur => ur.User)
                 .HasForeignKey(ur => ur.UserId)
                 .IsRequired();

                //entity.HasMany(sr => sr.SystemUserRoleList).WithOne().HasForeignKey(x => x.UserId).IsRequired();

                //entity.HasMany<SystemUser>().WithOne().HasForeignKey(x => x.Id);
            });
            builder.Entity<SystemRole>(entity => {
                entity.ToTable(name: "Roles");
                entity.HasKey(r => r.Id);

                entity.HasMany(u => u.SystemUserRoleList)
                    .WithOne(ur => ur.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();
                entity.HasMany<IdentityRoleClaim<string>>()
                    .WithOne()
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();
            });

            builder.Entity<SystemUserRole>(entity =>
            {
                entity.ToTable(name: "UserRoles");
                entity.HasKey(r => new { r.UserId, r.RoleId });

                entity.HasOne(e=>e.Role)
                .WithMany(e=>e.SystemUserRoleList)
                .HasForeignKey(e=>e.RoleId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.User)
                .WithMany(e => e.SystemUserRoleList)
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

                //in case you chagned the TKey type
                //entity.HasKey(key => new { key.UserId, key.RoleId });

                // define the relationship between SystemUserRole and SystemRole
                //entity.HasOne(x => x.Role).WithMany(x => x.SystemUserRoleList).HasForeignKey(x => x.RoleId);

                // define the relationship between SystemUserRole and SystemUser
                //entity.HasOne(x => x.User).WithMany(x => x.SystemUserRoleList).HasForeignKey(x => x.UserId);
            });

            //    builder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaims"); });
            //    builder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLogins"); });
            //    builder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaims"); });
            //    builder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokens"); });


            builder.Entity<IdentityRoleClaim<string>>(roleClaim =>
            {
                roleClaim.HasKey(rc => rc.Id);
                roleClaim.ToTable("RoleClaims");
            });

            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
        }

        public void CreateDevDummyData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SystemRole>().HasData(new SystemRole
            {
                Name = "Admin",
                DisplayName = "Administrator"
            }, new SystemRole
            {
                Name = "Manager",
                DisplayName = "Manager"
            }, new SystemRole
            {
                Name = "General",
                DisplayName = "General Staff"
            });

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
