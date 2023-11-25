using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class WonBid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_WonUserId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_SellerPayments_Orders_OrderId",
                table: "SellerPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_SellerPayments_Users_SellerId",
                table: "SellerPayments");

            migrationBuilder.DropIndex(
                name: "IX_SellerPayments_OrderId",
                table: "SellerPayments");

            migrationBuilder.DropIndex(
                name: "IX_SellerPayments_SellerId",
                table: "SellerPayments");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "SellerPayments");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "SellerPayments",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "WonUserId",
                table: "Items",
                newName: "WonBidId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_WonUserId",
                table: "Items",
                newName: "IX_Items_WonBidId");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "SellerPayments",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_SellerPayments_ItemId",
                table: "SellerPayments",
                column: "ItemId",
                unique: true,
                filter: "[ItemId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Bids_WonBidId",
                table: "Items",
                column: "WonBidId",
                principalTable: "Bids",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SellerPayments_Items_ItemId",
                table: "SellerPayments",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Bids_WonBidId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_SellerPayments_Items_ItemId",
                table: "SellerPayments");

            migrationBuilder.DropIndex(
                name: "IX_SellerPayments_ItemId",
                table: "SellerPayments");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "SellerPayments",
                newName: "SellerId");

            migrationBuilder.RenameColumn(
                name: "WonBidId",
                table: "Items",
                newName: "WonUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_WonBidId",
                table: "Items",
                newName: "IX_Items_WonUserId");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "SellerPayments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "SellerPayments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SellerPayments_OrderId",
                table: "SellerPayments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SellerPayments_SellerId",
                table: "SellerPayments",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_WonUserId",
                table: "Items",
                column: "WonUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SellerPayments_Orders_OrderId",
                table: "SellerPayments",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SellerPayments_Users_SellerId",
                table: "SellerPayments",
                column: "SellerId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
