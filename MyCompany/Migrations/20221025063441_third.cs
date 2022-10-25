using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "d16bba23-bf5f-4f43-870d-4b939d6384ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63158fc6-394d-48f7-817c-1d23efd1bc82", "AQAAAAEAACcQAAAAEE5EUVXNXffeEDh7VKLL1VJkyDArdrKtOfD/A5gXPRv4/kalFX6MAaoJfPHBxlhK7g==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("48a76a45-c59d-4095-84a1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 6, 34, 41, 59, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 6, 34, 41, 59, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5ba76a45-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 6, 34, 41, 59, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 6, 34, 41, 59, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 6, 34, 41, 59, DateTimeKind.Utc).AddTicks(2245));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "8f380802-2ec4-47b3-970e-d1e72be18769");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac1685f5-f2aa-4258-bd9a-9e4f383ed503", "AQAAAAEAACcQAAAAENMXeU3oOYsS2sg+rxqmpxCTie1yhJImOMnbmkLSudGGh8K9C4CuI1dCmOYh5YPEZw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("48a76a45-c59d-4095-84a1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 6, 24, 52, 924, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 6, 24, 52, 924, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5ba76a45-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 6, 24, 52, 924, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 6, 24, 52, 924, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 6, 24, 52, 924, DateTimeKind.Utc).AddTicks(5280));
        }
    }
}
