using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class UserSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AuctionSessions",
                columns: new[] { "Id", "Deleted", "EndDate", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 12, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, null, new DateTime(2023, 12, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, null, new DateTime(2023, 12, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, null, new DateTime(2023, 12, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 25, 7, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, null, new DateTime(2024, 1, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, null, new DateTime(2024, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, null, new DateTime(2023, 12, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, null, new DateTime(2023, 12, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 9, null, new DateTime(2023, 12, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Deleted", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, null, "Tiền cổ" },
                    { 2, null, null, "Nội thất" },
                    { 3, null, null, "Xe" },
                    { 4, null, null, "Trang sức" },
                    { 5, null, null, "Tranh" },
                    { 6, null, null, "Khoáng sản" },
                    { 7, null, null, "Văn tự" },
                    { 8, null, null, "Trang phục" },
                    { 9, null, null, "Đồ sưu tầm" },
                    { 10, null, null, "Văn tự" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Deleted", "Note", "Url" },
                values: new object[,]
                {
                    { 1, null, "Generated", "1fDReENNEAcCtkvWpvMwiF_HnqCdfHIOE" },
                    { 2, null, "Generated", "1VQyOksZ9hyEd3L84xEg2sbPy8-zsJWtG" },
                    { 3, null, "Generated", "1K1eSFe7JESqKVoj89U2cDKG76piC-29p" },
                    { 4, null, "Generated", "1zvORDR3ME5QAVdpdkvVhqC1I-cftwmeP" },
                    { 5, null, "Generated", "1DOJgh8UniAvTGW6inoLYgjN68XIlHTyR" }
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
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, "tuannshe160097@fpt.edu.vn", null, null, "Admin", null, null, "0855068490", null, 5, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, "1@fpt.edu.vn", null, null, "Admin", null, null, "08550684901", null, 1, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, "2@fpt.edu.vn", null, null, "Admin", null, null, "08550684902", null, 1, null },
                    { 4, null, null, null, null, null, null, null, null, null, null, null, "3@fpt.edu.vn", null, null, "Admin", null, null, "08550684903", null, 1, null },
                    { 5, null, null, null, null, null, null, null, null, null, null, null, "4@fpt.edu.vn", null, null, "Admin", null, null, "08550684904", null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BankAccountNum", "BankCode", "BankName", "CitizenId", "CitizenIdImageId", "City", "Deleted", "DeletedReason", "District", "DoB", "Email", "Gender", "HouseNumber", "IsVerified", "Name", "OtpExpiry", "OtpHash", "Phone", "PortraitId", "RoleId", "Street" },
                values: new object[,]
                {
                    { 10, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cổ Tân, số 58", true, "Phạm Phan Trang", null, null, "3770113400", null, 4, "" },
                    { 11, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Văn Tố, số 80", true, "Ngô Trương Quyền", null, null, "2351820611", null, 4, "" },
                    { 12, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phố Huế, số 15", true, "Phan Huỳnh Phương", null, null, "3614163732", null, 4, "" },
                    { 13, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Tư Giản, số 39", true, "Vũ Lê Quyền", null, null, "7642662077", null, 4, "" },
                    { 14, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Yết Kiêu, số 41", true, "Dương Phan Hào", null, null, "5642542317", null, 4, "" },
                    { 15, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Mã, số 83", true, "Lê Đặng Khánh", null, null, "8460300310", null, 4, "" },
                    { 16, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lý Thái Tổ, số 86", true, "Phan Vũ Huệ", null, null, "5688567336", null, 4, "" },
                    { 17, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Chiếu, số 49", true, "Bùi Vũ Hùng", null, null, "2803884552", null, 4, "" },
                    { 18, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Tạ Hiện, số 90", true, "Lê Trần Hữu", null, null, "7863215225", null, 4, "" },
                    { 19, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Du, số 1", true, "Lê Trần Khánh", null, null, "6683615868", null, 4, "" },
                    { 20, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Khắc Cần, số 74", true, "Đặng Đặng Thuần", null, null, "3417845816", null, 4, "" },
                    { 21, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Thợ Nhuộm, số 9", true, "Phạm Đinh Bảo", null, null, "7025473832", null, 4, "" },
                    { 22, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đình Ngang, số 7", true, "Trần Ngô Thi", null, null, "0152268443", null, 4, "" },
                    { 23, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Tống Duy Tân, số 70", true, "Đinh Phan Thi", null, null, "4718007611", null, 4, "" },
                    { 24, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Chả Cá, số 45", true, "Dương Bùi Trai", null, null, "5540540440", null, 4, "" },
                    { 25, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phan Bội Châu, số 25", true, "Phạm Võ Linh", null, null, "0623736020", null, 4, "" },
                    { 26, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Vải, số 22", true, "Vũ Huỳnh Quỳnh", null, null, "1186642505", null, 4, "" },
                    { 27, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Ô Quan Chưởng, số 42", true, "Hồ Trương Dương", null, null, "3036021362", null, 4, "" },
                    { 28, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đường Thành, số 40", true, "Ngô Trần Hồng", null, null, "0532766048", null, 4, "" },
                    { 29, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Gai, số 92", true, "Đinh Hồ Dũng", null, null, "0010510608", null, 4, "" },
                    { 30, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Trần Phú, số 28", true, "Đỗ Đinh Tuyết", null, null, "8045460304", null, 4, "" },
                    { 31, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lò Sũ, số 85", true, "Nguyễn Hồ Hoa", null, null, "2853263141", null, 4, "" },
                    { 32, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Ngõ Gạch, số 84", true, "Nguyễn Bùi Cúc", null, null, "7455064625", null, 4, "" },
                    { 33, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Chương Dương Độ, số 49", true, "Trương Đinh Chí", null, null, "2006602711", null, 4, "" },
                    { 34, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Trần Phú, số 21", true, "Đỗ Phạm Hường", null, null, "8611623254", null, 4, "" },
                    { 35, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Thuốc Bắc, số 53", true, "Bùi Bùi Liên", null, null, "1255887456", null, 4, "" },
                    { 36, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Chĩnh, số 1", true, "Hồ Ngô Linh", null, null, "7336634875", null, 4, "" },
                    { 37, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Gà, số 6", true, "Trần Phạm Ngọc", null, null, "8718023434", null, 4, "" },
                    { 38, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Bông, số 12", true, "Bùi Huỳnh Thảo", null, null, "5870627587", null, 4, "" },
                    { 39, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lê Văn Hưu, số 65", true, "Võ Dương Vinh", null, null, "1325764442", null, 4, "" },
                    { 40, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Bảo Khánh, số 40", true, "Nguyễn Huỳnh Dương", null, null, "1847888346", null, 4, "" },
                    { 41, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Siêu, số 29", true, "Phạm Võ Lành", null, null, "8532367842", null, 4, "" },
                    { 42, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Tre, số 84", true, "Hoàng Nguyễn Trang", null, null, "3732657811", null, 4, "" },
                    { 43, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lý Thường Kiệt, số 72", true, "Hoàng Nguyễn Vinh", null, null, "3230264678", null, 4, "" },
                    { 44, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lê Duẩn, số 14", true, "Trần Đỗ Hoa", null, null, "4441318837", null, 4, "" },
                    { 45, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Đồng, số 42", true, "Hồ Lê Nguyệt", null, null, "6016780344", null, 4, "" },
                    { 46, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cầu Gỗ, số 19", true, "Phan Vũ Yên", null, null, "5733664546", null, 4, "" },
                    { 47, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Mành, số 50", true, "Vũ Lê Yên", null, null, "0256127257", null, 4, "" },
                    { 48, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hồng Hà, số 35", true, "Phạm Võ Quân", null, null, "8348122733", null, 4, "" },
                    { 49, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đinh Lễ, số 33", true, "Đỗ Trương Trinh", null, null, "5002454811", null, 4, "" },
                    { 50, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cầu Gỗ, số 97", true, "Đặng Vũ Hương", null, null, "5488617008", null, 4, "" },
                    { 51, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Tràng Thi, số 43", true, "Phan Võ Khánh", null, null, "7222220618", null, 4, "" },
                    { 52, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cổ Tân, số 80", true, "Đỗ Nguyễn An", null, null, "6420764521", null, 4, "" },
                    { 53, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Bảo Khánh, số 20", true, "Trương Ngô Trang", null, null, "2151342530", null, 4, "" },
                    { 54, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Bông, số 49", true, "Vũ Bùi Anh", null, null, "6425220242", null, 4, "" },
                    { 55, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Văn Tố, số 22", true, "Võ Hồ Tuyến", null, null, "2023527138", null, 4, "" },
                    { 56, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Yết Kiêu, số 96", true, "Lê Hồ Diệu", null, null, "8540426315", null, 4, "" },
                    { 57, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Muối, số 79", true, "Dương Hoàng Trúc", null, null, "7247754447", null, 4, "" },
                    { 58, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Rươi, số 47", true, "Phan Đặng Đạt", null, null, "3132260851", null, 4, "" },
                    { 59, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lê Văn Hưu, số 57", true, "Vũ Lê Châu", null, null, "4624112015", null, 4, "" },
                    { 60, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Trần Nhật Duật, số 31", true, "Đỗ Huỳnh Viện", null, null, "0853184851", null, 4, "" },
                    { 61, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Lược, số 92", true, "Trần Lê Dũng", null, null, "8368310345", null, 4, "" },
                    { 62, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cầu Đông, số 45", true, "Đinh Đỗ Quân", null, null, "5060150654", null, 4, "" },
                    { 63, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Hữu Huân, số 12", true, "Nguyễn Phan Diệp", null, null, "7337684073", null, 4, "" },
                    { 64, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Tô Tịch, số 38", true, "Dương Bùi Chí", null, null, "7226565846", null, 4, "" },
                    { 65, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đình Ngang, số 12", true, "Trần Dương Tuyết", null, null, "4310667378", null, 4, "" },
                    { 66, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Bảo Khánh, số 88", true, "Hoàng Vũ Trinh", null, null, "0704663857", null, 4, "" },
                    { 67, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Tràng Thi, số 50", true, "Đinh Dương Mỹ", null, null, "3353853083", null, 4, "" },
                    { 68, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Chả Cá, số 45", true, "Nguyễn Võ Ngọc", null, null, "6523605576", null, 4, "" },
                    { 69, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Ô Quan Chưởng, số 71", true, "Đỗ Ngô Bảo", null, null, "2828562464", null, 4, "" },
                    { 70, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đồng Xuân, số 87", true, "Đỗ Đỗ Trinh", null, null, "6811050437", null, 4, "" },
                    { 71, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàm Tử Quan, số 94", true, "Võ Phạm Ngải", null, null, "1774006517", null, 4, "" },
                    { 72, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Buồm, số 83", true, "Phạm Trương Trinh", null, null, "2550802327", null, 4, "" },
                    { 73, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Chợ Gạo, số 59", true, "Trần Vũ Viện", null, null, "8467280486", null, 4, "" },
                    { 74, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Trần Quang Khải, số 85", true, "Hồ Vũ Ngải", null, null, "4544511776", null, 4, "" },
                    { 75, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Điếu, số 81", true, "Phạm Trần Phúc", null, null, "4743784550", null, 4, "" },
                    { 76, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lê Phụng Hiểu, số 42", true, "Ngô Đặng Tuân", null, null, "6305350345", null, 4, "" },
                    { 77, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Giầy, số 39", true, "Đinh Dương Tuấn", null, null, "5461227545", null, 4, "" },
                    { 78, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đoàn Nhữ Hài, số 1", true, "Võ Phan Bình", null, null, "0530042731", null, 4, "" },
                    { 79, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Bồ, số 38", true, "Dương Đỗ Nguyên", null, null, "2541462405", null, 4, "" },
                    { 80, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Vải, số 80", true, "Hoàng Bùi Liêm", null, null, "6180412708", null, 4, "" },
                    { 81, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Thuốc Bắc, số 14", true, "Ngô Lê Hường", null, null, "6784333605", null, 4, "" },
                    { 82, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Chả Cá, số 19", true, "Nguyễn Đỗ Loan", null, null, "6678425817", null, 4, "" },
                    { 83, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Gà, số 73", true, "Huỳnh Võ Tuấn", null, null, "1742707068", null, 4, "" },
                    { 84, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Du, số 32", true, "Phạm Ngô Thị", null, null, "0838146434", null, 4, "" },
                    { 85, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nhà Hỏa, số 19", true, "Dương Đỗ Đức", null, null, "6837485050", null, 4, "" },
                    { 86, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Quang Bích, số 63", true, "Võ Võ Diệu", null, null, "7653712406", null, 4, "" },
                    { 87, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hà Trung, số 29", true, "Võ Hồ From", null, null, "2033230087", null, 4, "" },
                    { 88, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phan Bội Châu, số 2", true, "Vũ Vũ Hoa", null, null, "7541542281", null, 4, "" },
                    { 89, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Mã, số 34", true, "Ngô Bùi Phượng", null, null, "4420773777", null, 4, "" },
                    { 90, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Cân, số 83", true, "Nguyễn Ngô Liêm", null, null, "2567878811", null, 4, "" },
                    { 91, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lý Nam Đế, số 82", true, "Vũ Đỗ Quyền", null, null, "0788285604", null, 4, "" },
                    { 92, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Thái Học, số 79", true, "Trương Phan Bảo", null, null, "7565876421", null, 4, "" },
                    { 93, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phùng Hưng, số 48", true, "Bùi Ngô Quý", null, null, "8868786623", null, 4, "" },
                    { 94, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyên Khiết, số 77", true, "Hoàng Huỳnh Quỳnh", null, null, "1243230718", null, 4, "" },
                    { 95, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cầu Đất, số 29", true, "Lê Đinh Lan", null, null, "4572430657", null, 4, "" },
                    { 96, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hồ Hoàn Kiếm, số 50", true, "Dương Trần Long", null, null, "0016028553", null, 4, "" },
                    { 97, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đào Duy Từ, số 13", true, "Trần Trương Viện", null, null, "6074708360", null, 4, "" },
                    { 98, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Siêu, số 63", true, "Trương Dương Huệ", null, null, "3658820874", null, 4, "" },
                    { 99, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Ngang, số 90", true, "Trần Đặng Linh", null, null, "3560110732", null, 4, "" },
                    { 100, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hồng Hà, số 27", true, "Trương Trần Chí", null, null, "6813813582", null, 4, "" },
                    { 101, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Mành, số 88", true, "Vũ Ngô Hoa", null, null, "1551647738", null, 4, "" },
                    { 102, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Thiếc, số 59", true, "Dương Nguyễn Thuần", null, null, "5517757773", null, 4, "" },
                    { 103, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Gai, số 58", true, "Hồ Trần Thu", null, null, "0870140303", null, 4, "" },
                    { 104, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đinh Tiên Hoàng, số 79", true, "Huỳnh Đỗ Sơn", null, null, "3180687116", null, 4, "" },
                    { 105, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Giấy, số 99", true, "Phan Huỳnh Dương", null, null, "4007838143", null, 4, "" },
                    { 106, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Thanh Yên, số 78", true, "Lê Đỗ From", null, null, "4032061606", null, 4, "" },
                    { 107, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Trần Nhật Duật, số 21", true, "Phan Đinh Hữu", null, null, "6351770841", null, 4, "" },
                    { 108, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Bảo Khánh, số 79", true, "Vũ Huỳnh Viện", null, null, "5661122350", null, 4, "" },
                    { 109, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phạm Sư Mạnh, số 55", true, "Võ Nguyễn Văn", null, null, "5176606851", null, 4, "" },
                    { 110, "Generated", "8623202530", "ICB", "VietinBank", "6421581861", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1977, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "106@gmail.com", "Female", "Mã Mây, số 48", true, "Nguyễn Nguyễn Diệu", null, null, "6608040514", 2, 3, "" },
                    { 111, "Generated", "8771083865", "ICB", "VietinBank", "0616854286", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2000, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "107@gmail.com", "Female", "Ngô Quyền, số 24", true, "Vũ Lê Hải", null, null, "2545230670", 4, 3, "" },
                    { 112, "Generated", "2754874688", "ICB", "VietinBank", "8103368243", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1984, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "108@gmail.com", "Female", "Chả Cá, số 77", true, "Đỗ Phan Hiếu", null, null, "5027023016", 5, 3, "" },
                    { 113, "Generated", "5747664075", "ICB", "VietinBank", "4866872036", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1983, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "109@gmail.com", "Female", "Lý Thường Kiệt, số 28", true, "Ngô Hoàng Tú", null, null, "3017001376", 1, 3, "" },
                    { 114, "Generated", "4233536180", "ICB", "VietinBank", "2486360121", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2002, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "110@gmail.com", "Female", "Nguyễn Văn Tố, số 13", true, "Hoàng Nguyễn Nam", null, null, "6676510354", 3, 3, "" },
                    { 115, "Generated", "6671465218", "ICB", "VietinBank", "1547872015", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1995, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "111@gmail.com", "Female", "Nhà Hỏa, số 39", true, "Đinh Đinh Nguyên", null, null, "6166204426", 4, 3, "" },
                    { 116, "Generated", "1861814076", "ICB", "VietinBank", "7318774833", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1996, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "112@gmail.com", "Female", "Tô Tịch, số 82", true, "Ngô Ngô Tiên", null, null, "5560373475", 5, 3, "" },
                    { 117, "Generated", "6230077456", "ICB", "VietinBank", "7443828877", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1983, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "113@gmail.com", "Female", "Trần Bình Trọng, số 1", true, "Ngô Nguyễn Hương", null, null, "0852068830", 5, 3, "" },
                    { 118, "Generated", "2403877853", "ICB", "VietinBank", "2308020586", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1974, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "114@gmail.com", "Female", "Hàng Cót, số 99", true, "Hồ Huỳnh Viên", null, null, "0580321573", 1, 3, "" },
                    { 119, "Generated", "4133131470", "ICB", "VietinBank", "5872333267", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1989, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "115@gmail.com", "Female", "Lương Ngọc Quyến, số 78", true, "Hoàng Phan Hồng", null, null, "0728344007", 4, 3, "" },
                    { 120, "Generated", "0078077223", "ICB", "VietinBank", "7517558430", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1993, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "116@gmail.com", "Female", "Hàng Hòm, số 74", true, "Đặng Vũ Viện", null, null, "6547742515", 1, 3, "" },
                    { 121, "Generated", "4023368332", "ICB", "VietinBank", "7820140705", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1974, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "117@gmail.com", "Female", "Hàng Giầy, số 53", true, "Võ Lê Tuyết", null, null, "8165134846", 4, 3, "" },
                    { 122, "Generated", "3001556461", "ICB", "VietinBank", "1433833320", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1976, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "118@gmail.com", "Female", "Hàng Giầy, số 30", true, "Đinh Hoàng Loan", null, null, "1358335505", 2, 3, "" },
                    { 123, "Generated", "6784610103", "ICB", "VietinBank", "1481520513", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1989, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "119@gmail.com", "Female", "Tràng Thi, số 7", true, "Nguyễn Phan Đình", null, null, "1328811887", 3, 3, "" },
                    { 124, "Generated", "3058448247", "ICB", "VietinBank", "0820621882", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1979, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "120@gmail.com", "Female", "Trần Hưng Đạo, số 83", true, "Hồ Đinh Quân", null, null, "2242188487", 3, 3, "" },
                    { 125, "Generated", "4623146717", "ICB", "VietinBank", "2020617143", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1989, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "121@gmail.com", "Female", "Hàng Giầy, số 67", true, "Nguyễn Hoàng Chí", null, null, "2002418881", 2, 3, "" },
                    { 126, "Generated", "7354321720", "ICB", "VietinBank", "8326541787", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "122@gmail.com", "Female", "Đoàn Nhữ Hài, số 9", true, "Đặng Ngô Hào", null, null, "0288100378", 5, 3, "" },
                    { 127, "Generated", "4077177440", "ICB", "VietinBank", "4621154232", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1984, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "123@gmail.com", "Female", "Thợ Nhuộm, số 91", true, "Phan Vũ Hào", null, null, "0775350404", 2, 3, "" },
                    { 128, "Generated", "4383244502", "ICB", "VietinBank", "2101700553", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1985, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "124@gmail.com", "Female", "Chân Cầm, số 21", true, "Hồ Phạm Trí", null, null, "8127337210", 2, 3, "" },
                    { 129, "Generated", "5261670408", "ICB", "VietinBank", "2767467085", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1994, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "125@gmail.com", "Female", "Yết Kiêu, số 9", true, "Dương Hồ Hào", null, null, "1601111587", 4, 3, "" },
                    { 130, "Generated", "0140774051", "ICB", "VietinBank", "2312585041", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1999, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "126@gmail.com", "Female", "Lương Văn Can, số 17", true, "Đỗ Phạm Thi", null, null, "7705473012", 3, 3, "" },
                    { 131, "Generated", "3224123004", "ICB", "VietinBank", "0833288738", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1997, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "127@gmail.com", "Female", "Điện Biên Phủ, số 46", true, "Đỗ Hoàng Thi", null, null, "8307225443", 4, 3, "" },
                    { 132, "Generated", "0343082873", "ICB", "VietinBank", "0748501014", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2001, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "128@gmail.com", "Female", "Hàng Chai, số 52", true, "Dương Ngô Quyên", null, null, "6050744232", 2, 3, "" },
                    { 133, "Generated", "7326165378", "ICB", "VietinBank", "4763820687", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1993, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "129@gmail.com", "Female", "Ngô Văn Sở, số 79", true, "Hồ Hồ Vinh", null, null, "4458512470", 4, 3, "" },
                    { 134, "Generated", "1328835810", "ICB", "VietinBank", "3881464705", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1989, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "130@gmail.com", "Female", "Ngõ Gạch, số 65", true, "Vũ Trương Hào", null, null, "8752424634", 2, 3, "" },
                    { 135, "Generated", "1554003476", "ICB", "VietinBank", "8762740124", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1993, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "131@gmail.com", "Female", "Nguyễn Tư Giản, số 10", true, "Vũ Hồ Nam", null, null, "8404358645", 1, 3, "" },
                    { 136, "Generated", "7032027256", "ICB", "VietinBank", "4422447052", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1985, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "132@gmail.com", "Female", "Hàng Đào, số 73", true, "Hồ Phan Hiếu", null, null, "0405000330", 2, 3, "" },
                    { 137, "Generated", "1481870443", "ICB", "VietinBank", "5603652507", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1975, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "133@gmail.com", "Female", "Hàng Chiếu, số 86", true, "Đỗ Hồ Hường", null, null, "4868487027", 2, 3, "" },
                    { 138, "Generated", "0363380600", "ICB", "VietinBank", "0588076716", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1999, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "134@gmail.com", "Female", "Hồ Hoàn Kiếm, số 81", true, "Đinh Huỳnh Bảo", null, null, "5083443587", 3, 3, "" },
                    { 139, "Generated", "3016088687", "ICB", "VietinBank", "0552545105", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1974, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "135@gmail.com", "Female", "Hàng Thiếc, số 14", true, "Dương Huỳnh Kim", null, null, "1800864500", 5, 3, "" },
                    { 140, "Generated", "3312778341", "ICB", "VietinBank", "4466810728", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1995, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "136@gmail.com", "Female", "Thợ Nhuộm, số 62", true, "Huỳnh Ngô Cam", null, null, "1211603385", 4, 3, "" },
                    { 141, "Generated", "8101640385", "ICB", "VietinBank", "8087404444", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1994, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "137@gmail.com", "Female", "Hàng Đào, số 37", true, "Trần Huỳnh Lan", null, null, "3170056355", 2, 3, "" },
                    { 142, "Generated", "7284743641", "ICB", "VietinBank", "7551144413", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1984, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "138@gmail.com", "Female", "Lê Phụng Hiểu, số 92", true, "Phan Nguyễn Nguyên", null, null, "5335202775", 3, 3, "" },
                    { 143, "Generated", "4133347384", "ICB", "VietinBank", "7068884505", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2000, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "139@gmail.com", "Female", "Lãn Ông, số 30", true, "Võ Đặng Diệp", null, null, "8166835055", 3, 3, "" },
                    { 144, "Generated", "1263886222", "ICB", "VietinBank", "6122843110", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1996, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "140@gmail.com", "Female", "Phạm Ngũ Lão, số 41", true, "Đinh Phan Quyền", null, null, "1745727227", 1, 3, "" },
                    { 145, "Generated", "5871611385", "ICB", "VietinBank", "8161708178", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1978, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "141@gmail.com", "Female", "Lương Ngọc Quyến, số 96", true, "Ngô Nguyễn Đạt", null, null, "5636722862", 1, 3, "" },
                    { 146, "Generated", "7878267846", "ICB", "VietinBank", "2664237480", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1977, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "142@gmail.com", "Female", "Bát Đàn, số 41", true, "Dương Vũ Hồng", null, null, "1113614525", 5, 3, "" },
                    { 147, "Generated", "5418673220", "ICB", "VietinBank", "7521362685", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1975, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "143@gmail.com", "Female", "Nguyễn Quang Bích, số 41", true, "Ngô Trương Thảo", null, null, "8444350475", 4, 3, "" },
                    { 148, "Generated", "6341501821", "ICB", "VietinBank", "6156373370", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2004, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "144@gmail.com", "Female", "Bạch Đằng, số 84", true, "Lê Nguyễn Phượng", null, null, "6680401223", 2, 3, "" },
                    { 149, "Generated", "0415510018", "ICB", "VietinBank", "1602058814", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1994, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "145@gmail.com", "Female", "Gia Ngư, số 32", true, "Bùi Phạm Nam", null, null, "6136223035", 5, 3, "" },
                    { 150, "Generated", "0471015667", "ICB", "VietinBank", "7721707430", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2004, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "146@gmail.com", "Female", "Lý Quốc Sư, số 86", true, "Lê Trương Diệu", null, null, "4824476257", 4, 3, "" },
                    { 151, "Generated", "3561530566", "ICB", "VietinBank", "2583521040", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2001, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "147@gmail.com", "Female", "Cầu Đất, số 82", true, "Bùi Đinh Huệ", null, null, "7154623531", 2, 3, "" },
                    { 152, "Generated", "5250683004", "ICB", "VietinBank", "3266217310", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1989, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "148@gmail.com", "Female", "Lê Thánh Tông, số 64", true, "Phạm Trương Mỹ", null, null, "7488877777", 2, 3, "" },
                    { 153, "Generated", "5015778840", "ICB", "VietinBank", "6046725124", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "149@gmail.com", "Female", "Lý Nam Đế, số 46", true, "Đỗ Trần Lành", null, null, "3326203153", 4, 3, "" },
                    { 154, "Generated", "2440835511", "ICB", "VietinBank", "8006744217", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1988, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "150@gmail.com", "Female", "Cổ Tân, số 19", true, "Vũ Đỗ Huy", null, null, "1424574452", 3, 3, "" },
                    { 155, "Generated", "3760424830", "ICB", "VietinBank", "7825621743", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "151@gmail.com", "Female", "Lãn Ông, số 82", true, "Hoàng Vũ Linh", null, null, "4055206314", 4, 3, "" },
                    { 156, "Generated", "0803282025", "ICB", "VietinBank", "3434203656", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1992, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "152@gmail.com", "Female", "Cầu Đất, số 98", true, "Lê Nguyễn Kim", null, null, "4780352058", 3, 3, "" },
                    { 157, "Generated", "0015207465", "ICB", "VietinBank", "8550486717", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1985, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "153@gmail.com", "Female", "Đình Ngang, số 16", true, "Đặng Phan Bảo", null, null, "5868476652", 2, 3, "" },
                    { 158, "Generated", "3114386850", "ICB", "VietinBank", "7265764153", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1991, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "154@gmail.com", "Female", "Yết Kiêu, số 67", true, "Vũ Phan Liêm", null, null, "2608361536", 5, 3, "" },
                    { 159, "Generated", "4600435747", "ICB", "VietinBank", "2421711430", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1978, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "155@gmail.com", "Female", "Hàng Đào, số 0", true, "Hoàng Nguyễn Tuân", null, null, "1427116523", 3, 3, "" },
                    { 160, "Generated", "5245707566", "ICB", "VietinBank", "0657604237", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1985, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "156@gmail.com", "Female", "Trần Khánh Dư, số 79", true, "Trần Nguyễn Hùng", null, null, "4743088150", 5, 2, "" },
                    { 161, "Generated", "2840037842", "ICB", "VietinBank", "1486504253", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1986, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "157@gmail.com", "Female", "Lương Văn Can, số 12", true, "Bùi Trương Dũng", null, null, "7113685586", 5, 2, "" },
                    { 162, "Generated", "4133574400", "ICB", "VietinBank", "5073323027", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2001, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "158@gmail.com", "Female", "Cổng Đục, số 26", true, "Đặng Đinh Hải", null, null, "1637368862", 2, 2, "" },
                    { 163, "Generated", "0168267682", "ICB", "VietinBank", "3142313577", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1981, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "159@gmail.com", "Female", "Chân Cầm, số 38", true, "Ngô Trương Quyên", null, null, "3814521582", 4, 2, "" },
                    { 164, "Generated", "5775318207", "ICB", "VietinBank", "4810335745", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "160@gmail.com", "Female", "Phạm Sư Mạnh, số 86", true, "Hoàng Võ Thanh", null, null, "7016001656", 1, 2, "" },
                    { 165, "Generated", "7267776083", "ICB", "VietinBank", "5701441674", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1981, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "161@gmail.com", "Female", "Phủ Doãn, số 0", true, "Vũ Trần Thùy", null, null, "2386816650", 5, 2, "" },
                    { 166, "Generated", "4201066301", "ICB", "VietinBank", "7341218320", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2003, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "162@gmail.com", "Female", "Trần Nhật Duật, số 21", true, "Võ Đinh Đức", null, null, "0268137160", 2, 2, "" },
                    { 167, "Generated", "3243050664", "ICB", "VietinBank", "0487076401", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1977, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "163@gmail.com", "Female", "Hàng Cân, số 54", true, "Bùi Trần Quyền", null, null, "8168871335", 1, 2, "" },
                    { 168, "Generated", "4453736544", "ICB", "VietinBank", "0824780107", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2001, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "164@gmail.com", "Female", "Hàng Đậu, số 59", true, "Phan Ngô Trai", null, null, "1304067713", 1, 2, "" },
                    { 169, "Generated", "5316162684", "ICB", "VietinBank", "5047502575", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1983, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), "165@gmail.com", "Female", "Nguyễn Chế Nghĩa, số 82", true, "Phan Vũ Văn", null, null, "7287251836", 1, 2, "" }
                });

            migrationBuilder.InsertData(
                table: "SellerApplications",
                columns: new[] { "Id", "Address", "BankAccountNum", "BankCode", "BankName", "CitizenId", "CitizenIdImageId", "City", "Content", "Deleted", "District", "DoB", "Email", "Gender", "HouseNumber", "PortraitId", "Status", "Street", "UserId" },
                values: new object[,]
                {
                    { 1, "Generated", "8623202530", "ICB", "VietinBank", "6421581861", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1977, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "106@gmail.com", "Female", "Mã Mây, số 48", 2, 2, "", 110 },
                    { 2, "Generated", "8771083865", "ICB", "VietinBank", "0616854286", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2000, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "107@gmail.com", "Female", "Ngô Quyền, số 24", 4, 2, "", 111 },
                    { 3, "Generated", "2754874688", "ICB", "VietinBank", "8103368243", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1984, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "108@gmail.com", "Female", "Chả Cá, số 77", 5, 2, "", 112 },
                    { 4, "Generated", "5747664075", "ICB", "VietinBank", "4866872036", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1983, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "109@gmail.com", "Female", "Lý Thường Kiệt, số 28", 1, 2, "", 113 },
                    { 5, "Generated", "4233536180", "ICB", "VietinBank", "2486360121", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2002, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "110@gmail.com", "Female", "Nguyễn Văn Tố, số 13", 3, 2, "", 114 },
                    { 6, "Generated", "6671465218", "ICB", "VietinBank", "1547872015", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1995, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "111@gmail.com", "Female", "Nhà Hỏa, số 39", 4, 2, "", 115 },
                    { 7, "Generated", "1861814076", "ICB", "VietinBank", "7318774833", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1996, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "112@gmail.com", "Female", "Tô Tịch, số 82", 5, 2, "", 116 },
                    { 8, "Generated", "6230077456", "ICB", "VietinBank", "7443828877", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1983, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "113@gmail.com", "Female", "Trần Bình Trọng, số 1", 5, 2, "", 117 },
                    { 9, "Generated", "2403877853", "ICB", "VietinBank", "2308020586", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1974, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "114@gmail.com", "Female", "Hàng Cót, số 99", 1, 2, "", 118 },
                    { 10, "Generated", "4133131470", "ICB", "VietinBank", "5872333267", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1989, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "115@gmail.com", "Female", "Lương Ngọc Quyến, số 78", 4, 2, "", 119 },
                    { 11, "Generated", "0078077223", "ICB", "VietinBank", "7517558430", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1993, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "116@gmail.com", "Female", "Hàng Hòm, số 74", 1, 2, "", 120 },
                    { 12, "Generated", "4023368332", "ICB", "VietinBank", "7820140705", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1974, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "117@gmail.com", "Female", "Hàng Giầy, số 53", 4, 2, "", 121 },
                    { 13, "Generated", "3001556461", "ICB", "VietinBank", "1433833320", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1976, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "118@gmail.com", "Female", "Hàng Giầy, số 30", 2, 2, "", 122 },
                    { 14, "Generated", "6784610103", "ICB", "VietinBank", "1481520513", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1989, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "119@gmail.com", "Female", "Tràng Thi, số 7", 3, 2, "", 123 },
                    { 15, "Generated", "3058448247", "ICB", "VietinBank", "0820621882", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1979, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "120@gmail.com", "Female", "Trần Hưng Đạo, số 83", 3, 2, "", 124 },
                    { 16, "Generated", "4623146717", "ICB", "VietinBank", "2020617143", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1989, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "121@gmail.com", "Female", "Hàng Giầy, số 67", 2, 2, "", 125 },
                    { 17, "Generated", "7354321720", "ICB", "VietinBank", "8326541787", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1992, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "122@gmail.com", "Female", "Đoàn Nhữ Hài, số 9", 5, 2, "", 126 },
                    { 18, "Generated", "4077177440", "ICB", "VietinBank", "4621154232", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1984, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "123@gmail.com", "Female", "Thợ Nhuộm, số 91", 2, 2, "", 127 },
                    { 19, "Generated", "4383244502", "ICB", "VietinBank", "2101700553", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1985, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "124@gmail.com", "Female", "Chân Cầm, số 21", 2, 2, "", 128 },
                    { 20, "Generated", "5261670408", "ICB", "VietinBank", "2767467085", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1994, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "125@gmail.com", "Female", "Yết Kiêu, số 9", 4, 2, "", 129 },
                    { 21, "Generated", "0140774051", "ICB", "VietinBank", "2312585041", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1999, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "126@gmail.com", "Female", "Lương Văn Can, số 17", 3, 2, "", 130 },
                    { 22, "Generated", "3224123004", "ICB", "VietinBank", "0833288738", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1997, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "127@gmail.com", "Female", "Điện Biên Phủ, số 46", 4, 2, "", 131 },
                    { 23, "Generated", "0343082873", "ICB", "VietinBank", "0748501014", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2001, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "128@gmail.com", "Female", "Hàng Chai, số 52", 2, 2, "", 132 },
                    { 24, "Generated", "7326165378", "ICB", "VietinBank", "4763820687", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1993, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "129@gmail.com", "Female", "Ngô Văn Sở, số 79", 4, 2, "", 133 },
                    { 25, "Generated", "1328835810", "ICB", "VietinBank", "3881464705", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1989, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "130@gmail.com", "Female", "Ngõ Gạch, số 65", 2, 2, "", 134 },
                    { 26, "Generated", "1554003476", "ICB", "VietinBank", "8762740124", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1993, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "131@gmail.com", "Female", "Nguyễn Tư Giản, số 10", 1, 2, "", 135 },
                    { 27, "Generated", "7032027256", "ICB", "VietinBank", "4422447052", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1985, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "132@gmail.com", "Female", "Hàng Đào, số 73", 2, 2, "", 136 },
                    { 28, "Generated", "1481870443", "ICB", "VietinBank", "5603652507", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1975, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "133@gmail.com", "Female", "Hàng Chiếu, số 86", 2, 2, "", 137 },
                    { 29, "Generated", "0363380600", "ICB", "VietinBank", "0588076716", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1999, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "134@gmail.com", "Female", "Hồ Hoàn Kiếm, số 81", 3, 2, "", 138 },
                    { 30, "Generated", "3016088687", "ICB", "VietinBank", "0552545105", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1974, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "135@gmail.com", "Female", "Hàng Thiếc, số 14", 5, 2, "", 139 },
                    { 31, "Generated", "3312778341", "ICB", "VietinBank", "4466810728", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1995, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "136@gmail.com", "Female", "Thợ Nhuộm, số 62", 4, 2, "", 140 },
                    { 32, "Generated", "8101640385", "ICB", "VietinBank", "8087404444", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1994, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "137@gmail.com", "Female", "Hàng Đào, số 37", 2, 2, "", 141 },
                    { 33, "Generated", "7284743641", "ICB", "VietinBank", "7551144413", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1984, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "138@gmail.com", "Female", "Lê Phụng Hiểu, số 92", 3, 2, "", 142 },
                    { 34, "Generated", "4133347384", "ICB", "VietinBank", "7068884505", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2000, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "139@gmail.com", "Female", "Lãn Ông, số 30", 3, 2, "", 143 },
                    { 35, "Generated", "1263886222", "ICB", "VietinBank", "6122843110", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1996, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "140@gmail.com", "Female", "Phạm Ngũ Lão, số 41", 1, 2, "", 144 },
                    { 36, "Generated", "5871611385", "ICB", "VietinBank", "8161708178", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1978, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "141@gmail.com", "Female", "Lương Ngọc Quyến, số 96", 1, 2, "", 145 },
                    { 37, "Generated", "7878267846", "ICB", "VietinBank", "2664237480", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1977, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "142@gmail.com", "Female", "Bát Đàn, số 41", 5, 2, "", 146 },
                    { 38, "Generated", "5418673220", "ICB", "VietinBank", "7521362685", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1975, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "143@gmail.com", "Female", "Nguyễn Quang Bích, số 41", 4, 2, "", 147 },
                    { 39, "Generated", "6341501821", "ICB", "VietinBank", "6156373370", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2004, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "144@gmail.com", "Female", "Bạch Đằng, số 84", 2, 2, "", 148 },
                    { 40, "Generated", "0415510018", "ICB", "VietinBank", "1602058814", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1994, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "145@gmail.com", "Female", "Gia Ngư, số 32", 5, 2, "", 149 },
                    { 41, "Generated", "0471015667", "ICB", "VietinBank", "7721707430", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2004, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "146@gmail.com", "Female", "Lý Quốc Sư, số 86", 4, 2, "", 150 },
                    { 42, "Generated", "3561530566", "ICB", "VietinBank", "2583521040", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2001, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "147@gmail.com", "Female", "Cầu Đất, số 82", 2, 2, "", 151 },
                    { 43, "Generated", "5250683004", "ICB", "VietinBank", "3266217310", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1989, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "148@gmail.com", "Female", "Lê Thánh Tông, số 64", 2, 2, "", 152 },
                    { 44, "Generated", "5015778840", "ICB", "VietinBank", "6046725124", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "149@gmail.com", "Female", "Lý Nam Đế, số 46", 4, 2, "", 153 },
                    { 45, "Generated", "2440835511", "ICB", "VietinBank", "8006744217", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1988, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "150@gmail.com", "Female", "Cổ Tân, số 19", 3, 2, "", 154 },
                    { 46, "Generated", "3760424830", "ICB", "VietinBank", "7825621743", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "151@gmail.com", "Female", "Lãn Ông, số 82", 4, 2, "", 155 },
                    { 47, "Generated", "0803282025", "ICB", "VietinBank", "3434203656", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1992, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "152@gmail.com", "Female", "Cầu Đất, số 98", 3, 2, "", 156 },
                    { 48, "Generated", "0015207465", "ICB", "VietinBank", "8550486717", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1985, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "153@gmail.com", "Female", "Đình Ngang, số 16", 2, 2, "", 157 },
                    { 49, "Generated", "3114386850", "ICB", "VietinBank", "7265764153", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1991, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "154@gmail.com", "Female", "Yết Kiêu, số 67", 5, 2, "", 158 },
                    { 50, "Generated", "4600435747", "ICB", "VietinBank", "2421711430", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1978, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "155@gmail.com", "Female", "Hàng Đào, số 0", 3, 2, "", 159 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SellerApplications",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 169);

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
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
