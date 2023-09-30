using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class AddImageToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CitizenIdImage",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FaceImage",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CitizenIdImage",
                table: "Users",
                column: "CitizenIdImage");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FaceImage",
                table: "Users",
                column: "FaceImage");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Images_CitizenIdImage",
                table: "Users",
                column: "CitizenIdImage",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Images_FaceImage",
                table: "Users",
                column: "FaceImage",
                principalTable: "Images",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Images_CitizenIdImage",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Images_FaceImage",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CitizenIdImage",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_FaceImage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CitizenIdImage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FaceImage",
                table: "Users");
        }
    }
}
