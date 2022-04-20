using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class employee2022042002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEmergencyContact_Employees_EmployeeId",
                table: "EmployeeEmergencyContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "13beee15-1dea-47ee-bd9f-b84d679830fb");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1cc461b8-7fa1-42db-ae42-8662c83d7f31");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a35da9db-1052-499b-a87e-d491787ae595");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8a81411c-5acb-43e5-8bc5-22437d8b397f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a6a92957-8d2d-4e04-b1d8-4999f112758e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b9759dad-2d3a-4d57-a78f-66e88b7e91f8");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmergencyContactId",
                table: "EmployeeEmergencyContact",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employee",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "FullName", "Gender", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1L, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@gmail.com", "Keith", "Keith Poon", 0, "Poon", "20205454" },
                    { 2L, new DateTime(1999, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ada@gmail.com", "Ada", "Ada Wong", 0, "Wong", "29294545" },
                    { 3L, new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "walter@gmail.com", "Walter", "Walter Ma", 0, "Ma", "29295454" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ApplicationId", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a2693486-411f-4176-a7a6-77a2085e5d65", null, "46cfbfac-0a78-43bb-b00b-82de546f0f0f", "Administrator", "Admin", null },
                    { "91078112-02cd-4cea-b704-7b1996664e79", null, "49b18fa6-3748-40c0-bb49-b5f22f02fc53", "Manager", "Manager", null },
                    { "37352c09-a4f4-4ade-8325-b65eda246875", null, "383d3765-a838-4d3e-837e-673d7153ae11", "General Staff", "General", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2cee74ed-7a8b-4478-b5a3-2ae1dbef0ffa", 0, "1a67fb16-759e-4a0a-b09f-6ddd44884fbf", null, false, false, null, null, null, null, null, false, "1f307a0d-0496-4e3a-9fd9-ed1668709399", false, "Admin" },
                    { "a3bb991f-561d-47df-8a76-fb6ea1614a10", 0, "584f8ab9-6a47-420b-9058-2ba30c507ca0", null, false, false, null, null, null, null, null, false, "f887fe27-8f99-4b82-b285-effeed8482c2", false, "Tester" },
                    { "ae948656-8c7c-48e6-a1b2-d2aa915e7786", 0, "b66ac9f8-2086-4138-aaf4-32122358e1e8", null, false, false, null, null, null, null, null, false, "1a1deb9a-c356-4f23-90e5-3c0fef38263a", false, "Demo" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEmergencyContact_Employee_EmployeeId",
                table: "EmployeeEmergencyContact",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEmergencyContact_Employee_EmployeeId",
                table: "EmployeeEmergencyContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "37352c09-a4f4-4ade-8325-b65eda246875");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "91078112-02cd-4cea-b704-7b1996664e79");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a2693486-411f-4176-a7a6-77a2085e5d65");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2cee74ed-7a8b-4478-b5a3-2ae1dbef0ffa");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a3bb991f-561d-47df-8a76-fb6ea1614a10");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ae948656-8c7c-48e6-a1b2-d2aa915e7786");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EmployeeEmergencyContact",
                newName: "EmergencyContactId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ApplicationId", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13beee15-1dea-47ee-bd9f-b84d679830fb", null, "7f75df32-9e34-4b06-861f-1d4014cbe233", "Administrator", "Admin", null },
                    { "a35da9db-1052-499b-a87e-d491787ae595", null, "e29270cd-357a-41a9-a1ef-403da582248a", "Manager", "Manager", null },
                    { "1cc461b8-7fa1-42db-ae42-8662c83d7f31", null, "130a5870-21e4-4c42-a426-bfda3050e686", "General Staff", "General", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8a81411c-5acb-43e5-8bc5-22437d8b397f", 0, "30bb0a51-5dce-4ef9-996a-eb6384d1598c", null, false, false, null, null, null, null, null, false, "e313d96b-ca9c-4816-a429-57894cb065f1", false, "Admin" },
                    { "a6a92957-8d2d-4e04-b1d8-4999f112758e", 0, "8b4833ed-0651-4d67-b9b4-a980b802f913", null, false, false, null, null, null, null, null, false, "29b0519a-46fe-48f4-b957-a1ff53edcf3a", false, "Tester" },
                    { "b9759dad-2d3a-4d57-a78f-66e88b7e91f8", 0, "1293cd45-6c5f-4589-b23a-2af93dc63e2b", null, false, false, null, null, null, null, null, false, "83f69eaf-ca32-4737-a0d5-771cf3118105", false, "Demo" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEmergencyContact_Employees_EmployeeId",
                table: "EmployeeEmergencyContact",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
