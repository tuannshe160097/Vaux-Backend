using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class ItemPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemProperties_Items_ItemId",
                table: "ItemProperties");

            migrationBuilder.DropTable(
                name: "SellerPayments");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "ItemProperties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ItemPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerPayout = table.Column<long>(type: "bigint", nullable: false),
                    ExpertPayout = table.Column<long>(type: "bigint", nullable: false),
                    Revenue = table.Column<long>(type: "bigint", nullable: false),
                    ExpertPaymentStatus = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    SellerPaymentStatus = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    ExpertPaymentApprovedById = table.Column<int>(type: "int", nullable: true),
                    SellerPaymentApprovedById = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemPayments_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemPayments_Users_ExpertPaymentApprovedById",
                        column: x => x.ExpertPaymentApprovedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemPayments_Users_SellerPaymentApprovedById",
                        column: x => x.SellerPaymentApprovedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemPayments_ExpertPaymentApprovedById",
                table: "ItemPayments",
                column: "ExpertPaymentApprovedById");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPayments_ItemId",
                table: "ItemPayments",
                column: "ItemId",
                unique: true,
                filter: "[ItemId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPayments_SellerPaymentApprovedById",
                table: "ItemPayments",
                column: "SellerPaymentApprovedById");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemProperties_Items_ItemId",
                table: "ItemProperties",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemProperties_Items_ItemId",
                table: "ItemProperties");

            migrationBuilder.DropTable(
                name: "ItemPayments");

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "ItemProperties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "SellerPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovedById = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellerPayments_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SellerPayments_Users_ApprovedById",
                        column: x => x.ApprovedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Deleted", "Title" },
                values: new object[,]
                {
                    { 1, null, "MODERATOR" },
                    { 2, null, "EXPERT" },
                    { 3, null, "SELLER" },
                    { 4, null, "BUYER" },
                    { 5, null, "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BankAccountNum", "BankCode", "BankName", "CitizenId", "CitizenIdImageId", "City", "Deleted", "DeletedReason", "District", "DoB", "Email", "Gender", "HouseNumber", "Name", "OtpExpiry", "OtpHash", "Phone", "PortraitId", "RoleId", "Street" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, null, "tuannshe160097@fpt.edu.vn", null, null, "Doxx him John", null, null, "0855068490", null, 5, null });

            migrationBuilder.CreateIndex(
                name: "IX_SellerPayments_ApprovedById",
                table: "SellerPayments",
                column: "ApprovedById");

            migrationBuilder.CreateIndex(
                name: "IX_SellerPayments_ItemId",
                table: "SellerPayments",
                column: "ItemId",
                unique: true,
                filter: "[ItemId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemProperties_Items_ItemId",
                table: "ItemProperties",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");
        }
    }
}
