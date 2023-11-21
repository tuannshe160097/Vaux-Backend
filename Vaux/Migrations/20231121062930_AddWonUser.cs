using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class AddWonUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WonUserId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_WonUserId",
                table: "Items",
                column: "WonUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_WonUserId",
                table: "Items",
                column: "WonUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_WonUserId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_WonUserId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "WonUserId",
                table: "Items");
        }
    }
}
