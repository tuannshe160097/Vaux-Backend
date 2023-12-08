using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class AuctionSessionReportSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AuctionSessionReport",
                columns: new[] { "Id", "ActiveBidders", "ActiveBids", "ActiveItems", "ActiveSellers", "AuctionedItems", "Deleted", "SoldItems", "TotalRevenue", "UnauctionedItems", "UnpaidItems" },
                values: new object[,]
                {
                    { 1, 165, 1250, 40, 21, 25, null, 13, 108504385L, 15, 12 },
                    { 2, 165, 2050, 55, 31, 41, null, 19, 158225640L, 14, 22 },
                    { 3, 165, 1700, 55, 23, 34, null, 18, 149594972L, 21, 16 }
                });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReportId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReportId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReportId",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 3);

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
        }
    }
}
