using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class SuperUserOtpExpiry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "OtpExpiry",
                table: "SuperUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SuperUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "OtpExpiry",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OtpExpiry",
                table: "SuperUsers");
        }
    }
}
