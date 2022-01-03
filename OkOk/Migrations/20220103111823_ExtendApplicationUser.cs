using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class ExtendApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "04cfe54b-a771-4750-aee7-b8267266eae1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "338f651f-74c3-40b7-a340-1b017f9cb881" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "6f82dbf9-4a9f-4089-aad1-a527410342c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "f6005de8-915d-4288-b6d7-c04765685084" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04cfe54b-a771-4750-aee7-b8267266eae1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "338f651f-74c3-40b7-a340-1b017f9cb881");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f82dbf9-4a9f-4089-aad1-a527410342c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6005de8-915d-4288-b6d7-c04765685084");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20817567-9593-45be-a63e-c41aac402464", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "03e2fcfa-869f-4c80-b59e-8f996ad3283b", 0, "ce2285fd-33fc-41f3-a38f-ee36f4f881e2", "ApplicationUser", "dechaun@okokapp.nl", true, "Dechaun", "OkOk", false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEHKu0Y+Y2Vyju5rSzhUcO7MRQGznYLmDeNE8p8mBt8y2Bpzo8O63ubiPSwP9T6mAqw==", "1234567890", true, "462f00b1-7ce6-4114-bf91-fc0806e872bc", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1072f42f-320c-4878-97d5-ab7b4334e083", 0, "aeb8e4d6-eb32-47b5-beb5-885ef3bce1c5", "ApplicationUser", "timothy@okokapp.nl", true, "Timothy", "OkOk", false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEFq8w//J58SE+j3N2TOouean3B8Je7b5t9+KCMXt3OJOjbi0HkdFv/7OJAaFvdrVsQ==", "1234567890", true, "eebfa0b4-f723-4d06-bbb2-29c2e8e0080f", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cbb04c70-d0f8-4488-8de7-e249d7cfd574", 0, "3cbe0ee6-7554-407f-9387-d5b4b5511507", "ApplicationUser", "angelo@okokapp.nl", true, "Angelo", "OkOk", false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEHFsI+wBHKSsBu2hKpkhi06wnLSV8lHAbfxiTjyG6ZdgLvBiVJnuZ/EqrJC0Rt4RZw==", "1234567890", true, "a94f67e5-f50f-4f9a-a2ae-c9a794d98b3e", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d39826b0-083f-4b44-8b18-e40e2b1f71ec", 0, "106bda8d-1f90-4fac-8f55-674ead6ad7c7", "ApplicationUser", "yash@okokapp.nl", true, "Yash", "OkOk", false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEEJ0bHKqqr6nqWSqGYegT7YRWmwTHK37XYsfzPpM9QZVCDiV96HjDMk4B2LX63w83Q==", "1234567890", true, "d0038783-8279-4068-9d84-7c2fa90904a8", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "20817567-9593-45be-a63e-c41aac402464", "03e2fcfa-869f-4c80-b59e-8f996ad3283b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "20817567-9593-45be-a63e-c41aac402464", "1072f42f-320c-4878-97d5-ab7b4334e083" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "20817567-9593-45be-a63e-c41aac402464", "cbb04c70-d0f8-4488-8de7-e249d7cfd574" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "20817567-9593-45be-a63e-c41aac402464", "d39826b0-083f-4b44-8b18-e40e2b1f71ec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20817567-9593-45be-a63e-c41aac402464", "03e2fcfa-869f-4c80-b59e-8f996ad3283b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20817567-9593-45be-a63e-c41aac402464", "1072f42f-320c-4878-97d5-ab7b4334e083" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20817567-9593-45be-a63e-c41aac402464", "cbb04c70-d0f8-4488-8de7-e249d7cfd574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20817567-9593-45be-a63e-c41aac402464", "d39826b0-083f-4b44-8b18-e40e2b1f71ec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20817567-9593-45be-a63e-c41aac402464");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03e2fcfa-869f-4c80-b59e-8f996ad3283b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1072f42f-320c-4878-97d5-ab7b4334e083");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbb04c70-d0f8-4488-8de7-e249d7cfd574");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d39826b0-083f-4b44-8b18-e40e2b1f71ec");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "04cfe54b-a771-4750-aee7-b8267266eae1", 0, "e704f15c-b187-4569-b047-62138a1a59ec", "ApplicationUser", "yash@okokapp.nl", true, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEFgW5DemWdkYB70LvBRUN/uUItuJRQmvBv1dFfsNTRmd23Xbiwid5TKhfgL5X5SJ3A==", "1234567890", true, "1ed6c6dd-19df-4a5d-8234-54a95bddec71", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "338f651f-74c3-40b7-a340-1b017f9cb881", 0, "900b8567-5ac3-437c-91af-23c488feaf9c", "ApplicationUser", "timothy@okokapp.nl", true, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEP5oqbtSwr50BBVIM+dG1mE6kNyixeaQcB72niNkbN051HZDUKoyxutuYn79HqBdug==", "1234567890", true, "500088d1-d20f-40f1-b383-24a4c0a30377", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6f82dbf9-4a9f-4089-aad1-a527410342c2", 0, "8d519f79-3a30-43da-bb1e-ecb1b03ac2f3", "ApplicationUser", "angelo@okokapp.nl", true, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEGFXLCOor4qogTv8+1aI8Y1c085r932/h+nFa9s5TlsTsdJocuy9kEBZQE/qWlSjgg==", "1234567890", true, "e992e446-622d-48f6-8a2e-1f8b9bd5a7dc", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f6005de8-915d-4288-b6d7-c04765685084", 0, "c6a2ccb6-0c29-4eed-9ad5-d44b2ac1402b", "ApplicationUser", "dechaun@okokapp.nl", true, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAEAiZQF9+irLtQoPq4/hiPHurRUbEyde8CJ9wHVysBmDG1hHtfcDdHuqyPVTWVigCOw==", "1234567890", true, "4af86b04-3f67-4702-9b87-546d1a288a05", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "04cfe54b-a771-4750-aee7-b8267266eae1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "338f651f-74c3-40b7-a340-1b017f9cb881" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "6f82dbf9-4a9f-4089-aad1-a527410342c2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09971dd1-6b45-48fa-b1b2-d3099bbc3ecc", "f6005de8-915d-4288-b6d7-c04765685084" });
        }
    }
}
