using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class ConnectAzureDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "594ccb28-5385-417f-9a4b-33ec45bd4bc5", "2faa4962-1c19-45ab-a790-b62962796d15" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "594ccb28-5385-417f-9a4b-33ec45bd4bc5", "51f9781c-d8b8-49de-9275-b4c82801fbdb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "594ccb28-5385-417f-9a4b-33ec45bd4bc5", "e2844bdc-5b14-4a37-9fbf-de2a7ae25130" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "594ccb28-5385-417f-9a4b-33ec45bd4bc5", "eccab88c-1f37-4bff-b2eb-f118bc7f11e0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "594ccb28-5385-417f-9a4b-33ec45bd4bc5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2faa4962-1c19-45ab-a790-b62962796d15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51f9781c-d8b8-49de-9275-b4c82801fbdb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2844bdc-5b14-4a37-9fbf-de2a7ae25130");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eccab88c-1f37-4bff-b2eb-f118bc7f11e0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18446784-a4d1-4b37-81c4-53c2dead7c12", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1b54be5e-2e4e-44e8-acc1-0a4f673295cb", 0, "81106312-2e9f-44a6-91c2-5d635e5e7ede", "IdentityUser", "dechaun@okokapp.nl", true, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEJpID6erI97mUY0JPu36EtX26Ht4rXJ0uRIJ7JM7Po0rjBmL5QAoHBpbOT0oGLSiEw==", "1234567890", true, "a1090704-adeb-4a21-9780-dd5a0ca7ae59", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "361ec33b-8687-428a-97f3-9783f4ab4fa7", 0, "86a0892a-ca78-46db-8d87-1ef7547b0684", "IdentityUser", "angelo@okokapp.nl", true, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAECvUAkOY02MXmTz+OwD6LhrvEvuYknYwEmmV4Na3CqgfdK8Ktr2nRuZ7XF4wMgW0pg==", "1234567890", true, "8f4a34d0-467f-48f3-9e88-67fb3afe5bef", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a5696501-64b6-4a25-94cf-e037654da923", 0, "ae6f2112-cedc-42e0-933a-7e0e82a15a10", "IdentityUser", "yash@okokapp.nl", true, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEKbKFhS2tuo9+7rj2n7b3O6kCXjx+cqLY2DVfcyTOocpwQ7YEFc075B/YNb/0eLn2g==", "1234567890", true, "2c4feef2-2013-466e-b2a7-ecdad9968ae1", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d0b86383-0252-4b1a-8c99-4abbcccf2144", 0, "ffefa94a-01ce-4713-a1bb-06a93b160141", "IdentityUser", "timothy@okokapp.nl", true, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEK09ItiXO3H+Kv4Z/ijX/hRs8VBytrJve/OVzpy6Vsg1dmWI34fhp/OwZo65gl/+OQ==", "1234567890", true, "451815ab-ba83-4f7e-80ad-98dae3271e3e", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "18446784-a4d1-4b37-81c4-53c2dead7c12", "1b54be5e-2e4e-44e8-acc1-0a4f673295cb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "18446784-a4d1-4b37-81c4-53c2dead7c12", "361ec33b-8687-428a-97f3-9783f4ab4fa7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "18446784-a4d1-4b37-81c4-53c2dead7c12", "a5696501-64b6-4a25-94cf-e037654da923" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "18446784-a4d1-4b37-81c4-53c2dead7c12", "d0b86383-0252-4b1a-8c99-4abbcccf2144" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "18446784-a4d1-4b37-81c4-53c2dead7c12", "1b54be5e-2e4e-44e8-acc1-0a4f673295cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "18446784-a4d1-4b37-81c4-53c2dead7c12", "361ec33b-8687-428a-97f3-9783f4ab4fa7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "18446784-a4d1-4b37-81c4-53c2dead7c12", "a5696501-64b6-4a25-94cf-e037654da923" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "18446784-a4d1-4b37-81c4-53c2dead7c12", "d0b86383-0252-4b1a-8c99-4abbcccf2144" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18446784-a4d1-4b37-81c4-53c2dead7c12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b54be5e-2e4e-44e8-acc1-0a4f673295cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "361ec33b-8687-428a-97f3-9783f4ab4fa7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5696501-64b6-4a25-94cf-e037654da923");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0b86383-0252-4b1a-8c99-4abbcccf2144");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "594ccb28-5385-417f-9a4b-33ec45bd4bc5", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2faa4962-1c19-45ab-a790-b62962796d15", 0, "16063d07-9806-43fa-8bef-adb99b881157", "IdentityUser", "dechaun@okokapp.nl", true, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEPc1FC4bVT7zSV5ODY9EpkypgjKe1AtAP+BQOFO00I/6s5d4z167RRKyyVuGs7mJzQ==", "1234567890", true, "f2e45111-c063-41f4-9121-e3dd18c1b545", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "51f9781c-d8b8-49de-9275-b4c82801fbdb", 0, "237894f4-7f6f-4bf8-8817-46a9f5ffb4c7", "IdentityUser", "timothy@okokapp.nl", true, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAECDuimj8P+vXcVnQh57b9CZAlDpwyLe57UBCjw0TVMzj3DwwwFJ6vVwhLIuXhRlt4Q==", "1234567890", true, "f0bfb281-493f-40c6-9e7d-9e6355959135", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e2844bdc-5b14-4a37-9fbf-de2a7ae25130", 0, "ce359b2c-ef9a-4623-b36f-1d73640f49fe", "IdentityUser", "yash@okokapp.nl", true, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEKWDIooMq3/cdSJTu1QsiVugs+qDdpBLQEU4HkTZwkGHtz1AQ/6aFeRT4t5W6aRApQ==", "1234567890", true, "2f707f3e-8891-434f-aa05-5cbc6e2966a8", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eccab88c-1f37-4bff-b2eb-f118bc7f11e0", 0, "c5b69cbc-ca15-4cd4-a800-73c6ebae3089", "IdentityUser", "angelo@okokapp.nl", true, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEFFhJbMBM5f6K1yHuTKtagNjwYEGN82e1KN/m3l0KmlPDq0PEQtFHCynyq8VuWrgEg==", "1234567890", true, "123ce60f-b19c-4b1b-b6da-f3b681a46e35", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "594ccb28-5385-417f-9a4b-33ec45bd4bc5", "2faa4962-1c19-45ab-a790-b62962796d15" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "594ccb28-5385-417f-9a4b-33ec45bd4bc5", "51f9781c-d8b8-49de-9275-b4c82801fbdb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "594ccb28-5385-417f-9a4b-33ec45bd4bc5", "e2844bdc-5b14-4a37-9fbf-de2a7ae25130" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "594ccb28-5385-417f-9a4b-33ec45bd4bc5", "eccab88c-1f37-4bff-b2eb-f118bc7f11e0" });
        }
    }
}
