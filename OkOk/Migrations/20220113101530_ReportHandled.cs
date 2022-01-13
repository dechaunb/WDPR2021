using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class ReportHandled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Handled",
                table: "Reports",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a09fa62e-1022-456e-8a7f-30f18b5ed9e7", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1d99a032-b08b-4fc7-b9f5-d1b41bfe86b2", 0, "12b5f4b6-a445-4e9f-a0ee-162d713bc651", "ApplicationUser", "yash@okokapp.nl", true, "Yash", "OkOk", null, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEL4nwO4jA0yNqmcKkwGaABrOpAw3g319m/kYlKY1mWDFn7VFwSrWP60bFDC2wUWDiA==", "1234567890", true, "12bdc186-7564-4612-bbf7-4b1aab0e306f", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b9b10b4d-4cb9-47aa-b486-681789d59130", 0, "d575e9d1-e374-4f46-8150-4104b5f9e92b", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", null, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAENqPITpWUs2Qw75SpbZwdutaLicUZ4O8YZVKqz+GJeT2PWV2ET80DBe8goujIs5vDQ==", "1234567890", true, "46f712b9-5cc8-49c9-a06e-042e19a749a7", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d544a8e5-2bf6-4a82-b9ac-316d178db3c9", 0, "21ad3ec1-c0ca-415e-9d7d-b35a464b680f", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", null, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEDwTHyrflC+hrxt1dVlDDQFsh7BJb70aWKUuStHD8QMvef0DOpH/Hiy6t90uPjvVlQ==", "1234567890", true, "fa550c41-70dc-47c3-a268-62759eb58103", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f3602c9b-c226-452d-b272-263aa41cd91e", 0, "9bafd373-f333-4546-9946-7ec315ebe895", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", null, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEGCD5f9PbOZImeBnQdAsp4ba8KbJ6Mq2alhQZ3zGR86JuAB5vf32iSsgIMn68U0T5A==", "1234567890", true, "a9c342b2-dce9-4a50-8b50-7c48ff2ea6ba", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a09fa62e-1022-456e-8a7f-30f18b5ed9e7", "1d99a032-b08b-4fc7-b9f5-d1b41bfe86b2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a09fa62e-1022-456e-8a7f-30f18b5ed9e7", "b9b10b4d-4cb9-47aa-b486-681789d59130" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a09fa62e-1022-456e-8a7f-30f18b5ed9e7", "d544a8e5-2bf6-4a82-b9ac-316d178db3c9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a09fa62e-1022-456e-8a7f-30f18b5ed9e7", "f3602c9b-c226-452d-b272-263aa41cd91e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a09fa62e-1022-456e-8a7f-30f18b5ed9e7", "1d99a032-b08b-4fc7-b9f5-d1b41bfe86b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a09fa62e-1022-456e-8a7f-30f18b5ed9e7", "b9b10b4d-4cb9-47aa-b486-681789d59130" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a09fa62e-1022-456e-8a7f-30f18b5ed9e7", "d544a8e5-2bf6-4a82-b9ac-316d178db3c9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a09fa62e-1022-456e-8a7f-30f18b5ed9e7", "f3602c9b-c226-452d-b272-263aa41cd91e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a09fa62e-1022-456e-8a7f-30f18b5ed9e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d99a032-b08b-4fc7-b9f5-d1b41bfe86b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9b10b4d-4cb9-47aa-b486-681789d59130");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d544a8e5-2bf6-4a82-b9ac-316d178db3c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3602c9b-c226-452d-b272-263aa41cd91e");

            migrationBuilder.DropColumn(
                name: "Handled",
                table: "Reports");

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
    }
}
