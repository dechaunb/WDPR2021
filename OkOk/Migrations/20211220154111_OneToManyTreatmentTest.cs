using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class OneToManyTreatmentTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treatment_AspNetUsers_ClientApplicationUserId",
                table: "Treatment");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "24ead0cf-877e-4ec2-b325-ce67c4236b7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "610b0cc0-6f19-46e2-b033-e290ddd6c0b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "7b824801-f924-462d-aae0-49d1656c6a9f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "c266a7fe-6e83-4275-a09e-d48956cb9a2d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "056937bb-1d6c-488a-a629-0212959e8834");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24ead0cf-877e-4ec2-b325-ce67c4236b7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "610b0cc0-6f19-46e2-b033-e290ddd6c0b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b824801-f924-462d-aae0-49d1656c6a9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c266a7fe-6e83-4275-a09e-d48956cb9a2d");

            migrationBuilder.RenameColumn(
                name: "ClientApplicationUserId",
                table: "Treatment",
                newName: "DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Treatment_ClientApplicationUserId",
                table: "Treatment",
                newName: "IX_Treatment_DoctorId");

            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "Treatment",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specialism",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SignUpRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Handled = table.Column<bool>(type: "INTEGER", nullable: false),
                    DoctorApplicationUserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignUpRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignUpRequest_AspNetUsers_DoctorApplicationUserId",
                        column: x => x.DoctorApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca60e46e-f45a-4acf-ba6a-31731b64c6d9", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "54dc975b-4075-4937-b530-a184b92c142e", 0, "7cfc72d2-9f7f-4943-83fc-2d826b61cd81", "IdentityUser", "dechaun@okokapp.nl", true, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEF1JEHaN6STP48qjWKpuP3vt31GIRoQrd+k8ic3+3g5wOLJO347sN7Lo6W7XyMjWrg==", "1234567890", true, "41e4840b-77b3-4898-9364-09f1ec80fab7", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5fc5eee9-60fd-4e0e-9a46-ffee3ef1b314", 0, "0d3f137c-f247-43f5-b6a5-31e5c949e7bd", "IdentityUser", "timothy@okokapp.nl", true, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAENmhaQvO/SoETTqHll43VstHAeX6R98M2IoFbZfPkP70gZGw8DI5GzGjTpcUe+vCIQ==", "1234567890", true, "53c3c84f-35b7-424a-be5e-719f8b9d6af8", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8a80fefa-44c6-435c-a438-6b87dc70e2ae", 0, "78135484-e3b6-40d7-8775-444c99610f96", "IdentityUser", "angelo@okokapp.nl", true, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEA0qxEkY+ITTlaheBhY2eJV9K6LOA/eghr4mBZQKxb7J9PLj0V5zMZe7VPH+IoIAUQ==", "1234567890", true, "529830ac-a0fa-4420-8425-be2f2f7f4ba4", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b062a111-d60f-434b-9477-cbd06023d0a4", 0, "295e3392-c3a9-420b-a7e7-c1a4c55747f7", "IdentityUser", "yash@okokapp.nl", true, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEL4MKPSd5yVAOAkrWBcCR4egyUDYqQun5NEHZPIbJYOlS7p3rW9dAzdTC2ujvmmB3g==", "1234567890", true, "9d98efa2-80fc-45b4-b63c-f2432dd9cf80", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ca60e46e-f45a-4acf-ba6a-31731b64c6d9", "54dc975b-4075-4937-b530-a184b92c142e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ca60e46e-f45a-4acf-ba6a-31731b64c6d9", "5fc5eee9-60fd-4e0e-9a46-ffee3ef1b314" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ca60e46e-f45a-4acf-ba6a-31731b64c6d9", "8a80fefa-44c6-435c-a438-6b87dc70e2ae" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ca60e46e-f45a-4acf-ba6a-31731b64c6d9", "b062a111-d60f-434b-9477-cbd06023d0a4" });

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_ClientId",
                table: "Treatment",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_SignUpRequest_DoctorApplicationUserId",
                table: "SignUpRequest",
                column: "DoctorApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatment_AspNetUsers_ClientId",
                table: "Treatment",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatment_AspNetUsers_DoctorId",
                table: "Treatment",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treatment_AspNetUsers_ClientId",
                table: "Treatment");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatment_AspNetUsers_DoctorId",
                table: "Treatment");

            migrationBuilder.DropTable(
                name: "SignUpRequest");

            migrationBuilder.DropIndex(
                name: "IX_Treatment_ClientId",
                table: "Treatment");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca60e46e-f45a-4acf-ba6a-31731b64c6d9", "54dc975b-4075-4937-b530-a184b92c142e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca60e46e-f45a-4acf-ba6a-31731b64c6d9", "5fc5eee9-60fd-4e0e-9a46-ffee3ef1b314" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca60e46e-f45a-4acf-ba6a-31731b64c6d9", "8a80fefa-44c6-435c-a438-6b87dc70e2ae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca60e46e-f45a-4acf-ba6a-31731b64c6d9", "b062a111-d60f-434b-9477-cbd06023d0a4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca60e46e-f45a-4acf-ba6a-31731b64c6d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54dc975b-4075-4937-b530-a184b92c142e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fc5eee9-60fd-4e0e-9a46-ffee3ef1b314");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a80fefa-44c6-435c-a438-6b87dc70e2ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b062a111-d60f-434b-9477-cbd06023d0a4");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Treatment");

            migrationBuilder.DropColumn(
                name: "Specialism",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Treatment",
                newName: "ClientApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Treatment_DoctorId",
                table: "Treatment",
                newName: "IX_Treatment_ClientApplicationUserId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "24ead0cf-877e-4ec2-b325-ce67c4236b7f", 0, "a0b96649-ff70-4ee2-b5fe-9efe4da86fad", "IdentityUser", "timothy@okokapp.nl", true, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEBMcmlHrTP9DxVhSnlXgJ+WScZ7GYn0WrTl4whc04NBhOIkuUYAz0GlOOl5UXMhCnw==", "1234567890", true, "716abd7a-3372-47a5-9e3d-59a743c38417", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "610b0cc0-6f19-46e2-b033-e290ddd6c0b1", 0, "88a2b8c2-0a30-4209-a7b2-4b9565c3be75", "IdentityUser", "angelo@okokapp.nl", true, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEDrdhXIQ9lvtVrVmyvGkuE4JXxZpgo5LCVIo33kPZ1V3+H3hfKCJPFjI8I0BX1CbTw==", "1234567890", true, "c66f49f3-d35d-46db-abd7-721c9bebffe8", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b824801-f924-462d-aae0-49d1656c6a9f", 0, "d13b34b1-7a1e-44cd-acfc-0ee01ffbe2c3", "IdentityUser", "yash@okokapp.nl", true, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEO7GrH0oL9JuPOJgiuPvBTULHM5DdvM2TU/oj9ZFqAzSH2TlajyapKRKORkkTae4CA==", "1234567890", true, "4ada1396-b106-4aa4-8ede-96d9832f8820", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c266a7fe-6e83-4275-a09e-d48956cb9a2d", 0, "fa74d86f-2a64-4120-a192-2a7f5a8b08f4", "IdentityUser", "dechaun@okokapp.nl", true, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAELOLhERSwZ2Ym9HEYE8mwKmX+ge7IYzK1Fpz8C/K3AQf8XaBEkF/AUaadhAM/q5RuA==", "1234567890", true, "524907d0-88d6-4ab1-9697-a4fdab0522f3", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "24ead0cf-877e-4ec2-b325-ce67c4236b7f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "610b0cc0-6f19-46e2-b033-e290ddd6c0b1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "7b824801-f924-462d-aae0-49d1656c6a9f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "c266a7fe-6e83-4275-a09e-d48956cb9a2d" });

            migrationBuilder.AddForeignKey(
                name: "FK_Treatment_AspNetUsers_ClientApplicationUserId",
                table: "Treatment",
                column: "ClientApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
