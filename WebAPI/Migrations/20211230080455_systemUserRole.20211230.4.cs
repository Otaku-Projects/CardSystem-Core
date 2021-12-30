using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class systemUserRole202112304 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_Roles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Users_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_Users_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_Users_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ApplicationFunctionSystemUserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

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

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaims");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "Roles",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ApplicationFunctionSystemRole",
                columns: table => new
                {
                    FunctionsId = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationFunctionSystemRole", x => new { x.FunctionsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_ApplicationFunctionSystemRole_ApplicationFunction_FunctionsId",
                        column: x => x.FunctionsId,
                        principalTable: "ApplicationFunction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationFunctionSystemRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationFunctionSystemRole_RolesId",
                table: "ApplicationFunctionSystemRole",
                column: "RolesId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_SystemRoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_SystemUserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens");

            migrationBuilder.DropTable(
                name: "ApplicationFunctionSystemRole");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_SystemRoleId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_SystemUserId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims");

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

            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Roles",
                newName: "RoleName");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ApplicationFunctionSystemUserRole",
                columns: table => new
                {
                    FunctionsId = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationFunctionSystemUserRole", x => new { x.FunctionsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_ApplicationFunctionSystemUserRole_ApplicationFunction_FunctionsId",
                        column: x => x.FunctionsId,
                        principalTable: "ApplicationFunction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationFunctionSystemUserRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationFunctionSystemUserRole_RolesId",
                table: "ApplicationFunctionSystemUserRole",
                column: "RolesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_Roles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Users_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_Users_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_Users_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
