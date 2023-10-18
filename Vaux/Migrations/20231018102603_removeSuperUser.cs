using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class removeSuperUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_SuperUsers_SuperUserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_SellerPayments_SuperUsers_ApprovedById",
                table: "SellerPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_SellerPayments_Users_UserId",
                table: "SellerPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusChanges_SuperUsers_StatusChangedById",
                table: "StatusChanges");

            migrationBuilder.DropTable(
                name: "SuperUsers");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_SuperUserId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "SuperUserId",
                table: "Notifications");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SellerPayments",
                newName: "SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_SellerPayments_UserId",
                table: "SellerPayments",
                newName: "IX_SellerPayments_SellerId");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CitizenId", "CitizenIdImageId", "City", "Deleted", "DeletedReason", "District", "DoB", "Email", "Gender", "HouseNumber", "Name", "OtpExpiry", "OtpHash", "Phone", "PortraitId", "RoleId", "Street" },
                values: new object[] { 1, null, null, null, null, null, null, null, "tuannshe160097@fpt.edu.vn", null, null, "Admin", null, null, "0855068490", null, 5, null });

            migrationBuilder.AddForeignKey(
                name: "FK_SellerPayments_Users_ApprovedById",
                table: "SellerPayments",
                column: "ApprovedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SellerPayments_Users_SellerId",
                table: "SellerPayments",
                column: "SellerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatusChanges_Users_StatusChangedById",
                table: "StatusChanges",
                column: "StatusChangedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SellerPayments_Users_ApprovedById",
                table: "SellerPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_SellerPayments_Users_SellerId",
                table: "SellerPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusChanges_Users_StatusChangedById",
                table: "StatusChanges");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "SellerPayments",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SellerPayments_SellerId",
                table: "SellerPayments",
                newName: "IX_SellerPayments_UserId");

            migrationBuilder.AddColumn<int>(
                name: "SuperUserId",
                table: "Notifications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SuperUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitizenIdImageId = table.Column<int>(type: "int", nullable: true),
                    PortraitId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CitizenId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtpExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OtpHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuperUsers_Images_CitizenIdImageId",
                        column: x => x.CitizenIdImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SuperUsers_Images_PortraitId",
                        column: x => x.PortraitId,
                        principalTable: "Images",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SuperUsers_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SuperUsers",
                columns: new[] { "Id", "CitizenId", "CitizenIdImageId", "Deleted", "DoB", "Email", "Gender", "Name", "OtpExpiry", "OtpHash", "Phone", "PortraitId", "RoleId" },
                values: new object[] { 1, "", null, null, null, "tuannshe160097@fpt.edu.vn", null, "Admin", null, null, "0855068490", null, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_SuperUserId",
                table: "Notifications",
                column: "SuperUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SuperUsers_CitizenIdImageId",
                table: "SuperUsers",
                column: "CitizenIdImageId");

            migrationBuilder.CreateIndex(
                name: "IX_SuperUsers_Email",
                table: "SuperUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SuperUsers_Phone",
                table: "SuperUsers",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SuperUsers_PortraitId",
                table: "SuperUsers",
                column: "PortraitId");

            migrationBuilder.CreateIndex(
                name: "IX_SuperUsers_RoleId",
                table: "SuperUsers",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_SuperUsers_SuperUserId",
                table: "Notifications",
                column: "SuperUserId",
                principalTable: "SuperUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SellerPayments_SuperUsers_ApprovedById",
                table: "SellerPayments",
                column: "ApprovedById",
                principalTable: "SuperUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SellerPayments_Users_UserId",
                table: "SellerPayments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatusChanges_SuperUsers_StatusChangedById",
                table: "StatusChanges",
                column: "StatusChangedById",
                principalTable: "SuperUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
