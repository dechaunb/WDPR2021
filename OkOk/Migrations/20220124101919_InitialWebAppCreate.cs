using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class InitialWebAppCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    HouseNumberAddition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Handled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupportGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockedOutReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OldEnough = table.Column<bool>(type: "bit", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Specialism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ChatUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    ChildId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GuardianId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_SupportGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "SupportGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SignUpRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Handled = table.Column<bool>(type: "bit", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignUpRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignUpRequests_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignUpRequests_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatments_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Treatments_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MessageChatapplicationUser",
                columns: table => new
                {
                    ChatUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    MessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageReports", x => new { x.MessageId, x.ReportId });
                    table.ForeignKey(
                        name: "FK_MessageReports_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MessageReports_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "HouseNumberAddition", "Street", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("ae53d356-69e9-404b-a710-4b0d96db1b43"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" },
                    { new Guid("b0ea30dd-95d6-46df-9f09-064aedf54785"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59c6519c-b661-49ce-897f-8f6a748efb5a", "1", "Guardian", "GUARDIAN" },
                    { "afd50f9e-b32d-4595-a8ab-2002a9b6b309", "1", "Doctor", "DOCTOR" },
                    { "d3cb8512-d11c-45eb-a72d-ba4ba3edad81", "1", "Admin", "ADMIN" },
                    { "e98e074f-6fff-4854-8717-0622310e9498", "1", "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3eef6450-6406-4820-8e6b-6c23e27b0ea8", 0, "abf8cf8a-ca0d-464c-b84c-c121b1bedfdf", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", null, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEOWk/4W8vxsbYwexwRLb6idmNPDT1idO4NR3aJQRYddIwuWaiC1MjqGGLhswCuFZuA==", "1234567890", true, "d0f22e03-102f-4724-a959-110559979c89", false, "dechaun@okokapp.nl" },
                    { "81db857f-158c-40af-9425-33c28f561402", 0, "c3182880-8f71-45ea-883f-885758438bf1", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", null, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEHErUlIwpUy94hww6+3wRI8rGMjlky2VGigCcoyHidZD4NdamStAJA8A9ULvQMZnpQ==", "1234567890", true, "05222ec1-d841-43ea-96da-0eb091f047e4", false, "angelo@okokapp.nl" },
                    { "84a7995c-76c7-4312-94a4-ade11032c6f5", 0, "dbf3137a-f150-4e94-8048-51aca2c7598f", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", null, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEJj8YHvaR278tlTwW9KBSS8pS84ImQiKmGNxcG9ozV/B4Bpexxqet/TBl1BxWekvmw==", "1234567890", true, "6d2877bd-cf54-42f3-867f-b4ac7326bcee", false, "timothy@okokapp.nl" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialism", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "80105c0c-5018-40e5-af82-87cd5e9cf2b5", 0, "046f81f7-ad5a-408e-a4bd-930262a09d17", "DoctorApplicationUser", "doctortwo@okokapp.nl", true, "Doctor", "Two", null, false, null, "DOCTORTWO@OKOKAPP.NL", "DOCTORTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAECJ/TSC+sT8Jpx8zsg0oJpY6UzpKDCaAAT2jF8OhIQ1yjHCdM1CaiPTYELq5Gy2oYA==", "1234567890", true, "35c2b4cc-761d-450b-99f4-8d1d661e98c0", "Autisme", false, "doctortwo@okokapp.nl" },
                    { "8c53a982-ac5b-4879-a8b3-3cd0f739f35a", 0, "e5b0b0ab-7134-4ba5-aee6-57b2c54d4d5a", "DoctorApplicationUser", "doctorone@okokapp.nl", true, "Doctor", "One", null, false, null, "DOCTORONE@OKOKAPP.NL", "DOCTORONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAENT4w7zueA1cfF+Ev3S87XPGzJNjtS6FeeY4XdUG0G8IaqTXKoMR6SDCvKaYlIhwbg==", "1234567890", true, "c76aaca4-f515-419e-be53-917ad6744cef", "Autisme", false, "doctorone@okokapp.nl" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "92c83641-7e8a-44f1-908c-e46000426b2b", 0, "9a790569-8d96-4d3c-a4ea-388b3067ba6a", "GuardianApplicationUser", "guardiantwo@okokapp.nl", true, "Guardian", "Two", null, false, null, "GUARDIANTWO@OKOKAPP.NL", "GUARDIANTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEFnHCayTgl6ouvNG7P6gNo6gWSX9vaTnElKSQLNetzzNYMCCQwOx13mnGSXRIAnLGw==", "1234567890", true, "65bd26c0-8f87-4039-bc5b-cd519002b203", false, "guardiantwo@okokapp.nl" },
                    { "9d0aad18-e632-45d2-9412-a8af6b400078", 0, "2eeb9cf2-b0ac-461c-b680-ef8f369621fa", "GuardianApplicationUser", "guardianone@okokapp.nl", true, "Guardian", "One", null, false, null, "GUARDIANONE@OKOKAPP.NL", "GUARDIANONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAEJiijGuxgnmHtyRyQ942RebcwN3trC3J74vjdc5/QauCKj3IuDGvmnVKBPf5+0PEDg==", "1234567890", true, "0fda0fbe-ee7f-4ef5-81e9-a7b3a323a02a", false, "guardianone@okokapp.nl" }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[,]
                {
                    { new Guid("3ca3ef8f-8256-4a60-bb8f-da080e98b53f"), false },
                    { new Guid("40381add-e7f6-49cd-ba65-9a3a63993de8"), false },
                    { new Guid("b0290c51-f347-4604-9d55-f705daba7371"), false },
                    { new Guid("fff0cb7f-4794-4601-a114-b83a3bd38eab"), false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d3cb8512-d11c-45eb-a72d-ba4ba3edad81", "3eef6450-6406-4820-8e6b-6c23e27b0ea8" },
                    { "afd50f9e-b32d-4595-a8ab-2002a9b6b309", "80105c0c-5018-40e5-af82-87cd5e9cf2b5" },
                    { "d3cb8512-d11c-45eb-a72d-ba4ba3edad81", "81db857f-158c-40af-9425-33c28f561402" },
                    { "d3cb8512-d11c-45eb-a72d-ba4ba3edad81", "84a7995c-76c7-4312-94a4-ade11032c6f5" },
                    { "afd50f9e-b32d-4595-a8ab-2002a9b6b309", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a" },
                    { "59c6519c-b661-49ce-897f-8f6a748efb5a", "92c83641-7e8a-44f1-908c-e46000426b2b" },
                    { "59c6519c-b661-49ce-897f-8f6a748efb5a", "9d0aad18-e632-45d2-9412-a8af6b400078" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OldEnough", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2f6bc50b-3889-4bd5-949e-a54af81e44c1", 0, new Guid("ae53d356-69e9-404b-a710-4b0d96db1b43"), "3cf1ed2c-458a-4ed4-a51e-b82d0016c3a6", "ClientApplicationUser", "clienttwo@okokapp.nl", true, "Client", "Two", null, false, null, "CLIENTTWO@OKOKAPP.NL", "CLIENTTWO@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAEMosDZbgcyVdTFoZVcJst5Cx0F7nR0YkkUvNSKZAXZkgyIujZl6yqCAvOXh+Lvgnfg==", "1234567890", true, "6adcfe42-3faf-422c-91f3-b543611648ea", false, "clienttwo@okokapp.nl" },
                    { "515ecb4b-67a6-452d-8d55-928f1bd76c58", 0, new Guid("b0ea30dd-95d6-46df-9f09-064aedf54785"), "22a5f00f-15f4-4607-819c-9a653ce15505", "ClientApplicationUser", "clientone@okokapp.nl", true, "Client", "One", null, false, null, "CLIENTONE@OKOKAPP.NL", "CLIENTONE@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAEMV0a3UXlQzyzA4KfXAhwJsrpKfmgA28VPO3EU/BA1PQFw8jWOKTl6itHWEFVYDkaw==", "1234567890", true, "910a57ac-f3dc-4ee9-8c4c-9975e88d6799", false, "clientone@okokapp.nl" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e98e074f-6fff-4854-8717-0622310e9498", "2f6bc50b-3889-4bd5-949e-a54af81e44c1" },
                    { "e98e074f-6fff-4854-8717-0622310e9498", "515ecb4b-67a6-452d-8d55-928f1bd76c58" }
                });

            migrationBuilder.InsertData(
                table: "GuardianChild",
                columns: new[] { "ChildId", "GuardianId" },
                values: new object[,]
                {
                    { "2f6bc50b-3889-4bd5-949e-a54af81e44c1", "92c83641-7e8a-44f1-908c-e46000426b2b" },
                    { "515ecb4b-67a6-452d-8d55-928f1bd76c58", "9d0aad18-e632-45d2-9412-a8af6b400078" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[,]
                {
                    { new Guid("0efc54d8-2369-4c99-96ad-d96c37e181e3"), "Dit is een geseede message [3]", new DateTime(2022, 1, 24, 11, 19, 18, 662, DateTimeKind.Local).AddTicks(1248), null, "2f6bc50b-3889-4bd5-949e-a54af81e44c1" },
                    { new Guid("518b2793-f3a8-4bea-be3c-9e5429de7264"), "Dit is een geseede message [1]", new DateTime(2022, 1, 24, 11, 19, 18, 662, DateTimeKind.Local).AddTicks(1233), null, "515ecb4b-67a6-452d-8d55-928f1bd76c58" },
                    { new Guid("80320823-bfee-4948-95f7-cd45970893eb"), "Dit is een geseede message [4]", new DateTime(2022, 1, 24, 11, 19, 18, 662, DateTimeKind.Local).AddTicks(1252), null, "2f6bc50b-3889-4bd5-949e-a54af81e44c1" },
                    { new Guid("d1d970c6-cc18-4011-afcc-bf6c82c52bf0"), "Dit is een geseede message [2]", new DateTime(2022, 1, 24, 11, 19, 18, 662, DateTimeKind.Local).AddTicks(1244), null, "515ecb4b-67a6-452d-8d55-928f1bd76c58" }
                });

            migrationBuilder.InsertData(
                table: "SignUpRequests",
                columns: new[] { "Id", "ClientId", "DoctorId", "Handled" },
                values: new object[,]
                {
                    { new Guid("af4e9136-526d-41e4-af5a-f9f26c95257f"), "2f6bc50b-3889-4bd5-949e-a54af81e44c1", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a", false },
                    { new Guid("d75e1b49-f870-4a37-9fa2-dc013a7c16d1"), "515ecb4b-67a6-452d-8d55-928f1bd76c58", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a", false }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[,]
                {
                    { new Guid("08c340fe-0a9c-4e74-b657-738fe7286cb0"), "515ecb4b-67a6-452d-8d55-928f1bd76c58", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a" },
                    { new Guid("148e3fbc-87c7-4170-8ad9-8f5961ea0fd0"), "515ecb4b-67a6-452d-8d55-928f1bd76c58", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a" },
                    { new Guid("1691c211-b2f0-4e1b-90db-a4ccc07924bf"), "515ecb4b-67a6-452d-8d55-928f1bd76c58", new DateTime(2022, 1, 24, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a" },
                    { new Guid("3796214b-b6dc-4c26-8c89-c9d74c726bb4"), "2f6bc50b-3889-4bd5-949e-a54af81e44c1", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "80105c0c-5018-40e5-af82-87cd5e9cf2b5" },
                    { new Guid("5ea37995-847f-45b4-a874-d429e0a70c4e"), "2f6bc50b-3889-4bd5-949e-a54af81e44c1", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "80105c0c-5018-40e5-af82-87cd5e9cf2b5" },
                    { new Guid("5fd60fa0-908f-472d-a7c3-a733ffe01fd1"), "2f6bc50b-3889-4bd5-949e-a54af81e44c1", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "80105c0c-5018-40e5-af82-87cd5e9cf2b5" },
                    { new Guid("7bfdeccb-03f6-4bd0-9664-6ab1323c479f"), "2f6bc50b-3889-4bd5-949e-a54af81e44c1", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "80105c0c-5018-40e5-af82-87cd5e9cf2b5" },
                    { new Guid("7efc4872-68b1-4ba1-a912-6a43e7c68f6a"), "515ecb4b-67a6-452d-8d55-928f1bd76c58", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a" },
                    { new Guid("8651eb2c-fcee-4fba-8d90-c5b75b8b71c4"), "2f6bc50b-3889-4bd5-949e-a54af81e44c1", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "80105c0c-5018-40e5-af82-87cd5e9cf2b5" },
                    { new Guid("87d8cf00-b794-4fcd-bba4-ee808072e3ec"), "515ecb4b-67a6-452d-8d55-928f1bd76c58", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a" },
                    { new Guid("890020da-e86e-44ed-ba6b-3c8053b4d1f4"), "515ecb4b-67a6-452d-8d55-928f1bd76c58", new DateTime(2022, 1, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a" },
                    { new Guid("9298aaed-e91b-4cd8-a607-dda7c8b849b9"), "515ecb4b-67a6-452d-8d55-928f1bd76c58", new DateTime(2022, 1, 24, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a" },
                    { new Guid("a20908e0-4c8d-424d-99dc-ee9f6fb1be48"), "2f6bc50b-3889-4bd5-949e-a54af81e44c1", new DateTime(2022, 1, 24, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "80105c0c-5018-40e5-af82-87cd5e9cf2b5" },
                    { new Guid("c89f3137-e2fd-4f28-baae-8fee737066c8"), "515ecb4b-67a6-452d-8d55-928f1bd76c58", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a" },
                    { new Guid("ecae555f-f38e-4c69-93b2-d5da71cfd23a"), "515ecb4b-67a6-452d-8d55-928f1bd76c58", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "8c53a982-ac5b-4879-a8b3-3cd0f739f35a" },
                    { new Guid("f299ebf4-4d09-44bf-b71d-cc2f7ca9ff88"), "2f6bc50b-3889-4bd5-949e-a54af81e44c1", new DateTime(2022, 1, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "80105c0c-5018-40e5-af82-87cd5e9cf2b5" },
                    { new Guid("f5f333ba-7760-4a52-814a-7e9941eb27f3"), "2f6bc50b-3889-4bd5-949e-a54af81e44c1", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "80105c0c-5018-40e5-af82-87cd5e9cf2b5" },
                    { new Guid("f697a84b-ffbf-4720-8118-f4cf264b8e4b"), "2f6bc50b-3889-4bd5-949e-a54af81e44c1", new DateTime(2022, 1, 24, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "80105c0c-5018-40e5-af82-87cd5e9cf2b5" }
                });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[,]
                {
                    { new Guid("0efc54d8-2369-4c99-96ad-d96c37e181e3"), new Guid("3ca3ef8f-8256-4a60-bb8f-da080e98b53f") },
                    { new Guid("518b2793-f3a8-4bea-be3c-9e5429de7264"), new Guid("40381add-e7f6-49cd-ba65-9a3a63993de8") },
                    { new Guid("518b2793-f3a8-4bea-be3c-9e5429de7264"), new Guid("b0290c51-f347-4604-9d55-f705daba7371") },
                    { new Guid("518b2793-f3a8-4bea-be3c-9e5429de7264"), new Guid("fff0cb7f-4794-4601-a114-b83a3bd38eab") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[AddressId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                unique: true,
                filter: "[ClientId] IS NOT NULL");

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
