using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
<<<<<<< HEAD:OkOk/Migrations/20220120194115_InitialCreate.cs
    public partial class InitialCreate : Migration
=======
    public partial class Initial : Migration
>>>>>>> 2c562443547b477c0cebdba24a68f7f3cfdae3c6:OkOk/Migrations/20220118103728_Initial.cs
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
                values: new object[] { new Guid("029214ef-1367-4d6c-aab1-7f7d7f0ed813"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "HouseNumberAddition", "Street", "ZipCode" },
                values: new object[] { new Guid("ade6035d-2456-4a17-a031-e6a3c1e633c9"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39ceb643-fa38-4f80-89b6-d7906f3e1df9", "1", "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:OkOk/Migrations/20220120194115_InitialCreate.cs
                values: new object[] { "edfb3daa-fba1-4bf2-853c-8c55cfbdede9", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe0f0271-dc88-4274-b980-befced3a17bc", "1", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "30ba2c54-c4d3-4bfb-8400-8e9c1eb9a177", 0, "c1057ab8-73cc-429d-89f1-6241d08a10a6", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", null, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEO/G8R9gE6Pw4HdHTpghxakrSAqaMxqF4Hx7b4t3QFEmZn9ha8Mn96kYpqbejRsduQ==", "1234567890", true, "6f786448-ef21-4f14-97f3-5d8a9e3b4761", false, "angelo@okokapp.nl" });
=======
                values: new object[] { "7fc5c0d9-7c58-4542-a1f9-b9b5d16e6255", "1", "Admin", "ADMIN" });
>>>>>>> 2c562443547b477c0cebdba24a68f7f3cfdae3c6:OkOk/Migrations/20220118103728_Initial.cs

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
<<<<<<< HEAD:OkOk/Migrations/20220120194115_InitialCreate.cs
                values: new object[] { "aebddf58-ffc4-445d-8606-a0cf78a5263d", 0, "73bd2770-3e41-4dee-8dbb-24c4eb791b8e", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", null, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEMHdzYtHRk+XegMgyoq+LcecH7obD8zbSawIKJYzEQ4H2H26xGOVoe5RG1BAvPfYog==", "1234567890", true, "5cf9d104-abb3-46fb-8e05-b061f79a5138", false, "timothy@okokapp.nl" });
=======
                values: new object[] { "53f62527-7337-4ba7-aea1-190f03808d9d", 0, "8db079dc-7bbb-4175-bc84-a589d03f91fc", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", null, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEKMltFh3o/ZO/pX8zcK9J6BqMMjjpq0+vuO2/LP8/hGY3+qctYomy4X5mjPE1uo1rA==", "1234567890", true, "8949840a-3c52-4262-be4e-07143a3f74a5", false, "dechaun@okokapp.nl" });
>>>>>>> 2c562443547b477c0cebdba24a68f7f3cfdae3c6:OkOk/Migrations/20220118103728_Initial.cs

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
<<<<<<< HEAD:OkOk/Migrations/20220120194115_InitialCreate.cs
                values: new object[] { "d6ce7a95-df3d-4008-929a-c7867e05216a", 0, "37714b5a-063d-4790-9228-29ed60e59826", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", null, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAELvymvyFe0hgkHFV/3i0Ly5YD7h/gtaCI7UWSrN6zT+IQxLx+ulZw+nxrHBlsRObUA==", "1234567890", true, "e9d9aa7e-8e56-4375-866a-a09c35b472ee", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialism", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2b7ef106-96bc-4faa-ab48-5ab29e9a9447", 0, "df3d6bf6-1857-44e1-94e0-d27d50424167", "DoctorApplicationUser", "doctorone@okokapp.nl", true, "Doctor", "One", null, false, null, "DOCTORONE@OKOKAPP.NL", "DOCTORONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAEOXqXJ71fE4FC2kuqRk5gFaj8bXiPhmUlk5sA7hnIgiqZ+uqqS5sUiD3peb3RSfZWg==", "1234567890", true, "0f6c1d49-e0c8-4e48-8e08-5bfdd563dc72", "Autisme", false, "doctorone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialism", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c427ade3-3d27-4023-8fd5-46fbab6e7a6f", 0, "67c20998-b855-47c2-94ec-a642da562ba2", "DoctorApplicationUser", "doctortwo@okokapp.nl", true, "Doctor", "Two", null, false, null, "DOCTORTWO@OKOKAPP.NL", "DOCTORTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEKf6iEP52W+IuV3gQSr3rJFTHeTWQe0incf+uMh2P5PaaPiso0Lwhn4Crpx3I7sRAw==", "1234567890", true, "80ac755c-bea2-495d-8d1c-0f823c1e2227", "Autisme", false, "doctortwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "58380249-7ae0-4acb-8a6f-ea8538cf71d4", 0, "9d73e26e-13b1-4391-bb02-becd852528e4", "GuardianApplicationUser", "guardianone@okokapp.nl", true, "Guardian", "One", null, false, null, "GUARDIANONE@OKOKAPP.NL", "GUARDIANONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAEMD6GwhItXzVRl2/KLPqTa3KSP4DrEDL0ljXCxRR0qgnq0fpxtaStzWLD9eD35Pchg==", "1234567890", true, "a7fe3c40-1cec-4097-add9-ed97773d4cbf", false, "guardianone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "840ef66d-11a4-47a8-af7e-9ad16ab34d67", 0, "861dbd65-e997-4408-aba3-4f02c71be89f", "GuardianApplicationUser", "guardiantwo@okokapp.nl", true, "Guardian", "Two", null, false, null, "GUARDIANTWO@OKOKAPP.NL", "GUARDIANTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEOxdyogu7IEz6aNa7rwtOqx3UkvIB/8e8eboXV9UhiX2OkrCpVIdv6vVQzkywhk59Q==", "1234567890", true, "3bb5a64f-3d43-4f4c-bc65-dcbc2ec774ed", false, "guardiantwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("00b24115-2f00-46f0-ada2-deb01be556c8"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("0b158b7a-2b6a-45ef-ba92-4bc96838c0ab"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("11a7f39b-fb24-475c-8e1e-c1639e98abac"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("c2452f1f-4fde-4c6c-8234-ef077aada3f5"), false });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "39ceb643-fa38-4f80-89b6-d7906f3e1df9", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447" });
=======
                values: new object[] { "d2625ac3-b544-434d-81b0-b1e267504ea7", 0, "5f51ba52-4ead-459f-b64b-07d5dcbb7450", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", null, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEDO0KoQX3geOUVyPCjxFr5zIa0x36Sa9GWNDfF0ZYcn8vwkEOxtFkqqGJCOX1+Pl0g==", "1234567890", true, "99f94423-02ab-44fc-83e5-ea37e3810fc0", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f1bbc63e-b551-4792-84c2-e02f43cca68f", 0, "3649ba95-4d6f-4485-bcef-ada4290f0765", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", null, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEIKkHp2u6GMlOHykrVySqlIOAo9DK0y+MbMMn4mJy3gRe6HnTM0HLHRAvbMitteZIQ==", "1234567890", true, "c0ef3f07-4aa6-4b35-964f-3a087ac6750c", false, "timothy@okokapp.nl" });
>>>>>>> 2c562443547b477c0cebdba24a68f7f3cfdae3c6:OkOk/Migrations/20220118103728_Initial.cs

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
<<<<<<< HEAD:OkOk/Migrations/20220120194115_InitialCreate.cs
                values: new object[] { "edfb3daa-fba1-4bf2-853c-8c55cfbdede9", "30ba2c54-c4d3-4bfb-8400-8e9c1eb9a177" });
=======
                values: new object[] { "7fc5c0d9-7c58-4542-a1f9-b9b5d16e6255", "53f62527-7337-4ba7-aea1-190f03808d9d" });
>>>>>>> 2c562443547b477c0cebdba24a68f7f3cfdae3c6:OkOk/Migrations/20220118103728_Initial.cs

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
<<<<<<< HEAD:OkOk/Migrations/20220120194115_InitialCreate.cs
                values: new object[] { "edfb3daa-fba1-4bf2-853c-8c55cfbdede9", "aebddf58-ffc4-445d-8606-a0cf78a5263d" });
=======
                values: new object[] { "7fc5c0d9-7c58-4542-a1f9-b9b5d16e6255", "d2625ac3-b544-434d-81b0-b1e267504ea7" });
