using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class seedemployeeEmergencyContact2022042003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "EmployeeEmergencyContact",
                columns: new[] { "Id", "EmployeeId", "FullName", "Phone", "Relationship" },
                values: new object[,]
                {
                    { 1L, 1L, "Kennth Cheung", "90905454", "Uncle" },
                    { 2L, 1L, "Leo Poon", "90995454", "Father" },
                    { 3L, 2L, "Anna Lee", "90904545", "Mother" },
                    { 4L, 2L, "Ricky Wong", "90994545", "Father" },
                    { 5L, 3L, "Ivy Chan", "90905454", "Step Father" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeEmergencyContact",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "EmployeeEmergencyContact",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "EmployeeEmergencyContact",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "EmployeeEmergencyContact",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "EmployeeEmergencyContact",
                keyColumn: "Id",
                keyValue: 5L);

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
        }
    }
}
