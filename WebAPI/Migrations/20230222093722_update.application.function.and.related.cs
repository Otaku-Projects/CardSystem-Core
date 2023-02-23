using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class updateapplicationfunctionandrelated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationFunctionSystemRole_ApplicationFunction_FunctionsId",
                table: "ApplicationFunctionSystemRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_ApplicationSystem_ApplicationId",
                table: "Roles");

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

            migrationBuilder.RenameColumn(
                name: "ApplicationId",
                table: "Roles",
                newName: "ApplicationSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_ApplicationId",
                table: "Roles",
                newName: "IX_Roles_ApplicationSystemId");

            migrationBuilder.RenameColumn(
                name: "FunctionsId",
                table: "ApplicationFunctionSystemRole",
                newName: "ApplicationFunctionsListId");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "ApplicationFunction",
                newName: "IconName");

            migrationBuilder.AddColumn<string>(
                name: "IconCSS",
                table: "ApplicationFunction",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "ApplicationFunction",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ApplicationSystemId", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "acc8de46-2f40-4826-91e7-56ba9d1d88e0", null, "ed5c47e2-5e04-4235-846a-ef26ffeb05f3", "Administrator", "Admin", null },
                    { "97e426ed-1e2c-496f-8128-b4e72684f946", null, "9ec7d8e6-d10e-4927-857b-c7f0b47bcd71", "Manager", "Manager", null },
                    { "b01eeaf8-8d33-4db5-90a6-a850bea9823d", null, "63b1d515-27d7-4ed1-a4f5-1609e4dcc102", "General Staff", "General", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a5fee3da-6305-42f7-83d5-b868d5d02dec", 0, "eb5d426c-c98f-4958-a9d9-4fed8c28236d", null, false, false, null, null, null, null, null, false, "749f5a81-6006-4aa8-b53e-deef83a3f2c1", false, "Admin" },
                    { "9abe312a-b4ad-4e44-bb1f-fae3164f5b88", 0, "16f337f1-bb21-493e-a964-fac286a7c1d5", null, false, false, null, null, null, null, null, false, "7365680f-2b46-445c-878b-a53b59810600", false, "Tester" },
                    { "1fde5200-9a39-41b6-950b-90aff9010260", 0, "4c4686a7-0c5b-4b97-b945-bf9b9f9ed893", null, false, false, null, null, null, null, null, false, "9b391b36-2f43-429c-bd32-058a34edf6bf", false, "Demo" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationFunctionSystemRole_ApplicationFunction_ApplicationFunctionsListId",
                table: "ApplicationFunctionSystemRole",
                column: "ApplicationFunctionsListId",
                principalTable: "ApplicationFunction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_ApplicationSystem_ApplicationSystemId",
                table: "Roles",
                column: "ApplicationSystemId",
                principalTable: "ApplicationSystem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationFunctionSystemRole_ApplicationFunction_ApplicationFunctionsListId",
                table: "ApplicationFunctionSystemRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_ApplicationSystem_ApplicationSystemId",
                table: "Roles");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "97e426ed-1e2c-496f-8128-b4e72684f946");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "acc8de46-2f40-4826-91e7-56ba9d1d88e0");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b01eeaf8-8d33-4db5-90a6-a850bea9823d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1fde5200-9a39-41b6-950b-90aff9010260");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9abe312a-b4ad-4e44-bb1f-fae3164f5b88");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a5fee3da-6305-42f7-83d5-b868d5d02dec");

            migrationBuilder.DropColumn(
                name: "IconCSS",
                table: "ApplicationFunction");

            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "ApplicationFunction");

            migrationBuilder.RenameColumn(
                name: "ApplicationSystemId",
                table: "Roles",
                newName: "ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_ApplicationSystemId",
                table: "Roles",
                newName: "IX_Roles_ApplicationId");

            migrationBuilder.RenameColumn(
                name: "ApplicationFunctionsListId",
                table: "ApplicationFunctionSystemRole",
                newName: "FunctionsId");

            migrationBuilder.RenameColumn(
                name: "IconName",
                table: "ApplicationFunction",
                newName: "Icon");

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
                name: "FK_ApplicationFunctionSystemRole_ApplicationFunction_FunctionsId",
                table: "ApplicationFunctionSystemRole",
                column: "FunctionsId",
                principalTable: "ApplicationFunction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_ApplicationSystem_ApplicationId",
                table: "Roles",
                column: "ApplicationId",
                principalTable: "ApplicationSystem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