>>>>>>> 2c562443547b477c0cebdba24a68f7f3cfdae3c6:OkOk/Migrations/20220118103728_Initial.cs

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
<<<<<<< HEAD:OkOk/Migrations/20220120194115_InitialCreate.cs
                values: new object[] { "39ceb643-fa38-4f80-89b6-d7906f3e1df9", "c427ade3-3d27-4023-8fd5-46fbab6e7a6f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "edfb3daa-fba1-4bf2-853c-8c55cfbdede9", "d6ce7a95-df3d-4008-929a-c7867e05216a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OldEnough", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", 0, new Guid("ade6035d-2456-4a17-a031-e6a3c1e633c9"), "1ccb3467-afea-49da-8bfb-37500340e046", "ClientApplicationUser", "clienttwo@okokapp.nl", true, "Client", "Two", null, false, null, "CLIENTTWO@OKOKAPP.NL", "CLIENTTWO@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAEPgACdJi6hpzCZi/ElCBAUflbbmmYfp5zT4iniebHQ2D5YQfXfYj10dxHKPylYy0UA==", "1234567890", true, "0afb5393-5021-488e-9668-086e0e88a17e", false, "clienttwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OldEnough", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "720407f4-7258-4ea7-9b48-248236068846", 0, new Guid("029214ef-1367-4d6c-aab1-7f7d7f0ed813"), "fa9ca50b-859a-4af2-ac15-bcfbe2eb7206", "ClientApplicationUser", "clientone@okokapp.nl", true, "Client", "One", null, false, null, "CLIENTONE@OKOKAPP.NL", "CLIENTONE@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAEBvFLEpuns6yWwnO1hImF2wL6NcydVm4iIsq762M0JhUKaKa8gtTLhopA/PFk2BuGg==", "1234567890", true, "1bfa4280-47fb-4f6c-aa74-d52811c11a88", false, "clientone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fe0f0271-dc88-4274-b980-befced3a17bc", "2dd3a743-1183-4ce5-b5b8-b63398f7cd20" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fe0f0271-dc88-4274-b980-befced3a17bc", "720407f4-7258-4ea7-9b48-248236068846" });

            migrationBuilder.InsertData(
                table: "GuardianChild",
                columns: new[] { "ChildId", "GuardianId" },
                values: new object[] { "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", "840ef66d-11a4-47a8-af7e-9ad16ab34d67" });

            migrationBuilder.InsertData(
                table: "GuardianChild",
                columns: new[] { "ChildId", "GuardianId" },
                values: new object[] { "720407f4-7258-4ea7-9b48-248236068846", "58380249-7ae0-4acb-8a6f-ea8538cf71d4" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("212f8194-0019-4a32-acf7-aea61f497571"), "Dit is een geseede message [3]", new DateTime(2022, 1, 20, 20, 41, 15, 557, DateTimeKind.Local).AddTicks(2810), null, "2dd3a743-1183-4ce5-b5b8-b63398f7cd20" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("27372a87-0b13-4567-82e0-7ddad7210b5d"), "Dit is een geseede message [2]", new DateTime(2022, 1, 20, 20, 41, 15, 557, DateTimeKind.Local).AddTicks(2808), null, "720407f4-7258-4ea7-9b48-248236068846" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("78583d2a-fc58-4670-a0f8-9c2e5e860b5f"), "Dit is een geseede message [1]", new DateTime(2022, 1, 20, 20, 41, 15, 557, DateTimeKind.Local).AddTicks(2798), null, "720407f4-7258-4ea7-9b48-248236068846" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("c18f2561-63c1-45ab-9ea6-fbdfc3f003b5"), "Dit is een geseede message [4]", new DateTime(2022, 1, 20, 20, 41, 15, 557, DateTimeKind.Local).AddTicks(2813), null, "2dd3a743-1183-4ce5-b5b8-b63398f7cd20" });

            migrationBuilder.InsertData(
                table: "SignUpRequests",
                columns: new[] { "Id", "ClientId", "DoctorId", "Handled" },
                values: new object[] { new Guid("6584592f-e0e3-470f-8283-a6b30764c070"), "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447", false });

            migrationBuilder.InsertData(
                table: "SignUpRequests",
                columns: new[] { "Id", "ClientId", "DoctorId", "Handled" },
                values: new object[] { new Guid("6c990b1e-783b-454f-b957-ad49464b40be"), "720407f4-7258-4ea7-9b48-248236068846", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447", false });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("09496113-9235-44e3-8a42-7869a9e418e5"), "720407f4-7258-4ea7-9b48-248236068846", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("0e288c5e-7986-4b48-9135-135c3ad2db83"), "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "c427ade3-3d27-4023-8fd5-46fbab6e7a6f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("15dad6c5-078f-4baf-98a6-d72383e2fd22"), "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", new DateTime(2022, 1, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "c427ade3-3d27-4023-8fd5-46fbab6e7a6f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("1aa7035d-5abe-4b9a-a876-aa8a7b120f77"), "720407f4-7258-4ea7-9b48-248236068846", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("303ca8fc-b0af-462e-ae3b-bbb0ee931486"), "720407f4-7258-4ea7-9b48-248236068846", new DateTime(2022, 1, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("3675e088-e70d-42c5-aee9-208f6b7d3855"), "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", new DateTime(2022, 1, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c427ade3-3d27-4023-8fd5-46fbab6e7a6f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("3db7e857-9f68-4eca-90b2-929e39ebc548"), "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "c427ade3-3d27-4023-8fd5-46fbab6e7a6f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("5d258558-fbbc-46cd-815d-c4c371c92463"), "720407f4-7258-4ea7-9b48-248236068846", new DateTime(2022, 1, 20, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("7175bbd6-e382-459d-96fd-a20b49dd7a12"), "720407f4-7258-4ea7-9b48-248236068846", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("7b7f5624-e10e-455b-9391-4031e02d83f9"), "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", new DateTime(2022, 1, 20, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c427ade3-3d27-4023-8fd5-46fbab6e7a6f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("89b85bd0-8991-447c-a0c0-54dc9b05527b"), "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c427ade3-3d27-4023-8fd5-46fbab6e7a6f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("8d26def2-9522-44b5-ac00-3255a3d83aa6"), "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c427ade3-3d27-4023-8fd5-46fbab6e7a6f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("90f352d5-4943-4462-bc08-64716a49ebf3"), "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c427ade3-3d27-4023-8fd5-46fbab6e7a6f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("cbaa749b-d856-4048-9bbc-ec00bb2ec525"), "720407f4-7258-4ea7-9b48-248236068846", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("e248e973-aa75-4e5c-ac9e-ffbd34630220"), "720407f4-7258-4ea7-9b48-248236068846", new DateTime(2022, 1, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("e599e441-8f00-47fc-8a8f-c8bf3efc4ee3"), "720407f4-7258-4ea7-9b48-248236068846", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("e6bab421-592d-410d-b5d9-11a1752e2337"), "2dd3a743-1183-4ce5-b5b8-b63398f7cd20", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c427ade3-3d27-4023-8fd5-46fbab6e7a6f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("ea917d24-b4a7-48d1-9b59-ba650f70d131"), "720407f4-7258-4ea7-9b48-248236068846", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "2b7ef106-96bc-4faa-ab48-5ab29e9a9447" });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("212f8194-0019-4a32-acf7-aea61f497571"), new Guid("00b24115-2f00-46f0-ada2-deb01be556c8") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("78583d2a-fc58-4670-a0f8-9c2e5e860b5f"), new Guid("0b158b7a-2b6a-45ef-ba92-4bc96838c0ab") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("78583d2a-fc58-4670-a0f8-9c2e5e860b5f"), new Guid("11a7f39b-fb24-475c-8e1e-c1639e98abac") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("78583d2a-fc58-4670-a0f8-9c2e5e860b5f"), new Guid("c2452f1f-4fde-4c6c-8234-ef077aada3f5") });
=======
                values: new object[] { "7fc5c0d9-7c58-4542-a1f9-b9b5d16e6255", "f1bbc63e-b551-4792-84c2-e02f43cca68f" });
>>>>>>> 2c562443547b477c0cebdba24a68f7f3cfdae3c6:OkOk/Migrations/20220118103728_Initial.cs

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
