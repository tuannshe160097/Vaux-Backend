using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class AddExpertAssignment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpertId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ExpertId",
                table: "Items",
                column: "ExpertId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_ExpertId",
                table: "Items",
                column: "ExpertId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_ExpertId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ExpertId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ExpertId",
                table: "Items");
        }
    }
}
