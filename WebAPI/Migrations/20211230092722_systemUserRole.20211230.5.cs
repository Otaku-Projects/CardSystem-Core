using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class systemUserRole202112305 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_SystemRoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_SystemUserId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_SystemRoleId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_SystemUserId",
                table: "UserRoles");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8c288899-9121-4ddf-8211-e20c2960fcb1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b77ed690-2bf3-49ea-9037-46d0a5412a7e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "db691785-d9ee-4ef2-beba-8ef5acacc52f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1ed3ad8d-f703-4928-8967-d670e86da98e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8b227392-985b-4245-98cf-7fbc1f50bc02");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e66d3aae-2988-4ff6-8bc9-46c6f40bd8fe");

            migrationBuilder.DropColumn(
                name: "SystemRoleId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "SystemUserId",
                table: "UserRoles");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "SystemRoleId",
                table: "UserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemUserId",
                table: "UserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ApplicationId", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b77ed690-2bf3-49ea-9037-46d0a5412a7e", null, "c025d3a1-38e5-4c89-b60a-4c8f57ea8eef", "Administrator", "Admin", null },
                    { "8c288899-9121-4ddf-8211-e20c2960fcb1", null, "b00d47ca-866e-438a-837f-37a2d52e6d24", "Manager", "Manager", null },
                    { "db691785-d9ee-4ef2-beba-8ef5acacc52f", null, "8e8c19f9-5124-4e35-b599-72e7a0e7e218", "General Staff", "General", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8b227392-985b-4245-98cf-7fbc1f50bc02", 0, "7af89539-25ab-48df-8a12-d609254bfc5c", null, false, false, null, null, null, null, null, false, "26c57506-2d21-4d71-a5ca-ddb00461293c", false, "Admin" },
                    { "e66d3aae-2988-4ff6-8bc9-46c6f40bd8fe", 0, "8d42bcc7-dd4a-479f-b162-027dec990de2", null, false, false, null, null, null, null, null, false, "2e9d37b8-482b-478a-bad7-66f1a26e00a7", false, "Tester" },
                    { "1ed3ad8d-f703-4928-8967-d670e86da98e", 0, "4fb35340-2c3b-44e6-a1c6-3ebbb908025f", null, false, false, null, null, null, null, null, false, "e1691704-487d-42bf-b05a-fe33bb7fd1fb", false, "Demo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_SystemRoleId",
                table: "UserRoles",
                column: "SystemRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_SystemUserId",
                table: "UserRoles",
                column: "SystemUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_SystemRoleId",
                table: "UserRoles",
                column: "SystemRoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_SystemUserId",
                table: "UserRoles",
                column: "SystemUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
