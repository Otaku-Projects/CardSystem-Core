﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.DataContext;

namespace WebAPI.Migrations
{
    [DbContext(typeof(CoreDataContext))]
    [Migration("20220420180545_seed.employeeEmergencyContact.20220420.03")]
    partial class seedemployeeEmergencyContact2022042003
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationFunctionSystemRole", b =>
                {
                    b.Property<int>("FunctionsId")
                        .HasColumnType("int");

                    b.Property<string>("RolesId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FunctionsId", "RolesId");

                    b.HasIndex("RolesId");

                    b.ToTable("ApplicationFunctionSystemRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("WebAPI.Model.ApplicationFunction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<int?>("FunctionGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("FunctionGroupId");

                    b.ToTable("ApplicationFunction");
                });

            modelBuilder.Entity("WebAPI.Model.ApplicationSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationSystem");
                });

            modelBuilder.Entity("WebAPI.Model.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateOfBirth = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test@gmail.com",
                            FirstName = "Keith",
                            FullName = "Keith Poon",
                            Gender = 0,
                            LastName = "Poon",
                            PhoneNumber = "20205454"
                        },
                        new
                        {
                            Id = 2L,
                            DateOfBirth = new DateTime(1999, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ada@gmail.com",
                            FirstName = "Ada",
                            FullName = "Ada Wong",
                            Gender = 0,
                            LastName = "Wong",
                            PhoneNumber = "29294545"
                        },
                        new
                        {
                            Id = 3L,
                            DateOfBirth = new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "walter@gmail.com",
                            FirstName = "Walter",
                            FullName = "Walter Ma",
                            Gender = 0,
                            LastName = "Ma",
                            PhoneNumber = "29295454"
                        });
                });

            modelBuilder.Entity("WebAPI.Model.EmployeeEmergencyContact", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("EmployeeId")
                        .HasColumnType("bigint");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeEmergencyContact");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            EmployeeId = 1L,
                            FullName = "Kennth Cheung",
                            Phone = "90905454",
                            Relationship = "Uncle"
                        },
                        new
                        {
                            Id = 2L,
                            EmployeeId = 1L,
                            FullName = "Leo Poon",
                            Phone = "90995454",
                            Relationship = "Father"
                        },
                        new
                        {
                            Id = 3L,
                            EmployeeId = 2L,
                            FullName = "Anna Lee",
                            Phone = "90904545",
                            Relationship = "Mother"
                        },
                        new
                        {
                            Id = 4L,
                            EmployeeId = 2L,
                            FullName = "Ricky Wong",
                            Phone = "90994545",
                            Relationship = "Father"
                        },
                        new
                        {
                            Id = 5L,
                            EmployeeId = 3L,
                            FullName = "Ivy Chan",
                            Phone = "90905454",
                            Relationship = "Step Father"
                        });
                });

            modelBuilder.Entity("WebAPI.Model.FunctionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDisable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FunctionGroup");
                });

            modelBuilder.Entity("WebAPI.Model.SystemRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "ec8cb413-28c5-4a79-8b80-f61d5403c6d9",
                            ConcurrencyStamp = "31146fb0-254d-4c2f-b079-08aa0f578a5b",
                            DisplayName = "Administrator",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "7874ef41-dbbe-49dd-a7ac-6ab5eb2535e2",
                            ConcurrencyStamp = "4832dfca-1e12-474d-8460-e0d892c49589",
                            DisplayName = "Manager",
                            Name = "Manager"
                        },
                        new
                        {
                            Id = "d6136cf4-f496-4cd2-b219-429cc9e806d2",
                            ConcurrencyStamp = "46697f88-2967-4119-8174-8dcf9ad3d381",
                            DisplayName = "General Staff",
                            Name = "General"
                        });
                });

            modelBuilder.Entity("WebAPI.Model.SystemUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "623f1f0a-ed73-4396-aaa5-1350a0c08ea6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7493a463-a405-46ec-bde7-84979d472512",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8381b486-b390-46bd-aaab-e3e578a0904c",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "3ae6274b-e82d-4229-aeeb-505bd37c52a3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "673e7647-be11-41f3-aef1-819f477437ec",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b7a0523f-3c55-4f27-8cd0-274c57947337",
                            TwoFactorEnabled = false,
                            UserName = "Tester"
                        },
                        new
                        {
                            Id = "5a546b5d-799b-423e-bb65-499e9bed14e9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ce5e86ca-11fc-44a3-869a-622bc13da586",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "529ea267-f567-49e6-95a9-6cc4e739eff4",
                            TwoFactorEnabled = false,
                            UserName = "Demo"
                        });
                });

            modelBuilder.Entity("WebAPI.Model.SystemUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("ApplicationFunctionSystemRole", b =>
                {
                    b.HasOne("WebAPI.Model.ApplicationFunction", null)
                        .WithMany()
                        .HasForeignKey("FunctionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Model.SystemRole", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("WebAPI.Model.SystemRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebAPI.Model.SystemUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebAPI.Model.SystemUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebAPI.Model.SystemUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI.Model.ApplicationFunction", b =>
                {
                    b.HasOne("WebAPI.Model.ApplicationSystem", "Application")
                        .WithMany("Functions")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Model.FunctionGroup", "FunctionGroup")
                        .WithMany("Function")
                        .HasForeignKey("FunctionGroupId");

                    b.Navigation("Application");

                    b.Navigation("FunctionGroup");
                });

            modelBuilder.Entity("WebAPI.Model.EmployeeEmergencyContact", b =>
                {
                    b.HasOne("WebAPI.Model.Employee", "Employee")
                        .WithMany("EmergencyContactList")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("WebAPI.Model.SystemRole", b =>
                {
                    b.HasOne("WebAPI.Model.ApplicationSystem", "Application")
                        .WithMany("Roles")
                        .HasForeignKey("ApplicationId");

                    b.Navigation("Application");
                });

            modelBuilder.Entity("WebAPI.Model.SystemUserRole", b =>
                {
                    b.HasOne("WebAPI.Model.SystemRole", "Role")
                        .WithMany("SystemUserRoleList")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Model.SystemUser", "User")
                        .WithMany("SystemUserRoleList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebAPI.Model.ApplicationSystem", b =>
                {
                    b.Navigation("Functions");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("WebAPI.Model.Employee", b =>
                {
                    b.Navigation("EmergencyContactList");
                });

            modelBuilder.Entity("WebAPI.Model.FunctionGroup", b =>
                {
                    b.Navigation("Function");
                });

            modelBuilder.Entity("WebAPI.Model.SystemRole", b =>
                {
                    b.Navigation("SystemUserRoleList");
                });

            modelBuilder.Entity("WebAPI.Model.SystemUser", b =>
                {
                    b.Navigation("SystemUserRoleList");
                });
#pragma warning restore 612, 618
        }
    }
}
