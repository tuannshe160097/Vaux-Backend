using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class buyerProtectionFee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<long>(
                name: "BuyerProtectionFee",
                table: "ItemPayments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 1,
                column: "TotalRevenue",
                value: 23377948L);

            migrationBuilder.UpdateData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 2,
                column: "TotalRevenue",
                value: 43046244L);

            migrationBuilder.UpdateData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 3,
                column: "TotalRevenue",
                value: 35458772L);

            migrationBuilder.UpdateData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 4,
                column: "TotalRevenue",
                value: 50791953L);

            migrationBuilder.UpdateData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 5,
                column: "TotalRevenue",
                value: 42713354L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4376904L, 3870583L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4469608L, 3952986L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4360901L, 3856358L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4435105L, 3922317L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4455130L, 3940117L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4420773L, 3909577L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4472686L, 3955722L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4411250L, 3901113L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4475646L, 3958353L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4469630L, 3953006L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4481729L, 3963760L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4361708L, 3857075L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4496275L, 3976690L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4436185L, 3923276L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4181215L, 3696637L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4480364L, 3962547L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4486988L, 3968434L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4413154L, 3902806L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4466206L, 3949963L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4357649L, 3853468L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4479897L, 3962132L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4433179L, 3920605L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4264916L, 3771038L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4471342L, 3954527L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4444168L, 3930373L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4313502L, 3814225L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4450056L, 3935606L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4424582L, 3912963L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4115480L, 3638206L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4361704L, 3857072L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4465541L, 3949372L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4411581L, 3901407L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4467149L, 3950800L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4312583L, 3813409L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4483928L, 3965715L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4429021L, 3916908L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4486231L, 3967762L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4388898L, 3881244L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4424756L, 3913118L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4392666L, 3884594L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4433455L, 3920850L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4492091L, 3972971L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4479240L, 3961548L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4406012L, 3896457L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4416810L, 3906055L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4406805L, 3897162L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4480756L, 3962896L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4368236L, 3862878L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4438164L, 3925036L });

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BuyerProtectionFee", "Revenue" },
                values: new object[] { 4484871L, 3966554L });

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoB",
                value: new DateTime(1977, 8, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoB",
                value: new DateTime(2000, 12, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoB",
                value: new DateTime(1984, 3, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoB",
                value: new DateTime(1984, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoB",
                value: new DateTime(2002, 11, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DoB",
                value: new DateTime(1995, 2, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DoB",
                value: new DateTime(1996, 8, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DoB",
                value: new DateTime(1983, 7, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DoB",
                value: new DateTime(1974, 6, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DoB",
                value: new DateTime(1989, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 11,
                column: "DoB",
                value: new DateTime(1993, 12, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 12,
                column: "DoB",
                value: new DateTime(1974, 3, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 13,
                column: "DoB",
                value: new DateTime(1976, 3, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 14,
                column: "DoB",
                value: new DateTime(1989, 1, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 15,
                column: "DoB",
                value: new DateTime(1979, 2, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 16,
                column: "DoB",
                value: new DateTime(1989, 12, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 17,
                column: "DoB",
                value: new DateTime(1992, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 18,
                column: "DoB",
                value: new DateTime(1984, 1, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 19,
                column: "DoB",
                value: new DateTime(1985, 4, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 20,
                column: "DoB",
                value: new DateTime(1994, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 21,
                column: "DoB",
                value: new DateTime(1999, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 22,
                column: "DoB",
                value: new DateTime(1997, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 23,
                column: "DoB",
                value: new DateTime(2001, 4, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 24,
                column: "DoB",
                value: new DateTime(1993, 6, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 25,
                column: "DoB",
                value: new DateTime(1989, 9, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 26,
                column: "DoB",
                value: new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 27,
                column: "DoB",
                value: new DateTime(1985, 10, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 28,
                column: "DoB",
                value: new DateTime(1975, 2, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 29,
                column: "DoB",
                value: new DateTime(1999, 2, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 30,
                column: "DoB",
                value: new DateTime(1974, 6, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 31,
                column: "DoB",
                value: new DateTime(1995, 8, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 32,
                column: "DoB",
                value: new DateTime(1994, 4, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 33,
                column: "DoB",
                value: new DateTime(1984, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 34,
                column: "DoB",
                value: new DateTime(2000, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 35,
                column: "DoB",
                value: new DateTime(1996, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 36,
                column: "DoB",
                value: new DateTime(1978, 1, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 37,
                column: "DoB",
                value: new DateTime(1977, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 38,
                column: "DoB",
                value: new DateTime(1975, 10, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 39,
                column: "DoB",
                value: new DateTime(2004, 1, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 40,
                column: "DoB",
                value: new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 41,
                column: "DoB",
                value: new DateTime(2004, 2, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 42,
                column: "DoB",
                value: new DateTime(2001, 5, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 43,
                column: "DoB",
                value: new DateTime(1989, 5, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 44,
                column: "DoB",
                value: new DateTime(1995, 11, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 45,
                column: "DoB",
                value: new DateTime(1988, 7, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 46,
                column: "DoB",
                value: new DateTime(1986, 9, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 47,
                column: "DoB",
                value: new DateTime(1992, 6, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 48,
                column: "DoB",
                value: new DateTime(1985, 10, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 49,
                column: "DoB",
                value: new DateTime(1991, 1, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 50,
                column: "DoB",
                value: new DateTime(1978, 12, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 110,
                column: "DoB",
                value: new DateTime(1977, 8, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 111,
                column: "DoB",
                value: new DateTime(2000, 12, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 112,
                column: "DoB",
                value: new DateTime(1984, 3, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 113,
                column: "DoB",
                value: new DateTime(1984, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 114,
                column: "DoB",
                value: new DateTime(2002, 11, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 115,
                column: "DoB",
                value: new DateTime(1995, 2, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 116,
                column: "DoB",
                value: new DateTime(1996, 8, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 117,
                column: "DoB",
                value: new DateTime(1983, 7, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 118,
                column: "DoB",
                value: new DateTime(1974, 6, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 119,
                column: "DoB",
                value: new DateTime(1989, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 120,
                column: "DoB",
                value: new DateTime(1993, 12, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 121,
                column: "DoB",
                value: new DateTime(1974, 3, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 122,
                column: "DoB",
                value: new DateTime(1976, 3, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 123,
                column: "DoB",
                value: new DateTime(1989, 1, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 124,
                column: "DoB",
                value: new DateTime(1979, 2, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 125,
                column: "DoB",
                value: new DateTime(1989, 12, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 126,
                column: "DoB",
                value: new DateTime(1992, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 127,
                column: "DoB",
                value: new DateTime(1984, 1, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 128,
                column: "DoB",
                value: new DateTime(1985, 4, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 129,
                column: "DoB",
                value: new DateTime(1994, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 130,
                column: "DoB",
                value: new DateTime(1999, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 131,
                column: "DoB",
                value: new DateTime(1997, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 132,
                column: "DoB",
                value: new DateTime(2001, 4, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 133,
                column: "DoB",
                value: new DateTime(1993, 6, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 134,
                column: "DoB",
                value: new DateTime(1989, 9, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 135,
                column: "DoB",
                value: new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 136,
                column: "DoB",
                value: new DateTime(1985, 10, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 137,
                column: "DoB",
                value: new DateTime(1975, 2, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 138,
                column: "DoB",
                value: new DateTime(1999, 2, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 139,
                column: "DoB",
                value: new DateTime(1974, 6, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 140,
                column: "DoB",
                value: new DateTime(1995, 8, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 141,
                column: "DoB",
                value: new DateTime(1994, 4, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 142,
                column: "DoB",
                value: new DateTime(1984, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 143,
                column: "DoB",
                value: new DateTime(2000, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 144,
                column: "DoB",
                value: new DateTime(1996, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 145,
                column: "DoB",
                value: new DateTime(1978, 1, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 146,
                column: "DoB",
                value: new DateTime(1977, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 147,
                column: "DoB",
                value: new DateTime(1975, 10, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 148,
                column: "DoB",
                value: new DateTime(2004, 1, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 149,
                column: "DoB",
                value: new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 150,
                column: "DoB",
                value: new DateTime(2004, 2, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 151,
                column: "DoB",
                value: new DateTime(2001, 5, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 152,
                column: "DoB",
                value: new DateTime(1989, 5, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 153,
                column: "DoB",
                value: new DateTime(1995, 11, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 154,
                column: "DoB",
                value: new DateTime(1988, 7, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 155,
                column: "DoB",
                value: new DateTime(1986, 9, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 156,
                column: "DoB",
                value: new DateTime(1992, 6, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 157,
                column: "DoB",
                value: new DateTime(1985, 10, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 158,
                column: "DoB",
                value: new DateTime(1991, 1, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 159,
                column: "DoB",
                value: new DateTime(1978, 12, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 160,
                column: "DoB",
                value: new DateTime(1985, 12, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 161,
                column: "DoB",
                value: new DateTime(1986, 7, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 162,
                column: "DoB",
                value: new DateTime(2001, 5, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 163,
                column: "DoB",
                value: new DateTime(1981, 10, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 164,
                column: "DoB",
                value: new DateTime(2005, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 165,
                column: "DoB",
                value: new DateTime(1981, 2, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 166,
                column: "DoB",
                value: new DateTime(2003, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 167,
                column: "DoB",
                value: new DateTime(1977, 9, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 168,
                column: "DoB",
                value: new DateTime(2001, 3, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 169,
                column: "DoB",
                value: new DateTime(1983, 3, 23, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyerProtectionFee",
                table: "ItemPayments");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 1,
                column: "TotalRevenue",
                value: 49813128L);

            migrationBuilder.UpdateData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 2,
                column: "TotalRevenue",
                value: 91720750L);

            migrationBuilder.UpdateData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 3,
                column: "TotalRevenue",
                value: 75552377L);

            migrationBuilder.UpdateData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 4,
                column: "TotalRevenue",
                value: 108225381L);

            migrationBuilder.UpdateData(
                table: "AuctionSessionReport",
                keyColumn: "Id",
                keyValue: 5,
                column: "TotalRevenue",
                value: 91013361L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Revenue",
                value: 8247487L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Revenue",
                value: 8422594L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Revenue",
                value: 8217259L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Revenue",
                value: 8357422L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Revenue",
                value: 8395247L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Revenue",
                value: 8330350L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Revenue",
                value: 8428408L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 8,
                column: "Revenue",
                value: 8312363L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 9,
                column: "Revenue",
                value: 8433999L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 10,
                column: "Revenue",
                value: 8422636L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 11,
                column: "Revenue",
                value: 8445489L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 12,
                column: "Revenue",
                value: 8218783L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 13,
                column: "Revenue",
                value: 8472965L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 14,
                column: "Revenue",
                value: 8359461L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 15,
                column: "Revenue",
                value: 7877852L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 16,
                column: "Revenue",
                value: 8442911L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 17,
                column: "Revenue",
                value: 8455422L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 18,
                column: "Revenue",
                value: 8315960L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 19,
                column: "Revenue",
                value: 8416169L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 20,
                column: "Revenue",
                value: 8211117L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 21,
                column: "Revenue",
                value: 8442029L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 22,
                column: "Revenue",
                value: 8353784L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 23,
                column: "Revenue",
                value: 8035954L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 24,
                column: "Revenue",
                value: 8425869L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 25,
                column: "Revenue",
                value: 8374541L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 26,
                column: "Revenue",
                value: 8127727L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 27,
                column: "Revenue",
                value: 8385662L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 28,
                column: "Revenue",
                value: 8337545L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 29,
                column: "Revenue",
                value: 7753686L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 30,
                column: "Revenue",
                value: 8218776L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 31,
                column: "Revenue",
                value: 8414913L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 32,
                column: "Revenue",
                value: 8312988L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 33,
                column: "Revenue",
                value: 8417949L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 34,
                column: "Revenue",
                value: 8125992L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 35,
                column: "Revenue",
                value: 8449643L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 36,
                column: "Revenue",
                value: 8345929L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 37,
                column: "Revenue",
                value: 8453993L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 38,
                column: "Revenue",
                value: 8270142L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 39,
                column: "Revenue",
                value: 8337874L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 40,
                column: "Revenue",
                value: 8277260L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 41,
                column: "Revenue",
                value: 8354305L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 42,
                column: "Revenue",
                value: 8465062L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 43,
                column: "Revenue",
                value: 8440788L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 44,
                column: "Revenue",
                value: 8302469L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 45,
                column: "Revenue",
                value: 8322865L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 46,
                column: "Revenue",
                value: 8303967L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 47,
                column: "Revenue",
                value: 8443652L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 48,
                column: "Revenue",
                value: 8231114L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 49,
                column: "Revenue",
                value: 8363200L);

            migrationBuilder.UpdateData(
                table: "ItemPayments",
                keyColumn: "Id",
                keyValue: 50,
                column: "Revenue",
                value: 8451425L);

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoB",
                value: new DateTime(1977, 8, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoB",
                value: new DateTime(2000, 12, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoB",
                value: new DateTime(1984, 2, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoB",
                value: new DateTime(1983, 12, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoB",
                value: new DateTime(2002, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DoB",
                value: new DateTime(1995, 2, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DoB",
                value: new DateTime(1996, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DoB",
                value: new DateTime(1983, 7, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DoB",
                value: new DateTime(1974, 5, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DoB",
                value: new DateTime(1989, 6, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 11,
                column: "DoB",
                value: new DateTime(1993, 12, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 12,
                column: "DoB",
                value: new DateTime(1974, 3, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 13,
                column: "DoB",
                value: new DateTime(1976, 3, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 14,
                column: "DoB",
                value: new DateTime(1989, 1, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 15,
                column: "DoB",
                value: new DateTime(1979, 2, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 16,
                column: "DoB",
                value: new DateTime(1989, 11, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 17,
                column: "DoB",
                value: new DateTime(1992, 9, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 18,
                column: "DoB",
                value: new DateTime(1984, 1, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 19,
                column: "DoB",
                value: new DateTime(1985, 4, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 20,
                column: "DoB",
                value: new DateTime(1994, 3, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 21,
                column: "DoB",
                value: new DateTime(1999, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 22,
                column: "DoB",
                value: new DateTime(1997, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 23,
                column: "DoB",
                value: new DateTime(2001, 4, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 24,
                column: "DoB",
                value: new DateTime(1993, 6, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 25,
                column: "DoB",
                value: new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 26,
                column: "DoB",
                value: new DateTime(1993, 2, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 27,
                column: "DoB",
                value: new DateTime(1985, 10, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 28,
                column: "DoB",
                value: new DateTime(1975, 2, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 29,
                column: "DoB",
                value: new DateTime(1999, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 30,
                column: "DoB",
                value: new DateTime(1974, 6, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 31,
                column: "DoB",
                value: new DateTime(1995, 7, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 32,
                column: "DoB",
                value: new DateTime(1994, 4, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 33,
                column: "DoB",
                value: new DateTime(1984, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 34,
                column: "DoB",
                value: new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 35,
                column: "DoB",
                value: new DateTime(1996, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 36,
                column: "DoB",
                value: new DateTime(1978, 1, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 37,
                column: "DoB",
                value: new DateTime(1977, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 38,
                column: "DoB",
                value: new DateTime(1975, 10, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 39,
                column: "DoB",
                value: new DateTime(2004, 1, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 40,
                column: "DoB",
                value: new DateTime(1994, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 41,
                column: "DoB",
                value: new DateTime(2004, 2, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 42,
                column: "DoB",
                value: new DateTime(2001, 5, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 43,
                column: "DoB",
                value: new DateTime(1989, 4, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 44,
                column: "DoB",
                value: new DateTime(1995, 11, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 45,
                column: "DoB",
                value: new DateTime(1988, 7, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 46,
                column: "DoB",
                value: new DateTime(1986, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 47,
                column: "DoB",
                value: new DateTime(1992, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 48,
                column: "DoB",
                value: new DateTime(1985, 10, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 49,
                column: "DoB",
                value: new DateTime(1991, 1, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 50,
                column: "DoB",
                value: new DateTime(1978, 12, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 110,
                column: "DoB",
                value: new DateTime(1977, 8, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 111,
                column: "DoB",
                value: new DateTime(2000, 12, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 112,
                column: "DoB",
                value: new DateTime(1984, 2, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 113,
                column: "DoB",
                value: new DateTime(1983, 12, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 114,
                column: "DoB",
                value: new DateTime(2002, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 115,
                column: "DoB",
                value: new DateTime(1995, 2, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 116,
                column: "DoB",
                value: new DateTime(1996, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 117,
                column: "DoB",
                value: new DateTime(1983, 7, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 118,
                column: "DoB",
                value: new DateTime(1974, 5, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 119,
                column: "DoB",
                value: new DateTime(1989, 6, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 120,
                column: "DoB",
                value: new DateTime(1993, 12, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 121,
                column: "DoB",
                value: new DateTime(1974, 3, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 122,
                column: "DoB",
                value: new DateTime(1976, 3, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 123,
                column: "DoB",
                value: new DateTime(1989, 1, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 124,
                column: "DoB",
                value: new DateTime(1979, 2, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 125,
                column: "DoB",
                value: new DateTime(1989, 11, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 126,
                column: "DoB",
                value: new DateTime(1992, 9, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 127,
                column: "DoB",
                value: new DateTime(1984, 1, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 128,
                column: "DoB",
                value: new DateTime(1985, 4, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 129,
                column: "DoB",
                value: new DateTime(1994, 3, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 130,
                column: "DoB",
                value: new DateTime(1999, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 131,
                column: "DoB",
                value: new DateTime(1997, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 132,
                column: "DoB",
                value: new DateTime(2001, 4, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 133,
                column: "DoB",
                value: new DateTime(1993, 6, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 134,
                column: "DoB",
                value: new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 135,
                column: "DoB",
                value: new DateTime(1993, 2, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 136,
                column: "DoB",
                value: new DateTime(1985, 10, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 137,
                column: "DoB",
                value: new DateTime(1975, 2, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 138,
                column: "DoB",
                value: new DateTime(1999, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 139,
                column: "DoB",
                value: new DateTime(1974, 6, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 140,
                column: "DoB",
                value: new DateTime(1995, 7, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 141,
                column: "DoB",
                value: new DateTime(1994, 4, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 142,
                column: "DoB",
                value: new DateTime(1984, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 143,
                column: "DoB",
                value: new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 144,
                column: "DoB",
                value: new DateTime(1996, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 145,
                column: "DoB",
                value: new DateTime(1978, 1, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 146,
                column: "DoB",
                value: new DateTime(1977, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 147,
                column: "DoB",
                value: new DateTime(1975, 10, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 148,
                column: "DoB",
                value: new DateTime(2004, 1, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 149,
                column: "DoB",
                value: new DateTime(1994, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 150,
                column: "DoB",
                value: new DateTime(2004, 2, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 151,
                column: "DoB",
                value: new DateTime(2001, 5, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 152,
                column: "DoB",
                value: new DateTime(1989, 4, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 153,
                column: "DoB",
                value: new DateTime(1995, 11, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 154,
                column: "DoB",
                value: new DateTime(1988, 7, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 155,
                column: "DoB",
                value: new DateTime(1986, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 156,
                column: "DoB",
                value: new DateTime(1992, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 157,
                column: "DoB",
                value: new DateTime(1985, 10, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 158,
                column: "DoB",
                value: new DateTime(1991, 1, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 159,
                column: "DoB",
                value: new DateTime(1978, 12, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 160,
                column: "DoB",
                value: new DateTime(1985, 12, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 161,
                column: "DoB",
                value: new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 162,
                column: "DoB",
                value: new DateTime(2001, 5, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 163,
                column: "DoB",
                value: new DateTime(1981, 10, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 164,
                column: "DoB",
                value: new DateTime(2005, 6, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 165,
                column: "DoB",
                value: new DateTime(1981, 2, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 166,
                column: "DoB",
                value: new DateTime(2003, 6, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 167,
                column: "DoB",
                value: new DateTime(1977, 9, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 168,
                column: "DoB",
                value: new DateTime(2001, 3, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 169,
                column: "DoB",
                value: new DateTime(1983, 3, 19, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
