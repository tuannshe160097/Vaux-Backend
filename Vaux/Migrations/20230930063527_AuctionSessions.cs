using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Vaux.Models;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class AuctionSessions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuctionSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionSessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuctionSessionItem",
                columns: table => new
                {
                    AuctionSessionsId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionSessionItem", x => new { x.AuctionSessionsId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_AuctionSessionItem_AuctionSessions_AuctionSessionsId",
                        column: x => x.AuctionSessionsId,
                        principalTable: "AuctionSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuctionSessionItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuctionSessionItem_ItemsId",
                table: "AuctionSessionItem",
                column: "ItemsId");

            migrationBuilder.Sql(ModelBase.GenerateUpdateTriggerSql("AuctionSessions"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuctionSessionItem");

            migrationBuilder.DropTable(
                name: "AuctionSessions");
        }
    }
}
