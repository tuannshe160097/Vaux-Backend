using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class fixRoleNameTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "MODERATOR");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "MOODERATOR");
        }
    }
}
