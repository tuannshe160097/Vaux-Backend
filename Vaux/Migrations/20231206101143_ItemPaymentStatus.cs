using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class ItemPaymentStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPayments_Users_ApprovedById",
                table: "ItemPayments");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ItemPayments",
                newName: "SellerPaymentStatus");

            migrationBuilder.RenameColumn(
                name: "ApprovedById",
                table: "ItemPayments",
                newName: "SellerPaymentApprovedById");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPayments_ApprovedById",
                table: "ItemPayments",
                newName: "IX_ItemPayments_SellerPaymentApprovedById");

            migrationBuilder.AddColumn<int>(
                name: "ExpertPaymentApprovedById",
                table: "ItemPayments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpertPaymentStatus",
                table: "ItemPayments",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPayments_ExpertPaymentApprovedById",
                table: "ItemPayments",
                column: "ExpertPaymentApprovedById");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPayments_Users_ExpertPaymentApprovedById",
                table: "ItemPayments",
                column: "ExpertPaymentApprovedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPayments_Users_SellerPaymentApprovedById",
                table: "ItemPayments",
                column: "SellerPaymentApprovedById",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPayments_Users_ExpertPaymentApprovedById",
                table: "ItemPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPayments_Users_SellerPaymentApprovedById",
                table: "ItemPayments");

            migrationBuilder.DropIndex(
                name: "IX_ItemPayments_ExpertPaymentApprovedById",
                table: "ItemPayments");

            migrationBuilder.DropColumn(
                name: "ExpertPaymentApprovedById",
                table: "ItemPayments");

            migrationBuilder.DropColumn(
                name: "ExpertPaymentStatus",
                table: "ItemPayments");

            migrationBuilder.RenameColumn(
                name: "SellerPaymentStatus",
                table: "ItemPayments",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "SellerPaymentApprovedById",
                table: "ItemPayments",
                newName: "ApprovedById");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPayments_SellerPaymentApprovedById",
                table: "ItemPayments",
                newName: "IX_ItemPayments_ApprovedById");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPayments_Users_ApprovedById",
                table: "ItemPayments",
                column: "ApprovedById",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
