using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusSellerPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SellerPayments_SuperUsers_ApprovedById",
                table: "SellerPayments");

            migrationBuilder.AlterColumn<int>(
                name: "ApprovedById",
                table: "SellerPayments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "SellerPayments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_SellerPayments_SuperUsers_ApprovedById",
                table: "SellerPayments",
                column: "ApprovedById",
                principalTable: "SuperUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SellerPayments_SuperUsers_ApprovedById",
                table: "SellerPayments");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "SellerPayments");

            migrationBuilder.AlterColumn<int>(
                name: "ApprovedById",
                table: "SellerPayments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SellerPayments_SuperUsers_ApprovedById",
                table: "SellerPayments",
                column: "ApprovedById",
                principalTable: "SuperUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
