using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    HouseNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    HouseNumberAddition = table.Column<string>(type: "TEXT", nullable: true),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    ZipCode = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Handled = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupportGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    LockedOutReason = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    OldEnough = table.Column<bool>(type: "INTEGER", nullable: true),
                    AddressId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Specialism = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_ChatApplicationUserSupportGroup_SupportGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "SupportGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuardianChild",
                columns: table => new
                {
                    ChildId = table.Column<string>(type: "TEXT", nullable: false),
                    GuardianId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuardianChild", x => new { x.ChildId, x.GuardianId });
                    table.ForeignKey(
                        name: "FK_GuardianChild_AspNetUsers_ChildId",
                        column: x => x.ChildId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuardianChild_AspNetUsers_GuardianId",
                        column: x => x.GuardianId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SenderId = table.Column<string>(type: "TEXT", nullable: false),
                    GroupId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
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
                name: "SignUpRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Handled = table.Column<bool>(type: "INTEGER", nullable: false),
                    ClientId = table.Column<string>(type: "TEXT", nullable: false),
                    DoctorId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignUpRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignUpRequests_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_SignUpRequests_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ClientId = table.Column<string>(type: "TEXT", nullable: false),
                    DoctorId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatments_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Treatments_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "MessageChatapplicationUser",
                columns: table => new
                {
                    ChatUserId = table.Column<string>(type: "TEXT", nullable: false),
                    MessageId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageChatapplicationUser", x => new { x.ChatUserId, x.MessageId });
                    table.ForeignKey(
                        name: "FK_MessageChatapplicationUser_AspNetUsers_ChatUserId",
                        column: x => x.ChatUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MessageChatapplicationUser_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "HouseNumberAddition", "Street", "ZipCode" },
                values: new object[] { new Guid("64962e21-66cf-40ec-b12a-37de59de6c7c"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "HouseNumberAddition", "Street", "ZipCode" },
                values: new object[] { new Guid("677cdac0-ba63-4733-8e09-41a045061db7"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0924445e-57c0-4a24-9669-41723a4dd725", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43fcfd8c-ffa8-4631-bf8a-c44fa5fc6772", "1", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "86821904-0651-4cf5-afa8-ae3cedcc9e54", "1", "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1bde3423-e929-44c8-9bbd-46801fbe8db0", 0, "fe5b6ff7-d4b6-42b9-aaa0-c15f40121a9a", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", null, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAECCc2QfGLi8rXCdFauBY8O879HFjZvFWE3iPrAzPmp9TFKPdBo5rwX62FvtzPBnuEw==", "1234567890", true, "7696c203-0e2f-429c-9b0b-7e3ba5fcc3ac", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b4f042d-c602-47f8-8055-99d47b2823eb", 0, "c51e14d2-c37e-42d9-a8b5-2eea3b714fac", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", null, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEDrjfWrTQqm3eeqvQrxtZgKhnJ7YySltlO+KjV/d1xla82v5g+7l81RtWsrrBSeBlQ==", "1234567890", true, "93abfcb7-8f5d-45dd-804b-addb685e5697", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8d3532f8-3f69-4a85-bf67-efedbb1cb2e0", 0, "dd943147-895b-4582-93aa-b3a95e11e375", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", null, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEC02CJOXJUUslgOGyxDm/uuKs6861TKDw7etNDt0JKmHCKzrREoO64LgAbI0qQ2mqQ==", "1234567890", true, "add4cd5c-8278-4c0f-baa5-932fe0bea702", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialism", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2ee042d6-0b84-44b9-b3fe-906d5212ae4f", 0, "4918c1f2-2204-4130-83ed-ece40601b647", "DoctorApplicationUser", "doctortwo@okokapp.nl", true, "Doctor", "Two", null, false, null, "DOCTORTWO@OKOKAPP.NL", "DOCTORTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEF0LkuusQpaaBi7WMjAPo5yiUHG3Ojczwax8GgntgmQ9w7psMEeKYeNxpuTdhiWwPA==", "1234567890", true, "6f5023f4-5c1d-42d5-bdcc-bc5e230a1c77", "Autisme", false, "doctortwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialism", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bb1e7949-970c-4562-aa28-84d0fd78ebcf", 0, "c2921e20-8bcd-4dd6-a2bc-6ecb8b481a09", "DoctorApplicationUser", "doctorone@okokapp.nl", true, "Doctor", "One", null, false, null, "DOCTORONE@OKOKAPP.NL", "DOCTORONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAEC0hdj2wz5NrFZZXga+XYpBKYuGWz/Ce0K/sbl2eZNn5KT+bZXpjcBSOXEa7ltprSw==", "1234567890", true, "24c0c779-dc33-41d4-8fe9-3f522d765231", "Autisme", false, "doctorone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cc79d039-7fcb-474c-b24d-aaaed317be81", 0, "cebfe319-15e6-40ad-a29c-4ccb63ef7200", "GuardianApplicationUser", "guardiantwo@okokapp.nl", true, "Guardian", "Two", null, false, null, "GUARDIANTWO@OKOKAPP.NL", "GUARDIANTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEOr3g/1GaXJ5XPmvgu9jA5ykt144Nl7k2USklQEel32mdxZYPPlOwkkgkrziS57VyA==", "1234567890", true, "79ee3200-bcd3-430c-b3bd-a8b353b2938b", false, "guardiantwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eaa74cdb-3c47-48cf-8d2a-5aa9610dc437", 0, "5a08f9a2-da58-4d46-b541-262e5ac0bb59", "GuardianApplicationUser", "guardianone@okokapp.nl", true, "Guardian", "One", null, false, null, "GUARDIANONE@OKOKAPP.NL", "GUARDIANONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAEFqrgWSMVO8VPXhbXU1IQyIGeJKqmwLAJpREWH8c7NOz1kU67/ms1+HtAMo+tJm03w==", "1234567890", true, "386f5822-dfe6-49b1-8196-3a6e82084496", false, "guardianone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("16ea97e6-449c-4a2f-a956-936257a55850"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("66914dce-6438-42c4-9451-41f576c81234"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("8410b868-dc2a-40f2-956b-c6bffcac7f25"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("c6e901c9-a118-45bb-b598-2fd91d32cec2"), false });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0924445e-57c0-4a24-9669-41723a4dd725", "1bde3423-e929-44c8-9bbd-46801fbe8db0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "86821904-0651-4cf5-afa8-ae3cedcc9e54", "2ee042d6-0b84-44b9-b3fe-906d5212ae4f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0924445e-57c0-4a24-9669-41723a4dd725", "7b4f042d-c602-47f8-8055-99d47b2823eb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0924445e-57c0-4a24-9669-41723a4dd725", "8d3532f8-3f69-4a85-bf67-efedbb1cb2e0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "86821904-0651-4cf5-afa8-ae3cedcc9e54", "bb1e7949-970c-4562-aa28-84d0fd78ebcf" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OldEnough", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", 0, new Guid("677cdac0-ba63-4733-8e09-41a045061db7"), "4af8b5f1-ba4c-412e-b1d5-41ab08d0e2c5", "ClientApplicationUser", "clientone@okokapp.nl", true, "Client", "One", null, false, null, "CLIENTONE@OKOKAPP.NL", "CLIENTONE@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAENraWpy6QbWFnTUoDw7YvhPY2PXjF1leAIWx9yK9YIUfDCSfytpb4ge3c10i4v8QBg==", "1234567890", true, "b02ff5b2-3f91-4703-9d8b-b1abf67a5e47", false, "clientone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OldEnough", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8eee0687-e7c2-4b44-8120-e5140f3844e1", 0, new Guid("64962e21-66cf-40ec-b12a-37de59de6c7c"), "ff386128-02b0-476a-8f01-74b32a457a97", "ClientApplicationUser", "clienttwo@okokapp.nl", true, "Client", "Two", null, false, null, "CLIENTTWO@OKOKAPP.NL", "CLIENTTWO@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAEEumUuOVOHaPkR/WMRiF7GJ2K/UAGJBlrJIHjuRln2Q5+jq77U+lNFOJQ31rXTfoVw==", "1234567890", true, "d85a5850-ef5a-4b78-9207-2d02345aebfc", false, "clienttwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "43fcfd8c-ffa8-4631-bf8a-c44fa5fc6772", "1e120e00-0ef7-443c-8dd3-f09753c9f3fc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "43fcfd8c-ffa8-4631-bf8a-c44fa5fc6772", "8eee0687-e7c2-4b44-8120-e5140f3844e1" });

            migrationBuilder.InsertData(
                table: "GuardianChild",
                columns: new[] { "ChildId", "GuardianId" },
                values: new object[] { "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", "eaa74cdb-3c47-48cf-8d2a-5aa9610dc437" });

            migrationBuilder.InsertData(
                table: "GuardianChild",
                columns: new[] { "ChildId", "GuardianId" },
                values: new object[] { "8eee0687-e7c2-4b44-8120-e5140f3844e1", "cc79d039-7fcb-474c-b24d-aaaed317be81" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("49ab8a91-1b53-4c29-8972-7e864596807e"), "Dit is een geseede message [3]", new DateTime(2022, 1, 20, 20, 47, 17, 983, DateTimeKind.Local).AddTicks(1562), null, "8eee0687-e7c2-4b44-8120-e5140f3844e1" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("7fe5398d-a358-445e-978a-bb6274549783"), "Dit is een geseede message [4]", new DateTime(2022, 1, 20, 20, 47, 17, 983, DateTimeKind.Local).AddTicks(1566), null, "8eee0687-e7c2-4b44-8120-e5140f3844e1" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("9f151af1-6060-41df-a25e-73825fee6771"), "Dit is een geseede message [2]", new DateTime(2022, 1, 20, 20, 47, 17, 983, DateTimeKind.Local).AddTicks(1559), null, "1e120e00-0ef7-443c-8dd3-f09753c9f3fc" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("c53584f7-8a6d-4c2e-8535-10851dfba056"), "Dit is een geseede message [1]", new DateTime(2022, 1, 20, 20, 47, 17, 983, DateTimeKind.Local).AddTicks(1382), null, "1e120e00-0ef7-443c-8dd3-f09753c9f3fc" });

            migrationBuilder.InsertData(
                table: "SignUpRequests",
                columns: new[] { "Id", "ClientId", "DoctorId", "Handled" },
                values: new object[] { new Guid("68e1ca26-b0b1-41f9-b382-c106822564d8"), "8eee0687-e7c2-4b44-8120-e5140f3844e1", "bb1e7949-970c-4562-aa28-84d0fd78ebcf", false });

            migrationBuilder.InsertData(
                table: "SignUpRequests",
                columns: new[] { "Id", "ClientId", "DoctorId", "Handled" },
                values: new object[] { new Guid("a66fb693-87c4-473d-9878-40dcf0fe2663"), "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", "bb1e7949-970c-4562-aa28-84d0fd78ebcf", false });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("1313a704-9282-4f20-8a8f-6a73b4174139"), "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", new DateTime(2022, 1, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "bb1e7949-970c-4562-aa28-84d0fd78ebcf" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("1ad2a1f2-c061-4852-a915-b9ce570e0ffd"), "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "bb1e7949-970c-4562-aa28-84d0fd78ebcf" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("388bf9c2-c682-4868-b96d-e208ca34b8c6"), "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "bb1e7949-970c-4562-aa28-84d0fd78ebcf" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("3c512acc-0aed-4187-9db7-85834ebd098e"), "8eee0687-e7c2-4b44-8120-e5140f3844e1", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2ee042d6-0b84-44b9-b3fe-906d5212ae4f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("50a1b7d2-1abf-434e-a2ef-5d050ec2c8c5"), "8eee0687-e7c2-4b44-8120-e5140f3844e1", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2ee042d6-0b84-44b9-b3fe-906d5212ae4f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("5385b5b7-45b6-41d3-b1a7-a7f83475233e"), "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", new DateTime(2022, 1, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "bb1e7949-970c-4562-aa28-84d0fd78ebcf" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("54423453-115c-422b-a29d-a932f86c86d4"), "8eee0687-e7c2-4b44-8120-e5140f3844e1", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2ee042d6-0b84-44b9-b3fe-906d5212ae4f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("638b2a9e-33ef-4b66-8ed5-a8d2543aa11a"), "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "bb1e7949-970c-4562-aa28-84d0fd78ebcf" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("6ef7cb92-8399-4785-884b-0b6184d1b85c"), "8eee0687-e7c2-4b44-8120-e5140f3844e1", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "2ee042d6-0b84-44b9-b3fe-906d5212ae4f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("82def934-13f8-4eb9-97ef-56a87bcd6f04"), "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "bb1e7949-970c-4562-aa28-84d0fd78ebcf" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("a19870a7-7959-4870-bc1f-19a3830bdd73"), "8eee0687-e7c2-4b44-8120-e5140f3844e1", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2ee042d6-0b84-44b9-b3fe-906d5212ae4f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("afc45e9c-136d-486c-ba72-9f8d21b2f122"), "8eee0687-e7c2-4b44-8120-e5140f3844e1", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "2ee042d6-0b84-44b9-b3fe-906d5212ae4f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("ccbc229a-7f1b-45ee-bee4-da3f59200269"), "8eee0687-e7c2-4b44-8120-e5140f3844e1", new DateTime(2022, 1, 20, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2ee042d6-0b84-44b9-b3fe-906d5212ae4f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("d09b22ca-b135-4cee-a311-c35cdccf336e"), "8eee0687-e7c2-4b44-8120-e5140f3844e1", new DateTime(2022, 1, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "2ee042d6-0b84-44b9-b3fe-906d5212ae4f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("d6e3d22e-80d6-4fff-83b5-59e0f4a8389f"), "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", new DateTime(2022, 1, 20, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "bb1e7949-970c-4562-aa28-84d0fd78ebcf" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("e1d4b88f-95f4-40e8-af41-9c6f46d56633"), "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "bb1e7949-970c-4562-aa28-84d0fd78ebcf" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("e93c0ab4-82cc-4cfc-ad3f-b017b217047a"), "1e120e00-0ef7-443c-8dd3-f09753c9f3fc", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "bb1e7949-970c-4562-aa28-84d0fd78ebcf" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("f3c50074-7bf0-43dd-a5f3-d348a2c2de3e"), "8eee0687-e7c2-4b44-8120-e5140f3844e1", new DateTime(2022, 1, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2ee042d6-0b84-44b9-b3fe-906d5212ae4f" });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("49ab8a91-1b53-4c29-8972-7e864596807e"), new Guid("66914dce-6438-42c4-9451-41f576c81234") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("c53584f7-8a6d-4c2e-8535-10851dfba056"), new Guid("16ea97e6-449c-4a2f-a956-936257a55850") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("c53584f7-8a6d-4c2e-8535-10851dfba056"), new Guid("8410b868-dc2a-40f2-956b-c6bffcac7f25") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("c53584f7-8a6d-4c2e-8535-10851dfba056"), new Guid("c6e901c9-a118-45bb-b598-2fd91d32cec2") });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChatApplicationUserSupportGroup_GroupId",
                table: "ChatApplicationUserSupportGroup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GuardianChild_GuardianId",
                table: "GuardianChild",
                column: "GuardianId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageChatapplicationUser_MessageId",
                table: "MessageChatapplicationUser",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageReports_ReportId",
                table: "MessageReports",
                column: "ReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_GroupId",
                table: "Messages",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_SignUpRequests_ClientId",
                table: "SignUpRequests",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SignUpRequests_DoctorId",
                table: "SignUpRequests",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_ClientId",
                table: "Treatments",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_DoctorId",
                table: "Treatments",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChatApplicationUserSupportGroup");

            migrationBuilder.DropTable(
                name: "GuardianChild");

            migrationBuilder.DropTable(
                name: "MessageChatapplicationUser");

            migrationBuilder.DropTable(
                name: "MessageReports");

            migrationBuilder.DropTable(
                name: "SignUpRequests");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SupportGroups");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
