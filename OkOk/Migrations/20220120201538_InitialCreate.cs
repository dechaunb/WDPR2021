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
                values: new object[] { new Guid("d59ed4f4-4a52-423b-9be2-789dabb0cd01"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "HouseNumberAddition", "Street", "ZipCode" },
                values: new object[] { new Guid("f8a551b0-0ab2-4d0a-b5dd-183b8a1fe571"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16e828f3-dee1-47eb-8450-dd69d7374cf9", "1", "Guardian", "GUARDIAN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e75f9f05-a964-4b48-8d2e-ec57c5986234", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb404819-a49a-48ed-af48-6a70a6e78043", "1", "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbf65982-e9a7-4c05-b2e0-57f4d77d4cef", "1", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "40e2b11d-7be4-41a6-ad95-508a04908823", 0, "6e09cfae-f005-4d0a-a328-0c6b5912c9c8", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", null, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEKoldaDKnu463J4bdDAgGIVkviulj/tXhNtygjTXwwqzwG7KaPzAgfs94WosYZXBZg==", "1234567890", true, "1dc1dc69-df57-4373-9113-6f8c37dcb496", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "70ad9b1f-1653-4c8b-b0cc-05151dd9c3e5", 0, "24fa01fb-4ad5-40af-8221-c36d3be256b5", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", null, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEF87HRCu2fpGIN5rEyUJM+zwzPgtm4F8/WOfLK8wqJDmb0LafXUFA9ocviz1qAo4HQ==", "1234567890", true, "6f7489ee-71f0-4677-80e5-ac4360df8750", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cb942955-b31b-4e4d-b2f9-9d1928aeda7b", 0, "14260196-cbb9-4551-b7bd-c25ec8048c2e", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", null, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAENTXlnpvglCiOT+Cnl/T7TFVgpSsI8OrydVV9YeboGk4MFSmuhtOEwyj+AG2boSL3A==", "1234567890", true, "cdb8e1d9-2a55-410b-97d6-73560e903faa", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialism", "TwoFactorEnabled", "UserName" },
                values: new object[] { "03065621-afd5-485b-a179-309f05a2f95c", 0, "9604c963-698e-4e4b-ab6c-9a7404bdffde", "DoctorApplicationUser", "doctorone@okokapp.nl", true, "Doctor", "One", null, false, null, "DOCTORONE@OKOKAPP.NL", "DOCTORONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAEPrKeBlvY7I8erE9VERTpvlGuoDQSUtYDwcjbX8jxPTsyXaVRtQtd69jFaaO7NyyRA==", "1234567890", true, "7c53a1b1-8983-4298-9596-5fcc118482c1", "Autisme", false, "doctorone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialism", "TwoFactorEnabled", "UserName" },
                values: new object[] { "280b2964-749e-4c67-9fa3-52d053d23cb9", 0, "895a40b3-a158-48e5-9e4f-380f22922f0b", "DoctorApplicationUser", "doctortwo@okokapp.nl", true, "Doctor", "Two", null, false, null, "DOCTORTWO@OKOKAPP.NL", "DOCTORTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEIUOcxtNWln+TO9Lh5stYovF14R/cwjFlKB5k3fJzpxa1DSfhQOUnIo/Fi0qEdcf0Q==", "1234567890", true, "a6e3c09a-6031-47b5-9f2d-92d8d59a728e", "Autisme", false, "doctortwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8235b4b5-7f18-466d-aca1-913fdc869705", 0, "91d0dc3f-438f-4e1c-98e9-5a167ca7d961", "GuardianApplicationUser", "guardiantwo@okokapp.nl", true, "Guardian", "Two", null, false, null, "GUARDIANTWO@OKOKAPP.NL", "GUARDIANTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEAAaMVUHZNvAfxS/Djfp1TsheITB8zeD68f0PNgIvpU68+mhDZojtBi/rwEEdD01Yw==", "1234567890", true, "d00dee68-afe1-4452-916b-da5735209c6e", false, "guardiantwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9a1588e9-e19a-4a13-a9b8-e51c3039e338", 0, "59367880-c9c5-41b1-887d-c8be87a16ed2", "GuardianApplicationUser", "guardianone@okokapp.nl", true, "Guardian", "One", null, false, null, "GUARDIANONE@OKOKAPP.NL", "GUARDIANONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAEEK1+7su/R8+XEJDxQyprz2c95ZX3mvqHrvuuo/XKTAsjskLGlh1Gg2sL/du/NAGgQ==", "1234567890", true, "08503e43-e116-4b56-ad9a-56e863d1e02c", false, "guardianone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("45ac16ac-d464-4c4d-9c38-b6ce022d017b"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("5d673c75-8984-4c31-80f8-5726797b42bb"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("724fe7b0-495d-4dbe-a9a8-c3e5b6a23f44"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("c9621624-3619-4670-8e3d-254934dd496a"), false });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fb404819-a49a-48ed-af48-6a70a6e78043", "03065621-afd5-485b-a179-309f05a2f95c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fb404819-a49a-48ed-af48-6a70a6e78043", "280b2964-749e-4c67-9fa3-52d053d23cb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e75f9f05-a964-4b48-8d2e-ec57c5986234", "40e2b11d-7be4-41a6-ad95-508a04908823" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e75f9f05-a964-4b48-8d2e-ec57c5986234", "70ad9b1f-1653-4c8b-b0cc-05151dd9c3e5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "16e828f3-dee1-47eb-8450-dd69d7374cf9", "8235b4b5-7f18-466d-aca1-913fdc869705" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "16e828f3-dee1-47eb-8450-dd69d7374cf9", "9a1588e9-e19a-4a13-a9b8-e51c3039e338" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e75f9f05-a964-4b48-8d2e-ec57c5986234", "cb942955-b31b-4e4d-b2f9-9d1928aeda7b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OldEnough", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6a15ca21-cccb-42ed-8f19-edd6934910c8", 0, new Guid("f8a551b0-0ab2-4d0a-b5dd-183b8a1fe571"), "e9c2c9bd-e873-4dfb-b138-b29817f55f62", "ClientApplicationUser", "clienttwo@okokapp.nl", true, "Client", "Two", null, false, null, "CLIENTTWO@OKOKAPP.NL", "CLIENTTWO@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAECAACz00t1edQeEBelPsieq5blo2j3NIZiouAGiWPq3UGbUanI3Q8GN3x36MxkTO/Q==", "1234567890", true, "b8298d75-086b-4a45-88c0-e931d7ffdf28", false, "clienttwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OldEnough", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "de8459c4-4062-4068-9856-256096919996", 0, new Guid("d59ed4f4-4a52-423b-9be2-789dabb0cd01"), "36d8aa3a-25a1-4536-bce9-37ecb1a450a1", "ClientApplicationUser", "clientone@okokapp.nl", true, "Client", "One", null, false, null, "CLIENTONE@OKOKAPP.NL", "CLIENTONE@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAEDVVY6I4evYkROHM61cpgRgS7pFU/uvhBzlmGd0KvYXJl1HUCZUrMAIaBxVAcPvG5Q==", "1234567890", true, "d9acc481-f9ef-4da4-9ba0-715c76c62193", false, "clientone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fbf65982-e9a7-4c05-b2e0-57f4d77d4cef", "6a15ca21-cccb-42ed-8f19-edd6934910c8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fbf65982-e9a7-4c05-b2e0-57f4d77d4cef", "de8459c4-4062-4068-9856-256096919996" });

            migrationBuilder.InsertData(
                table: "GuardianChild",
                columns: new[] { "ChildId", "GuardianId" },
                values: new object[] { "6a15ca21-cccb-42ed-8f19-edd6934910c8", "8235b4b5-7f18-466d-aca1-913fdc869705" });

            migrationBuilder.InsertData(
                table: "GuardianChild",
                columns: new[] { "ChildId", "GuardianId" },
                values: new object[] { "de8459c4-4062-4068-9856-256096919996", "9a1588e9-e19a-4a13-a9b8-e51c3039e338" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("008fed72-f9a3-4100-9c57-a88a152f400d"), "Dit is een geseede message [4]", new DateTime(2022, 1, 20, 21, 15, 37, 932, DateTimeKind.Local).AddTicks(3810), null, "6a15ca21-cccb-42ed-8f19-edd6934910c8" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("3cf2624f-90a0-4166-815f-0ee1215c5677"), "Dit is een geseede message [2]", new DateTime(2022, 1, 20, 21, 15, 37, 932, DateTimeKind.Local).AddTicks(3793), null, "de8459c4-4062-4068-9856-256096919996" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("de8627de-1e2e-4ff0-bc1f-285711469eb5"), "Dit is een geseede message [3]", new DateTime(2022, 1, 20, 21, 15, 37, 932, DateTimeKind.Local).AddTicks(3804), null, "6a15ca21-cccb-42ed-8f19-edd6934910c8" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("f34da526-98c8-40e2-849d-405e40f1a758"), "Dit is een geseede message [1]", new DateTime(2022, 1, 20, 21, 15, 37, 932, DateTimeKind.Local).AddTicks(3775), null, "de8459c4-4062-4068-9856-256096919996" });

            migrationBuilder.InsertData(
                table: "SignUpRequests",
                columns: new[] { "Id", "ClientId", "DoctorId", "Handled" },
                values: new object[] { new Guid("2f7d5ac7-9c1b-41aa-b3c8-96674e124912"), "de8459c4-4062-4068-9856-256096919996", "03065621-afd5-485b-a179-309f05a2f95c", false });

            migrationBuilder.InsertData(
                table: "SignUpRequests",
                columns: new[] { "Id", "ClientId", "DoctorId", "Handled" },
                values: new object[] { new Guid("c1d625a0-fb07-4e2f-ab0e-e781f658406b"), "6a15ca21-cccb-42ed-8f19-edd6934910c8", "03065621-afd5-485b-a179-309f05a2f95c", false });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("57636457-11f5-41f5-87dc-5010ea1b2a18"), "6a15ca21-cccb-42ed-8f19-edd6934910c8", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "280b2964-749e-4c67-9fa3-52d053d23cb9" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("5dca797c-6daf-40ff-8edc-cb196c255cc2"), "de8459c4-4062-4068-9856-256096919996", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "03065621-afd5-485b-a179-309f05a2f95c" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("5f5b360d-a126-4d38-8052-e89886452a49"), "de8459c4-4062-4068-9856-256096919996", new DateTime(2022, 1, 20, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "03065621-afd5-485b-a179-309f05a2f95c" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("6058a610-95bf-4158-bb19-68b03783e725"), "de8459c4-4062-4068-9856-256096919996", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "03065621-afd5-485b-a179-309f05a2f95c" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("65115d57-0a20-4c64-911b-e3ee05d9682e"), "de8459c4-4062-4068-9856-256096919996", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "03065621-afd5-485b-a179-309f05a2f95c" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("7b1c423a-03cf-4ee7-8116-9747904de6f7"), "6a15ca21-cccb-42ed-8f19-edd6934910c8", new DateTime(2022, 1, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "280b2964-749e-4c67-9fa3-52d053d23cb9" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("8ee08a12-da9a-459c-98a3-86faea194e80"), "6a15ca21-cccb-42ed-8f19-edd6934910c8", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "280b2964-749e-4c67-9fa3-52d053d23cb9" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("97ccf801-d2b8-4837-90a9-2c98884c12bd"), "de8459c4-4062-4068-9856-256096919996", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "03065621-afd5-485b-a179-309f05a2f95c" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("a0c7d3f3-dc4d-48db-a66b-ed088463149c"), "6a15ca21-cccb-42ed-8f19-edd6934910c8", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "280b2964-749e-4c67-9fa3-52d053d23cb9" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("a3b60a54-fc11-4343-b6e0-e735d2484b76"), "6a15ca21-cccb-42ed-8f19-edd6934910c8", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "280b2964-749e-4c67-9fa3-52d053d23cb9" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("aa118147-97fa-45bf-a53a-2cbf7104165e"), "6a15ca21-cccb-42ed-8f19-edd6934910c8", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "280b2964-749e-4c67-9fa3-52d053d23cb9" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("c814d5f5-aa91-4d9e-8b81-f991cfff956c"), "de8459c4-4062-4068-9856-256096919996", new DateTime(2022, 1, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "03065621-afd5-485b-a179-309f05a2f95c" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("cbfc6a25-247a-485b-83ef-73ec425a8e99"), "6a15ca21-cccb-42ed-8f19-edd6934910c8", new DateTime(2022, 1, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "280b2964-749e-4c67-9fa3-52d053d23cb9" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("d650536c-8d90-43c7-a5e2-cc7c031a4a48"), "de8459c4-4062-4068-9856-256096919996", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "03065621-afd5-485b-a179-309f05a2f95c" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("e050f7f6-37a4-42bb-9553-355286dc1dd3"), "de8459c4-4062-4068-9856-256096919996", new DateTime(2022, 1, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "03065621-afd5-485b-a179-309f05a2f95c" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("ec8b93ab-4339-49f6-8319-8a27866281af"), "6a15ca21-cccb-42ed-8f19-edd6934910c8", new DateTime(2022, 1, 20, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "280b2964-749e-4c67-9fa3-52d053d23cb9" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("ed5c0ca2-a65f-4771-9177-baff8b83684a"), "de8459c4-4062-4068-9856-256096919996", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "03065621-afd5-485b-a179-309f05a2f95c" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("fc54150e-8241-464e-86c6-5d38696ecf04"), "6a15ca21-cccb-42ed-8f19-edd6934910c8", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "280b2964-749e-4c67-9fa3-52d053d23cb9" });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("de8627de-1e2e-4ff0-bc1f-285711469eb5"), new Guid("c9621624-3619-4670-8e3d-254934dd496a") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("f34da526-98c8-40e2-849d-405e40f1a758"), new Guid("45ac16ac-d464-4c4d-9c38-b6ce022d017b") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("f34da526-98c8-40e2-849d-405e40f1a758"), new Guid("5d673c75-8984-4c31-80f8-5726797b42bb") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("f34da526-98c8-40e2-849d-405e40f1a758"), new Guid("724fe7b0-495d-4dbe-a9a8-c3e5b6a23f44") });

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
