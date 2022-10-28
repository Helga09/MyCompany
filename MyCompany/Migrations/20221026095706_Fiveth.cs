using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class Fiveth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Publish",
                table: "News",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "5c4d6b5c-cd0e-4da9-8e57-9085aa2d57c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "254145bc-b60d-4058-8dd3-a50c25849684", "AQAAAAEAACcQAAAAELIiquaVbVmuzLbtktlEJoXOLX50PFJB/f/cVjfMiXFWFZ4hHABqLy1eELK/nPNfSQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("48a76a45-c59d-4095-84a1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 26, 9, 57, 6, 415, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 26, 9, 57, 6, 415, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5ba76a45-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 26, 9, 57, 6, 415, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 26, 9, 57, 6, 415, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 26, 9, 57, 6, 415, DateTimeKind.Utc).AddTicks(7156));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Publish",
                table: "News");

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
    }
}
