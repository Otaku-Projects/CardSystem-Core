using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class initialemployee202112161 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "371724c0-c63b-490d-9ae1-94c1f7c92e73");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "629c8e76-11d3-4065-9e78-d091e3717a6a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "73c412e5-510b-4913-8315-479127125b78");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9a7f3d42-6a5c-4e22-855b-8306a9861436", 0, "ffe0f56d-1ea5-4a06-b559-4c3d85529d53", null, false, false, null, null, null, null, null, false, "6a708f10-a686-4c2d-aead-a6874d01899c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8a65061d-2fd8-4d90-8fa1-ade7b5801b3a", 0, "8cd73bdf-7c02-4812-9fc6-e0d120b9203b", null, false, false, null, null, null, null, null, false, "8a77028c-12a3-4d36-87b9-0f7031104520", false, "Tester" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "184826be-9ba3-4815-81c8-1398e29852ec", 0, "20f98c25-26bf-4484-b851-9d3080ef69d5", null, false, false, null, null, null, null, null, false, "f969c279-e07f-4339-9263-67fac03c7daa", false, "Demo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "184826be-9ba3-4815-81c8-1398e29852ec");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8a65061d-2fd8-4d90-8fa1-ade7b5801b3a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9a7f3d42-6a5c-4e22-855b-8306a9861436");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "371724c0-c63b-490d-9ae1-94c1f7c92e73", 0, "5bf3d645-3acc-4757-b46e-6d72af4fffb7", null, false, false, null, null, null, null, null, false, "454da416-0f5d-4b9a-9ce6-b12d2b387584", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "629c8e76-11d3-4065-9e78-d091e3717a6a", 0, "99f20cec-d603-465f-950d-c63bd2e5ecdf", null, false, false, null, null, null, null, null, false, "86217be8-9d6c-4f5b-858c-3ea674bf116a", false, "Tester" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "73c412e5-510b-4913-8315-479127125b78", 0, "184d2422-044c-42b9-bea6-4cdb804b58cf", null, false, false, null, null, null, null, null, false, "15f033d0-d284-4f38-85e3-0db1604b9330", false, "Demo" });
        }
    }
}
