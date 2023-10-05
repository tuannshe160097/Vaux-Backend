using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class ModifyShipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Orders",
                newName: "TotalCost");

            migrationBuilder.AddColumn<long>(
                name: "ItemCost",
                table: "Shipments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ShipmentCost",
                table: "Shipments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "ShipmentId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ShipmentId",
                table: "Items",
                column: "ShipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Shipments_ShipmentId",
                table: "Items",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id");

            migrationBuilder.Sql(
                @"
                    CREATE TRIGGER [dbo].[TOTALCOST_UPDATE] ON [dbo].[Shipments]
                        AFTER INSERT
                    AS
                    BEGIN
                        SET NOCOUNT ON;

                        IF ((SELECT TRIGGER_NESTLEVEL()) > 1) RETURN;

                        DECLARE @OrderId INT
                        DECLARE @ItemCost INT
                        DECLARE @ShipmentCost INT

                        SELECT 
                            @OrderId = INSERTED.OrderId,
                            @ItemCost = INSERTED.ItemCost,
                            @ShipmentCost = INSERTED.ShipmentCost
                        FROM INSERTED

                        UPDATE [dbo].[Orders]
                        SET [TotalCost] = [TotalCost] + @ItemCost + @ShipmentCost
                        WHERE [Id] = @OrderId
                    END
                "
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Shipments_ShipmentId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ShipmentId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemCost",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "ShipmentCost",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "TotalCost",
                table: "Orders",
                newName: "Amount");
        }
    }
}
