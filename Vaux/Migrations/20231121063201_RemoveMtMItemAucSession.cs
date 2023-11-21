using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMtMItemAucSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionSessionItem_AuctionSessions_AuctionSessionId",
                table: "AuctionSessionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_AuctionSessionItem_Items_ItemId",
                table: "AuctionSessionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuctionSessionItem",
                table: "AuctionSessionItem");

            migrationBuilder.DropIndex(
                name: "IX_AuctionSessionItem_AuctionSessionId",
                table: "AuctionSessionItem");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AuctionSessionItem");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "AuctionSessionItem",
                newName: "ItemsId");

            migrationBuilder.RenameColumn(
                name: "AuctionSessionId",
                table: "AuctionSessionItem",
                newName: "AuctionSessionsId");

            migrationBuilder.RenameIndex(
                name: "IX_AuctionSessionItem_ItemId",
                table: "AuctionSessionItem",
                newName: "IX_AuctionSessionItem_ItemsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuctionSessionItem",
                table: "AuctionSessionItem",
                columns: new[] { "AuctionSessionsId", "ItemsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionSessionItem_AuctionSessions_AuctionSessionsId",
                table: "AuctionSessionItem",
                column: "AuctionSessionsId",
                principalTable: "AuctionSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionSessionItem_Items_ItemsId",
                table: "AuctionSessionItem",
                column: "ItemsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionSessionItem_AuctionSessions_AuctionSessionsId",
                table: "AuctionSessionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_AuctionSessionItem_Items_ItemsId",
                table: "AuctionSessionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuctionSessionItem",
                table: "AuctionSessionItem");

            migrationBuilder.RenameColumn(
                name: "ItemsId",
                table: "AuctionSessionItem",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "AuctionSessionsId",
                table: "AuctionSessionItem",
                newName: "AuctionSessionId");

            migrationBuilder.RenameIndex(
                name: "IX_AuctionSessionItem_ItemsId",
                table: "AuctionSessionItem",
                newName: "IX_AuctionSessionItem_ItemId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AuctionSessionItem",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuctionSessionItem",
                table: "AuctionSessionItem",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionSessionItem_AuctionSessionId",
                table: "AuctionSessionItem",
                column: "AuctionSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionSessionItem_AuctionSessions_AuctionSessionId",
                table: "AuctionSessionItem",
                column: "AuctionSessionId",
                principalTable: "AuctionSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionSessionItem_Items_ItemId",
                table: "AuctionSessionItem",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
