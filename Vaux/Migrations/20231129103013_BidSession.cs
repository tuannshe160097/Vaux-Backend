using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class BidSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OngoingSessionId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuctionSessionId",
                table: "Bids",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_OngoingSessionId",
                table: "Items",
                column: "OngoingSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_AuctionSessionId",
                table: "Bids",
                column: "AuctionSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_AuctionSessions_AuctionSessionId",
                table: "Bids",
                column: "AuctionSessionId",
                principalTable: "AuctionSessions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_AuctionSessions_OngoingSessionId",
                table: "Items",
                column: "OngoingSessionId",
                principalTable: "AuctionSessions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bids_AuctionSessions_AuctionSessionId",
                table: "Bids");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_AuctionSessions_OngoingSessionId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OngoingSessionId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Bids_AuctionSessionId",
                table: "Bids");

            migrationBuilder.DropColumn(
                name: "OngoingSessionId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "AuctionSessionId",
                table: "Bids");
        }
    }
}
