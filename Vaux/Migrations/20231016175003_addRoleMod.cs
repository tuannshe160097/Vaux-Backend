using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class addRoleMod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DoB",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DoB",
                table: "SuperUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "SuperUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "MOODERATOR");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Deleted", "Title" },
                values: new object[] { 5, null, "ADMIN" });

            migrationBuilder.UpdateData(
                table: "SuperUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DoB", "Gender", "RoleId" },
                values: new object[] { null, null, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "DoB",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DoB",
                table: "SuperUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "SuperUsers");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "ADMIN");

            migrationBuilder.UpdateData(
                table: "SuperUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleId",
                value: 1);
        }
    }
}
