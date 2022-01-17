using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class LockedOutReason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d455e97-1fb7-4832-9760-0ed6d40ea03a", "4774e026-5b9b-4695-9a63-27d552ae23b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d455e97-1fb7-4832-9760-0ed6d40ea03a", "707dc052-b166-4977-8704-a4ac414a37bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d455e97-1fb7-4832-9760-0ed6d40ea03a", "aadde2d9-2108-4e8a-8723-e10ed23bf10b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d455e97-1fb7-4832-9760-0ed6d40ea03a", "ce3bd425-b8a5-4254-8e68-0c97997b4da0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d455e97-1fb7-4832-9760-0ed6d40ea03a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4774e026-5b9b-4695-9a63-27d552ae23b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "707dc052-b166-4977-8704-a4ac414a37bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aadde2d9-2108-4e8a-8723-e10ed23bf10b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce3bd425-b8a5-4254-8e68-0c97997b4da0");

            migrationBuilder.AddColumn<string>(
                name: "LockedOutReason",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af19af82-a608-462a-92b5-dae351070f22", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0048e49d-7be3-4642-8058-8e78c2fd406d", 0, "3fd02b1f-8084-4817-b8c7-9ef4cc37948c", "ApplicationUser", "yash@okokapp.nl", true, "Yash", "OkOk", null, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEKNosDRJ3kwSwse0dAAWUiiwEX86vC0u4KiEzIBXRKzz2x1jlInHt7gpx9xzZPSygQ==", "1234567890", true, "13165b1b-b253-4b9a-8804-9ddfc903ad66", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5874f7ed-e3b2-487a-823f-df7fe8d1d81a", 0, "3208d057-a254-4b6b-9911-ea90e03c78bd", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", null, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEIYvhXHNQ68n1ZDZJF5PGgOwtj2bPKuP5Q28rBljyTNjn2AqMy/HgV9vaeqjMLxpXA==", "1234567890", true, "cfe43a04-0917-4aae-9d44-e36d1be468e2", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "63fda3aa-cf2d-4ad6-91cf-8bf1073ade7e", 0, "1af2d5d3-7480-436a-817f-7bfc87a860c6", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", null, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEDiuCKXNRw0k0dGNFNDVA2SOwmt1u8aPghc0y2rhB9Zp0XyDp8d6fNcsrQcfxIqT4w==", "1234567890", true, "4badbb5a-56f6-4767-aa56-5ea3ebcb9ba8", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fd73af46-b9b1-43db-94c8-505b5cc7c31f", 0, "9dee6739-03c5-400b-a42e-5e2ad96e9df1", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", null, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEBqw7zfhdGhqo5S/WW604SDyW1/WOZq/rph83c3Vj3ug5fsD2HKXI7ZZr/GipG6AgA==", "1234567890", true, "14cc3885-85d5-4a6d-ab8c-d716917bacda", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "af19af82-a608-462a-92b5-dae351070f22", "0048e49d-7be3-4642-8058-8e78c2fd406d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "af19af82-a608-462a-92b5-dae351070f22", "5874f7ed-e3b2-487a-823f-df7fe8d1d81a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "af19af82-a608-462a-92b5-dae351070f22", "63fda3aa-cf2d-4ad6-91cf-8bf1073ade7e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "af19af82-a608-462a-92b5-dae351070f22", "fd73af46-b9b1-43db-94c8-505b5cc7c31f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af19af82-a608-462a-92b5-dae351070f22", "0048e49d-7be3-4642-8058-8e78c2fd406d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af19af82-a608-462a-92b5-dae351070f22", "5874f7ed-e3b2-487a-823f-df7fe8d1d81a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af19af82-a608-462a-92b5-dae351070f22", "63fda3aa-cf2d-4ad6-91cf-8bf1073ade7e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af19af82-a608-462a-92b5-dae351070f22", "fd73af46-b9b1-43db-94c8-505b5cc7c31f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af19af82-a608-462a-92b5-dae351070f22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0048e49d-7be3-4642-8058-8e78c2fd406d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5874f7ed-e3b2-487a-823f-df7fe8d1d81a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63fda3aa-cf2d-4ad6-91cf-8bf1073ade7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd73af46-b9b1-43db-94c8-505b5cc7c31f");

            migrationBuilder.DropColumn(
                name: "LockedOutReason",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d455e97-1fb7-4832-9760-0ed6d40ea03a", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4774e026-5b9b-4695-9a63-27d552ae23b9", 0, "d15275f4-f9bb-4423-9c6d-a52136db3cd2", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEEMAskX5MRzRXIWUI0z45Bpcb5RWahc5lizMXs7sne6KoW/QlEP8LLB8s9+EDwjSQg==", "1234567890", true, "083ef4b3-e360-42b4-be26-1b36f11f1886", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "707dc052-b166-4977-8704-a4ac414a37bd", 0, "7ce52876-b228-47c7-8b49-61953ff6e436", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEFG3K0Z/c1yhSX2sdIfgA7MfVnhQ/syVA1h8I+vMi0HUhlzPf5hm3bj61jG7T+oiqA==", "1234567890", true, "8129cd3e-26a6-47d9-991c-a572faa58826", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aadde2d9-2108-4e8a-8723-e10ed23bf10b", 0, "cd275f9a-decd-40d1-83cc-a8a227531a14", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEIS1KXYMy3EcBE7MUNeSY2EwgWoHLHtiOAptFK2UxGPd4GMs9DOWGt6oTCKLvaE7vQ==", "1234567890", true, "5de4c47a-6f0d-4029-b7be-dc7ac019c4f9", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ce3bd425-b8a5-4254-8e68-0c97997b4da0", 0, "c862a346-9881-4dde-8f7d-8bc47779b918", "ApplicationUser", "yash@okokapp.nl", true, "Yash", "OkOk", false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAELajOn6x73e1GwrR6Hm03frLm4s9Rvu5HPIbBXse+GrOnyqflsO6rYbA9KHK/iJBXA==", "1234567890", true, "69132d58-2693-49dd-86bd-a86ffe9637af", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8d455e97-1fb7-4832-9760-0ed6d40ea03a", "4774e026-5b9b-4695-9a63-27d552ae23b9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8d455e97-1fb7-4832-9760-0ed6d40ea03a", "707dc052-b166-4977-8704-a4ac414a37bd" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8d455e97-1fb7-4832-9760-0ed6d40ea03a", "aadde2d9-2108-4e8a-8723-e10ed23bf10b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8d455e97-1fb7-4832-9760-0ed6d40ea03a", "ce3bd425-b8a5-4254-8e68-0c97997b4da0" });
        }
    }
}
