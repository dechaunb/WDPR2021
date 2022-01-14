using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class ReportHandledUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39692590-6c93-49fa-b848-a958cb591395", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "486812c6-b897-4eb6-ae02-b1ec8249cd66", 0, "bf38c213-ce37-4929-9ed8-3288fecda847", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", null, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEI2sg1/fo8KTTrgIRnOOG2bWOBWaBb5UJ6jUlT4RacAMYvusBK0+jhEdDl7qcpWqoA==", "1234567890", true, "bba93319-81f8-469a-84d1-15658bd0305e", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "52e5363f-ff82-4c54-b546-09066746da42", 0, "ee1c614d-9f45-4d33-9d93-53b1d0947a74", "ApplicationUser", "yash@okokapp.nl", true, "Yash", "OkOk", null, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEFdHLBBysWsPVZp+yujG9YZbpwju1Lhcn+HY3Qm17SwiFYXfzlX0PtPqsOnQfT8vBA==", "1234567890", true, "e3cbdc3f-5380-4fce-add0-4b3e39dac24d", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8756ee34-594f-40e6-96ba-04e35060d49a", 0, "bc69d4d3-f7dd-49ad-8627-c5399f1674f5", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", null, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAENR0zubjqgLajw4qyWfNy3jfBuuJq15E3BgnLbNQXDB9ptmX2MID7ULxc6AVHDE+VA==", "1234567890", true, "032202a5-cfa3-4bd9-879b-c2c58bc40a51", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockedOutReason", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dc07dc9a-a30b-459a-b5ae-bd2e7ebdd153", 0, "f09a78d3-b12e-4882-a50f-e65f74b73c18", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", null, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEIZwb16PUPUTkDxtQo3wdU+ZM3s7etXNOLssOqkUUaLiCoTUAO3S7PBlFXBoVsgGEw==", "1234567890", true, "1eaed93d-f9d7-42d3-8e16-11ece2f40946", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "39692590-6c93-49fa-b848-a958cb591395", "486812c6-b897-4eb6-ae02-b1ec8249cd66" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "39692590-6c93-49fa-b848-a958cb591395", "52e5363f-ff82-4c54-b546-09066746da42" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "39692590-6c93-49fa-b848-a958cb591395", "8756ee34-594f-40e6-96ba-04e35060d49a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "39692590-6c93-49fa-b848-a958cb591395", "dc07dc9a-a30b-459a-b5ae-bd2e7ebdd153" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39692590-6c93-49fa-b848-a958cb591395", "486812c6-b897-4eb6-ae02-b1ec8249cd66" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39692590-6c93-49fa-b848-a958cb591395", "52e5363f-ff82-4c54-b546-09066746da42" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39692590-6c93-49fa-b848-a958cb591395", "8756ee34-594f-40e6-96ba-04e35060d49a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39692590-6c93-49fa-b848-a958cb591395", "dc07dc9a-a30b-459a-b5ae-bd2e7ebdd153" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39692590-6c93-49fa-b848-a958cb591395");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "486812c6-b897-4eb6-ae02-b1ec8249cd66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52e5363f-ff82-4c54-b546-09066746da42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8756ee34-594f-40e6-96ba-04e35060d49a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc07dc9a-a30b-459a-b5ae-bd2e7ebdd153");

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
    }
}
