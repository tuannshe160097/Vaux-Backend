using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SuperUsers",
                columns: new[] { "Id", "CitizenId", "CitizenIdImageId", "Deleted", "Email", "Name", "OtpHash", "Phone", "PortraitId", "RoleId" },
                values: new object[] { 1, "", null, null, "tuannshe160097@fpt.edu.vn", "Admin", null, "0855068490", null, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperUsers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
