using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderSellerPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "SellerPayments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SellerPayments_OrderId",
                table: "SellerPayments",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SellerPayments_Orders_OrderId",
                table: "SellerPayments",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SellerPayments_Orders_OrderId",
                table: "SellerPayments");

            migrationBuilder.DropIndex(
                name: "IX_SellerPayments_OrderId",
                table: "SellerPayments");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "SellerPayments");
        }
    }
}
