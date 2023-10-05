using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatusChanges_SuperUsers_StatusChangedByRefId",
                table: "StatusChanges");

            migrationBuilder.DropColumn(
                name: "StatusChangedBy",
                table: "StatusChanges");

            migrationBuilder.RenameColumn(
                name: "StatusChangedByRefId",
                table: "StatusChanges",
                newName: "StatusChangedById");

            migrationBuilder.RenameIndex(
                name: "IX_StatusChanges_StatusChangedByRefId",
                table: "StatusChanges",
                newName: "IX_StatusChanges_StatusChangedById");

            migrationBuilder.AlterColumn<long>(
                name: "TotalCost",
                table: "Orders",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "ReservePrice",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_StatusChanges_SuperUsers_StatusChangedById",
                table: "StatusChanges",
                column: "StatusChangedById",
                principalTable: "SuperUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatusChanges_SuperUsers_StatusChangedById",
                table: "StatusChanges");

            migrationBuilder.RenameColumn(
                name: "StatusChangedById",
                table: "StatusChanges",
                newName: "StatusChangedByRefId");

            migrationBuilder.RenameIndex(
                name: "IX_StatusChanges_StatusChangedById",
                table: "StatusChanges",
                newName: "IX_StatusChanges_StatusChangedByRefId");

            migrationBuilder.AddColumn<int>(
                name: "StatusChangedBy",
                table: "StatusChanges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "TotalCost",
                table: "Orders",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValue: 0L);

            migrationBuilder.AlterColumn<int>(
                name: "ReservePrice",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusChanges_SuperUsers_StatusChangedByRefId",
                table: "StatusChanges",
                column: "StatusChangedByRefId",
                principalTable: "SuperUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
