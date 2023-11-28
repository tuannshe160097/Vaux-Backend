using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class HighestBid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Bids_WonBidId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "WonBidId",
                table: "Items",
                newName: "HighestBidId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_WonBidId",
                table: "Items",
                newName: "IX_Items_HighestBidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Bids_HighestBidId",
                table: "Items",
                column: "HighestBidId",
                principalTable: "Bids",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Bids_HighestBidId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "HighestBidId",
                table: "Items",
                newName: "WonBidId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_HighestBidId",
                table: "Items",
                newName: "IX_Items_WonBidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Bids_WonBidId",
                table: "Items",
                column: "WonBidId",
                principalTable: "Bids",
                principalColumn: "Id");
        }
    }
}
