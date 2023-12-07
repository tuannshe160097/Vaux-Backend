using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class ItemPaymentSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ItemPayments",
                columns: new[] { "Id", "Deleted", "ExpertPaymentApprovedById", "ExpertPayout", "ItemId", "Revenue", "SellerPaymentApprovedById", "SellerPayout" },
                values: new object[,]
                {
                    { 1, null, null, 2436296L, 238, 8195411L, null, 42043566L },
                    { 2, null, null, 2479403L, 239, 8341975L, null, 42793627L },
                    { 3, null, null, 2482859L, 224, 8353722L, null, 42853751L },
                    { 4, null, null, 2485915L, 240, 8364114L, null, 42906934L },
                    { 5, null, null, 2444143L, 242, 8222087L, null, 42180090L },
                    { 6, null, null, 2443110L, 201, 8218575L, null, 42162116L },
                    { 7, null, null, 2510804L, 217, 8448735L, null, 43339994L },
                    { 8, null, null, 2495364L, 246, 8396241L, null, 43071344L },
                    { 9, null, null, 2378650L, 225, 7999412L, null, 41040516L },
                    { 10, null, null, 2445353L, 243, 8226201L, null, 42201143L },
                    { 11, null, null, 2473107L, 232, 8320567L, null, 42684073L },
                    { 12, null, null, 2515247L, 205, 8463841L, null, 43417303L },
                    { 13, null, null, 2507489L, 250, 8437464L, null, 43282314L },
                    { 14, null, null, 2487693L, 212, 8370159L, null, 42937870L },
                    { 15, null, null, 2310350L, 244, 7767193L, null, 39852102L },
                    { 16, null, null, 2395042L, 210, 8055143L, null, 41325734L },
                    { 17, null, null, 2500837L, 227, 8414847L, null, 43166568L },
                    { 18, null, null, 2503728L, 213, 8424676L, null, 43216870L },
                    { 19, null, null, 2501887L, 245, 8418418L, null, 43184841L },
                    { 20, null, null, 2511869L, 208, 8452357L, null, 43358529L },
                    { 21, null, null, 2513746L, 221, 8458740L, null, 43391192L },
                    { 22, null, null, 2487204L, 202, 8368494L, null, 42929352L },
                    { 23, null, null, 2504284L, 226, 8426566L, null, 43226545L },
                    { 24, null, null, 2463058L, 235, 8286399L, null, 42509215L },
                    { 25, null, null, 2512638L, 234, 8454970L, null, 43371904L },
                    { 26, null, null, 2490014L, 219, 8378050L, null, 42978254L },
                    { 27, null, null, 2506000L, 237, 8432402L, null, 43256408L },
                    { 28, null, null, 2437168L, 230, 8198373L, null, 42058730L },
                    { 29, null, null, 2485956L, 222, 8364253L, null, 42907645L },
                    { 30, null, null, 2488862L, 247, 8374131L, null, 42958199L },
                    { 31, null, null, 2416789L, 249, 8129083L, null, 41704128L },
                    { 32, null, null, 2499585L, 206, 8410591L, null, 43144785L },
                    { 33, null, null, 2466763L, 214, 8298996L, null, 42573684L },
                    { 34, null, null, 2457725L, 223, 8268266L, null, 42416419L },
                    { 35, null, null, 2519640L, 207, 8478777L, null, 43493741L },
                    { 36, null, null, 2486990L, 241, 8367770L, null, 42925641L },
                    { 37, null, null, 2487850L, 215, 8370693L, null, 42940603L },
                    { 38, null, null, 2419807L, 220, 8139344L, null, 41756641L },
                    { 39, null, null, 2383108L, 228, 8014568L, null, 41118083L },
                    { 40, null, null, 2453808L, 216, 8254950L, null, 42348267L },
                    { 41, null, null, 2441865L, 218, 8214341L, null, 42140451L },
                    { 42, null, null, 2510583L, 248, 8447986L, null, 43336158L },
                    { 43, null, null, 2512784L, 209, 8455466L, null, 43374442L },
                    { 44, null, null, 2463458L, 231, 8287758L, null, 42516170L },
                    { 45, null, null, 2501520L, 204, 8417169L, null, 43178451L },
                    { 46, null, null, 2377797L, 229, 7996512L, null, 41025676L },
                    { 47, null, null, 2445805L, 236, 8227738L, null, 42209012L },
                    { 48, null, null, 2484824L, 211, 8360402L, null, 42887939L },
                    { 49, null, null, 2416366L, 203, 8127647L, null, 41696778L },
                    { 50, null, null, 2496632L, 233, 8400553L, null, 43093411L }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "TotalCost",
                value: 52715273L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "TotalCost",
                value: 53655005L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "TotalCost",
                value: 53730332L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "TotalCost",
                value: 53796963L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "TotalCost",
                value: 52886320L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "TotalCost",
                value: 52863801L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "TotalCost",
                value: 54339533L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "TotalCost",
                value: 54002949L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "TotalCost",
                value: 104371275L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "TotalCost",
                value: 53517747L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                column: "TotalCost",
                value: 54436391L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "TotalCost",
                value: 54267267L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                column: "TotalCost",
                value: 53835722L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                column: "TotalCost",
                value: 49969645L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                column: "TotalCost",
                value: 51815919L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                column: "TotalCost",
                value: 54122252L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                column: "TotalCost",
                value: 54185274L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                column: "TotalCost",
                value: 54145146L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                column: "TotalCost",
                value: 54362755L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                column: "TotalCost",
                value: 54403678L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                column: "TotalCost",
                value: 53825050L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                column: "TotalCost",
                value: 107496067L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                column: "TotalCost",
                value: 54379512L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                column: "TotalCost",
                value: 53886318L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                column: "TotalCost",
                value: 54234810L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                column: "TotalCost",
                value: 52734271L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                column: "TotalCost",
                value: 53797854L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                column: "TotalCost",
                value: 53861192L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                column: "TotalCost",
                value: 52290000L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                column: "TotalCost",
                value: 54094961L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                column: "TotalCost",
                value: 53379443L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                column: "TotalCost",
                value: 53182410L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                column: "TotalCost",
                value: 54532158L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                column: "TotalCost",
                value: 53820401L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                column: "TotalCost",
                value: 53839146L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                column: "TotalCost",
                value: 103911551L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                column: "TotalCost",
                value: 53097025L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                column: "TotalCost",
                value: 52836657L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                column: "TotalCost",
                value: 54334727L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                column: "TotalCost",
                value: 107690078L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                column: "TotalCost",
                value: 105577125L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                column: "TotalCost",
                value: 52922555L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                column: "TotalCost",
                value: 53773165L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                column: "TotalCost",
                value: 106311387L);

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoB",
                value: new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoB",
                value: new DateTime(1986, 3, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoB",
                value: new DateTime(1984, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoB",
                value: new DateTime(1988, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoB",
                value: new DateTime(1999, 4, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DoB",
                value: new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DoB",
                value: new DateTime(1975, 6, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DoB",
                value: new DateTime(1981, 6, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DoB",
                value: new DateTime(1998, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DoB",
                value: new DateTime(1990, 7, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 11,
                column: "DoB",
                value: new DateTime(1998, 9, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 12,
                column: "DoB",
                value: new DateTime(1977, 8, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 13,
                column: "DoB",
                value: new DateTime(2000, 10, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 14,
                column: "DoB",
                value: new DateTime(1986, 7, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 15,
                column: "DoB",
                value: new DateTime(1985, 11, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 16,
                column: "DoB",
                value: new DateTime(1992, 6, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 17,
                column: "DoB",
                value: new DateTime(1991, 8, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 18,
                column: "DoB",
                value: new DateTime(1980, 5, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 19,
                column: "DoB",
                value: new DateTime(1979, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 20,
                column: "DoB",
                value: new DateTime(1987, 2, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 21,
                column: "DoB",
                value: new DateTime(2001, 7, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 22,
                column: "DoB",
                value: new DateTime(1974, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 23,
                column: "DoB",
                value: new DateTime(1984, 12, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 24,
                column: "DoB",
                value: new DateTime(1986, 11, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 25,
                column: "DoB",
                value: new DateTime(1982, 4, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 26,
                column: "DoB",
                value: new DateTime(1985, 4, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 27,
                column: "DoB",
                value: new DateTime(1985, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 28,
                column: "DoB",
                value: new DateTime(1988, 5, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 29,
                column: "DoB",
                value: new DateTime(1992, 3, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 30,
                column: "DoB",
                value: new DateTime(1984, 7, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 31,
                column: "DoB",
                value: new DateTime(2000, 6, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 32,
                column: "DoB",
                value: new DateTime(1978, 4, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 33,
                column: "DoB",
                value: new DateTime(1993, 5, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 34,
                column: "DoB",
                value: new DateTime(1998, 4, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 35,
                column: "DoB",
                value: new DateTime(2000, 4, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 36,
                column: "DoB",
                value: new DateTime(1975, 4, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 37,
                column: "DoB",
                value: new DateTime(1977, 3, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 38,
                column: "DoB",
                value: new DateTime(1993, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 39,
                column: "DoB",
                value: new DateTime(1994, 2, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 40,
                column: "DoB",
                value: new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 41,
                column: "DoB",
                value: new DateTime(1980, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 42,
                column: "DoB",
                value: new DateTime(1993, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 43,
                column: "DoB",
                value: new DateTime(1994, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 44,
                column: "DoB",
                value: new DateTime(1984, 1, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 45,
                column: "DoB",
                value: new DateTime(1975, 12, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 46,
                column: "DoB",
                value: new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 47,
                column: "DoB",
                value: new DateTime(1999, 4, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 48,
                column: "DoB",
                value: new DateTime(1977, 2, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 49,
                column: "DoB",
                value: new DateTime(2004, 3, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 50,
                column: "DoB",
                value: new DateTime(1981, 11, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 52675273L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53615005L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53690332L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53756963L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 52846320L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 52823801L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54299533L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53962949L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 51418578L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 52872697L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53477747L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54396391L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54227267L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53795722L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49929645L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 51775919L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54082252L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54145274L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54105146L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54322755L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54363678L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53785050L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54157395L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53258672L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54339512L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53846318L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54194810L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 52694271L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53757854L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53821192L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 52250000L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54054961L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53339443L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53142410L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54492158L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53780401L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53799146L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 52315792L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 51515759L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53057025L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 52796657L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54294727L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54342692L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53267386L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 54097140L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 51399985L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 52882555L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53733165L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 52240791L, 40000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 53990596L, 40000L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 110,
                column: "DoB",
                value: new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 111,
                column: "DoB",
                value: new DateTime(1986, 3, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 112,
                column: "DoB",
                value: new DateTime(1984, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 113,
                column: "DoB",
                value: new DateTime(1988, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 114,
                column: "DoB",
                value: new DateTime(1999, 4, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 115,
                column: "DoB",
                value: new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 116,
                column: "DoB",
                value: new DateTime(1975, 6, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 117,
                column: "DoB",
                value: new DateTime(1981, 6, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 118,
                column: "DoB",
                value: new DateTime(1998, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 119,
                column: "DoB",
                value: new DateTime(1990, 7, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 120,
                column: "DoB",
                value: new DateTime(1998, 9, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 121,
                column: "DoB",
                value: new DateTime(1977, 8, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 122,
                column: "DoB",
                value: new DateTime(2000, 10, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 123,
                column: "DoB",
                value: new DateTime(1986, 7, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 124,
                column: "DoB",
                value: new DateTime(1985, 11, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 125,
                column: "DoB",
                value: new DateTime(1992, 6, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 126,
                column: "DoB",
                value: new DateTime(1991, 8, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 127,
                column: "DoB",
                value: new DateTime(1980, 5, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 128,
                column: "DoB",
                value: new DateTime(1979, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 129,
                column: "DoB",
                value: new DateTime(1987, 2, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 130,
                column: "DoB",
                value: new DateTime(2001, 7, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 131,
                column: "DoB",
                value: new DateTime(1974, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 132,
                column: "DoB",
                value: new DateTime(1984, 12, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 133,
                column: "DoB",
                value: new DateTime(1986, 11, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 134,
                column: "DoB",
                value: new DateTime(1982, 4, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 135,
                column: "DoB",
                value: new DateTime(1985, 4, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 136,
                column: "DoB",
                value: new DateTime(1985, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 137,
                column: "DoB",
                value: new DateTime(1988, 5, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 138,
                column: "DoB",
                value: new DateTime(1992, 3, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 139,
                column: "DoB",
                value: new DateTime(1984, 7, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 140,
                column: "DoB",
                value: new DateTime(2000, 6, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 141,
                column: "DoB",
                value: new DateTime(1978, 4, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 142,
                column: "DoB",
                value: new DateTime(1993, 5, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 143,
                column: "DoB",
                value: new DateTime(1998, 4, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 144,
                column: "DoB",
                value: new DateTime(2000, 4, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 145,
                column: "DoB",
                value: new DateTime(1975, 4, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 146,
                column: "DoB",
                value: new DateTime(1977, 3, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 147,
                column: "DoB",
                value: new DateTime(1993, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 148,
                column: "DoB",
                value: new DateTime(1994, 2, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 149,
                column: "DoB",
                value: new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 150,
                column: "DoB",
                value: new DateTime(1980, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 151,
                column: "DoB",
                value: new DateTime(1993, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 152,
                column: "DoB",
                value: new DateTime(1994, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 153,
                column: "DoB",
                value: new DateTime(1984, 1, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 154,
                column: "DoB",
                value: new DateTime(1975, 12, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 155,
                column: "DoB",
                value: new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 156,
                column: "DoB",
                value: new DateTime(1999, 4, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 157,
                column: "DoB",
                value: new DateTime(1977, 2, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 158,
                column: "DoB",
                value: new DateTime(2004, 3, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 159,
                column: "DoB",
                value: new DateTime(1981, 11, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 160,
                column: "DoB",
                value: new DateTime(1981, 7, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 161,
                column: "DoB",
                value: new DateTime(1977, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 162,
                column: "DoB",
                value: new DateTime(1992, 3, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 163,
                column: "DoB",
                value: new DateTime(1984, 10, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 164,
                column: "DoB",
                value: new DateTime(2002, 2, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 165,
                column: "DoB",
                value: new DateTime(1996, 8, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 166,
                column: "DoB",
                value: new DateTime(1989, 3, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 167,
                column: "DoB",
                value: new DateTime(2005, 3, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 168,
                column: "DoB",
                value: new DateTime(1983, 4, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 169,
                column: "DoB",
                value: new DateTime(1985, 11, 12, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "TotalCost",
                value: 48335939L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "TotalCost",
                value: 49198078L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "TotalCost",
                value: 49267186L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "TotalCost",
                value: 49328315L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "TotalCost",
                value: 48492863L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "TotalCost",
                value: 48472203L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "TotalCost",
                value: 49826086L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "TotalCost",
                value: 49517293L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "TotalCost",
                value: 95700070L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "TotalCost",
                value: 49072154L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                column: "TotalCost",
                value: 49914946L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "TotalCost",
                value: 49759787L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                column: "TotalCost",
                value: 49363874L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                column: "TotalCost",
                value: 45817014L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                column: "TotalCost",
                value: 47510844L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                column: "TotalCost",
                value: 49626745L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                column: "TotalCost",
                value: 49684564L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                column: "TotalCost",
                value: 49647749L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                column: "TotalCost",
                value: 49847390L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                column: "TotalCost",
                value: 49884934L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                column: "TotalCost",
                value: 49354083L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                column: "TotalCost",
                value: 98566851L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                column: "TotalCost",
                value: 49862764L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                column: "TotalCost",
                value: 49410292L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                column: "TotalCost",
                value: 49730010L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                column: "TotalCost",
                value: 48353368L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                column: "TotalCost",
                value: 49329133L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                column: "TotalCost",
                value: 49387241L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                column: "TotalCost",
                value: 47945780L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                column: "TotalCost",
                value: 49601708L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                column: "TotalCost",
                value: 48945269L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                column: "TotalCost",
                value: 48764505L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                column: "TotalCost",
                value: 50002806L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                column: "TotalCost",
                value: 49349818L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                column: "TotalCost",
                value: 49367015L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                column: "TotalCost",
                value: 95278305L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                column: "TotalCost",
                value: 48686170L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                column: "TotalCost",
                value: 48447300L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                column: "TotalCost",
                value: 49821677L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                column: "TotalCost",
                value: 98744843L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                column: "TotalCost",
                value: 96806354L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                column: "TotalCost",
                value: 48526106L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                column: "TotalCost",
                value: 49306482L);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                column: "TotalCost",
                value: 97479989L);

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoB",
                value: new DateTime(1993, 4, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoB",
                value: new DateTime(1986, 3, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoB",
                value: new DateTime(1984, 8, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoB",
                value: new DateTime(1988, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoB",
                value: new DateTime(1999, 4, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DoB",
                value: new DateTime(1985, 11, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DoB",
                value: new DateTime(1975, 6, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DoB",
                value: new DateTime(1981, 6, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DoB",
                value: new DateTime(1998, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DoB",
                value: new DateTime(1990, 7, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 11,
                column: "DoB",
                value: new DateTime(1998, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 12,
                column: "DoB",
                value: new DateTime(1977, 8, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 13,
                column: "DoB",
                value: new DateTime(2000, 10, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 14,
                column: "DoB",
                value: new DateTime(1986, 7, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 15,
                column: "DoB",
                value: new DateTime(1985, 11, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 16,
                column: "DoB",
                value: new DateTime(1992, 6, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 17,
                column: "DoB",
                value: new DateTime(1991, 8, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 18,
                column: "DoB",
                value: new DateTime(1980, 4, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 19,
                column: "DoB",
                value: new DateTime(1979, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 20,
                column: "DoB",
                value: new DateTime(1987, 2, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 21,
                column: "DoB",
                value: new DateTime(2001, 7, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 22,
                column: "DoB",
                value: new DateTime(1974, 7, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 23,
                column: "DoB",
                value: new DateTime(1984, 12, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 24,
                column: "DoB",
                value: new DateTime(1986, 11, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 25,
                column: "DoB",
                value: new DateTime(1982, 4, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 26,
                column: "DoB",
                value: new DateTime(1985, 4, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 27,
                column: "DoB",
                value: new DateTime(1985, 9, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 28,
                column: "DoB",
                value: new DateTime(1988, 5, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 29,
                column: "DoB",
                value: new DateTime(1992, 3, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 30,
                column: "DoB",
                value: new DateTime(1984, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 31,
                column: "DoB",
                value: new DateTime(2000, 6, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 32,
                column: "DoB",
                value: new DateTime(1978, 4, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 33,
                column: "DoB",
                value: new DateTime(1993, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 34,
                column: "DoB",
                value: new DateTime(1998, 4, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 35,
                column: "DoB",
                value: new DateTime(2000, 4, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 36,
                column: "DoB",
                value: new DateTime(1975, 4, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 37,
                column: "DoB",
                value: new DateTime(1977, 3, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 38,
                column: "DoB",
                value: new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 39,
                column: "DoB",
                value: new DateTime(1994, 2, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 40,
                column: "DoB",
                value: new DateTime(2000, 5, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 41,
                column: "DoB",
                value: new DateTime(1980, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 42,
                column: "DoB",
                value: new DateTime(1993, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 43,
                column: "DoB",
                value: new DateTime(1994, 4, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 44,
                column: "DoB",
                value: new DateTime(1984, 1, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 45,
                column: "DoB",
                value: new DateTime(1975, 12, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 46,
                column: "DoB",
                value: new DateTime(1992, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 47,
                column: "DoB",
                value: new DateTime(1999, 4, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 48,
                column: "DoB",
                value: new DateTime(1977, 2, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 49,
                column: "DoB",
                value: new DateTime(2004, 3, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 50,
                column: "DoB",
                value: new DateTime(1981, 11, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48325939L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49188078L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49257186L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49318315L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48482863L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48462203L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49816086L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49507293L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 47173008L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48507062L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49062154L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49904946L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49749787L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49353874L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 45807014L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 47500844L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49616745L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49674564L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49637749L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49837390L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49874934L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49344083L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49685684L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48861167L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49852764L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49400292L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49720010L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48343368L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49319133L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49377241L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 47935780L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49591708L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48935269L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48754505L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49992806L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49339818L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49357015L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 47996140L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 47262165L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48676170L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48437300L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49811677L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49855681L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48869162L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49630404L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 47155950L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 48516106L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49296482L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 47927332L, 10000L });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ItemCost", "ShippingCost" },
                values: new object[] { 49532657L, 10000L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 110,
                column: "DoB",
                value: new DateTime(1993, 4, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 111,
                column: "DoB",
                value: new DateTime(1986, 3, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 112,
                column: "DoB",
                value: new DateTime(1984, 8, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 113,
                column: "DoB",
                value: new DateTime(1988, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 114,
                column: "DoB",
                value: new DateTime(1999, 4, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 115,
                column: "DoB",
                value: new DateTime(1985, 11, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 116,
                column: "DoB",
                value: new DateTime(1975, 6, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 117,
                column: "DoB",
                value: new DateTime(1981, 6, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 118,
                column: "DoB",
                value: new DateTime(1998, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 119,
                column: "DoB",
                value: new DateTime(1990, 7, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 120,
                column: "DoB",
                value: new DateTime(1998, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 121,
                column: "DoB",
                value: new DateTime(1977, 8, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 122,
                column: "DoB",
                value: new DateTime(2000, 10, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 123,
                column: "DoB",
                value: new DateTime(1986, 7, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 124,
                column: "DoB",
                value: new DateTime(1985, 11, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 125,
                column: "DoB",
                value: new DateTime(1992, 6, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 126,
                column: "DoB",
                value: new DateTime(1991, 8, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 127,
                column: "DoB",
                value: new DateTime(1980, 4, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 128,
                column: "DoB",
                value: new DateTime(1979, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 129,
                column: "DoB",
                value: new DateTime(1987, 2, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 130,
                column: "DoB",
                value: new DateTime(2001, 7, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 131,
                column: "DoB",
                value: new DateTime(1974, 7, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 132,
                column: "DoB",
                value: new DateTime(1984, 12, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 133,
                column: "DoB",
                value: new DateTime(1986, 11, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 134,
                column: "DoB",
                value: new DateTime(1982, 4, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 135,
                column: "DoB",
                value: new DateTime(1985, 4, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 136,
                column: "DoB",
                value: new DateTime(1985, 9, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 137,
                column: "DoB",
                value: new DateTime(1988, 5, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 138,
                column: "DoB",
                value: new DateTime(1992, 3, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 139,
                column: "DoB",
                value: new DateTime(1984, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 140,
                column: "DoB",
                value: new DateTime(2000, 6, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 141,
                column: "DoB",
                value: new DateTime(1978, 4, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 142,
                column: "DoB",
                value: new DateTime(1993, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 143,
                column: "DoB",
                value: new DateTime(1998, 4, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 144,
                column: "DoB",
                value: new DateTime(2000, 4, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 145,
                column: "DoB",
                value: new DateTime(1975, 4, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 146,
                column: "DoB",
                value: new DateTime(1977, 3, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 147,
                column: "DoB",
                value: new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 148,
                column: "DoB",
                value: new DateTime(1994, 2, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 149,
                column: "DoB",
                value: new DateTime(2000, 5, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 150,
                column: "DoB",
                value: new DateTime(1980, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 151,
                column: "DoB",
                value: new DateTime(1993, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 152,
                column: "DoB",
                value: new DateTime(1994, 4, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 153,
                column: "DoB",
                value: new DateTime(1984, 1, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 154,
                column: "DoB",
                value: new DateTime(1975, 12, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 155,
                column: "DoB",
                value: new DateTime(1992, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 156,
                column: "DoB",
                value: new DateTime(1999, 4, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 157,
                column: "DoB",
                value: new DateTime(1977, 2, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 158,
                column: "DoB",
                value: new DateTime(2004, 3, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 159,
                column: "DoB",
                value: new DateTime(1981, 11, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 160,
                column: "DoB",
                value: new DateTime(1981, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 161,
                column: "DoB",
                value: new DateTime(1977, 5, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 162,
                column: "DoB",
                value: new DateTime(1992, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 163,
                column: "DoB",
                value: new DateTime(1984, 10, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 164,
                column: "DoB",
                value: new DateTime(2002, 2, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 165,
                column: "DoB",
                value: new DateTime(1996, 8, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 166,
                column: "DoB",
                value: new DateTime(1989, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 167,
                column: "DoB",
                value: new DateTime(2005, 3, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 168,
                column: "DoB",
                value: new DateTime(1983, 4, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 169,
                column: "DoB",
                value: new DateTime(1985, 11, 11, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
