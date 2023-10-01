using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class ItemApplicationCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ItemApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ItemApplications_CategoryId",
                table: "ItemApplications",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemApplications_Categories_CategoryId",
                table: "ItemApplications",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemApplications_Categories_CategoryId",
                table: "ItemApplications");

            migrationBuilder.DropIndex(
                name: "IX_ItemApplications_CategoryId",
                table: "ItemApplications");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ItemApplications");
        }
    }
}
