﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class SessionSeedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 28, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 211,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 212,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 213,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 214,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 215,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 216,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 217,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 218,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 219,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 220,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 221,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 222,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 223,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 224,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 225,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 226,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 227,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 228,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 229,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 230,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 231,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 232,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 233,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 234,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 235,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 236,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 237,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 238,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 239,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 240,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 241,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 242,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 243,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 244,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 245,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 246,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 247,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 248,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 249,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 250,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 301,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 302,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 303,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 304,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 305,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 306,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 307,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 308,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 309,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 310,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 311,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 312,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 313,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 314,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 315,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 316,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 317,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 318,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 319,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 320,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 321,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 322,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 323,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 324,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 325,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 326,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 327,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 328,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 329,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 330,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 331,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 332,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 333,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 334,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 335,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 336,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 337,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 338,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 339,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 340,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 341,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 342,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 343,
                column: "WonDate",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 344,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 345,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 346,
                column: "WonDate",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 347,
                column: "WonDate",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 348,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 349,
                column: "WonDate",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 350,
                column: "WonDate",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoB",
                value: new DateTime(1977, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoB",
                value: new DateTime(2001, 1, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoB",
                value: new DateTime(1984, 4, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoB",
                value: new DateTime(1984, 2, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoB",
                value: new DateTime(2002, 12, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DoB",
                value: new DateTime(1995, 3, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DoB",
                value: new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DoB",
                value: new DateTime(1983, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DoB",
                value: new DateTime(1974, 7, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DoB",
                value: new DateTime(1989, 8, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 11,
                column: "DoB",
                value: new DateTime(1994, 1, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 12,
                column: "DoB",
                value: new DateTime(1974, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 13,
                column: "DoB",
                value: new DateTime(1976, 4, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 14,
                column: "DoB",
                value: new DateTime(1989, 2, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 15,
                column: "DoB",
                value: new DateTime(1979, 3, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 16,
                column: "DoB",
                value: new DateTime(1990, 1, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 17,
                column: "DoB",
                value: new DateTime(1992, 10, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 18,
                column: "DoB",
                value: new DateTime(1984, 2, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 19,
                column: "DoB",
                value: new DateTime(1985, 5, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 20,
                column: "DoB",
                value: new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 21,
                column: "DoB",
                value: new DateTime(1999, 11, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 22,
                column: "DoB",
                value: new DateTime(1997, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 23,
                column: "DoB",
                value: new DateTime(2001, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 24,
                column: "DoB",
                value: new DateTime(1993, 7, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 25,
                column: "DoB",
                value: new DateTime(1989, 10, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 26,
                column: "DoB",
                value: new DateTime(1993, 3, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 27,
                column: "DoB",
                value: new DateTime(1985, 11, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 28,
                column: "DoB",
                value: new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 29,
                column: "DoB",
                value: new DateTime(1999, 3, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 30,
                column: "DoB",
                value: new DateTime(1974, 7, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 31,
                column: "DoB",
                value: new DateTime(1995, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 32,
                column: "DoB",
                value: new DateTime(1994, 5, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 33,
                column: "DoB",
                value: new DateTime(1984, 10, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 34,
                column: "DoB",
                value: new DateTime(2000, 3, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 35,
                column: "DoB",
                value: new DateTime(1996, 11, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 36,
                column: "DoB",
                value: new DateTime(1978, 2, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 37,
                column: "DoB",
                value: new DateTime(1977, 8, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 38,
                column: "DoB",
                value: new DateTime(1975, 11, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 39,
                column: "DoB",
                value: new DateTime(2004, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 40,
                column: "DoB",
                value: new DateTime(1994, 12, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 41,
                column: "DoB",
                value: new DateTime(2004, 3, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 42,
                column: "DoB",
                value: new DateTime(2001, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 43,
                column: "DoB",
                value: new DateTime(1989, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 44,
                column: "DoB",
                value: new DateTime(1995, 12, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 45,
                column: "DoB",
                value: new DateTime(1988, 8, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 46,
                column: "DoB",
                value: new DateTime(1986, 10, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 47,
                column: "DoB",
                value: new DateTime(1992, 7, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 48,
                column: "DoB",
                value: new DateTime(1985, 12, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 49,
                column: "DoB",
                value: new DateTime(1991, 2, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 50,
                column: "DoB",
                value: new DateTime(1979, 1, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 251,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 252,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 253,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 254,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 255,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 256,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 257,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 258,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 259,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 260,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 261,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 262,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 263,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 264,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 265,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 266,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 267,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 268,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 269,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 270,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 271,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 272,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 273,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 274,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 275,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 276,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 277,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 278,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 279,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 280,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 281,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 282,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 283,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 284,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 285,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 286,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 287,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 288,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 289,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 290,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 291,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 292,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 293,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 294,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 295,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 296,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 297,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 298,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 299,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 300,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 301,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 302,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 303,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 304,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 305,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 306,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 307,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 308,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 309,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 310,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 311,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 312,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 313,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 314,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 315,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 316,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 317,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 318,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 319,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 320,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 321,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 322,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 323,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 324,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 325,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 326,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 327,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 328,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 329,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 330,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 331,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 332,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 333,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 334,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 335,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 336,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 337,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 338,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 339,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 340,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 341,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 342,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 343,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 344,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 345,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 346,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 347,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 348,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 349,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 350,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 351,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 352,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 353,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 354,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 355,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 356,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 357,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 358,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 359,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 360,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 361,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 362,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 363,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 364,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 365,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 366,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 367,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 368,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 369,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 370,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 371,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 372,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 373,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 374,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 375,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 376,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 377,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 378,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 379,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 380,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 381,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 382,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 383,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 384,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 385,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 386,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 387,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 388,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 389,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 390,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 391,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 392,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 393,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 394,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 395,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 396,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 397,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 398,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 399,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 400,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 401,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 402,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 403,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 404,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 405,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 406,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 407,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 408,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 409,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 410,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 411,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 412,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 413,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 414,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 415,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 416,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 417,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 418,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 419,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 420,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 421,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 422,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 423,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 424,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 425,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 426,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 427,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 428,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 429,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 430,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 431,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 432,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 433,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 434,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 435,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 436,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 437,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 438,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 439,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 440,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 441,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 442,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 443,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 444,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 445,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 446,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 447,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 448,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 449,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 450,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 451,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 452,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 453,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 454,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 455,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 456,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 457,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 458,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 459,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 460,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 461,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 462,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 463,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 464,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 465,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 466,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 467,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 468,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 469,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 470,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 471,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 472,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 473,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 474,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 475,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 476,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 477,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 478,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 479,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 480,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 481,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 482,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 483,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 484,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 485,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 486,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 487,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 488,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 489,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 490,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 491,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 492,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 493,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 494,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 495,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 496,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 497,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 498,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 499,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 500,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 501,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 502,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 503,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 504,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 505,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 506,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 507,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 508,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 509,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 510,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 511,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 512,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 513,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 514,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 515,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 516,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 517,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 518,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 519,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 520,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 521,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 522,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 523,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 524,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 525,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 526,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 527,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 528,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 529,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 530,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 531,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 532,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 533,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 534,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 535,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 536,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 537,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 538,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 539,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 540,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 541,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 542,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 543,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 544,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 545,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 546,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 547,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 548,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 549,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 550,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 551,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 552,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 553,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 554,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 555,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 556,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 557,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 558,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 559,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 560,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 561,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 562,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 563,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 564,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 565,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 566,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 567,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 568,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 569,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 570,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 571,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 572,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 573,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 574,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 575,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 576,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 577,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 578,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 579,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 580,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 581,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 582,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 583,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 584,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 585,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 586,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 587,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 588,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 589,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 590,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 591,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 592,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 593,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 594,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 595,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 596,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 597,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 598,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 599,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 600,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 601,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 602,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 603,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 604,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 605,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 606,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 607,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 608,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 609,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 610,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 611,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 612,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 613,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 614,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 615,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 616,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 617,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 618,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 619,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 620,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 621,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 622,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 623,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 624,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 625,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 626,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 627,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 628,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 629,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 630,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 631,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 632,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 633,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 634,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 635,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 636,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 637,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 638,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 639,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 640,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 641,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 642,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 643,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 644,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 645,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 646,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 647,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 648,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 649,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 650,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 651,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 652,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 653,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 654,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 655,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 656,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 657,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 658,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 659,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 660,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 661,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 662,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 663,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 664,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 665,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 666,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 667,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 668,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 669,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 670,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 671,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 672,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 673,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 674,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 675,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 676,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 677,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 678,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 679,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 680,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 681,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 682,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 683,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 684,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 685,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 686,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 687,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 688,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 689,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 690,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 691,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 692,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 693,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 694,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 695,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 696,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 697,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 698,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 699,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 700,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 701,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 702,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 703,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 704,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 705,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 706,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 707,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 708,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 709,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 710,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 711,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 712,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 713,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 714,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 715,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 716,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 717,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 718,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 719,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 720,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 721,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 722,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 723,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 724,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 725,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 726,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 727,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 728,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 729,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 730,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 731,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 732,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 733,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 734,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 735,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 736,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 737,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 738,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 739,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 740,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 741,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 742,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 743,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 744,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 745,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 746,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 747,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 748,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 749,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 750,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 751,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 752,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 753,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 754,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 755,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 756,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 757,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 758,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 759,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 760,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 761,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 762,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 763,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 764,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 765,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 766,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 767,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 768,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 769,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 770,
                column: "Created",
                value: new DateTime(2023, 12, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 771,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 772,
                column: "Created",
                value: new DateTime(2023, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 773,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 774,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 775,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 776,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 777,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 778,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 779,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 780,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 781,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 782,
                column: "Created",
                value: new DateTime(2023, 8, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 783,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 784,
                column: "Created",
                value: new DateTime(2023, 8, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 785,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 786,
                column: "Created",
                value: new DateTime(2023, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 787,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 788,
                column: "Created",
                value: new DateTime(2023, 9, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 789,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 790,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 791,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 792,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 793,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 794,
                column: "Created",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 795,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 796,
                column: "Created",
                value: new DateTime(2023, 10, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 797,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 798,
                column: "Created",
                value: new DateTime(2023, 11, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 799,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 800,
                column: "Created",
                value: new DateTime(2023, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 110,
                column: "DoB",
                value: new DateTime(1977, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 111,
                column: "DoB",
                value: new DateTime(2001, 1, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 112,
                column: "DoB",
                value: new DateTime(1984, 4, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 113,
                column: "DoB",
                value: new DateTime(1984, 2, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 114,
                column: "DoB",
                value: new DateTime(2002, 12, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 115,
                column: "DoB",
                value: new DateTime(1995, 3, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 116,
                column: "DoB",
                value: new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 117,
                column: "DoB",
                value: new DateTime(1983, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 118,
                column: "DoB",
                value: new DateTime(1974, 7, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 119,
                column: "DoB",
                value: new DateTime(1989, 8, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 120,
                column: "DoB",
                value: new DateTime(1994, 1, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 121,
                column: "DoB",
                value: new DateTime(1974, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 122,
                column: "DoB",
                value: new DateTime(1976, 4, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 123,
                column: "DoB",
                value: new DateTime(1989, 2, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 124,
                column: "DoB",
                value: new DateTime(1979, 3, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 125,
                column: "DoB",
                value: new DateTime(1990, 1, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 126,
                column: "DoB",
                value: new DateTime(1992, 10, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 127,
                column: "DoB",
                value: new DateTime(1984, 2, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 128,
                column: "DoB",
                value: new DateTime(1985, 5, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 129,
                column: "DoB",
                value: new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 130,
                column: "DoB",
                value: new DateTime(1999, 11, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 131,
                column: "DoB",
                value: new DateTime(1997, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 132,
                column: "DoB",
                value: new DateTime(2001, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 133,
                column: "DoB",
                value: new DateTime(1993, 7, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 134,
                column: "DoB",
                value: new DateTime(1989, 10, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 135,
                column: "DoB",
                value: new DateTime(1993, 3, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 136,
                column: "DoB",
                value: new DateTime(1985, 11, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 137,
                column: "DoB",
                value: new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 138,
                column: "DoB",
                value: new DateTime(1999, 3, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 139,
                column: "DoB",
                value: new DateTime(1974, 7, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 140,
                column: "DoB",
                value: new DateTime(1995, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 141,
                column: "DoB",
                value: new DateTime(1994, 5, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 142,
                column: "DoB",
                value: new DateTime(1984, 10, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 143,
                column: "DoB",
                value: new DateTime(2000, 3, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 144,
                column: "DoB",
                value: new DateTime(1996, 11, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 145,
                column: "DoB",
                value: new DateTime(1978, 2, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 146,
                column: "DoB",
                value: new DateTime(1977, 8, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 147,
                column: "DoB",
                value: new DateTime(1975, 11, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 148,
                column: "DoB",
                value: new DateTime(2004, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 149,
                column: "DoB",
                value: new DateTime(1994, 12, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 150,
                column: "DoB",
                value: new DateTime(2004, 3, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 151,
                column: "DoB",
                value: new DateTime(2001, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 152,
                column: "DoB",
                value: new DateTime(1989, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 153,
                column: "DoB",
                value: new DateTime(1995, 12, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 154,
                column: "DoB",
                value: new DateTime(1988, 8, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 155,
                column: "DoB",
                value: new DateTime(1986, 10, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 156,
                column: "DoB",
                value: new DateTime(1992, 7, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 157,
                column: "DoB",
                value: new DateTime(1985, 12, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 158,
                column: "DoB",
                value: new DateTime(1991, 2, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 159,
                column: "DoB",
                value: new DateTime(1979, 1, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 160,
                column: "DoB",
                value: new DateTime(1986, 1, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 161,
                column: "DoB",
                value: new DateTime(1986, 8, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 162,
                column: "DoB",
                value: new DateTime(2001, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 163,
                column: "DoB",
                value: new DateTime(1981, 11, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 164,
                column: "DoB",
                value: new DateTime(2005, 7, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 165,
                column: "DoB",
                value: new DateTime(1981, 4, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 166,
                column: "DoB",
                value: new DateTime(2003, 7, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 167,
                column: "DoB",
                value: new DateTime(1977, 10, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 168,
                column: "DoB",
                value: new DateTime(2001, 4, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 169,
                column: "DoB",
                value: new DateTime(1983, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 4, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 18, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 25, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 4, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 211,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 212,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 213,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 214,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 215,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 216,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 217,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 218,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 219,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 220,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 221,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 222,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 223,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 224,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 225,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 226,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 227,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 228,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 229,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 230,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 231,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 232,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 233,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 234,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 235,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 236,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 237,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 238,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 239,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 240,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 241,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 242,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 243,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 244,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 245,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 246,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 247,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 248,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 249,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 250,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 301,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 302,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 303,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 304,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 305,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 306,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 307,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 308,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 309,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 310,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 311,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 312,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 313,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 314,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 315,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 316,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 317,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 318,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 319,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 320,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 321,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 322,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 323,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 324,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 325,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 326,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 327,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 328,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 329,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 330,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 331,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 332,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 333,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 334,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 335,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 336,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 337,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 338,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 339,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 340,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 341,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 342,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 343,
                column: "WonDate",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 344,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 345,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 346,
                column: "WonDate",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 347,
                column: "WonDate",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 348,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 349,
                column: "WonDate",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 350,
                column: "WonDate",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoB",
                value: new DateTime(1977, 8, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoB",
                value: new DateTime(2000, 12, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoB",
                value: new DateTime(1984, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoB",
                value: new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoB",
                value: new DateTime(2002, 11, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DoB",
                value: new DateTime(1995, 2, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DoB",
                value: new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DoB",
                value: new DateTime(1983, 7, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DoB",
                value: new DateTime(1974, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DoB",
                value: new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 11,
                column: "DoB",
                value: new DateTime(1993, 12, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 12,
                column: "DoB",
                value: new DateTime(1974, 3, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 13,
                column: "DoB",
                value: new DateTime(1976, 3, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 14,
                column: "DoB",
                value: new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 15,
                column: "DoB",
                value: new DateTime(1979, 2, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 16,
                column: "DoB",
                value: new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 17,
                column: "DoB",
                value: new DateTime(1992, 9, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 18,
                column: "DoB",
                value: new DateTime(1984, 1, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 19,
                column: "DoB",
                value: new DateTime(1985, 4, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 20,
                column: "DoB",
                value: new DateTime(1994, 3, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 21,
                column: "DoB",
                value: new DateTime(1999, 10, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 22,
                column: "DoB",
                value: new DateTime(1997, 8, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 23,
                column: "DoB",
                value: new DateTime(2001, 4, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 24,
                column: "DoB",
                value: new DateTime(1993, 6, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 25,
                column: "DoB",
                value: new DateTime(1989, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 26,
                column: "DoB",
                value: new DateTime(1993, 2, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 27,
                column: "DoB",
                value: new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 28,
                column: "DoB",
                value: new DateTime(1975, 2, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 29,
                column: "DoB",
                value: new DateTime(1999, 2, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 30,
                column: "DoB",
                value: new DateTime(1974, 6, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 31,
                column: "DoB",
                value: new DateTime(1995, 8, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 32,
                column: "DoB",
                value: new DateTime(1994, 4, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 33,
                column: "DoB",
                value: new DateTime(1984, 9, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 34,
                column: "DoB",
                value: new DateTime(2000, 2, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 35,
                column: "DoB",
                value: new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 36,
                column: "DoB",
                value: new DateTime(1978, 1, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 37,
                column: "DoB",
                value: new DateTime(1977, 7, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 38,
                column: "DoB",
                value: new DateTime(1975, 10, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 39,
                column: "DoB",
                value: new DateTime(2004, 1, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 40,
                column: "DoB",
                value: new DateTime(1994, 11, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 41,
                column: "DoB",
                value: new DateTime(2004, 2, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 42,
                column: "DoB",
                value: new DateTime(2001, 5, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 43,
                column: "DoB",
                value: new DateTime(1989, 5, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 44,
                column: "DoB",
                value: new DateTime(1995, 11, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 45,
                column: "DoB",
                value: new DateTime(1988, 7, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 46,
                column: "DoB",
                value: new DateTime(1986, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 47,
                column: "DoB",
                value: new DateTime(1992, 6, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 48,
                column: "DoB",
                value: new DateTime(1985, 10, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 49,
                column: "DoB",
                value: new DateTime(1991, 1, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 50,
                column: "DoB",
                value: new DateTime(1978, 12, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 251,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 252,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 253,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 254,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 255,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 256,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 257,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 258,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 259,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 260,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 261,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 262,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 263,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 264,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 265,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 266,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 267,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 268,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 269,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 270,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 271,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 272,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 273,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 274,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 275,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 276,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 277,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 278,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 279,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 280,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 281,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 282,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 283,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 284,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 285,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 286,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 287,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 288,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 289,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 290,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 291,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 292,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 293,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 294,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 295,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 296,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 297,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 298,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 299,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 300,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 301,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 302,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 303,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 304,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 305,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 306,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 307,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 308,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 309,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 310,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 311,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 312,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 313,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 314,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 315,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 316,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 317,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 318,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 319,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 320,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 321,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 322,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 323,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 324,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 325,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 326,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 327,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 328,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 329,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 330,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 331,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 332,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 333,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 334,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 335,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 336,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 337,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 338,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 339,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 340,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 341,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 342,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 343,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 344,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 345,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 346,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 347,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 348,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 349,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 350,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 351,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 352,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 353,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 354,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 355,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 356,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 357,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 358,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 359,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 360,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 361,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 362,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 363,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 364,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 365,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 366,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 367,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 368,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 369,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 370,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 371,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 372,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 373,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 374,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 375,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 376,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 377,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 378,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 379,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 380,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 381,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 382,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 383,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 384,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 385,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 386,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 387,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 388,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 389,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 390,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 391,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 392,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 393,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 394,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 395,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 396,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 397,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 398,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 399,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 400,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 401,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 402,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 403,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 404,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 405,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 406,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 407,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 408,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 409,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 410,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 411,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 412,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 413,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 414,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 415,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 416,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 417,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 418,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 419,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 420,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 421,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 422,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 423,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 424,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 425,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 426,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 427,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 428,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 429,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 430,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 431,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 432,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 433,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 434,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 435,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 436,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 437,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 438,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 439,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 440,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 441,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 442,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 443,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 444,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 445,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 446,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 447,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 448,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 449,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 450,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 451,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 452,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 453,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 454,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 455,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 456,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 457,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 458,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 459,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 460,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 461,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 462,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 463,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 464,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 465,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 466,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 467,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 468,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 469,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 470,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 471,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 472,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 473,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 474,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 475,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 476,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 477,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 478,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 479,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 480,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 481,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 482,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 483,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 484,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 485,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 486,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 487,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 488,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 489,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 490,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 491,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 492,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 493,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 494,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 495,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 496,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 497,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 498,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 499,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 500,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 501,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 502,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 503,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 504,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 505,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 506,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 507,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 508,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 509,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 510,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 511,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 512,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 513,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 514,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 515,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 516,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 517,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 518,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 519,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 520,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 521,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 522,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 523,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 524,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 525,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 526,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 527,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 528,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 529,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 530,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 531,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 532,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 533,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 534,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 535,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 536,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 537,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 538,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 539,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 540,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 541,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 542,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 543,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 544,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 545,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 546,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 547,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 548,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 549,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 550,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 551,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 552,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 553,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 554,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 555,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 556,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 557,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 558,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 559,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 560,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 561,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 562,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 563,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 564,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 565,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 566,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 567,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 568,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 569,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 570,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 571,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 572,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 573,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 574,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 575,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 576,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 577,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 578,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 579,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 580,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 581,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 582,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 583,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 584,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 585,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 586,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 587,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 588,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 589,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 590,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 591,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 592,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 593,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 594,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 595,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 596,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 597,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 598,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 599,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 600,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 601,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 602,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 603,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 604,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 605,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 606,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 607,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 608,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 609,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 610,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 611,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 612,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 613,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 614,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 615,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 616,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 617,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 618,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 619,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 620,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 621,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 622,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 623,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 624,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 625,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 626,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 627,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 628,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 629,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 630,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 631,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 632,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 633,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 634,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 635,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 636,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 637,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 638,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 639,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 640,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 641,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 642,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 643,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 644,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 645,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 646,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 647,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 648,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 649,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 650,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 651,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 652,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 653,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 654,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 655,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 656,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 657,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 658,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 659,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 660,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 661,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 662,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 663,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 664,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 665,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 666,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 667,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 668,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 669,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 670,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 671,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 672,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 673,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 674,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 675,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 676,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 677,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 678,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 679,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 680,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 681,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 682,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 683,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 684,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 685,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 686,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 687,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 688,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 689,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 690,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 691,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 692,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 693,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 694,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 695,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 696,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 697,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 698,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 699,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 700,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 701,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 702,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 703,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 704,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 705,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 706,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 707,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 708,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 709,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 710,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 711,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 712,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 713,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 714,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 715,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 716,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 717,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 718,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 719,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 720,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 721,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 722,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 723,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 724,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 725,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 726,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 727,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 728,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 729,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 730,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 731,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 732,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 733,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 734,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 735,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 736,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 737,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 738,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 739,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 740,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 741,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 742,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 743,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 744,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 745,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 746,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 747,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 748,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 749,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 750,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 751,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 752,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 753,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 754,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 755,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 756,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 757,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 758,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 759,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 760,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 761,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 762,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 763,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 764,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 765,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 766,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 767,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 768,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 769,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 770,
                column: "Created",
                value: new DateTime(2023, 11, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 771,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 772,
                column: "Created",
                value: new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 773,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 774,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 775,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 776,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 777,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 778,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 779,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 780,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 781,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 782,
                column: "Created",
                value: new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 783,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 784,
                column: "Created",
                value: new DateTime(2023, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 785,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 786,
                column: "Created",
                value: new DateTime(2023, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 787,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 788,
                column: "Created",
                value: new DateTime(2023, 8, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 789,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 790,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 791,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 792,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 793,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 794,
                column: "Created",
                value: new DateTime(2023, 9, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 795,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 796,
                column: "Created",
                value: new DateTime(2023, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 797,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 798,
                column: "Created",
                value: new DateTime(2023, 10, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 799,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 800,
                column: "Created",
                value: new DateTime(2023, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 110,
                column: "DoB",
                value: new DateTime(1977, 8, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 111,
                column: "DoB",
                value: new DateTime(2000, 12, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 112,
                column: "DoB",
                value: new DateTime(1984, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 113,
                column: "DoB",
                value: new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 114,
                column: "DoB",
                value: new DateTime(2002, 11, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 115,
                column: "DoB",
                value: new DateTime(1995, 2, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 116,
                column: "DoB",
                value: new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 117,
                column: "DoB",
                value: new DateTime(1983, 7, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 118,
                column: "DoB",
                value: new DateTime(1974, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 119,
                column: "DoB",
                value: new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 120,
                column: "DoB",
                value: new DateTime(1993, 12, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 121,
                column: "DoB",
                value: new DateTime(1974, 3, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 122,
                column: "DoB",
                value: new DateTime(1976, 3, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 123,
                column: "DoB",
                value: new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 124,
                column: "DoB",
                value: new DateTime(1979, 2, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 125,
                column: "DoB",
                value: new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 126,
                column: "DoB",
                value: new DateTime(1992, 9, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 127,
                column: "DoB",
                value: new DateTime(1984, 1, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 128,
                column: "DoB",
                value: new DateTime(1985, 4, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 129,
                column: "DoB",
                value: new DateTime(1994, 3, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 130,
                column: "DoB",
                value: new DateTime(1999, 10, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 131,
                column: "DoB",
                value: new DateTime(1997, 8, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 132,
                column: "DoB",
                value: new DateTime(2001, 4, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 133,
                column: "DoB",
                value: new DateTime(1993, 6, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 134,
                column: "DoB",
                value: new DateTime(1989, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 135,
                column: "DoB",
                value: new DateTime(1993, 2, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 136,
                column: "DoB",
                value: new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 137,
                column: "DoB",
                value: new DateTime(1975, 2, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 138,
                column: "DoB",
                value: new DateTime(1999, 2, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 139,
                column: "DoB",
                value: new DateTime(1974, 6, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 140,
                column: "DoB",
                value: new DateTime(1995, 8, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 141,
                column: "DoB",
                value: new DateTime(1994, 4, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 142,
                column: "DoB",
                value: new DateTime(1984, 9, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 143,
                column: "DoB",
                value: new DateTime(2000, 2, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 144,
                column: "DoB",
                value: new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 145,
                column: "DoB",
                value: new DateTime(1978, 1, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 146,
                column: "DoB",
                value: new DateTime(1977, 7, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 147,
                column: "DoB",
                value: new DateTime(1975, 10, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 148,
                column: "DoB",
                value: new DateTime(2004, 1, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 149,
                column: "DoB",
                value: new DateTime(1994, 11, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 150,
                column: "DoB",
                value: new DateTime(2004, 2, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 151,
                column: "DoB",
                value: new DateTime(2001, 5, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 152,
                column: "DoB",
                value: new DateTime(1989, 5, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 153,
                column: "DoB",
                value: new DateTime(1995, 11, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 154,
                column: "DoB",
                value: new DateTime(1988, 7, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 155,
                column: "DoB",
                value: new DateTime(1986, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 156,
                column: "DoB",
                value: new DateTime(1992, 6, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 157,
                column: "DoB",
                value: new DateTime(1985, 10, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 158,
                column: "DoB",
                value: new DateTime(1991, 1, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 159,
                column: "DoB",
                value: new DateTime(1978, 12, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 160,
                column: "DoB",
                value: new DateTime(1985, 12, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 161,
                column: "DoB",
                value: new DateTime(1986, 7, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 162,
                column: "DoB",
                value: new DateTime(2001, 5, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 163,
                column: "DoB",
                value: new DateTime(1981, 10, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 164,
                column: "DoB",
                value: new DateTime(2005, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 165,
                column: "DoB",
                value: new DateTime(1981, 3, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 166,
                column: "DoB",
                value: new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 167,
                column: "DoB",
                value: new DateTime(1977, 9, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 168,
                column: "DoB",
                value: new DateTime(2001, 3, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 169,
                column: "DoB",
                value: new DateTime(1983, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
