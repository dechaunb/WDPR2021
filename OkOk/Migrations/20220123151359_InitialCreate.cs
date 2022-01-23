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
                    SenderId = table.Column<string>(type: "TEXT", nullable: true),
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
                    ClientId = table.Column<string>(type: "TEXT", nullable: true),
                    DoctorId = table.Column<string>(type: "TEXT", nullable: true)
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
                    ClientId = table.Column<string>(type: "TEXT", nullable: true),
                    DoctorId = table.Column<string>(type: "TEXT", nullable: true)
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
                values: new object[] { new Guid("43327698-bdb9-45df-b7eb-9098baf81281"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "HouseNumberAddition", "Street", "ZipCode" },
                values: new object[] { new Guid("938c6cd6-9bdd-43ab-93f9-14379a3a5f28"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d39a882-17f2-4e2b-9e4b-13c80e158847", "1", "Guardian", "GUARDIAN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e00dd267-628a-4b64-8c6b-65a31cf63463", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8e73d04-3827-4cdc-82c0-91e59988cf2e", "1", "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb6e2f0e-9614-4e3c-bb94-b9c1fe2d3a9e", "1", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "48cf798d-2d19-4869-969f-a572fabf9ebc", 0, "ad5a226c-3c77-4882-b242-8b3537032655", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", null, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAELR3cYheUboHmREjLtfBUAkdo22PsBIMaBj+AwIexu882Grr7M5GwIcuIpBeICvWCg==", "1234567890", true, "1d97cbd9-989a-40c1-8ba4-12ecbd8e3f9a", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "52a7829f-02f6-4f70-a726-a4521850af9e", 0, "9b0b0992-858a-4f19-be91-06673b251b57", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", null, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEERIPCSBwP2NFcyHZkY1P+mBNR9G+X2UUIzGsAT3ujuBLaR6d2/ONnmsPDJOaN3UdA==", "1234567890", true, "b0eaf42d-3e54-415d-8622-1bcc4f098db1", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "895f771b-a2b5-463b-852c-2076635d1f1b", 0, "8b4478ec-ec49-4049-866f-99e7c52fcf45", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", null, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEBH94OsN9Db7ylaXW3dmTD75smYYmOW4e/kFaPFWVUEPj9rtcK/BVbTJpIBgE+wZYA==", "1234567890", true, "dfd00ddd-58ed-4ca6-b362-6d20b18cc267", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialism", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b", 0, "200e712c-a721-4db0-a46c-85b2c2e9d9c9", "DoctorApplicationUser", "doctorone@okokapp.nl", true, "Doctor", "One", null, false, null, "DOCTORONE@OKOKAPP.NL", "DOCTORONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAEIM/maeUYPEHYcAE3lNp7PZqC9F67gtFmRvUb/hV3+vM+ewEM1AcGDv0tj3P0ySQWA==", "1234567890", true, "967da4ef-0a18-47d8-9191-37fe5912847b", "Autisme", false, "doctorone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialism", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a237993d-0c22-4fc9-a055-6d448f84683f", 0, "6108c612-c4cc-441c-b155-eb8861120384", "DoctorApplicationUser", "doctortwo@okokapp.nl", true, "Doctor", "Two", null, false, null, "DOCTORTWO@OKOKAPP.NL", "DOCTORTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAELc6cahlHEwjej6mGPDIDiQvj1OrThh/IlVoUPqJCwNMC+UoJd5DW4CNxgoyZEzTNw==", "1234567890", true, "704b898e-ae2f-490b-a0ee-68e7f671fe93", "Autisme", false, "doctortwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b8f5e8c8-2486-40ff-aecd-1523cc43b65f", 0, "8f8b9dba-54d1-4c52-8bb7-04c4f87fa5a8", "GuardianApplicationUser", "guardianone@okokapp.nl", true, "Guardian", "One", null, false, null, "GUARDIANONE@OKOKAPP.NL", "GUARDIANONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAEFc4vzP0IVJ8xM677zGO0kAiBD7FBuABSy4xnNGkQaspbBlBRL+Z3JXZiT4PR6MH0g==", "1234567890", true, "d1ec7426-a4f8-440b-8e9d-bf4560f85fa0", false, "guardianone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e26a6e77-d1ca-444d-8bf5-2cd1666c7a24", 0, "f420171d-ac45-4b6b-9fcf-93d33d17631d", "GuardianApplicationUser", "guardiantwo@okokapp.nl", true, "Guardian", "Two", null, false, null, "GUARDIANTWO@OKOKAPP.NL", "GUARDIANTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEMqVP6uO/gH+Uw4NpVLfDRW2ZQqjskqBToIuRtiSJy98k03vtudhoGSC8GZJ41YAYQ==", "1234567890", true, "bfc7c3b6-49b0-48b5-b12f-b85445d51bcc", false, "guardiantwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("26445a1f-ed8a-4e94-8da2-5839e3b5e4d5"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("42b71c8d-9286-4e77-b498-0ae78fca600b"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("74c15987-793b-4bb4-b8c4-e378cfe038cf"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("c649b22d-68a5-4401-9107-c71fbe381ffa"), false });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e00dd267-628a-4b64-8c6b-65a31cf63463", "48cf798d-2d19-4869-969f-a572fabf9ebc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e8e73d04-3827-4cdc-82c0-91e59988cf2e", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e00dd267-628a-4b64-8c6b-65a31cf63463", "52a7829f-02f6-4f70-a726-a4521850af9e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e00dd267-628a-4b64-8c6b-65a31cf63463", "895f771b-a2b5-463b-852c-2076635d1f1b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e8e73d04-3827-4cdc-82c0-91e59988cf2e", "a237993d-0c22-4fc9-a055-6d448f84683f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9d39a882-17f2-4e2b-9e4b-13c80e158847", "b8f5e8c8-2486-40ff-aecd-1523cc43b65f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9d39a882-17f2-4e2b-9e4b-13c80e158847", "e26a6e77-d1ca-444d-8bf5-2cd1666c7a24" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OldEnough", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3e4d8c81-6c69-4f72-93d9-71329872f25b", 0, new Guid("43327698-bdb9-45df-b7eb-9098baf81281"), "ec4f0115-d696-4358-9553-42d05df35212", "ClientApplicationUser", "clienttwo@okokapp.nl", true, "Client", "Two", null, false, null, "CLIENTTWO@OKOKAPP.NL", "CLIENTTWO@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAEOIDXZEUlLFbWJbYLFsByyDPQ+uDKaq0sJjZw2NgPRWzpbcmQg8DuImRNl19g7aAZA==", "1234567890", true, "85deacb4-4544-46c5-bedc-43f26330eb23", false, "clienttwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OldEnough", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", 0, new Guid("938c6cd6-9bdd-43ab-93f9-14379a3a5f28"), "77063fff-ec58-4af7-8b58-127a94a41c8e", "ClientApplicationUser", "clientone@okokapp.nl", true, "Client", "One", null, false, null, "CLIENTONE@OKOKAPP.NL", "CLIENTONE@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAED4jMMTaZ/+Vnfe62BLlA9pSlRimjdT5E9/KmwE7oNIxJpvGEYBGtAc23QssOSTfGg==", "1234567890", true, "4c42efa9-be0d-4188-9126-26d964f1a65f", false, "clientone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fb6e2f0e-9614-4e3c-bb94-b9c1fe2d3a9e", "3e4d8c81-6c69-4f72-93d9-71329872f25b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fb6e2f0e-9614-4e3c-bb94-b9c1fe2d3a9e", "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb" });

            migrationBuilder.InsertData(
                table: "GuardianChild",
                columns: new[] { "ChildId", "GuardianId" },
                values: new object[] { "3e4d8c81-6c69-4f72-93d9-71329872f25b", "e26a6e77-d1ca-444d-8bf5-2cd1666c7a24" });

            migrationBuilder.InsertData(
                table: "GuardianChild",
                columns: new[] { "ChildId", "GuardianId" },
                values: new object[] { "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", "b8f5e8c8-2486-40ff-aecd-1523cc43b65f" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("079d8794-974e-4de9-82e7-d76fe34da12d"), "Dit is een geseede message [1]", new DateTime(2022, 1, 23, 16, 13, 59, 315, DateTimeKind.Local).AddTicks(3433), null, "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("21035c9e-f5e5-42bb-9bb3-0df72ce7ca6d"), "Dit is een geseede message [2]", new DateTime(2022, 1, 23, 16, 13, 59, 315, DateTimeKind.Local).AddTicks(3459), null, "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("9afacd3e-cb22-4e5d-82bc-119cfa33b24b"), "Dit is een geseede message [3]", new DateTime(2022, 1, 23, 16, 13, 59, 315, DateTimeKind.Local).AddTicks(3463), null, "3e4d8c81-6c69-4f72-93d9-71329872f25b" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("f7b2eaa7-7d4c-49e4-81e8-9dedc84ebcbd"), "Dit is een geseede message [4]", new DateTime(2022, 1, 23, 16, 13, 59, 315, DateTimeKind.Local).AddTicks(3467), null, "3e4d8c81-6c69-4f72-93d9-71329872f25b" });

            migrationBuilder.InsertData(
                table: "SignUpRequests",
                columns: new[] { "Id", "ClientId", "DoctorId", "Handled" },
                values: new object[] { new Guid("477c1fb9-bbc6-49c5-9e15-4b5d17c847e6"), "3e4d8c81-6c69-4f72-93d9-71329872f25b", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b", false });

            migrationBuilder.InsertData(
                table: "SignUpRequests",
                columns: new[] { "Id", "ClientId", "DoctorId", "Handled" },
                values: new object[] { new Guid("c1e4b216-5b09-4efe-9632-d2273556f245"), "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b", false });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("108f2081-3592-480b-90a2-0c729b8badc3"), "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("13460d55-848d-46e3-bab5-4202ded784f5"), "3e4d8c81-6c69-4f72-93d9-71329872f25b", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a237993d-0c22-4fc9-a055-6d448f84683f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("35d97051-d545-45a4-832a-f53c833f3a7b"), "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("371d748f-f9cf-4b3e-83f6-2f89c9b7942b"), "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", new DateTime(2022, 1, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("3f590170-610f-424f-a140-c0455320123f"), "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("4137242c-0b8d-4851-b32b-a7001b288f05"), "3e4d8c81-6c69-4f72-93d9-71329872f25b", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "a237993d-0c22-4fc9-a055-6d448f84683f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("7da6a096-13b6-48dc-970f-6ccfe81f73a1"), "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("900b2831-d375-4a33-8bbd-7e32b4cadbd4"), "3e4d8c81-6c69-4f72-93d9-71329872f25b", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a237993d-0c22-4fc9-a055-6d448f84683f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("960fa018-da5a-4301-b4db-7628dd1c58d7"), "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("ab4e5946-71c3-4ff5-9bc7-2d9fd5e134fa"), "3e4d8c81-6c69-4f72-93d9-71329872f25b", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "a237993d-0c22-4fc9-a055-6d448f84683f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("c0fd3df0-8d8b-40a7-b665-85b6ffc0bd56"), "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("cde47a9f-dc90-4f82-ae83-974be3f03578"), "3e4d8c81-6c69-4f72-93d9-71329872f25b", new DateTime(2022, 1, 23, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "a237993d-0c22-4fc9-a055-6d448f84683f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("d56b51ba-b5b3-4657-9d5a-2d7d25399fb1"), "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", new DateTime(2022, 1, 23, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("d98c3175-a090-4f8f-91fc-24d994d7c684"), "3e4d8c81-6c69-4f72-93d9-71329872f25b", new DateTime(2022, 1, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a237993d-0c22-4fc9-a055-6d448f84683f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("dd7ac4ee-13a7-436f-a3ea-985a7023972c"), "3e4d8c81-6c69-4f72-93d9-71329872f25b", new DateTime(2022, 1, 23, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a237993d-0c22-4fc9-a055-6d448f84683f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("dda75612-8965-4252-aac2-c44268d4592e"), "3e4d8c81-6c69-4f72-93d9-71329872f25b", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a237993d-0c22-4fc9-a055-6d448f84683f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("ec539a27-3607-47ec-94e4-5b0bf2fbe168"), "3e4d8c81-6c69-4f72-93d9-71329872f25b", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a237993d-0c22-4fc9-a055-6d448f84683f" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("fb55e11f-dc95-402d-b1da-43258f4d54b7"), "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", new DateTime(2022, 1, 23, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b" });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("079d8794-974e-4de9-82e7-d76fe34da12d"), new Guid("26445a1f-ed8a-4e94-8da2-5839e3b5e4d5") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("079d8794-974e-4de9-82e7-d76fe34da12d"), new Guid("74c15987-793b-4bb4-b8c4-e378cfe038cf") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("079d8794-974e-4de9-82e7-d76fe34da12d"), new Guid("c649b22d-68a5-4401-9107-c71fbe381ffa") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("9afacd3e-cb22-4e5d-82bc-119cfa33b24b"), new Guid("42b71c8d-9286-4e77-b498-0ae78fca600b") });

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
