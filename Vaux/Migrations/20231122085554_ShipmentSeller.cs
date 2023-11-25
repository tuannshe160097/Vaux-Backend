using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class ShipmentSeller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Shipments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_SellerId",
                table: "Shipments",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Users_SellerId",
                table: "Shipments",
                column: "SellerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Users_SellerId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_SellerId",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Shipments");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);
        }
    }
}
