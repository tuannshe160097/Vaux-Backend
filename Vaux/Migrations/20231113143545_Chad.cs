using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class Chad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessages_Users_ReceiverId",
                table: "ChatMessages");

            migrationBuilder.DropIndex(
                name: "IX_ChatMessages_ReceiverId",
                table: "ChatMessages");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "ChatMessages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "ChatMessages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_ReceiverId",
                table: "ChatMessages",
                column: "ReceiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessages_Users_ReceiverId",
                table: "ChatMessages",
                column: "ReceiverId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
