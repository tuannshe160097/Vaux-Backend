using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class modSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ReceiverName", "ReceiverPhone" },
                values: new object[] { "HuongNC", "0868196943" });

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
                keyValue: 2,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "haipkh@fpt.com", "HaiPKH", "0858617701" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "anhlthe150222@fpt.edu.vn", "AnhLT", "0522909921" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "huongnche153002@fpt.edu.vn", "HuongNC", "0868196943" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "minhtahe153458@fpt.edu.vn", "MinhTA", "0949566063" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ReceiverName", "ReceiverPhone" },
                values: new object[] { "Admin", "08550684903" });

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoB",
                value: new DateTime(1977, 8, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoB",
                value: new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoB",
                value: new DateTime(1984, 2, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoB",
                value: new DateTime(1983, 12, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoB",
                value: new DateTime(2002, 10, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DoB",
                value: new DateTime(1995, 2, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DoB",
                value: new DateTime(1996, 8, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DoB",
                value: new DateTime(1983, 7, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DoB",
                value: new DateTime(1974, 5, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DoB",
                value: new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 11,
                column: "DoB",
                value: new DateTime(1993, 11, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 12,
                column: "DoB",
                value: new DateTime(1974, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 13,
                column: "DoB",
                value: new DateTime(1976, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 14,
                column: "DoB",
                value: new DateTime(1989, 1, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 15,
                column: "DoB",
                value: new DateTime(1979, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 16,
                column: "DoB",
                value: new DateTime(1989, 11, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 17,
                column: "DoB",
                value: new DateTime(1992, 9, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 18,
                column: "DoB",
                value: new DateTime(1984, 1, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 19,
                column: "DoB",
                value: new DateTime(1985, 4, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 20,
                column: "DoB",
                value: new DateTime(1994, 3, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 21,
                column: "DoB",
                value: new DateTime(1999, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 22,
                column: "DoB",
                value: new DateTime(1997, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 23,
                column: "DoB",
                value: new DateTime(2001, 4, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 24,
                column: "DoB",
                value: new DateTime(1993, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 25,
                column: "DoB",
                value: new DateTime(1989, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 26,
                column: "DoB",
                value: new DateTime(1993, 2, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 27,
                column: "DoB",
                value: new DateTime(1985, 10, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 28,
                column: "DoB",
                value: new DateTime(1975, 2, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 29,
                column: "DoB",
                value: new DateTime(1999, 1, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 30,
                column: "DoB",
                value: new DateTime(1974, 6, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 31,
                column: "DoB",
                value: new DateTime(1995, 7, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 32,
                column: "DoB",
                value: new DateTime(1994, 4, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 33,
                column: "DoB",
                value: new DateTime(1984, 8, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 34,
                column: "DoB",
                value: new DateTime(2000, 2, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 35,
                column: "DoB",
                value: new DateTime(1996, 9, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 36,
                column: "DoB",
                value: new DateTime(1978, 1, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 37,
                column: "DoB",
                value: new DateTime(1977, 7, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 38,
                column: "DoB",
                value: new DateTime(1975, 10, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 39,
                column: "DoB",
                value: new DateTime(2004, 1, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 40,
                column: "DoB",
                value: new DateTime(1994, 10, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 41,
                column: "DoB",
                value: new DateTime(2004, 2, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 42,
                column: "DoB",
                value: new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 43,
                column: "DoB",
                value: new DateTime(1989, 4, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 44,
                column: "DoB",
                value: new DateTime(1995, 11, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 45,
                column: "DoB",
                value: new DateTime(1988, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 46,
                column: "DoB",
                value: new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 47,
                column: "DoB",
                value: new DateTime(1992, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 48,
                column: "DoB",
                value: new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 49,
                column: "DoB",
                value: new DateTime(1991, 1, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 50,
                column: "DoB",
                value: new DateTime(1978, 12, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "1@fpt.edu.vn", "Admin", "08550684901" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "2@fpt.edu.vn", "Admin", "08550684902" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "3@fpt.edu.vn", "Admin", "08550684903" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "4@fpt.edu.vn", "Admin", "08550684904" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 110,
                column: "DoB",
                value: new DateTime(1977, 8, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 111,
                column: "DoB",
                value: new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 112,
                column: "DoB",
                value: new DateTime(1984, 2, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 113,
                column: "DoB",
                value: new DateTime(1983, 12, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 114,
                column: "DoB",
                value: new DateTime(2002, 10, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 115,
                column: "DoB",
                value: new DateTime(1995, 2, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 116,
                column: "DoB",
                value: new DateTime(1996, 8, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 117,
                column: "DoB",
                value: new DateTime(1983, 7, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 118,
                column: "DoB",
                value: new DateTime(1974, 5, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 119,
                column: "DoB",
                value: new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 120,
                column: "DoB",
                value: new DateTime(1993, 11, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 121,
                column: "DoB",
                value: new DateTime(1974, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 122,
                column: "DoB",
                value: new DateTime(1976, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 123,
                column: "DoB",
                value: new DateTime(1989, 1, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 124,
                column: "DoB",
                value: new DateTime(1979, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 125,
                column: "DoB",
                value: new DateTime(1989, 11, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 126,
                column: "DoB",
                value: new DateTime(1992, 9, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 127,
                column: "DoB",
                value: new DateTime(1984, 1, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 128,
                column: "DoB",
                value: new DateTime(1985, 4, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 129,
                column: "DoB",
                value: new DateTime(1994, 3, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 130,
                column: "DoB",
                value: new DateTime(1999, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 131,
                column: "DoB",
                value: new DateTime(1997, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 132,
                column: "DoB",
                value: new DateTime(2001, 4, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 133,
                column: "DoB",
                value: new DateTime(1993, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 134,
                column: "DoB",
                value: new DateTime(1989, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 135,
                column: "DoB",
                value: new DateTime(1993, 2, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 136,
                column: "DoB",
                value: new DateTime(1985, 10, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 137,
                column: "DoB",
                value: new DateTime(1975, 2, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 138,
                column: "DoB",
                value: new DateTime(1999, 1, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 139,
                column: "DoB",
                value: new DateTime(1974, 6, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 140,
                column: "DoB",
                value: new DateTime(1995, 7, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 141,
                column: "DoB",
                value: new DateTime(1994, 4, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 142,
                column: "DoB",
                value: new DateTime(1984, 8, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 143,
                column: "DoB",
                value: new DateTime(2000, 2, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 144,
                column: "DoB",
                value: new DateTime(1996, 9, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 145,
                column: "DoB",
                value: new DateTime(1978, 1, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 146,
                column: "DoB",
                value: new DateTime(1977, 7, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 147,
                column: "DoB",
                value: new DateTime(1975, 10, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 148,
                column: "DoB",
                value: new DateTime(2004, 1, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 149,
                column: "DoB",
                value: new DateTime(1994, 10, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 150,
                column: "DoB",
                value: new DateTime(2004, 2, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 151,
                column: "DoB",
                value: new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 152,
                column: "DoB",
                value: new DateTime(1989, 4, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 153,
                column: "DoB",
                value: new DateTime(1995, 11, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 154,
                column: "DoB",
                value: new DateTime(1988, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 155,
                column: "DoB",
                value: new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 156,
                column: "DoB",
                value: new DateTime(1992, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 157,
                column: "DoB",
                value: new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 158,
                column: "DoB",
                value: new DateTime(1991, 1, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 159,
                column: "DoB",
                value: new DateTime(1978, 12, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 160,
                column: "DoB",
                value: new DateTime(1985, 12, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 161,
                column: "DoB",
                value: new DateTime(1986, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 162,
                column: "DoB",
                value: new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 163,
                column: "DoB",
                value: new DateTime(1981, 10, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 164,
                column: "DoB",
                value: new DateTime(2005, 6, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 165,
                column: "DoB",
                value: new DateTime(1981, 2, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 166,
                column: "DoB",
                value: new DateTime(2003, 6, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 167,
                column: "DoB",
                value: new DateTime(1977, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 168,
                column: "DoB",
                value: new DateTime(2001, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 169,
                column: "DoB",
                value: new DateTime(1983, 3, 18, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
