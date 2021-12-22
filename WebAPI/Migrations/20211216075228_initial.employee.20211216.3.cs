using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class initialemployee202112163 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmployeeEmergencyContact",
                columns: table => new
                {
                    EmergencyContactId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEmergencyContact", x => x.EmergencyContactId);
                    table.ForeignKey(
                        name: "FK_EmployeeEmergencyContact_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEmergencyContact_EmployeeId",
                table: "EmployeeEmergencyContact",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeEmergencyContact");

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

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");

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
    }
}
