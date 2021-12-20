using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class ManyToManyChatApplicationUserSupportGroupTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GuardianChild_Children_ChildId",
                table: "GuardianChild");

            migrationBuilder.DropForeignKey(
                name: "FK_GuardianChild_Guardians_GuardianId",
                table: "GuardianChild");

            migrationBuilder.DropForeignKey(
                name: "FK_SignUpRequest_AspNetUsers_DoctorApplicationUserId",
                table: "SignUpRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatment_AspNetUsers_ClientId",
                table: "Treatment");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatment_AspNetUsers_DoctorId",
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

            migrationBuilder.RenameColumn(
                name: "DoctorApplicationUserId",
                table: "SignUpRequest",
                newName: "DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_SignUpRequest_DoctorApplicationUserId",
                table: "SignUpRequest",
                newName: "IX_SignUpRequest_DoctorId");

            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "SignUpRequest",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SupportGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ChatUserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatApplicationUserSupportGroup",
                columns: table => new
                {
                    ChatUserId = table.Column<string>(type: "TEXT", nullable: false),
                    GroupId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatApplicationUserSupportGroup", x => new { x.ChatUserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_ChatApplicationUserSupportGroup_AspNetUsers_ChatUserId",
                        column: x => x.ChatUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatApplicationUserSupportGroup_SupportGroup_GroupId",
                        column: x => x.GroupId,
                        principalTable: "SupportGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29dc62a3-4483-43a0-af1f-65d127ec4465", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b251c7a-fdaa-4db8-8d69-f7d6957ecd28", 0, "67170085-262e-4216-a1f6-26c0999f18a0", "IdentityUser", "yash@okokapp.nl", true, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEEV1nrJWk+oX2XRBTl7Nuf1kV5dHP34vsB2haHSzCr2VLH8JrrnV8oG2bnpWgs24MA==", "1234567890", true, "9072ee5f-2276-4065-a4b7-1ac7257ec208", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6718af22-3490-4459-9ace-8c917ded7e18", 0, "404ff9f5-817a-445b-a123-f41175f471c9", "IdentityUser", "dechaun@okokapp.nl", true, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEByTKgTtztGpRgLWmYVLk4iyFR5p42JI5dX39WCzvoscjewc14MsQc3DsyQpOlshqQ==", "1234567890", true, "a360087f-e19e-4ae5-a1fc-959bea84404f", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aeaf6880-93d3-4942-8f0e-7325e10529e4", 0, "9404862c-0cb1-4121-90dc-5cc118e61b02", "IdentityUser", "angelo@okokapp.nl", true, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEEeswIUuI0fgl/dfzgJmcvE9MLLk7Dc0k/qnevR3Hkx8DDsMEvGH6b4NxY0Zbl7azg==", "1234567890", true, "a9bfbc94-bc81-444a-a471-56ab85978413", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eccb54df-5ac9-4e68-9fba-df19f93e5535", 0, "473cacd5-7854-48d0-bae1-cb7a63c03271", "IdentityUser", "timothy@okokapp.nl", true, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEIXO1GThu3Q5RzmZtXxVa6qK67uknVK5pqbwebDRpugMhTWfQx7t0R3rCPT/MwGVig==", "1234567890", true, "be58d4f2-fe30-47d5-a98d-e6cd5a340096", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "29dc62a3-4483-43a0-af1f-65d127ec4465", "3b251c7a-fdaa-4db8-8d69-f7d6957ecd28" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "29dc62a3-4483-43a0-af1f-65d127ec4465", "6718af22-3490-4459-9ace-8c917ded7e18" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "29dc62a3-4483-43a0-af1f-65d127ec4465", "aeaf6880-93d3-4942-8f0e-7325e10529e4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "29dc62a3-4483-43a0-af1f-65d127ec4465", "eccb54df-5ac9-4e68-9fba-df19f93e5535" });

            migrationBuilder.CreateIndex(
                name: "IX_SignUpRequest_ClientId",
                table: "SignUpRequest",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChatApplicationUserSupportGroup_GroupId",
                table: "ChatApplicationUserSupportGroup",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_GuardianChild_AspNetUsers_ChildId",
                table: "GuardianChild",
                column: "ChildId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GuardianChild_AspNetUsers_GuardianId",
                table: "GuardianChild",
                column: "GuardianId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignUpRequest_AspNetUsers_ClientId",
                table: "SignUpRequest",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SignUpRequest_AspNetUsers_DoctorId",
                table: "SignUpRequest",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatment_AspNetUsers_ClientId",
                table: "Treatment",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatment_AspNetUsers_DoctorId",
                table: "Treatment",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GuardianChild_AspNetUsers_ChildId",
                table: "GuardianChild");

            migrationBuilder.DropForeignKey(
                name: "FK_GuardianChild_AspNetUsers_GuardianId",
                table: "GuardianChild");

            migrationBuilder.DropForeignKey(
                name: "FK_SignUpRequest_AspNetUsers_ClientId",
                table: "SignUpRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_SignUpRequest_AspNetUsers_DoctorId",
                table: "SignUpRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatment_AspNetUsers_ClientId",
                table: "Treatment");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatment_AspNetUsers_DoctorId",
                table: "Treatment");

            migrationBuilder.DropTable(
                name: "ChatApplicationUserSupportGroup");

            migrationBuilder.DropTable(
                name: "SupportGroup");

            migrationBuilder.DropIndex(
                name: "IX_SignUpRequest_ClientId",
                table: "SignUpRequest");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29dc62a3-4483-43a0-af1f-65d127ec4465", "3b251c7a-fdaa-4db8-8d69-f7d6957ecd28" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29dc62a3-4483-43a0-af1f-65d127ec4465", "6718af22-3490-4459-9ace-8c917ded7e18" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29dc62a3-4483-43a0-af1f-65d127ec4465", "aeaf6880-93d3-4942-8f0e-7325e10529e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29dc62a3-4483-43a0-af1f-65d127ec4465", "eccb54df-5ac9-4e68-9fba-df19f93e5535" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29dc62a3-4483-43a0-af1f-65d127ec4465");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b251c7a-fdaa-4db8-8d69-f7d6957ecd28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6718af22-3490-4459-9ace-8c917ded7e18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aeaf6880-93d3-4942-8f0e-7325e10529e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eccb54df-5ac9-4e68-9fba-df19f93e5535");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "SignUpRequest");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "SignUpRequest",
                newName: "DoctorApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SignUpRequest_DoctorId",
                table: "SignUpRequest",
                newName: "IX_SignUpRequest_DoctorApplicationUserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_GuardianChild_Children_ChildId",
                table: "GuardianChild",
                column: "ChildId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GuardianChild_Guardians_GuardianId",
                table: "GuardianChild",
                column: "GuardianId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignUpRequest_AspNetUsers_DoctorApplicationUserId",
                table: "SignUpRequest",
                column: "DoctorApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

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
    }
}
