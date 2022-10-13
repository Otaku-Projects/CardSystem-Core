using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class initialbaseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationFunction_FunctionGroup_FunctionGroupId",
                table: "ApplicationFunction");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationFunctionSystemRole_Roles_RolesId",
                table: "ApplicationFunctionSystemRole");

            migrationBuilder.DropTable(
                name: "FunctionGroup");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7874ef41-dbbe-49dd-a7ac-6ab5eb2535e2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d6136cf4-f496-4cd2-b219-429cc9e806d2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ec8cb413-28c5-4a79-8b80-f61d5403c6d9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3ae6274b-e82d-4229-aeeb-505bd37c52a3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5a546b5d-799b-423e-bb65-499e9bed14e9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "623f1f0a-ed73-4396-aaa5-1350a0c08ea6");

            migrationBuilder.RenameColumn(
                name: "RolesId",
                table: "ApplicationFunctionSystemRole",
                newName: "RoleListId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationFunctionSystemRole_RolesId",
                table: "ApplicationFunctionSystemRole",
                newName: "IX_ApplicationFunctionSystemRole_RoleListId");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeEmergencyContact",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeeEmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "EmployeeEmergencyContact",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EmployeeEmergencyContact",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeeEmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ApplicationSystem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ApplicationSystem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ApplicationSystem",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ApplicationSystem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ApplicationSystem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ApplicationFunction",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ApplicationFunction",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ApplicationFunction",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ApplicationFunction",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ApplicationFunction",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ApplicationFunctionGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconCSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDisable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationFunctionGroup", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ApplicationId", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9ecf849e-5f0b-4082-88b8-80ad7760c2a7", null, "e44784e4-8bf7-4a74-980b-a74c734ce8b2", "Administrator", "Admin", null },
                    { "70894ca0-8850-4794-8e4b-ca89622510bf", null, "c6fbdc60-3d6a-4420-8292-fc203b8359e3", "Manager", "Manager", null },
                    { "8c567048-b5e1-4b51-8d56-d30dd239edcd", null, "f7c518db-0d84-4364-9a57-cb810a76d24b", "General Staff", "General", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "647169db-863a-4964-b92d-59835c2603ba", 0, "3dbd9ed7-a069-46db-a3ad-c9ed6cbfdb8f", null, false, false, null, null, null, null, null, false, "c8dc5cf6-2624-4422-8cc8-24fa91260641", false, "Admin" },
                    { "02586ad9-c0b4-4c36-8a74-685e22280d31", 0, "bec44b46-40cb-4cda-b86e-00c5f0dd8362", null, false, false, null, null, null, null, null, false, "8f6f84b9-eb2b-43a2-9325-2d7534f8b7ec", false, "Tester" },
                    { "39441903-b374-4e20-b3ef-19930c5a5216", 0, "14937389-fc1e-4e6e-a065-b882c56739b3", null, false, false, null, null, null, null, null, false, "183704bc-a8bd-4174-80d8-a8923c3a8c51", false, "Demo" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationFunction_ApplicationFunctionGroup_FunctionGroupId",
                table: "ApplicationFunction",
                column: "FunctionGroupId",
                principalTable: "ApplicationFunctionGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationFunctionSystemRole_Roles_RoleListId",
                table: "ApplicationFunctionSystemRole",
                column: "RoleListId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationFunction_ApplicationFunctionGroup_FunctionGroupId",
                table: "ApplicationFunction");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationFunctionSystemRole_Roles_RoleListId",
                table: "ApplicationFunctionSystemRole");

            migrationBuilder.DropTable(
                name: "ApplicationFunctionGroup");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "70894ca0-8850-4794-8e4b-ca89622510bf");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8c567048-b5e1-4b51-8d56-d30dd239edcd");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9ecf849e-5f0b-4082-88b8-80ad7760c2a7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "02586ad9-c0b4-4c36-8a74-685e22280d31");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39441903-b374-4e20-b3ef-19930c5a5216");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "647169db-863a-4964-b92d-59835c2603ba");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeEmergencyContact");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "EmployeeEmergencyContact");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "EmployeeEmergencyContact");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EmployeeEmergencyContact");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "EmployeeEmergencyContact");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ApplicationSystem");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ApplicationSystem");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ApplicationSystem");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ApplicationSystem");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ApplicationSystem");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ApplicationFunction");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ApplicationFunction");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ApplicationFunction");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ApplicationFunction");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ApplicationFunction");

            migrationBuilder.RenameColumn(
                name: "RoleListId",
                table: "ApplicationFunctionSystemRole",
                newName: "RolesId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationFunctionSystemRole_RoleListId",
                table: "ApplicationFunctionSystemRole",
                newName: "IX_ApplicationFunctionSystemRole_RolesId");

            migrationBuilder.CreateTable(
                name: "FunctionGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDisable = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionGroup", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ApplicationId", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ec8cb413-28c5-4a79-8b80-f61d5403c6d9", null, "31146fb0-254d-4c2f-b079-08aa0f578a5b", "Administrator", "Admin", null },
                    { "7874ef41-dbbe-49dd-a7ac-6ab5eb2535e2", null, "4832dfca-1e12-474d-8460-e0d892c49589", "Manager", "Manager", null },
                    { "d6136cf4-f496-4cd2-b219-429cc9e806d2", null, "46697f88-2967-4119-8174-8dcf9ad3d381", "General Staff", "General", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "623f1f0a-ed73-4396-aaa5-1350a0c08ea6", 0, "7493a463-a405-46ec-bde7-84979d472512", null, false, false, null, null, null, null, null, false, "8381b486-b390-46bd-aaab-e3e578a0904c", false, "Admin" },
                    { "3ae6274b-e82d-4229-aeeb-505bd37c52a3", 0, "673e7647-be11-41f3-aef1-819f477437ec", null, false, false, null, null, null, null, null, false, "b7a0523f-3c55-4f27-8cd0-274c57947337", false, "Tester" },
                    { "5a546b5d-799b-423e-bb65-499e9bed14e9", 0, "ce5e86ca-11fc-44a3-869a-622bc13da586", null, false, false, null, null, null, null, null, false, "529ea267-f567-49e6-95a9-6cc4e739eff4", false, "Demo" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationFunction_FunctionGroup_FunctionGroupId",
                table: "ApplicationFunction",
                column: "FunctionGroupId",
                principalTable: "FunctionGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationFunctionSystemRole_Roles_RolesId",
                table: "ApplicationFunctionSystemRole",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
