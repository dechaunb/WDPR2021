using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class ModelsCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatApplicationUserSupportGroup_SupportGroup_GroupId",
                table: "ChatApplicationUserSupportGroup");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treatment",
                table: "Treatment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupportGroup",
                table: "SupportGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignUpRequest",
                table: "SignUpRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

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

            migrationBuilder.RenameTable(
                name: "Treatment",
                newName: "Treatments");

            migrationBuilder.RenameTable(
                name: "SupportGroup",
                newName: "SupportGroups");

            migrationBuilder.RenameTable(
                name: "SignUpRequest",
                newName: "SignUpRequests");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_Treatment_DoctorId",
                table: "Treatments",
                newName: "IX_Treatments_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Treatment_ClientId",
                table: "Treatments",
                newName: "IX_Treatments_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_SignUpRequest_DoctorId",
                table: "SignUpRequests",
                newName: "IX_SignUpRequests_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_SignUpRequest_ClientId",
                table: "SignUpRequests",
                newName: "IX_SignUpRequests_ClientId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ChatUserId",
                table: "SupportGroups",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treatments",
                table: "Treatments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupportGroups",
                table: "SupportGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignUpRequests",
                table: "SignUpRequests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChatUserId = table.Column<string>(type: "TEXT", nullable: true),
                    GroupId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ChatUserId",
                        column: x => x.ChatUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Messages_SupportGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "SupportGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessageReports",
                columns: table => new
                {
                    MessageId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReportId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageReports", x => new { x.MessageId, x.ReportId });
                    table.ForeignKey(
                        name: "FK_MessageReports_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_MessageReports_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "04cfe54b-a771-4750-aee7-b8267266eae1", 0, "e704f15c-b187-4569-b047-62138a1a59ec", "ApplicationUser", "yash@okokapp.nl", true, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEFgW5DemWdkYB70LvBRUN/uUItuJRQmvBv1dFfsNTRmd23Xbiwid5TKhfgL5X5SJ3A==", "1234567890", true, "1ed6c6dd-19df-4a5d-8234-54a95bddec71", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "338f651f-74c3-40b7-a340-1b017f9cb881", 0, "900b8567-5ac3-437c-91af-23c488feaf9c", "ApplicationUser", "timothy@okokapp.nl", true, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEP5oqbtSwr50BBVIM+dG1mE6kNyixeaQcB72niNkbN051HZDUKoyxutuYn79HqBdug==", "1234567890", true, "500088d1-d20f-40f1-b383-24a4c0a30377", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6f82dbf9-4a9f-4089-aad1-a527410342c2", 0, "8d519f79-3a30-43da-bb1e-ecb1b03ac2f3", "ApplicationUser", "angelo@okokapp.nl", true, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEGFXLCOor4qogTv8+1aI8Y1c085r932/h+nFa9s5TlsTsdJocuy9kEBZQE/qWlSjgg==", "1234567890", true, "e992e446-622d-48f6-8a2e-1f8b9bd5a7dc", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f6005de8-915d-4288-b6d7-c04765685084", 0, "c6a2ccb6-0c29-4eed-9ad5-d44b2ac1402b", "ApplicationUser", "dechaun@okokapp.nl", true, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEAiZQF9+irLtQoPq4/hiPHurRUbEyde8CJ9wHVysBmDG1hHtfcDdHuqyPVTWVigCOw==", "1234567890", true, "4af86b04-3f67-4702-9b87-546d1a288a05", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "04cfe54b-a771-4750-aee7-b8267266eae1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "338f651f-74c3-40b7-a340-1b017f9cb881" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "6f82dbf9-4a9f-4089-aad1-a527410342c2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "f6005de8-915d-4288-b6d7-c04765685084" });

            migrationBuilder.CreateIndex(
                name: "IX_MessageReports_ReportId",
                table: "MessageReports",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatUserId",
                table: "Messages",
                column: "ChatUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_GroupId",
                table: "Messages",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatApplicationUserSupportGroup_SupportGroups_GroupId",
                table: "ChatApplicationUserSupportGroup",
                column: "GroupId",
                principalTable: "SupportGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignUpRequests_AspNetUsers_ClientId",
                table: "SignUpRequests",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SignUpRequests_AspNetUsers_DoctorId",
                table: "SignUpRequests",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_AspNetUsers_ClientId",
                table: "Treatments",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_AspNetUsers_DoctorId",
                table: "Treatments",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatApplicationUserSupportGroup_SupportGroups_GroupId",
                table: "ChatApplicationUserSupportGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_SignUpRequests_AspNetUsers_ClientId",
                table: "SignUpRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_SignUpRequests_AspNetUsers_DoctorId",
                table: "SignUpRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_AspNetUsers_ClientId",
                table: "Treatments");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_AspNetUsers_DoctorId",
                table: "Treatments");

            migrationBuilder.DropTable(
                name: "MessageReports");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treatments",
                table: "Treatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupportGroups",
                table: "SupportGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignUpRequests",
                table: "SignUpRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "04cfe54b-a771-4750-aee7-b8267266eae1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "338f651f-74c3-40b7-a340-1b017f9cb881" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "6f82dbf9-4a9f-4089-aad1-a527410342c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "f6005de8-915d-4288-b6d7-c04765685084" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04cfe54b-a771-4750-aee7-b8267266eae1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "338f651f-74c3-40b7-a340-1b017f9cb881");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f82dbf9-4a9f-4089-aad1-a527410342c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6005de8-915d-4288-b6d7-c04765685084");

            migrationBuilder.RenameTable(
                name: "Treatments",
                newName: "Treatment");

            migrationBuilder.RenameTable(
                name: "SupportGroups",
                newName: "SupportGroup");

            migrationBuilder.RenameTable(
                name: "SignUpRequests",
                newName: "SignUpRequest");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Treatments_DoctorId",
                table: "Treatment",
                newName: "IX_Treatment_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Treatments_ClientId",
                table: "Treatment",
                newName: "IX_Treatment_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_SignUpRequests_DoctorId",
                table: "SignUpRequest",
                newName: "IX_SignUpRequest_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_SignUpRequests_ClientId",
                table: "SignUpRequest",
                newName: "IX_SignUpRequest_ClientId");

            migrationBuilder.AlterColumn<string>(
                name: "ChatUserId",
                table: "SupportGroup",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treatment",
                table: "Treatment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupportGroup",
                table: "SupportGroup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignUpRequest",
                table: "SignUpRequest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29dc62a3-4483-43a0-af1f-65d127ec4465", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b251c7a-fdaa-4db8-8d69-f7d6957ecd28", 0, "67170085-262e-4216-a1f6-26c0999f18a0", "ApplicationUser", "yash@okokapp.nl", true, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEEV1nrJWk+oX2XRBTl7Nuf1kV5dHP34vsB2haHSzCr2VLH8JrrnV8oG2bnpWgs24MA==", "1234567890", true, "9072ee5f-2276-4065-a4b7-1ac7257ec208", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6718af22-3490-4459-9ace-8c917ded7e18", 0, "404ff9f5-817a-445b-a123-f41175f471c9", "ApplicationUser", "dechaun@okokapp.nl", true, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEByTKgTtztGpRgLWmYVLk4iyFR5p42JI5dX39WCzvoscjewc14MsQc3DsyQpOlshqQ==", "1234567890", true, "a360087f-e19e-4ae5-a1fc-959bea84404f", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aeaf6880-93d3-4942-8f0e-7325e10529e4", 0, "9404862c-0cb1-4121-90dc-5cc118e61b02", "ApplicationUser", "angelo@okokapp.nl", true, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEEeswIUuI0fgl/dfzgJmcvE9MLLk7Dc0k/qnevR3Hkx8DDsMEvGH6b4NxY0Zbl7azg==", "1234567890", true, "a9bfbc94-bc81-444a-a471-56ab85978413", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eccb54df-5ac9-4e68-9fba-df19f93e5535", 0, "473cacd5-7854-48d0-bae1-cb7a63c03271", "ApplicationUser", "timothy@okokapp.nl", true, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEIXO1GThu3Q5RzmZtXxVa6qK67uknVK5pqbwebDRpugMhTWfQx7t0R3rCPT/MwGVig==", "1234567890", true, "be58d4f2-fe30-47d5-a98d-e6cd5a340096", false, "timothy@okokapp.nl" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatApplicationUserSupportGroup_SupportGroup_GroupId",
                table: "ChatApplicationUserSupportGroup",
                column: "GroupId",
                principalTable: "SupportGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
