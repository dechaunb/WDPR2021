using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class InitialAzureDeployment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb6e2f0e-9614-4e3c-bb94-b9c1fe2d3a9e", "3e4d8c81-6c69-4f72-93d9-71329872f25b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e00dd267-628a-4b64-8c6b-65a31cf63463", "48cf798d-2d19-4869-969f-a572fabf9ebc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e8e73d04-3827-4cdc-82c0-91e59988cf2e", "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e00dd267-628a-4b64-8c6b-65a31cf63463", "52a7829f-02f6-4f70-a726-a4521850af9e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e00dd267-628a-4b64-8c6b-65a31cf63463", "895f771b-a2b5-463b-852c-2076635d1f1b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e8e73d04-3827-4cdc-82c0-91e59988cf2e", "a237993d-0c22-4fc9-a055-6d448f84683f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d39a882-17f2-4e2b-9e4b-13c80e158847", "b8f5e8c8-2486-40ff-aecd-1523cc43b65f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d39a882-17f2-4e2b-9e4b-13c80e158847", "e26a6e77-d1ca-444d-8bf5-2cd1666c7a24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb6e2f0e-9614-4e3c-bb94-b9c1fe2d3a9e", "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb" });

            migrationBuilder.DeleteData(
                table: "GuardianChild",
                keyColumns: new[] { "ChildId", "GuardianId" },
                keyValues: new object[] { "3e4d8c81-6c69-4f72-93d9-71329872f25b", "e26a6e77-d1ca-444d-8bf5-2cd1666c7a24" });

            migrationBuilder.DeleteData(
                table: "GuardianChild",
                keyColumns: new[] { "ChildId", "GuardianId" },
                keyValues: new object[] { "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb", "b8f5e8c8-2486-40ff-aecd-1523cc43b65f" });

            migrationBuilder.DeleteData(
                table: "MessageReports",
                keyColumns: new[] { "MessageId", "ReportId" },
                keyValues: new object[] { new Guid("079d8794-974e-4de9-82e7-d76fe34da12d"), new Guid("26445a1f-ed8a-4e94-8da2-5839e3b5e4d5") });

            migrationBuilder.DeleteData(
                table: "MessageReports",
                keyColumns: new[] { "MessageId", "ReportId" },
                keyValues: new object[] { new Guid("079d8794-974e-4de9-82e7-d76fe34da12d"), new Guid("74c15987-793b-4bb4-b8c4-e378cfe038cf") });

            migrationBuilder.DeleteData(
                table: "MessageReports",
                keyColumns: new[] { "MessageId", "ReportId" },
                keyValues: new object[] { new Guid("079d8794-974e-4de9-82e7-d76fe34da12d"), new Guid("c649b22d-68a5-4401-9107-c71fbe381ffa") });

            migrationBuilder.DeleteData(
                table: "MessageReports",
                keyColumns: new[] { "MessageId", "ReportId" },
                keyValues: new object[] { new Guid("9afacd3e-cb22-4e5d-82bc-119cfa33b24b"), new Guid("42b71c8d-9286-4e77-b498-0ae78fca600b") });

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("21035c9e-f5e5-42bb-9bb3-0df72ce7ca6d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f7b2eaa7-7d4c-49e4-81e8-9dedc84ebcbd"));

            migrationBuilder.DeleteData(
                table: "SignUpRequests",
                keyColumn: "Id",
                keyValue: new Guid("477c1fb9-bbc6-49c5-9e15-4b5d17c847e6"));

            migrationBuilder.DeleteData(
                table: "SignUpRequests",
                keyColumn: "Id",
                keyValue: new Guid("c1e4b216-5b09-4efe-9632-d2273556f245"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("108f2081-3592-480b-90a2-0c729b8badc3"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("13460d55-848d-46e3-bab5-4202ded784f5"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("35d97051-d545-45a4-832a-f53c833f3a7b"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("371d748f-f9cf-4b3e-83f6-2f89c9b7942b"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("3f590170-610f-424f-a140-c0455320123f"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("4137242c-0b8d-4851-b32b-a7001b288f05"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("7da6a096-13b6-48dc-970f-6ccfe81f73a1"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("900b2831-d375-4a33-8bbd-7e32b4cadbd4"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("960fa018-da5a-4301-b4db-7628dd1c58d7"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("ab4e5946-71c3-4ff5-9bc7-2d9fd5e134fa"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("c0fd3df0-8d8b-40a7-b665-85b6ffc0bd56"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("cde47a9f-dc90-4f82-ae83-974be3f03578"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("d56b51ba-b5b3-4657-9d5a-2d7d25399fb1"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("d98c3175-a090-4f8f-91fc-24d994d7c684"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("dd7ac4ee-13a7-436f-a3ea-985a7023972c"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("dda75612-8965-4252-aac2-c44268d4592e"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("ec539a27-3607-47ec-94e4-5b0bf2fbe168"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("fb55e11f-dc95-402d-b1da-43258f4d54b7"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d39a882-17f2-4e2b-9e4b-13c80e158847");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e00dd267-628a-4b64-8c6b-65a31cf63463");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8e73d04-3827-4cdc-82c0-91e59988cf2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb6e2f0e-9614-4e3c-bb94-b9c1fe2d3a9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48cf798d-2d19-4869-969f-a572fabf9ebc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52a7829f-02f6-4f70-a726-a4521850af9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "895f771b-a2b5-463b-852c-2076635d1f1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4bf7f22b-d20c-49ee-87d3-74f8e8d9972b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a237993d-0c22-4fc9-a055-6d448f84683f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8f5e8c8-2486-40ff-aecd-1523cc43b65f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e26a6e77-d1ca-444d-8bf5-2cd1666c7a24");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("079d8794-974e-4de9-82e7-d76fe34da12d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9afacd3e-cb22-4e5d-82bc-119cfa33b24b"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("26445a1f-ed8a-4e94-8da2-5839e3b5e4d5"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("42b71c8d-9286-4e77-b498-0ae78fca600b"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("74c15987-793b-4bb4-b8c4-e378cfe038cf"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("c649b22d-68a5-4401-9107-c71fbe381ffa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e4d8c81-6c69-4f72-93d9-71329872f25b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecc725e2-d4a3-4c5e-8bad-43d36fc065fb");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("43327698-bdb9-45df-b7eb-9098baf81281"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("938c6cd6-9bdd-43ab-93f9-14379a3a5f28"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "HouseNumberAddition", "Street", "ZipCode" },
                values: new object[] { new Guid("1557c261-7861-4bbc-8195-66dc66ed2208"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "HouseNumberAddition", "Street", "ZipCode" },
                values: new object[] { new Guid("d1a0bcee-d9e8-44fd-9e59-4f98f4df9394"), "Dorp", "Nederland", 1, null, "Dorpsstraat", "1234AB" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e27e5ad-8903-4eb4-86e9-b65d4265b645", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ade780e-7d19-446f-a73c-ba0e823c2408", "1", "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6c6f735-ac78-4c7a-9397-4048eef76f9f", "1", "Guardian", "GUARDIAN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cdfee3a0-db09-481f-a9eb-7c0248030830", "1", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1860b6f7-cc0f-4d4b-af5e-a64b973351c4", 0, "f98d04c6-668b-45da-a13f-24973ad246f4", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", null, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEJ/lSRJn9YZvms7aCFXjPJfPmwUXGPY+kUsF273Tv6fmW6BMlP1idnlooU4QIWFdTA==", "1234567890", true, "a2473174-f3b6-4275-9e14-880e9ee76710", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "af3e2f2f-fd13-4f74-8821-246bb1003ec0", 0, "7e3edb26-4db4-45e7-9c5c-350055b6dcac", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", null, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEMimGhIHIOo0mesN3LxhYSjNEycZsGH0ZJdKTCyAijBQWxsBIbOgJ2wYBysXiy59mg==", "1234567890", true, "5a43418e-6743-4fae-a880-29b680e801e6", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dc0cd687-6a58-43e3-95ae-af894531cef6", 0, "abc3bce2-0242-49a9-920e-f94f55083aa1", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", null, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEBEXNq1RSwo9LYMt4TFxmW1jIWLkiae0zqiEVIffjy7mRHNZsZ1xmJg8rTwMd+ucPg==", "1234567890", true, "3ace9313-86a0-4221-bfb0-67677df84f39", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialism", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a7594e4e-e53f-4af6-89b3-d430fcdad819", 0, "88b0ff0d-95f4-4b93-871a-cf58361c67af", "DoctorApplicationUser", "doctortwo@okokapp.nl", true, "Doctor", "Two", null, false, null, "DOCTORTWO@OKOKAPP.NL", "DOCTORTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEJvEv7OuG9A7VWtjuWj/LLcxLWygLKJxPzdlcWV4AbZyqA6NJrL3W69KZvR9CsP0HQ==", "1234567890", true, "13453174-3630-4d62-9747-72bdb43b19aa", "Autisme", false, "doctortwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialism", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7", 0, "0ae2995a-d90a-4723-ab4e-6aac3bde5c6a", "DoctorApplicationUser", "doctorone@okokapp.nl", true, "Doctor", "One", null, false, null, "DOCTORONE@OKOKAPP.NL", "DOCTORONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAEDf8P+pPvlS0FEVuVMtbmZaS1GMAXT21cT4+WPEp3VW8MaokHtqF20OpjAJTBB5OZA==", "1234567890", true, "88dbdc96-a71e-4c6d-bdfa-56009b687289", "Autisme", false, "doctorone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "370c7cda-2387-4309-a96b-c3b169118ad9", 0, "7f29a9e1-1c6e-406c-9375-6a483e31268a", "GuardianApplicationUser", "guardiantwo@okokapp.nl", true, "Guardian", "Two", null, false, null, "GUARDIANTWO@OKOKAPP.NL", "GUARDIANTWO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEN+KlmErd9rcet9dxy9wvX1F3ltfNyCCSDg4H7Hjd0SfmrEmmAD9CVzd9+hSloJ9nQ==", "1234567890", true, "d15674c8-e6c8-41b7-8450-30d0d7624304", false, "guardiantwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "416b6e21-0bfb-494f-8db9-f7afe6f4437b", 0, "cb6b1933-93ef-49c4-844c-38770b9447a9", "GuardianApplicationUser", "guardianone@okokapp.nl", true, "Guardian", "One", null, false, null, "GUARDIANONE@OKOKAPP.NL", "GUARDIANONE@OKOKAPP.NL", "AQAAAAEAACcQAAAAEOGBJhXorNSE42C3RIhhi8luSkv8GHCJ1RHPryo+XTQOG6hJOOwAjZMpRn4YZ/Gv6g==", "1234567890", true, "f84e0ebf-d5dd-48ea-8a83-9885b3611426", false, "guardianone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("52283e15-72ea-47ea-bc78-9f956e2257e0"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("5d628531-df45-4283-a040-ee01b2017e35"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("c334bc9f-35ac-495a-a0a2-9f9b4abeb399"), false });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Handled" },
                values: new object[] { new Guid("fb1edb04-f2b8-4a9d-b4eb-9c6ab4e5ead9"), false });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2e27e5ad-8903-4eb4-86e9-b65d4265b645", "1860b6f7-cc0f-4d4b-af5e-a64b973351c4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a6c6f735-ac78-4c7a-9397-4048eef76f9f", "370c7cda-2387-4309-a96b-c3b169118ad9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a6c6f735-ac78-4c7a-9397-4048eef76f9f", "416b6e21-0bfb-494f-8db9-f7afe6f4437b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9ade780e-7d19-446f-a73c-ba0e823c2408", "a7594e4e-e53f-4af6-89b3-d430fcdad819" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2e27e5ad-8903-4eb4-86e9-b65d4265b645", "af3e2f2f-fd13-4f74-8821-246bb1003ec0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9ade780e-7d19-446f-a73c-ba0e823c2408", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2e27e5ad-8903-4eb4-86e9-b65d4265b645", "dc0cd687-6a58-43e3-95ae-af894531cef6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OldEnough", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0371109d-6705-4bea-baf4-b5b0f0076845", 0, new Guid("1557c261-7861-4bbc-8195-66dc66ed2208"), "6581c428-be95-45c4-8147-b077d175b0ad", "ClientApplicationUser", "clienttwo@okokapp.nl", true, "Client", "Two", null, false, null, "CLIENTTWO@OKOKAPP.NL", "CLIENTTWO@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAEMq9G03ocpgGyuX4HSwqGmMH1t0Q38hRoJKud36veasfSvUQmO71LPdkKOE+7tTBYA==", "1234567890", true, "4f384ccb-07b5-4274-aab5-bf2f94da4ac7", false, "clienttwo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OldEnough", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", 0, new Guid("d1a0bcee-d9e8-44fd-9e59-4f98f4df9394"), "f83497d4-cb4e-4aa3-967d-435d4963fc4d", "ClientApplicationUser", "clientone@okokapp.nl", true, "Client", "One", null, false, null, "CLIENTONE@OKOKAPP.NL", "CLIENTONE@OKOKAPP.NL", false, "AQAAAAEAACcQAAAAEAIl6KLuK5xMw/8CPGVghiO9+G4Z6oIixSAeJikVnDoST9f7clY2Jri4Zn44obZsrA==", "1234567890", true, "8b0a7ecf-2dc0-4436-84cf-e47ab66223d7", false, "clientone@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cdfee3a0-db09-481f-a9eb-7c0248030830", "0371109d-6705-4bea-baf4-b5b0f0076845" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cdfee3a0-db09-481f-a9eb-7c0248030830", "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1" });

            migrationBuilder.InsertData(
                table: "GuardianChild",
                columns: new[] { "ChildId", "GuardianId" },
                values: new object[] { "0371109d-6705-4bea-baf4-b5b0f0076845", "370c7cda-2387-4309-a96b-c3b169118ad9" });

            migrationBuilder.InsertData(
                table: "GuardianChild",
                columns: new[] { "ChildId", "GuardianId" },
                values: new object[] { "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", "416b6e21-0bfb-494f-8db9-f7afe6f4437b" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("1e5d15e0-482c-4a2c-8a44-a4ed40ed49d1"), "Dit is een geseede message [3]", new DateTime(2022, 1, 24, 12, 43, 39, 856, DateTimeKind.Local).AddTicks(7022), null, "0371109d-6705-4bea-baf4-b5b0f0076845" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("4ac60d49-4b77-4b73-8f4b-444161ab8b3f"), "Dit is een geseede message [4]", new DateTime(2022, 1, 24, 12, 43, 39, 856, DateTimeKind.Local).AddTicks(7046), null, "0371109d-6705-4bea-baf4-b5b0f0076845" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("bfe24eea-759c-48a5-a670-0b3b21794bdb"), "Dit is een geseede message [2]", new DateTime(2022, 1, 24, 12, 43, 39, 856, DateTimeKind.Local).AddTicks(7009), null, "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "DateTime", "GroupId", "SenderId" },
                values: new object[] { new Guid("ece4974f-9d61-4cb3-b8d9-e4d3703aa4ef"), "Dit is een geseede message [1]", new DateTime(2022, 1, 24, 12, 43, 39, 856, DateTimeKind.Local).AddTicks(6961), null, "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1" });

            migrationBuilder.InsertData(
                table: "SignUpRequests",
                columns: new[] { "Id", "ClientId", "DoctorId", "Handled" },
                values: new object[] { new Guid("44c32b07-1e18-446e-acd8-aac2f0568455"), "0371109d-6705-4bea-baf4-b5b0f0076845", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7", false });

            migrationBuilder.InsertData(
                table: "SignUpRequests",
                columns: new[] { "Id", "ClientId", "DoctorId", "Handled" },
                values: new object[] { new Guid("933648f4-4611-4f82-9628-f915942e322c"), "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7", false });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("0cf76564-8e83-4fd4-8f13-cd8673e2a576"), "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", new DateTime(2022, 1, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("138dabe9-584c-4438-a89d-1c4659203a93"), "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("2113760f-05d5-46db-9b8c-cc92bec31093"), "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("3c4522b9-4d37-4223-a306-aedc0e592995"), "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", new DateTime(2022, 1, 24, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("58e6939d-ad46-4e97-8a17-2994a9ad80f1"), "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("7d1ce123-c4be-48bc-a530-6e7f10d29883"), "0371109d-6705-4bea-baf4-b5b0f0076845", new DateTime(2022, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "a7594e4e-e53f-4af6-89b3-d430fcdad819" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("8cddc0e0-6cab-4cb5-be47-559ba8024576"), "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", new DateTime(2022, 1, 24, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("b551d0e5-ae0b-446e-9e6a-4e730939e84e"), "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("b88ab050-dadb-4419-b530-4bda05486d07"), "0371109d-6705-4bea-baf4-b5b0f0076845", new DateTime(2022, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a7594e4e-e53f-4af6-89b3-d430fcdad819" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("b8fb4a9c-243a-4f28-82bb-17328b8bf769"), "0371109d-6705-4bea-baf4-b5b0f0076845", new DateTime(2022, 1, 24, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "a7594e4e-e53f-4af6-89b3-d430fcdad819" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("c6c97f19-7ac3-4fc4-a95d-7c2f3b55800b"), "0371109d-6705-4bea-baf4-b5b0f0076845", new DateTime(2022, 2, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), "Intake", "a7594e4e-e53f-4af6-89b3-d430fcdad819" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("c9e693f6-3601-47cf-a749-a81008fe8750"), "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("e21be5f9-bcbc-44ed-bea8-fd16ba95119b"), "0371109d-6705-4bea-baf4-b5b0f0076845", new DateTime(2022, 2, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a7594e4e-e53f-4af6-89b3-d430fcdad819" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("e28df4fb-4d89-4975-ba9b-15a27d07f6ba"), "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("e36a6e2f-49d9-48d5-b090-7f180fdfae6e"), "0371109d-6705-4bea-baf4-b5b0f0076845", new DateTime(2022, 1, 24, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a7594e4e-e53f-4af6-89b3-d430fcdad819" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("e76b9823-9412-4375-8f58-5cf3171aeff4"), "0371109d-6705-4bea-baf4-b5b0f0076845", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a7594e4e-e53f-4af6-89b3-d430fcdad819" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("ee17f75e-eb3f-47df-b0b2-d86956b6430c"), "0371109d-6705-4bea-baf4-b5b0f0076845", new DateTime(2022, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a7594e4e-e53f-4af6-89b3-d430fcdad819" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "ClientId", "DateTime", "Description", "DoctorId" },
                values: new object[] { new Guid("f59774a6-50e2-4a58-bf5e-93a79fa9055a"), "0371109d-6705-4bea-baf4-b5b0f0076845", new DateTime(2022, 1, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "Behandeling", "a7594e4e-e53f-4af6-89b3-d430fcdad819" });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("1e5d15e0-482c-4a2c-8a44-a4ed40ed49d1"), new Guid("5d628531-df45-4283-a040-ee01b2017e35") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("ece4974f-9d61-4cb3-b8d9-e4d3703aa4ef"), new Guid("52283e15-72ea-47ea-bc78-9f956e2257e0") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("ece4974f-9d61-4cb3-b8d9-e4d3703aa4ef"), new Guid("c334bc9f-35ac-495a-a0a2-9f9b4abeb399") });

            migrationBuilder.InsertData(
                table: "MessageReports",
                columns: new[] { "MessageId", "ReportId" },
                values: new object[] { new Guid("ece4974f-9d61-4cb3-b8d9-e4d3703aa4ef"), new Guid("fb1edb04-f2b8-4a9d-b4eb-9c6ab4e5ead9") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdfee3a0-db09-481f-a9eb-7c0248030830", "0371109d-6705-4bea-baf4-b5b0f0076845" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdfee3a0-db09-481f-a9eb-7c0248030830", "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e27e5ad-8903-4eb4-86e9-b65d4265b645", "1860b6f7-cc0f-4d4b-af5e-a64b973351c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6c6f735-ac78-4c7a-9397-4048eef76f9f", "370c7cda-2387-4309-a96b-c3b169118ad9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6c6f735-ac78-4c7a-9397-4048eef76f9f", "416b6e21-0bfb-494f-8db9-f7afe6f4437b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ade780e-7d19-446f-a73c-ba0e823c2408", "a7594e4e-e53f-4af6-89b3-d430fcdad819" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e27e5ad-8903-4eb4-86e9-b65d4265b645", "af3e2f2f-fd13-4f74-8821-246bb1003ec0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ade780e-7d19-446f-a73c-ba0e823c2408", "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e27e5ad-8903-4eb4-86e9-b65d4265b645", "dc0cd687-6a58-43e3-95ae-af894531cef6" });

            migrationBuilder.DeleteData(
                table: "GuardianChild",
                keyColumns: new[] { "ChildId", "GuardianId" },
                keyValues: new object[] { "0371109d-6705-4bea-baf4-b5b0f0076845", "370c7cda-2387-4309-a96b-c3b169118ad9" });

            migrationBuilder.DeleteData(
                table: "GuardianChild",
                keyColumns: new[] { "ChildId", "GuardianId" },
                keyValues: new object[] { "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1", "416b6e21-0bfb-494f-8db9-f7afe6f4437b" });

            migrationBuilder.DeleteData(
                table: "MessageReports",
                keyColumns: new[] { "MessageId", "ReportId" },
                keyValues: new object[] { new Guid("1e5d15e0-482c-4a2c-8a44-a4ed40ed49d1"), new Guid("5d628531-df45-4283-a040-ee01b2017e35") });

            migrationBuilder.DeleteData(
                table: "MessageReports",
                keyColumns: new[] { "MessageId", "ReportId" },
                keyValues: new object[] { new Guid("ece4974f-9d61-4cb3-b8d9-e4d3703aa4ef"), new Guid("52283e15-72ea-47ea-bc78-9f956e2257e0") });

            migrationBuilder.DeleteData(
                table: "MessageReports",
                keyColumns: new[] { "MessageId", "ReportId" },
                keyValues: new object[] { new Guid("ece4974f-9d61-4cb3-b8d9-e4d3703aa4ef"), new Guid("c334bc9f-35ac-495a-a0a2-9f9b4abeb399") });

            migrationBuilder.DeleteData(
                table: "MessageReports",
                keyColumns: new[] { "MessageId", "ReportId" },
                keyValues: new object[] { new Guid("ece4974f-9d61-4cb3-b8d9-e4d3703aa4ef"), new Guid("fb1edb04-f2b8-4a9d-b4eb-9c6ab4e5ead9") });

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4ac60d49-4b77-4b73-8f4b-444161ab8b3f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bfe24eea-759c-48a5-a670-0b3b21794bdb"));

            migrationBuilder.DeleteData(
                table: "SignUpRequests",
                keyColumn: "Id",
                keyValue: new Guid("44c32b07-1e18-446e-acd8-aac2f0568455"));

            migrationBuilder.DeleteData(
                table: "SignUpRequests",
                keyColumn: "Id",
                keyValue: new Guid("933648f4-4611-4f82-9628-f915942e322c"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("0cf76564-8e83-4fd4-8f13-cd8673e2a576"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("138dabe9-584c-4438-a89d-1c4659203a93"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("2113760f-05d5-46db-9b8c-cc92bec31093"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("3c4522b9-4d37-4223-a306-aedc0e592995"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("58e6939d-ad46-4e97-8a17-2994a9ad80f1"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("7d1ce123-c4be-48bc-a530-6e7f10d29883"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("8cddc0e0-6cab-4cb5-be47-559ba8024576"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("b551d0e5-ae0b-446e-9e6a-4e730939e84e"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("b88ab050-dadb-4419-b530-4bda05486d07"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("b8fb4a9c-243a-4f28-82bb-17328b8bf769"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("c6c97f19-7ac3-4fc4-a95d-7c2f3b55800b"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("c9e693f6-3601-47cf-a749-a81008fe8750"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("e21be5f9-bcbc-44ed-bea8-fd16ba95119b"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("e28df4fb-4d89-4975-ba9b-15a27d07f6ba"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("e36a6e2f-49d9-48d5-b090-7f180fdfae6e"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("e76b9823-9412-4375-8f58-5cf3171aeff4"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("ee17f75e-eb3f-47df-b0b2-d86956b6430c"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("f59774a6-50e2-4a58-bf5e-93a79fa9055a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e27e5ad-8903-4eb4-86e9-b65d4265b645");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ade780e-7d19-446f-a73c-ba0e823c2408");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6c6f735-ac78-4c7a-9397-4048eef76f9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdfee3a0-db09-481f-a9eb-7c0248030830");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1860b6f7-cc0f-4d4b-af5e-a64b973351c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af3e2f2f-fd13-4f74-8821-246bb1003ec0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc0cd687-6a58-43e3-95ae-af894531cef6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7594e4e-e53f-4af6-89b3-d430fcdad819");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0c6c4ee-6a82-4a54-a74b-713d8ae5abb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "370c7cda-2387-4309-a96b-c3b169118ad9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "416b6e21-0bfb-494f-8db9-f7afe6f4437b");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1e5d15e0-482c-4a2c-8a44-a4ed40ed49d1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ece4974f-9d61-4cb3-b8d9-e4d3703aa4ef"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("52283e15-72ea-47ea-bc78-9f956e2257e0"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("5d628531-df45-4283-a040-ee01b2017e35"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("c334bc9f-35ac-495a-a0a2-9f9b4abeb399"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("fb1edb04-f2b8-4a9d-b4eb-9c6ab4e5ead9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0371109d-6705-4bea-baf4-b5b0f0076845");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1316fdf4-ab3a-49a0-b6be-3edc9b7361e1");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1557c261-7861-4bbc-8195-66dc66ed2208"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d1a0bcee-d9e8-44fd-9e59-4f98f4df9394"));

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
        }
    }
}
