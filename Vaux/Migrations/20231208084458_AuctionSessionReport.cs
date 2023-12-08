using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class AuctionSessionReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportId",
                table: "AuctionSessions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AuctionSessionReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuctionedItems = table.Column<int>(type: "int", nullable: false),
                    UnauctionedItems = table.Column<int>(type: "int", nullable: false),
                    SoldItems = table.Column<int>(type: "int", nullable: false),
                    UnpaidItems = table.Column<int>(type: "int", nullable: false),
                    TotalRevenue = table.Column<long>(type: "bigint", nullable: false),
                    ActiveBidders = table.Column<int>(type: "int", nullable: false),
                    ActiveSellers = table.Column<int>(type: "int", nullable: false),
                    ActiveItems = table.Column<int>(type: "int", nullable: false),
                    ActiveBids = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionSessionReport", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReportId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReportId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReportId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReportId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReportId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReportId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReportId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReportId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReportId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_AuctionSessions_ReportId",
                table: "AuctionSessions",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionSessions_AuctionSessionReport_ReportId",
                table: "AuctionSessions",
                column: "ReportId",
                principalTable: "AuctionSessionReport",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionSessions_AuctionSessionReport_ReportId",
                table: "AuctionSessions");

            migrationBuilder.DropTable(
                name: "AuctionSessionReport");

            migrationBuilder.DropIndex(
                name: "IX_AuctionSessions_ReportId",
                table: "AuctionSessions");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "AuctionSessions");
        }
    }
}
