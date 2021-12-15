using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class initialemployee202112152 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3d47227c-a27f-48a3-860f-0c11bce60907");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7378565d-e6cf-4f1a-a066-618fbbac2ad6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d5039ea5-d219-4278-8532-9a54672816df");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d5039ea5-d219-4278-8532-9a54672816df", 0, "8c155d46-2039-4d33-ae78-761c3e93028b", null, false, false, null, null, null, null, null, false, "4f25832b-18fd-435b-8822-fff9b3f2341d", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3d47227c-a27f-48a3-860f-0c11bce60907", 0, "beaf3b56-b0b0-4787-9d09-7d9382f67044", null, false, false, null, null, null, null, null, false, "47da6cae-183d-4320-9376-a594a52863a5", false, "Tester" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7378565d-e6cf-4f1a-a066-618fbbac2ad6", 0, "3e226fd6-6a49-41ee-8c80-0695ae66783e", null, false, false, null, null, null, null, null, false, "bd877062-b985-4520-9613-22ec09ae0d85", false, "Demo" });
        }
    }
}
