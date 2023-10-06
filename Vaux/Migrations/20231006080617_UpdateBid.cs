using Microsoft.EntityFrameworkCore.Migrations;
using Vaux.Models;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Bids_HighestBidId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_HighestBidId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "HighestBidId",
                table: "Items");

            migrationBuilder.Sql(Bid.PreventLowerBidsTriggerSql());
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HighestBidId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_HighestBidId",
                table: "Items",
                column: "HighestBidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Bids_HighestBidId",
                table: "Items",
                column: "HighestBidId",
                principalTable: "Bids",
                principalColumn: "Id");

            migrationBuilder.Sql("DROP TRIGGER [dbo].[BIDS_PREVENT_LOWER]");
        }
    }
}
