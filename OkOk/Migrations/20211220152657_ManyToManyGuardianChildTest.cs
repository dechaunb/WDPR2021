using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkOk.Migrations
{
    public partial class ManyToManyGuardianChildTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cad77631-5455-42c6-a719-db8819cbbf52", "324e3ee1-2017-4129-894a-2ee065bdc4f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cad77631-5455-42c6-a719-db8819cbbf52", "3df1d204-75ba-4fd9-80a4-d669d4a3d265" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cad77631-5455-42c6-a719-db8819cbbf52", "b3c8ddd4-dd7c-4e92-9de4-e60fb026b223" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cad77631-5455-42c6-a719-db8819cbbf52", "fb0b9695-e9ba-4106-81bf-35cf235f4bbb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cad77631-5455-42c6-a719-db8819cbbf52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "324e3ee1-2017-4129-894a-2ee065bdc4f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3df1d204-75ba-4fd9-80a4-d669d4a3d265");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3c8ddd4-dd7c-4e92-9de4-e60fb026b223");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb0b9695-e9ba-4106-81bf-35cf235f4bbb");

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OldEnough",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
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
                    table.PrimaryKey("PK_Address", x => x.Id);
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
                        name: "FK_GuardianChild_Children_ChildId",
                        column: x => x.ChildId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuardianChild_Guardians_GuardianId",
                        column: x => x.GuardianId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Treatment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ClientApplicationUserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatment_AspNetUsers_ClientApplicationUserId",
                        column: x => x.ClientApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "24ead0cf-877e-4ec2-b325-ce67c4236b7f", 0, "a0b96649-ff70-4ee2-b5fe-9efe4da86fad", "IdentityUser", "timothy@okokapp.nl", true, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEBMcmlHrTP9DxVhSnlXgJ+WScZ7GYn0WrTl4whc04NBhOIkuUYAz0GlOOl5UXMhCnw==", "1234567890", true, "716abd7a-3372-47a5-9e3d-59a743c38417", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "610b0cc0-6f19-46e2-b033-e290ddd6c0b1", 0, "88a2b8c2-0a30-4209-a7b2-4b9565c3be75", "IdentityUser", "angelo@okokapp.nl", true, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEDrdhXIQ9lvtVrVmyvGkuE4JXxZpgo5LCVIo33kPZ1V3+H3hfKCJPFjI8I0BX1CbTw==", "1234567890", true, "c66f49f3-d35d-46db-abd7-721c9bebffe8", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b824801-f924-462d-aae0-49d1656c6a9f", 0, "d13b34b1-7a1e-44cd-acfc-0ee01ffbe2c3", "IdentityUser", "yash@okokapp.nl", true, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAEO7GrH0oL9JuPOJgiuPvBTULHM5DdvM2TU/oj9ZFqAzSH2TlajyapKRKORkkTae4CA==", "1234567890", true, "4ada1396-b106-4aa4-8ede-96d9832f8820", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c266a7fe-6e83-4275-a09e-d48956cb9a2d", 0, "fa74d86f-2a64-4120-a192-2a7f5a8b08f4", "IdentityUser", "dechaun@okokapp.nl", true, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAELOLhERSwZ2Ym9HEYE8mwKmX+ge7IYzK1Fpz8C/K3AQf8XaBEkF/AUaadhAM/q5RuA==", "1234567890", true, "524907d0-88d6-4ab1-9697-a4fdab0522f3", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "24ead0cf-877e-4ec2-b325-ce67c4236b7f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "610b0cc0-6f19-46e2-b033-e290ddd6c0b1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "7b824801-f924-462d-aae0-49d1656c6a9f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "c266a7fe-6e83-4275-a09e-d48956cb9a2d" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_GuardianChild_GuardianId",
                table: "GuardianChild",
                column: "GuardianId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_ClientApplicationUserId",
                table: "Treatment",
                column: "ClientApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "GuardianChild");

            migrationBuilder.DropTable(
                name: "Treatment");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "24ead0cf-877e-4ec2-b325-ce67c4236b7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "610b0cc0-6f19-46e2-b033-e290ddd6c0b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "7b824801-f924-462d-aae0-49d1656c6a9f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "056937bb-1d6c-488a-a629-0212959e8834", "c266a7fe-6e83-4275-a09e-d48956cb9a2d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "056937bb-1d6c-488a-a629-0212959e8834");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24ead0cf-877e-4ec2-b325-ce67c4236b7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "610b0cc0-6f19-46e2-b033-e290ddd6c0b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b824801-f924-462d-aae0-49d1656c6a9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c266a7fe-6e83-4275-a09e-d48956cb9a2d");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OldEnough",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cad77631-5455-42c6-a719-db8819cbbf52", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "324e3ee1-2017-4129-894a-2ee065bdc4f9", 0, "b47e6b93-0770-4119-a3ff-a942c0dc4381", "IdentityUser", "timothy@okokapp.nl", true, false, null, "TIMOTHY@OKOKAPP.NL", "TIMOTHY@OKOKAPP.NL", "AQAAAAEAACcQAAAAEL8XG+61E+qXuUWgO9MHfFT+cEv+DUemDDbT80sOkiZI5WqD/okY89Pg4322afWHmA==", "1234567890", true, "a2cf9f37-bb8c-4974-afbc-840b0bbe319b", false, "timothy@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3df1d204-75ba-4fd9-80a4-d669d4a3d265", 0, "b1d58039-5b24-4fb0-afa2-da80825e28dc", "IdentityUser", "yash@okokapp.nl", true, false, null, "YASH@OKOKAPP.NL", "YASH@OKOKAPP.NL", "AQAAAAEAACcQAAAAENIcK7L+qNs9To4kOAmE9/ixTgPplPytDzBegOSpS9oer97zXscfvZRYJbkV7ihnPw==", "1234567890", true, "0753a53d-6812-4ad9-90ca-94a5c699371a", false, "yash@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b3c8ddd4-dd7c-4e92-9de4-e60fb026b223", 0, "d1151621-a3dc-42f4-98f2-c22ba1e66d6d", "IdentityUser", "dechaun@okokapp.nl", true, false, null, "DECHAUN@OKOKAPP.NL", "DECHAUN@OKOKAPP.NL", "AQAAAAEAACcQAAAAENV5yezlrXqvYFzF3YVxCd3c5r+APfMHIJcGQ0FyGHYglH1K8Usp4BLft736OfgyIw==", "1234567890", true, "f64a928b-2573-441a-878e-ba18b06de0a9", false, "dechaun@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fb0b9695-e9ba-4106-81bf-35cf235f4bbb", 0, "201ff110-2187-4cae-94ab-7add45748b48", "IdentityUser", "angelo@okokapp.nl", true, false, null, "ANGELO@OKOKAPP.NL", "ANGELO@OKOKAPP.NL", "AQAAAAEAACcQAAAAEHEdEzxvTKwh036rmojsRzaDiAZBcxmX+PzEVf6uOgZhJF2Se5IG/MH/uZOqES9eaA==", "1234567890", true, "15574bb8-6e3e-469b-ba06-83fa3bfd90b5", false, "angelo@okokapp.nl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cad77631-5455-42c6-a719-db8819cbbf52", "324e3ee1-2017-4129-894a-2ee065bdc4f9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cad77631-5455-42c6-a719-db8819cbbf52", "3df1d204-75ba-4fd9-80a4-d669d4a3d265" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cad77631-5455-42c6-a719-db8819cbbf52", "b3c8ddd4-dd7c-4e92-9de4-e60fb026b223" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cad77631-5455-42c6-a719-db8819cbbf52", "fb0b9695-e9ba-4106-81bf-35cf235f4bbb" });
        }
    }
}
