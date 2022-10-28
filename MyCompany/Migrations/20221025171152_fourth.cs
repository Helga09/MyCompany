using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ff10569-b018-4fe7-a380-7d6a14c70b74", "3a62472e-4f66-49fa-a20f-e7685b9565d8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ff10569-b018-4fe7-a380-7d6a14c70b74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a62472e-4f66-49fa-a20f-e7685b9565d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "226ea9de-61ed-40d4-8712-d8c5313fec6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c94874a-c303-4a4b-8cea-34923270c52d", "AQAAAAEAACcQAAAAEGRYV5yOGr/PNKIBdD9y5f6FbU4VngkClbao4d28L30SNe9DWnb/SQBGMcC1IfxIdQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("48a76a45-c59d-4095-84a1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 17, 11, 52, 431, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 17, 11, 52, 431, DateTimeKind.Utc).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5ba76a45-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 17, 11, 52, 431, DateTimeKind.Utc).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 17, 11, 52, 431, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 17, 11, 52, 431, DateTimeKind.Utc).AddTicks(5218));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "d507bee2-d8d3-46f2-85ef-489370316437");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ff10569-b018-4fe7-a380-7d6a14c70b74", "9bb8dc6f-ed22-4fea-b650-131fe94ed769", "user", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af499ac6-4c42-40f3-b8e1-30ba284dd9f3", "AQAAAAEAACcQAAAAEM61SjOEz/LO/vsbmslA1m7qbYLL/Cbd1nh0uJoLLqao6abuGaRI6YeJ9lyRPAwuOQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3a62472e-4f66-49fa-a20f-e7685b9565d8", 0, "b9e8c649-4def-4ffd-bd80-06c5b0ddf021", "my1@email.com", true, false, null, "MY1@EMAIL.COM", "HELGA", "AQAAAAEAACcQAAAAEML4JQJYRi28+wMDANoEJ7NmbZPCDsrc/eagpqJ4n6qDDDtnd5SeCjHjxNmyzLBQMg==", null, false, "", false, "Helga" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("48a76a45-c59d-4095-84a1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 16, 57, 10, 178, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 16, 57, 10, 178, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5ba76a45-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 16, 57, 10, 178, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 16, 57, 10, 178, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 16, 57, 10, 178, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8ff10569-b018-4fe7-a380-7d6a14c70b74", "3a62472e-4f66-49fa-a20f-e7685b9565d8" });
        }
    }
}
