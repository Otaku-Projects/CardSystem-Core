using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class initialDTO20211220 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1b1d32fa-1716-44dc-ae09-9e9d9d50407b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47ab6368-1ef6-4e52-bf59-fd497a14a22a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "813f78d0-5524-4df2-8f95-cabac3ebd1d6");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b6061aab-a204-4a1a-9ff6-fa6e751df500", 0, "9e8f70e7-bfe6-4a73-866c-29be6811758a", null, false, false, null, null, null, null, null, false, "bd6629e2-56fd-4f34-9940-b5500ee9ef29", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fe68b0c4-88c1-41e5-b80e-dd3e1bd14029", 0, "3263f1b3-e47d-47dd-926b-f74d3be59b8a", null, false, false, null, null, null, null, null, false, "7e17ca00-6ad0-4c8e-9f5b-7b76bcd4d27a", false, "Tester" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cdd0325a-0d84-4389-b878-76b500f5021e", 0, "cdb25bdf-dc7b-4f53-bd79-0dce32bb067b", null, false, false, null, null, null, null, null, false, "d095675c-21d7-42ff-9ef6-6aa1d08e5030", false, "Demo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b6061aab-a204-4a1a-9ff6-fa6e751df500");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cdd0325a-0d84-4389-b878-76b500f5021e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fe68b0c4-88c1-41e5-b80e-dd3e1bd14029");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1b1d32fa-1716-44dc-ae09-9e9d9d50407b", 0, "7f452eff-0df4-4155-8053-207f86db2a0a", null, false, false, null, null, null, null, null, false, "ae25a539-da7f-4b50-85ef-d1bba3383a91", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "813f78d0-5524-4df2-8f95-cabac3ebd1d6", 0, "9c065451-d2ae-43b4-8e16-9b9c78dc48aa", null, false, false, null, null, null, null, null, false, "af061284-8a6d-49a1-bc2a-f0c7f9540e0b", false, "Tester" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "47ab6368-1ef6-4e52-bf59-fd497a14a22a", 0, "134fa69d-5c60-49ee-bf56-888f54461f88", null, false, false, null, null, null, null, null, false, "006eec73-13b4-42d2-86e8-3fe14d3b64c4", false, "Demo" });
        }
    }
}
