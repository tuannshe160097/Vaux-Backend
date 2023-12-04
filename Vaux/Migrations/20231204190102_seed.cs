﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vaux.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemProperties_Items_ItemId",
                table: "ItemProperties");

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "ItemProperties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                    { 6, null, new DateTime(2024, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), 2 }
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
                    { 5, null, "Generated", "1DOJgh8UniAvTGW6inoLYgjN68XIlHTyR" },
                    { 6, null, "Generated", "1fDReENNEAcCtkvWpvMwiF_HnqCdfHIOE" },
                    { 7, null, "Generated", "1VQyOksZ9hyEd3L84xEg2sbPy8-zsJWtG" },
                    { 8, null, "Generated", "1K1eSFe7JESqKVoj89U2cDKG76piC-29p" },
                    { 9, null, "Generated", "1zvORDR3ME5QAVdpdkvVhqC1I-cftwmeP" },
                    { 10, null, "Generated", "1DOJgh8UniAvTGW6inoLYgjN68XIlHTyR" },
                    { 11, null, "Generated", "1lQ1eUCDXVnMnDqxPa3RTztk0N3qsHyvP" },
                    { 12, null, "Generated", "1upsVLimN8xaZ3peARfPntWJu4Gj7P1WP" },
                    { 13, null, "Generated", "1A5-phXoxhKIRiqj8YnoD5oWqk2Ua629C" },
                    { 14, null, "Generated", "100fLwWf0t5_EYifXqeAjS5DmEBHRNpYg" },
                    { 15, null, "Generated", "1cRRj3h8NXCRTsMAilFVDSORt3Txx0bwb" },
                    { 16, null, "Generated", "162A-xxZ8q1K5E5ehkWfCBgtn9VlVs4dD" },
                    { 17, null, "Generated", "1sCVdJSyIRpE2n6IJSnbExc13g6F8RA-T" },
                    { 18, null, "Generated", "119tVm9ti33pV3Zk_C4cfdLu5mGFZXZiF" },
                    { 19, null, "Generated", "1q4jdxdrd7FQ5YEj4LWkegJf5nuTk3BfH" },
                    { 20, null, "Generated", "1qD6au1YKFsojnM5Mt2NjFYR4KJDaCik4" },
                    { 21, null, "Generated", "1r4m0I9fD26xSpajZ4Qu73fzxVaKQeJlS" },
                    { 22, null, "Generated", "178SmSAqmPuGEyQPyJCyd5THNPlEgTE4Z" },
                    { 23, null, "Generated", "1nohUVvOL337CV23LZZsnT5D56uobcnZ9" },
                    { 24, null, "Generated", "17xEyhtmDMs9JneeDF6TkH3jJWK9MDzS5" },
                    { 25, null, "Generated", "1qzvXnG78BxPyC5PxKnUIHWRYI0ufqloP" },
                    { 26, null, "Generated", "147tE9lV93qgZomyJVb86jmxD4cnAqJ0Z" },
                    { 27, null, "Generated", "1P1veS-lU9Fv0xdJOHGzct4DsXk1EfS1F" },
                    { 28, null, "Generated", "18qsoYjvijfns4VY5XxmVNFI7tNcG2GrA" },
                    { 29, null, "Generated", "1H5lFn65qyRs9x0nsmt4K8iZczjTpQEEE" },
                    { 30, null, "Generated", "1WJsssktOTp07ZqOnbXuRoohL9YZs4w" },
                    { 31, null, "Generated", "1f4LwIzuVi23ZW0mWqqkpN2jfNo9-x72y" },
                    { 32, null, "Generated", "1A0N3nCeubMNex28OyATYhgst5ViJYKoc" },
                    { 33, null, "Generated", "1spuK7h5S2P0IqCuj0tHGi5smcNl5q792" },
                    { 34, null, "Generated", "1ovvnNMv0008C_Q1pwbxhN8ER-wI4xF" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Admin");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BankAccountNum", "BankCode", "BankName", "CitizenId", "CitizenIdImageId", "City", "Deleted", "DeletedReason", "District", "DoB", "Email", "Gender", "HouseNumber", "Name", "OtpExpiry", "OtpHash", "Phone", "PortraitId", "RoleId", "Street" },
                values: new object[,]
                {
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
                    { 10, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đinh Liệt, số 77", true, "Phạm Huỳnh Vinh", null, null, "5085562520", null, 4, "" },
                    { 11, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Trần Khánh Dư, số 67", true, "Vũ Đỗ Quyền", null, null, "2242210482", null, 4, "" },
                    { 12, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Ngõ Trạm, số 38", true, "Hồ Huỳnh Hằng", null, null, "6743747420", null, 4, "" },
                    { 13, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Thanh Yên, số 25", true, "Trương Trương Vinh", null, null, "2134234563", null, 4, "" },
                    { 14, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cầu Đông, số 42", true, "Võ Đỗ Diệu", null, null, "8505238572", null, 4, "" },
                    { 15, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Bồ, số 27", true, "Phạm Phạm Thu", null, null, "7784812132", null, 4, "" },
                    { 16, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cầu Đất, số 78", true, "Võ Bùi Quý", null, null, "0810012628", null, 4, "" },
                    { 17, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cầu Đông, số 10", true, "Đặng Võ Quyên", null, null, "5222565440", null, 4, "" },
                    { 18, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Ngõ Gạch, số 50", true, "Phan Lê Quang", null, null, "1144255011", null, 4, "" },
                    { 19, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Xí, số 39", true, "Vũ Võ Quyền", null, null, "5505687434", null, 4, "" },
                    { 20, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Bông, số 11", true, "Nguyễn Phạm Diệu", null, null, "7541720181", null, 4, "" },
                    { 21, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Bạc, số 86", true, "Huỳnh Bùi Chí", null, null, "5888403041", null, 4, "" },
                    { 22, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Đường, số 65", true, "Phan Phan Bảo", null, null, "1817376461", null, 4, "" },
                    { 23, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phố Huế, số 49", true, "Huỳnh Bùi Tuyến", null, null, "6642834643", null, 4, "" },
                    { 24, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đường Thành, số 0", true, "Dương Trương Diệu", null, null, "6811010352", null, 4, "" },
                    { 25, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lý Nam Đế, số 8", true, "Trương Phạm Quý", null, null, "4358351704", null, 4, "" },
                    { 26, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Bồ, số 5", true, "Đặng Vũ Trí", null, null, "1732443824", null, 4, "" },
                    { 27, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đinh Liệt, số 48", true, "Phan Phạm Diệu", null, null, "7384888058", null, 4, "" },
                    { 28, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lý Đạo Thành, số 76", true, "Lê Phan Hường", null, null, "8384000824", null, 4, "" },
                    { 29, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lương Ngọc Quyến, số 0", true, "Hoàng Ngô Tú", null, null, "1368512141", null, 4, "" },
                    { 30, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Bài, số 74", true, "Đỗ Phan Quyên", null, null, "2127523288", null, 4, "" },
                    { 31, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Đường, số 80", true, "Bùi Hoàng Long", null, null, "3557613182", null, 4, "" },
                    { 32, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nhà Hỏa, số 92", true, "Hồ Nguyễn Trai", null, null, "3252182474", null, 4, "" },
                    { 33, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Điện Biên Phủ, số 94", true, "Hồ Đinh Hồng", null, null, "6516661057", null, 4, "" },
                    { 34, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Chả Cá, số 87", true, "Phạm Trần Trinh", null, null, "8881548377", null, 4, "" },
                    { 35, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Thợ Nhuộm, số 29", true, "Phạm Phạm Viện", null, null, "1510500661", null, 4, "" },
                    { 36, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Văn Tố, số 48", true, "Ngô Phạm Huy", null, null, "8887481533", null, 4, "" },
                    { 37, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nhà Hỏa, số 40", true, "Dương Phạm Dương", null, null, "5266627288", null, 4, "" },
                    { 38, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Mã, số 79", true, "Nguyễn Đinh Thu", null, null, "2884721868", null, 4, "" },
                    { 39, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Thiếp, số 60", true, "Lê Đặng Vinh", null, null, "6661583160", null, 4, "" },
                    { 40, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Rươi, số 68", true, "Vũ Hoàng An", null, null, "6850172701", null, 4, "" },
                    { 41, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cửa Nam, số 71", true, "Dương Đỗ Hà", null, null, "2051114044", null, 4, "" },
                    { 42, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phố Huế, số 16", true, "Phan Hồ Quý", null, null, "5101203648", null, 4, "" },
                    { 43, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Hòm, số 22", true, "Hoàng Dương Đức", null, null, "5330700763", null, 4, "" },
                    { 44, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Lê Văn Hưu, số 64", true, "Dương Hoàng Diệp", null, null, "0033511745", null, 4, "" },
                    { 45, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Tràng Thi, số 99", true, "Trương Vũ Hương", null, null, "3782742155", null, 4, "" },
                    { 46, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cửa Nam, số 87", true, "Võ Trương Tuyến", null, null, "1122844238", null, 4, "" },
                    { 47, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đồng Xuân, số 2", true, "Đỗ Hồ Thi", null, null, "7850048856", null, 4, "" },
                    { 48, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Quang Trung, số 44", true, "Dương Trương Nhung", null, null, "7704460721", null, 4, "" },
                    { 49, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Khay, số 14", true, "Phạm Hoàng Phúc", null, null, "8367757264", null, 4, "" },
                    { 50, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàn Thuyên, số 11", true, "Đỗ Nguyễn Hoa", null, null, "5643144300", null, 4, "" },
                    { 51, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Bè, số 22", true, "Đinh Bùi Hương", null, null, "8351621883", null, 4, "" },
                    { 52, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Muối, số 12", true, "Phan Trần Sơn", null, null, "4431410118", null, 4, "" },
                    { 53, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Ấu Triệu, số 18", true, "Võ Ngô Phương", null, null, "5425576367", null, 4, "" },
                    { 54, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Quán Sứ, số 29", true, "Hồ Lê Lan", null, null, "8137526138", null, 4, "" },
                    { 55, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Điếu, số 11", true, "Ngô Trần Nhung", null, null, "2427633633", null, 4, "" },
                    { 56, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Du, số 78", true, "Đinh Võ Tuấn", null, null, "3418836807", null, 4, "" },
                    { 57, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cửa Đông, số 76", true, "Trương Võ Yên", null, null, "6204584726", null, 4, "" },
                    { 58, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Tư Giản, số 76", true, "Trương Trương Diệp", null, null, "1062530328", null, 4, "" },
                    { 59, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phủ Doãn, số 44", true, "Hồ Bùi Tú", null, null, "0485548071", null, 4, "" },
                    { 60, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Hòm, số 99", true, "Đặng Hồ Thu", null, null, "7643575513", null, 4, "" },
                    { 61, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phạm Sư Mạnh, số 74", true, "Phạm Đinh Yên", null, null, "3374604372", null, 4, "" },
                    { 62, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cao Thắng, số 94", true, "Vũ Hồ Tuân", null, null, "6117071728", null, 4, "" },
                    { 63, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Bảo Khánh, số 43", true, "Võ Huỳnh Quỳnh", null, null, "5257736343", null, 4, "" },
                    { 64, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đinh Liệt, số 34", true, "Hoàng Trương Phương", null, null, "7543556731", null, 4, "" },
                    { 65, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Tôn Thất Thiệp, số 65", true, "Đinh Ngô Quỳnh", null, null, "1517583122", null, 4, "" },
                    { 66, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Mắm, số 53", true, "Đinh Vũ Diệp", null, null, "4367063443", null, 4, "" },
                    { 67, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Buồm, số 68", true, "Phan Võ Đức", null, null, "7161170744", null, 4, "" },
                    { 68, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cửa Nam, số 62", true, "Hồ Trần Quỳnh", null, null, "6037577655", null, 4, "" },
                    { 69, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Thanh Hà, số 55", true, "Võ Bùi Dương", null, null, "5257470427", null, 4, "" },
                    { 70, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đào Duy Từ, số 34", true, "Đinh Võ Chí", null, null, "2137588306", null, 4, "" },
                    { 71, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Xí, số 15", true, "Đặng Phan Bình", null, null, "6337717357", null, 4, "" },
                    { 72, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Bạch Đằng, số 48", true, "Bùi Dương Ngọc", null, null, "1530356775", null, 4, "" },
                    { 73, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hỏa Lò, số 96", true, "Vũ Ngô Tiên", null, null, "3088002243", null, 4, "" },
                    { 74, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cầu Đất, số 21", true, "Trần Trương Ngải", null, null, "4837420016", null, 4, "" },
                    { 75, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đông Thái, số 99", true, "Đinh Huỳnh Trí", null, null, "2331454081", null, 4, "" },
                    { 76, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Chả Cá, số 99", true, "Huỳnh Đinh Trang", null, null, "7777164551", null, 4, "" },
                    { 77, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Đồng Xuân, số 50", true, "Đinh Hồ Loan", null, null, "4602004542", null, 4, "" },
                    { 78, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Văn Tố, số 18", true, "Ngô Đặng Thu", null, null, "8221716504", null, 4, "" },
                    { 79, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Trần Bình Trọng, số 23", true, "Võ Phạm Kim", null, null, "6668622468", null, 4, "" },
                    { 80, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Thiếc, số 19", true, "Đỗ Nguyễn Châu", null, null, "7080105547", null, 4, "" },
                    { 81, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phan Đình Phùng, số 40", true, "Đỗ Đặng Phúc", null, null, "2662520402", null, 4, "" },
                    { 82, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phạm Sư Mạnh, số 94", true, "Nguyễn Nguyễn Huệ", null, null, "8307567660", null, 4, "" },
                    { 83, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Siêu, số 46", true, "Đỗ Phan Trí", null, null, "2164564088", null, 4, "" },
                    { 84, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cao Thắng, số 59", true, "Trương Đinh Văn", null, null, "3040738213", null, 4, "" },
                    { 85, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Triệu Quốc Đạt, số 89", true, "Võ Phạm Cúc", null, null, "2731858046", null, 4, "" },
                    { 86, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phạm Ngũ Lão, số 9", true, "Hoàng Hồ Nguyệt", null, null, "2872685224", null, 4, "" },
                    { 87, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cổ Tân, số 41", true, "Vũ Nguyễn Vân", null, null, "6583680677", null, 4, "" },
                    { 88, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Lược, số 70", true, "Đặng Trương Đình", null, null, "1742151545", null, 4, "" },
                    { 89, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Gà, số 30", true, "Lê Hoàng Yên", null, null, "6384872608", null, 4, "" },
                    { 90, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Gia Thiều, số 7", true, "Bùi Dương Liêm", null, null, "8577333284", null, 4, "" },
                    { 91, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Quang Trung, số 1", true, "Hồ Trần Khánh", null, null, "3801180445", null, 4, "" },
                    { 92, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hồ Hoàn Kiếm, số 33", true, "Huỳnh Trần Cam", null, null, "3111606212", null, 4, "" },
                    { 93, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phùng Hưng, số 53", true, "Dương Lê Lan", null, null, "8800421722", null, 4, "" },
                    { 94, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Vọng Đức, số 83", true, "Đỗ Bùi Tuyến", null, null, "3088146280", null, 4, "" },
                    { 95, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Thái Học, số 83", true, "Phạm Hoàng Viện", null, null, "7841580377", null, 4, "" },
                    { 96, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Tư Giản, số 72", true, "Phạm Đặng Bình", null, null, "7206821177", null, 4, "" },
                    { 97, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phạm Sư Mạnh, số 94", true, "Huỳnh Bùi Đạt", null, null, "5283485255", null, 4, "" },
                    { 98, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phúc Tân, số 43", true, "Đỗ Ngô Thanh", null, null, "1631244284", null, 4, "" },
                    { 99, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Bảo Khánh, số 61", true, "Phạm Đinh Lan", null, null, "2831183438", null, 4, "" },
                    { 100, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Thiếp, số 70", true, "Trần Nguyễn Vinh", null, null, "6807632862", null, 4, "" },
                    { 101, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Phủ Doãn, số 4", true, "Hồ Phạm Vinh", null, null, "1801221088", null, 4, "" },
                    { 102, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyễn Thiện Thuật, số 5", true, "Nguyễn Trần Thị", null, null, "4113766758", null, 4, "" },
                    { 103, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hai Bà Trưng, số 85", true, "Phan Đinh Chi", null, null, "8356728172", null, 4, "" },
                    { 104, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Cầu Đất, số 23", true, "Vũ Trần Loan", null, null, "1255687508", null, 4, "" },
                    { 105, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Hàng Bông, số 35", true, "Phan Đinh Hùng", null, null, "1418045237", null, 4, "" },
                    { 106, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Tràng Thi, số 42", true, "Nguyễn Đỗ Nguyên", null, null, "7586664011", null, 4, "" },
                    { 107, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Trương Hán Siêu, số 21", true, "Bùi Nguyễn Hà", null, null, "1485107173", null, 4, "" },
                    { 108, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Nguyên Khiết, số 2", true, "Đỗ Vũ Xuân", null, null, "8556161644", null, 4, "" },
                    { 109, "Generated", null, null, null, null, null, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", null, null, null, "Quang Trung, số 16", true, "Dương Võ Diệu", null, null, "6040608682", null, 4, "" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "Deleted", "ReceiverName", "ReceiverPhone", "Status", "TotalCost", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, "Admin", "08550684901", 2, 47746934L, 2 },
                    { 2, "Generated", null, "Phan Lê Quang", "1144255011", 2, 44308144L, 18 },
                    { 3, "Generated", null, "Trương Phạm Quý", "4358351704", 2, 98146476L, 25 },
                    { 4, "Generated", null, "Lê Phan Hường", "8384000824", 2, 93017728L, 28 },
                    { 5, "Generated", null, "Hoàng Ngô Tú", "1368512141", 2, 44947854L, 29 },
                    { 6, "Generated", null, "Đỗ Phan Quyên", "2127523288", 2, 41914900L, 30 },
                    { 7, "Generated", null, "Bùi Hoàng Long", "3557613182", 2, 137710829L, 31 },
                    { 8, "Generated", null, "Hồ Đinh Hồng", "6516661057", 2, 45175315L, 33 },
                    { 9, "Generated", null, "Đỗ Hồ Thi", "7850048856", 2, 38895493L, 47 },
                    { 10, "Generated", null, "Dương Trương Nhung", "7704460721", 2, 45408006L, 48 },
                    { 11, "Generated", null, "Phan Trần Sơn", "4431410118", 2, 46535551L, 52 },
                    { 12, "Generated", null, "Ngô Trần Nhung", "2427633633", 2, 45400668L, 55 },
                    { 13, "Generated", null, "Đinh Võ Tuấn", "3418836807", 2, 48708338L, 56 },
                    { 14, "Generated", null, "Trương Võ Yên", "6204584726", 2, 46384211L, 57 },
                    { 15, "Generated", null, "Trương Trương Diệp", "1062530328", 2, 48198715L, 58 },
                    { 16, "Generated", null, "Vũ Hồ Tuân", "6117071728", 2, 48869261L, 62 },
                    { 17, "Generated", null, "Đinh Ngô Quỳnh", "1517583122", 2, 45775662L, 65 },
                    { 18, "Generated", null, "Võ Bùi Dương", "5257470427", 2, 41395541L, 69 },
                    { 19, "Generated", null, "Đinh Võ Chí", "2137588306", 2, 38755786L, 70 },
                    { 20, "Generated", null, "Võ Phạm Kim", "6668622468", 2, 48786499L, 79 },
                    { 21, "Generated", null, "Đỗ Phan Trí", "2164564088", 2, 47706257L, 83 },
                    { 22, "Generated", null, "Lê Hoàng Yên", "6384872608", 2, 49412929L, 89 },
                    { 23, "Generated", null, "Dương Lê Lan", "8800421722", 2, 46197995L, 93 },
                    { 24, "Generated", null, "Phạm Đinh Lan", "2831183438", 2, 43471445L, 99 },
                    { 25, "Generated", null, "Nguyễn Trần Thị", "4113766758", 2, 47072582L, 102 },
                    { 26, "Generated", null, "Nguyễn Đỗ Nguyên", "7586664011", 2, 49715642L, 106 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BankAccountNum", "BankCode", "BankName", "CitizenId", "CitizenIdImageId", "City", "Deleted", "DeletedReason", "District", "DoB", "Email", "Gender", "HouseNumber", "IsVerified", "Name", "OtpExpiry", "OtpHash", "Phone", "PortraitId", "RoleId", "Street" },
                values: new object[,]
                {
                    { 110, "Generated", "3128327410", "ICB", "VietinBank", "6645111875", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1993, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "106@gmail.com", "Female", "Hàng Đồng, số 64", true, "Ngô Phan Chi", null, null, "6228141756", 5, 3, "" },
                    { 111, "Generated", "2274762126", "ICB", "VietinBank", "0615533383", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2005, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "107@gmail.com", "Female", "Đình Ngang, số 60", true, "Trần Trần Kim", null, null, "4427262455", 4, 3, "" },
                    { 112, "Generated", "2142315764", "ICB", "VietinBank", "7476823612", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1975, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "108@gmail.com", "Female", "Lương Ngọc Quyến, số 43", true, "Đặng Phan Cam", null, null, "3841061156", 4, 3, "" },
                    { 113, "Generated", "3346330153", "ICB", "VietinBank", "2734874232", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2004, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "109@gmail.com", "Female", "Hàng Chĩnh, số 1", true, "Huỳnh Phạm Ngải", null, null, "6223555334", 2, 3, "" },
                    { 114, "Generated", "7403265086", "ICB", "VietinBank", "3831380858", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1994, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "110@gmail.com", "Female", "Đinh Lễ, số 16", true, "Đinh Đỗ Lành", null, null, "5636687261", 1, 3, "" },
                    { 115, "Generated", "8741324235", "ICB", "VietinBank", "3673842166", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1992, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "111@gmail.com", "Female", "Mã Mây, số 93", true, "Hồ Hồ Hiếu", null, null, "7585024727", 2, 3, "" },
                    { 116, "Generated", "5725816161", "ICB", "VietinBank", "4274674203", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1981, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "112@gmail.com", "Female", "Lãn Ông, số 30", true, "Lê Bùi Phượng", null, null, "6512045107", 5, 3, "" },
                    { 117, "Generated", "4875385578", "ICB", "VietinBank", "2663152422", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1979, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "113@gmail.com", "Female", "Cầu Gỗ, số 49", true, "Đinh Phan Trúc", null, null, "8605815853", 5, 3, "" },
                    { 118, "Generated", "4256285738", "ICB", "VietinBank", "3337335425", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1989, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "114@gmail.com", "Female", "Thanh Hà, số 4", true, "Trương Huỳnh Lan", null, null, "6834057665", 4, 3, "" },
                    { 119, "Generated", "3746524752", "ICB", "VietinBank", "0842113882", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1989, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "115@gmail.com", "Female", "Ngô Quyền, số 46", true, "Trần Trần Huy", null, null, "8475583418", 5, 3, "" },
                    { 120, "Generated", "6767465541", "ICB", "VietinBank", "5158013414", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1996, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "116@gmail.com", "Female", "Phố Huế, số 71", true, "Đỗ Huỳnh Huệ", null, null, "4281552536", 3, 3, "" },
                    { 121, "Generated", "5632360823", "ICB", "VietinBank", "7614674851", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1999, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "117@gmail.com", "Female", "Bát Sứ, số 8", true, "Dương Trương Xuân", null, null, "4135570135", 4, 3, "" },
                    { 122, "Generated", "7817064385", "ICB", "VietinBank", "5061855134", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1992, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "118@gmail.com", "Female", "Dã Tượng, số 38", true, "Lê Võ Quyên", null, null, "3227718183", 4, 3, "" },
                    { 123, "Generated", "5104447584", "ICB", "VietinBank", "5166438171", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1994, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "119@gmail.com", "Female", "Chân Cầm, số 75", true, "Đinh Trương Thanh", null, null, "6466785858", 2, 3, "" },
                    { 124, "Generated", "0767628048", "ICB", "VietinBank", "3650323774", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2005, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "120@gmail.com", "Female", "Cổng Đục, số 22", true, "Huỳnh Trần Hiếu", null, null, "6027548516", 1, 3, "" },
                    { 125, "Generated", "7326014612", "ICB", "VietinBank", "8365452015", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1984, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "121@gmail.com", "Female", "Đoàn Nhữ Hài, số 48", true, "Dương Trương Nam", null, null, "8046357810", 2, 3, "" },
                    { 126, "Generated", "3083351877", "ICB", "VietinBank", "7334217648", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1989, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "122@gmail.com", "Female", "Hàng Hòm, số 19", true, "Hoàng Võ Nguyên", null, null, "6476368128", 4, 3, "" },
                    { 127, "Generated", "7353438045", "ICB", "VietinBank", "6752062038", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1997, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "123@gmail.com", "Female", "Hàng Trống, số 66", true, "Trần Phạm Hiếu", null, null, "8377600824", 5, 3, "" },
                    { 128, "Generated", "7271565068", "ICB", "VietinBank", "1455107855", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1994, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "124@gmail.com", "Female", "Nhà thờ, số 44", true, "Đinh Đặng Cúc", null, null, "1772348604", 5, 3, "" },
                    { 129, "Generated", "8586668132", "ICB", "VietinBank", "7348287573", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1984, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), "125@gmail.com", "Female", "Bạch Đằng, số 90", true, "Huỳnh Đặng Khánh", null, null, "1323473824", 5, 3, "" },
                    { 130, "Generated", "8384205845", "ICB", "VietinBank", "2570086425", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2003, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "126@gmail.com", "Female", "Nam Ngư, số 9", true, "Nguyễn Vũ Xuân", null, null, "1482178064", 4, 3, "" },
                    { 131, "Generated", "3355581620", "ICB", "VietinBank", "8564312526", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1990, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "127@gmail.com", "Female", "Trần Nhật Duật, số 80", true, "Đỗ Trần Bình", null, null, "1740714561", 4, 3, "" },
                    { 132, "Generated", "1884021487", "ICB", "VietinBank", "3618722501", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1992, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "128@gmail.com", "Female", "Hàng Bồ, số 39", true, "Phan Võ Nguyệt", null, null, "7175326745", 2, 3, "" },
                    { 133, "Generated", "1354734030", "ICB", "VietinBank", "5271565663", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1994, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "129@gmail.com", "Female", "Chân Cầm, số 3", true, "Võ Vũ Viện", null, null, "7577117185", 3, 3, "" },
                    { 134, "Generated", "8416764830", "ICB", "VietinBank", "1234405004", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2005, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "130@gmail.com", "Female", "Hàng Giấy, số 18", true, "Phạm Trần Hùng", null, null, "0330554446", 2, 3, "" },
                    { 135, "Generated", "3756580122", "ICB", "VietinBank", "3454850443", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1974, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "131@gmail.com", "Female", "Vạn Kiếp, số 22", true, "Ngô Trần Dương", null, null, "1011582413", 2, 3, "" },
                    { 136, "Generated", "0168311105", "ICB", "VietinBank", "4013803741", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1999, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "132@gmail.com", "Female", "Đào Duy Từ, số 47", true, "Hồ Dương Chi", null, null, "1247166148", 3, 3, "" },
                    { 137, "Generated", "6824035662", "ICB", "VietinBank", "3431402244", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1992, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "133@gmail.com", "Female", "Phan Đình Phùng, số 67", true, "Vũ Dương Thi", null, null, "8330378560", 3, 3, "" },
                    { 138, "Generated", "4148481113", "ICB", "VietinBank", "3613487603", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1978, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "134@gmail.com", "Female", "Lê Lai, số 40", true, "Vũ Ngô Phúc", null, null, "1317047721", 3, 3, "" },
                    { 139, "Generated", "7382337260", "ICB", "VietinBank", "2024421647", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1976, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "135@gmail.com", "Female", "Nam Ngư, số 39", true, "Hồ Hồ Hương", null, null, "4432324478", 1, 3, "" },
                    { 140, "Generated", "4426775602", "ICB", "VietinBank", "1156654074", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2004, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "136@gmail.com", "Female", "Lý Đạo Thành, số 15", true, "Huỳnh Hoàng Văn", null, null, "5222342550", 3, 3, "" },
                    { 141, "Generated", "3350702247", "ICB", "VietinBank", "5636611674", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "137@gmail.com", "Female", "Nguyễn Thái Học, số 46", true, "Hồ Phạm Nguyệt", null, null, "7717730628", 2, 3, "" },
                    { 142, "Generated", "1258152211", "ICB", "VietinBank", "8604428310", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "138@gmail.com", "Female", "Đặng Thái Thân, số 59", true, "Bùi Phạm Long", null, null, "2424515018", 2, 3, "" },
                    { 143, "Generated", "5124800137", "ICB", "VietinBank", "0510587334", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1975, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "139@gmail.com", "Female", "Phạm Sư Mạnh, số 81", true, "Lê Lê Nguyên", null, null, "8466516352", 3, 3, "" },
                    { 144, "Generated", "1483708214", "ICB", "VietinBank", "7716174081", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1974, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "140@gmail.com", "Female", "Đinh Lễ, số 95", true, "Trương Huỳnh Cam", null, null, "1204761330", 5, 3, "" },
                    { 145, "Generated", "2126215016", "ICB", "VietinBank", "1067828036", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2004, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "141@gmail.com", "Female", "Bạch Đằng, số 76", true, "Hoàng Phạm Phúc", null, null, "1680465833", 1, 3, "" },
                    { 146, "Generated", "8805631152", "ICB", "VietinBank", "6132852028", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1980, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "142@gmail.com", "Female", "Hàng Giấy, số 2", true, "Phan Hoàng Yên", null, null, "0704701677", 2, 3, "" },
                    { 147, "Generated", "8723155306", "ICB", "VietinBank", "4267267656", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1976, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "143@gmail.com", "Female", "Ngõ Gạch, số 28", true, "Phạm Hoàng Liêm", null, null, "1625805067", 1, 3, "" },
                    { 148, "Generated", "5711877562", "ICB", "VietinBank", "5613818470", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1991, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "144@gmail.com", "Female", "Nhà Hỏa, số 46", true, "Vũ Huỳnh Dũng", null, null, "5504176611", 1, 3, "" },
                    { 149, "Generated", "3337035417", "ICB", "VietinBank", "7550513083", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1984, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "145@gmail.com", "Female", "Lê Lai, số 91", true, "Hoàng Đinh Ngọc", null, null, "8104474811", 1, 3, "" },
                    { 150, "Generated", "5847324103", "ICB", "VietinBank", "7138047631", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "146@gmail.com", "Female", "Đinh Tiên Hoàng, số 42", true, "Trương Dương Trang", null, null, "2345845158", 5, 3, "" },
                    { 151, "Generated", "6242471346", "ICB", "VietinBank", "0720356311", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1993, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "147@gmail.com", "Female", "Nguyễn Gia Thiều, số 4", true, "Đỗ Nguyễn Hiếu", null, null, "6682447483", 5, 3, "" },
                    { 152, "Generated", "1124678705", "ICB", "VietinBank", "2413666751", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1995, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "148@gmail.com", "Female", "Ngô Thì Nhậm, số 38", true, "Lê Ngô Chí", null, null, "0823751446", 1, 3, "" },
                    { 153, "Generated", "8163862026", "ICB", "VietinBank", "4688823353", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1997, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "149@gmail.com", "Female", "Bát Đàn, số 38", true, "Phan Trần Giang", null, null, "8475341618", 3, 3, "" },
                    { 154, "Generated", "2811882175", "ICB", "VietinBank", "5208660105", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1988, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "150@gmail.com", "Female", "Hàm Tử Quan, số 59", true, "Hoàng Trương Nguyệt", null, null, "2413265225", 3, 3, "" },
                    { 155, "Generated", "5366381475", "ICB", "VietinBank", "3215083322", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1979, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "151@gmail.com", "Female", "Dã Tượng, số 30", true, "Hoàng Võ Quý", null, null, "4712747170", 1, 3, "" },
                    { 156, "Generated", "4404681023", "ICB", "VietinBank", "2841553237", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1982, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), "152@gmail.com", "Female", "Hàng Cót, số 48", true, "Hồ Vũ Liêm", null, null, "2282415644", 4, 3, "" },
                    { 157, "Generated", "3212424162", "ICB", "VietinBank", "3716718410", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1985, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "153@gmail.com", "Female", "Trần Nhật Duật, số 38", true, "Hoàng Đỗ Phúc", null, null, "7667684231", 3, 3, "" },
                    { 158, "Generated", "4146676816", "ICB", "VietinBank", "5826380016", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1975, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "154@gmail.com", "Female", "Lý Thái Tổ, số 30", true, "Trần Võ Tuấn", null, null, "5800512270", 4, 3, "" },
                    { 159, "Generated", "5140375114", "ICB", "VietinBank", "0858476582", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1987, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "155@gmail.com", "Female", "Thợ Nhuộm, số 51", true, "Vũ Phạm Chí", null, null, "0612871630", 5, 3, "" },
                    { 160, "Generated", "3423310121", "ICB", "VietinBank", "3537701470", 2, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1997, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "156@gmail.com", "Female", "Nguyễn Gia Thiều, số 55", true, "Hồ Huỳnh Chí", null, null, "0737656252", 2, 2, "" },
                    { 161, "Generated", "3105274051", "ICB", "VietinBank", "8251668008", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1999, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "157@gmail.com", "Female", "Hàng Thiếc, số 89", true, "Phạm Trương Vân", null, null, "6282302310", 4, 2, "" },
                    { 162, "Generated", "8636276056", "ICB", "VietinBank", "4222838080", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1987, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "158@gmail.com", "Female", "Bát Đàn, số 94", true, "Phan Phạm Tiên", null, null, "4767373182", 3, 2, "" },
                    { 163, "Generated", "1300376474", "ICB", "VietinBank", "8383822287", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "159@gmail.com", "Female", "Đinh Lễ, số 35", true, "Vũ Huỳnh Văn", null, null, "7836163882", 3, 2, "" },
                    { 164, "Generated", "0410421638", "ICB", "VietinBank", "0148746413", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1991, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "160@gmail.com", "Female", "Phan Chu Trinh, số 24", true, "Đinh Dương Loan", null, null, "1180055434", 1, 2, "" },
                    { 165, "Generated", "3533881737", "ICB", "VietinBank", "3424314720", 5, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1999, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "161@gmail.com", "Female", "Tô Tịch, số 71", true, "Trần Dương Hồng", null, null, "2266736245", 5, 2, "" },
                    { 166, "Generated", "1816210867", "ICB", "VietinBank", "7418167723", 3, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1981, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "162@gmail.com", "Female", "Chợ Gạo, số 88", true, "Ngô Huỳnh Vân", null, null, "0374044858", 3, 2, "" },
                    { 167, "Generated", "4173172874", "ICB", "VietinBank", "2061206568", 1, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2002, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "163@gmail.com", "Female", "Hàng Bài, số 96", true, "Nguyễn Vũ Kim", null, null, "4865233523", 1, 2, "" },
                    { 168, "Generated", "7500113574", "ICB", "VietinBank", "5585540156", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(1995, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "164@gmail.com", "Female", "Hàng Mành, số 58", true, "Huỳnh Phan An", null, null, "6621573156", 4, 2, "" },
                    { 169, "Generated", "1350656274", "ICB", "VietinBank", "0603253055", 4, "thanh_pho_ha_noi", null, null, "quan_hoan_kiem", new DateTime(2002, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "165@gmail.com", "Female", "Hàng Đào, số 16", true, "Bùi Đặng Viện", null, null, "5364002257", 4, 2, "" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "Deleted", "Description", "ExpertId", "HighestBidId", "Name", "OngoingSessionId", "OrderId", "PaymentDueDate", "SellerId", "ShipmentId", "Status", "ThumbnailId", "WonDate" },
                values: new object[,]
                {
                    { 1, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Văn tự 1", null, null, null, 124, null, 2, 30, null },
                    { 2, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Khoáng sản 2", null, null, null, 133, null, 2, 11, null },
                    { 3, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Đồ sưu tầm 3", null, null, null, 120, null, 2, 7, null },
                    { 4, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Nội thất 4", null, null, null, 153, null, 2, 9, null },
                    { 5, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Xe 5", null, null, null, 147, null, 2, 14, null },
                    { 6, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Trang sức 6", null, null, null, 135, null, 2, 29, null },
                    { 7, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Đồ sưu tầm 7", null, null, null, 139, null, 2, 31, null },
                    { 8, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Trang sức 8", null, null, null, 142, null, 2, 16, null },
                    { 9, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Trang phục 9", null, null, null, 119, null, 2, 9, null },
                    { 10, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Xe 10", null, null, null, 134, null, 2, 15, null },
                    { 11, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Nội thất 11", null, null, null, 149, null, 2, 26, null },
                    { 12, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Trang sức 12", null, null, null, 115, null, 2, 17, null },
                    { 13, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Văn tự 13", null, null, null, 152, null, 2, 23, null },
                    { 14, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Đồ sưu tầm 14", null, null, null, 126, null, 2, 18, null },
                    { 15, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Trang phục 15", null, null, null, 138, null, 2, 21, null },
                    { 16, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Tiền cổ 16", null, null, null, 130, null, 2, 15, null },
                    { 17, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Khoáng sản 17", null, null, null, 122, null, 2, 23, null },
                    { 18, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Nội thất 18", null, null, null, 119, null, 2, 15, null },
                    { 19, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Văn tự 19", null, null, null, 155, null, 2, 18, null },
                    { 20, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Trang sức 20", null, null, null, 133, null, 2, 16, null },
                    { 21, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Khoáng sản 21", null, null, null, 146, null, 2, 13, null },
                    { 22, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Văn tự 22", null, null, null, 129, null, 2, 26, null },
                    { 23, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Đồ sưu tầm 23", null, null, null, 130, null, 2, 12, null },
                    { 24, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Văn tự 24", null, null, null, 118, null, 2, 9, null },
                    { 25, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Trang sức 25", null, null, null, 131, null, 2, 34, null },
                    { 26, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Tranh 26", null, null, null, 124, null, 2, 18, null },
                    { 27, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Văn tự 27", null, null, null, 152, null, 2, 26, null },
                    { 28, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Nội thất 28", null, null, null, 126, null, 2, 8, null },
                    { 29, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Khoáng sản 29", null, null, null, 110, null, 2, 31, null },
                    { 30, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Xe 30", null, null, null, 125, null, 2, 27, null },
                    { 31, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Văn tự 31", null, null, null, 134, null, 2, 10, null },
                    { 32, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Xe 32", null, null, null, 152, null, 2, 20, null },
                    { 33, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Xe 33", null, null, null, 131, null, 2, 10, null },
                    { 34, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Đồ sưu tầm 34", null, null, null, 130, null, 2, 8, null },
                    { 35, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Trang sức 35", null, null, null, 159, null, 2, 7, null },
                    { 36, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Xe 36", null, null, null, 140, null, 2, 8, null },
                    { 37, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Tranh 37", null, null, null, 147, null, 2, 23, null },
                    { 38, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Xe 38", null, null, null, 124, null, 2, 30, null },
                    { 39, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Đồ sưu tầm 39", null, null, null, 137, null, 2, 22, null },
                    { 40, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Trang phục 40", null, null, null, 132, null, 2, 30, null },
                    { 41, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Nội thất 41", null, null, null, 124, null, 2, 7, null },
                    { 42, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Văn tự 42", null, null, null, 113, null, 2, 11, null },
                    { 43, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Nội thất 43", null, null, null, 135, null, 2, 22, null },
                    { 44, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Trang phục 44", null, null, null, 130, null, 2, 22, null },
                    { 45, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Trang phục 45", null, null, null, 148, null, 2, 27, null },
                    { 46, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Khoáng sản 46", null, null, null, 143, null, 2, 7, null },
                    { 47, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Đồ sưu tầm 47", null, null, null, 131, null, 2, 8, null },
                    { 48, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Nội thất 48", null, null, null, 151, null, 2, 28, null },
                    { 49, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Tiền cổ 49", null, null, null, 112, null, 2, 33, null },
                    { 50, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Tranh 50", null, null, null, 150, null, 2, 20, null },
                    { 51, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Nội thất 51", null, null, null, 128, null, 3, 19, null },
                    { 52, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Nội thất 52", null, null, null, 111, null, 3, 17, null },
                    { 53, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Văn tự 53", null, null, null, 135, null, 3, 23, null },
                    { 54, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Trang phục 54", null, null, null, 110, null, 3, 11, null },
                    { 55, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Tiền cổ 55", null, null, null, 123, null, 3, 17, null },
                    { 56, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Khoáng sản 56", null, null, null, 123, null, 3, 15, null },
                    { 57, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Đồ sưu tầm 57", null, null, null, 131, null, 3, 16, null },
                    { 58, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Xe 58", null, null, null, 115, null, 3, 7, null },
                    { 59, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Văn tự 59", null, null, null, 152, null, 3, 11, null },
                    { 60, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Văn tự 60", null, null, null, 151, null, 3, 30, null },
                    { 61, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Trang phục 61", null, null, null, 151, null, 3, 27, null },
                    { 62, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Văn tự 62", null, null, null, 144, null, 3, 18, null },
                    { 63, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Văn tự 63", null, null, null, 120, null, 3, 21, null },
                    { 64, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Xe 64", null, null, null, 117, null, 3, 12, null },
                    { 65, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Khoáng sản 65", null, null, null, 150, null, 3, 16, null },
                    { 66, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Tranh 66", null, null, null, 147, null, 3, 21, null },
                    { 67, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Văn tự 67", null, null, null, 148, null, 3, 17, null },
                    { 68, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Đồ sưu tầm 68", null, null, null, 154, null, 3, 17, null },
                    { 69, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Trang sức 69", null, null, null, 156, null, 3, 10, null },
                    { 70, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Tranh 70", null, null, null, 121, null, 3, 24, null },
                    { 71, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Văn tự 71", null, null, null, 116, null, 3, 34, null },
                    { 72, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Tranh 72", null, null, null, 135, null, 3, 26, null },
                    { 73, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Văn tự 73", null, null, null, 142, null, 3, 9, null },
                    { 74, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Tranh 74", null, null, null, 118, null, 3, 25, null },
                    { 75, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Tiền cổ 75", null, null, null, 142, null, 3, 24, null },
                    { 76, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Trang phục 76", null, null, null, 136, null, 3, 9, null },
                    { 77, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Đồ sưu tầm 77", null, null, null, 150, null, 3, 8, null },
                    { 78, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Khoáng sản 78", null, null, null, 115, null, 3, 20, null },
                    { 79, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Văn tự 79", null, null, null, 124, null, 3, 19, null },
                    { 80, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Xe 80", null, null, null, 126, null, 3, 34, null },
                    { 81, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Nội thất 81", null, null, null, 137, null, 3, 7, null },
                    { 82, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Nội thất 82", null, null, null, 131, null, 3, 16, null },
                    { 83, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Tranh 83", null, null, null, 129, null, 3, 18, null },
                    { 84, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Tranh 84", null, null, null, 153, null, 3, 29, null },
                    { 85, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Xe 85", null, null, null, 154, null, 3, 6, null },
                    { 86, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Tiền cổ 86", null, null, null, 157, null, 3, 29, null },
                    { 87, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Đồ sưu tầm 87", null, null, null, 138, null, 3, 32, null },
                    { 88, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Văn tự 88", null, null, null, 138, null, 3, 33, null },
                    { 89, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Đồ sưu tầm 89", null, null, null, 127, null, 3, 14, null },
                    { 90, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Văn tự 90", null, null, null, 145, null, 3, 9, null },
                    { 91, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Văn tự 91", null, null, null, 122, null, 3, 14, null },
                    { 92, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Xe 92", null, null, null, 112, null, 3, 16, null },
                    { 93, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Nội thất 93", null, null, null, 118, null, 3, 13, null },
                    { 94, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Tiền cổ 94", null, null, null, 152, null, 3, 12, null },
                    { 95, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Tiền cổ 95", null, null, null, 123, null, 3, 19, null },
                    { 96, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Nội thất 96", null, null, null, 138, null, 3, 16, null },
                    { 97, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Trang sức 97", null, null, null, 112, null, 3, 15, null },
                    { 98, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Trang phục 98", null, null, null, 157, null, 3, 31, null },
                    { 99, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Xe 99", null, null, null, 111, null, 3, 30, null },
                    { 100, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Nội thất 100", null, null, null, 122, null, 3, 25, null },
                    { 101, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Đồ sưu tầm 101", 6, null, null, 113, null, 4, 24, null },
                    { 102, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Văn tự 102", 6, null, null, 151, null, 4, 23, null },
                    { 103, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Khoáng sản 103", 6, null, null, 116, null, 4, 18, null },
                    { 104, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Tiền cổ 104", 6, null, null, 116, null, 4, 10, null },
                    { 105, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Trang sức 105", 6, null, null, 147, null, 4, 33, null },
                    { 106, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Nội thất 106", 6, null, null, 123, null, 4, 10, null },
                    { 107, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Nội thất 107", 6, null, null, 137, null, 4, 30, null },
                    { 108, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Xe 108", 6, null, null, 145, null, 4, 6, null },
                    { 109, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Trang sức 109", 6, null, null, 131, null, 4, 11, null },
                    { 110, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Tranh 110", 6, null, null, 118, null, 4, 22, null },
                    { 111, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Trang phục 111", 6, null, null, 150, null, 4, 20, null },
                    { 112, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Xe 112", 6, null, null, 138, null, 4, 18, null },
                    { 113, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Trang sức 113", 6, null, null, 114, null, 4, 32, null },
                    { 114, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Trang sức 114", 6, null, null, 112, null, 4, 32, null },
                    { 115, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Văn tự 115", 6, null, null, 142, null, 4, 30, null },
                    { 116, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Tranh 116", 6, null, null, 110, null, 4, 31, null },
                    { 117, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Nội thất 117", 6, null, null, 149, null, 4, 6, null },
                    { 118, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Trang phục 118", 6, null, null, 154, null, 4, 24, null },
                    { 119, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Trang sức 119", 6, null, null, 114, null, 4, 10, null },
                    { 120, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Khoáng sản 120", 6, null, null, 128, null, 4, 21, null },
                    { 121, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Trang sức 121", 6, null, null, 114, null, 4, 33, null },
                    { 122, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Khoáng sản 122", 6, null, null, 117, null, 4, 28, null },
                    { 123, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Tiền cổ 123", 6, null, null, 128, null, 4, 21, null },
                    { 124, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Văn tự 124", 6, null, null, 127, null, 4, 25, null },
                    { 125, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Trang phục 125", 6, null, null, 111, null, 4, 32, null },
                    { 126, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Trang sức 126", 6, null, null, 156, null, 4, 11, null },
                    { 127, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Văn tự 127", 6, null, null, 129, null, 4, 6, null },
                    { 128, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Trang phục 128", 6, null, null, 156, null, 4, 10, null },
                    { 129, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Tiền cổ 129", 6, null, null, 135, null, 4, 10, null },
                    { 130, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Trang sức 130", 6, null, null, 159, null, 4, 22, null },
                    { 131, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Xe 131", 6, null, null, 121, null, 4, 29, null },
                    { 132, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Tranh 132", 6, null, null, 127, null, 4, 33, null },
                    { 133, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Trang phục 133", 6, null, null, 143, null, 4, 33, null },
                    { 134, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Xe 134", 6, null, null, 117, null, 4, 9, null },
                    { 135, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Đồ sưu tầm 135", 6, null, null, 134, null, 4, 28, null },
                    { 136, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Tranh 136", 6, null, null, 130, null, 4, 33, null },
                    { 137, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Khoáng sản 137", 6, null, null, 149, null, 4, 25, null },
                    { 138, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Trang phục 138", 6, null, null, 142, null, 4, 6, null },
                    { 139, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Đồ sưu tầm 139", 6, null, null, 144, null, 4, 31, null },
                    { 140, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Trang phục 140", 6, null, null, 126, null, 4, 21, null },
                    { 141, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Tiền cổ 141", 6, null, null, 159, null, 4, 25, null },
                    { 142, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Khoáng sản 142", 6, null, null, 136, null, 4, 13, null },
                    { 143, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Xe 143", 6, null, null, 133, null, 4, 15, null },
                    { 144, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Đồ sưu tầm 144", 6, null, null, 116, null, 4, 19, null },
                    { 145, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Văn tự 145", 6, null, null, 159, null, 4, 6, null },
                    { 146, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Tranh 146", 6, null, null, 119, null, 4, 18, null },
                    { 147, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Khoáng sản 147", 6, null, null, 153, null, 4, 30, null },
                    { 148, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Nội thất 148", 6, null, null, 148, null, 4, 14, null },
                    { 149, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Tranh 149", 6, null, null, 137, null, 4, 8, null },
                    { 150, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Tranh 150", 6, null, null, 155, null, 4, 29, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "Deleted", "ReceiverName", "ReceiverPhone", "Status", "TotalCost", "UserId" },
                values: new object[,]
                {
                    { 27, "Generated", null, "Đinh Đỗ Lành", "5636687261", 2, 48983574L, 114 },
                    { 28, "Generated", null, "Đỗ Huỳnh Huệ", "4281552536", 2, 46361265L, 120 },
                    { 29, "Generated", null, "Dương Trương Xuân", "4135570135", 2, 88844608L, 121 },
                    { 30, "Generated", null, "Đinh Trương Thanh", "6466785858", 2, 48973395L, 123 },
                    { 31, "Generated", null, "Võ Vũ Viện", "7577117185", 2, 92371823L, 133 },
                    { 32, "Generated", null, "Hồ Dương Chi", "1247166148", 2, 44326384L, 136 },
                    { 33, "Generated", null, "Huỳnh Hoàng Văn", "5222342550", 2, 48054474L, 140 },
                    { 34, "Generated", null, "Lê Lê Nguyên", "8466516352", 2, 49061603L, 143 },
                    { 35, "Generated", null, "Trương Huỳnh Cam", "1204761330", 2, 43840057L, 144 },
                    { 36, "Generated", null, "Vũ Huỳnh Dũng", "5504176611", 2, 44394818L, 148 },
                    { 37, "Generated", null, "Lê Ngô Chí", "0823751446", 2, 91869684L, 152 },
                    { 38, "Generated", null, "Phan Trần Giang", "8475341618", 2, 49868963L, 153 },
                    { 39, "Generated", null, "Hoàng Đỗ Phúc", "7667684231", 2, 49803247L, 157 },
                    { 40, "Generated", null, "Vũ Phạm Chí", "0612871630", 2, 45670250L, 159 },
                    { 41, "Generated", null, "Hồ Huỳnh Chí", "0737656252", 2, 74601139L, 160 },
                    { 42, "Generated", null, "Phan Phạm Tiên", "4767373182", 2, 47217141L, 162 }
                });

            migrationBuilder.InsertData(
                table: "SellerApplications",
                columns: new[] { "Id", "Address", "BankAccountNum", "BankCode", "BankName", "CitizenId", "CitizenIdImageId", "City", "Content", "Deleted", "District", "DoB", "Email", "Gender", "HouseNumber", "PortraitId", "Status", "Street", "UserId" },
                values: new object[,]
                {
                    { 1, "Generated", "3128327410", "ICB", "VietinBank", "6645111875", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1993, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "106@gmail.com", "Female", "Hàng Đồng, số 64", 5, 2, "", 110 },
                    { 2, "Generated", "2274762126", "ICB", "VietinBank", "0615533383", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2005, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "107@gmail.com", "Female", "Đình Ngang, số 60", 4, 2, "", 111 },
                    { 3, "Generated", "2142315764", "ICB", "VietinBank", "7476823612", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1975, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "108@gmail.com", "Female", "Lương Ngọc Quyến, số 43", 4, 2, "", 112 },
                    { 4, "Generated", "3346330153", "ICB", "VietinBank", "2734874232", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2004, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "109@gmail.com", "Female", "Hàng Chĩnh, số 1", 2, 2, "", 113 },
                    { 5, "Generated", "7403265086", "ICB", "VietinBank", "3831380858", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1994, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "110@gmail.com", "Female", "Đinh Lễ, số 16", 1, 2, "", 114 },
                    { 6, "Generated", "8741324235", "ICB", "VietinBank", "3673842166", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1992, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "111@gmail.com", "Female", "Mã Mây, số 93", 2, 2, "", 115 },
                    { 7, "Generated", "5725816161", "ICB", "VietinBank", "4274674203", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1981, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "112@gmail.com", "Female", "Lãn Ông, số 30", 5, 2, "", 116 },
                    { 8, "Generated", "4875385578", "ICB", "VietinBank", "2663152422", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1979, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "113@gmail.com", "Female", "Cầu Gỗ, số 49", 5, 2, "", 117 },
                    { 9, "Generated", "4256285738", "ICB", "VietinBank", "3337335425", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1989, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "114@gmail.com", "Female", "Thanh Hà, số 4", 4, 2, "", 118 },
                    { 10, "Generated", "3746524752", "ICB", "VietinBank", "0842113882", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1989, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "115@gmail.com", "Female", "Ngô Quyền, số 46", 5, 2, "", 119 },
                    { 11, "Generated", "6767465541", "ICB", "VietinBank", "5158013414", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1996, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "116@gmail.com", "Female", "Phố Huế, số 71", 3, 2, "", 120 },
                    { 12, "Generated", "5632360823", "ICB", "VietinBank", "7614674851", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1999, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "117@gmail.com", "Female", "Bát Sứ, số 8", 4, 2, "", 121 },
                    { 13, "Generated", "7817064385", "ICB", "VietinBank", "5061855134", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1992, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "118@gmail.com", "Female", "Dã Tượng, số 38", 4, 2, "", 122 },
                    { 14, "Generated", "5104447584", "ICB", "VietinBank", "5166438171", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1994, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "119@gmail.com", "Female", "Chân Cầm, số 75", 2, 2, "", 123 },
                    { 15, "Generated", "0767628048", "ICB", "VietinBank", "3650323774", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2005, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "120@gmail.com", "Female", "Cổng Đục, số 22", 1, 2, "", 124 },
                    { 16, "Generated", "7326014612", "ICB", "VietinBank", "8365452015", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1984, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "121@gmail.com", "Female", "Đoàn Nhữ Hài, số 48", 2, 2, "", 125 },
                    { 17, "Generated", "3083351877", "ICB", "VietinBank", "7334217648", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1989, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "122@gmail.com", "Female", "Hàng Hòm, số 19", 4, 2, "", 126 },
                    { 18, "Generated", "7353438045", "ICB", "VietinBank", "6752062038", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1997, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "123@gmail.com", "Female", "Hàng Trống, số 66", 5, 2, "", 127 },
                    { 19, "Generated", "7271565068", "ICB", "VietinBank", "1455107855", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1994, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "124@gmail.com", "Female", "Nhà thờ, số 44", 5, 2, "", 128 },
                    { 20, "Generated", "8586668132", "ICB", "VietinBank", "7348287573", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1984, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), "125@gmail.com", "Female", "Bạch Đằng, số 90", 5, 2, "", 129 },
                    { 21, "Generated", "8384205845", "ICB", "VietinBank", "2570086425", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2003, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "126@gmail.com", "Female", "Nam Ngư, số 9", 4, 2, "", 130 },
                    { 22, "Generated", "3355581620", "ICB", "VietinBank", "8564312526", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1990, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "127@gmail.com", "Female", "Trần Nhật Duật, số 80", 4, 2, "", 131 },
                    { 23, "Generated", "1884021487", "ICB", "VietinBank", "3618722501", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1992, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "128@gmail.com", "Female", "Hàng Bồ, số 39", 2, 2, "", 132 },
                    { 24, "Generated", "1354734030", "ICB", "VietinBank", "5271565663", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1994, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "129@gmail.com", "Female", "Chân Cầm, số 3", 3, 2, "", 133 },
                    { 25, "Generated", "8416764830", "ICB", "VietinBank", "1234405004", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2005, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "130@gmail.com", "Female", "Hàng Giấy, số 18", 2, 2, "", 134 },
                    { 26, "Generated", "3756580122", "ICB", "VietinBank", "3454850443", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1974, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "131@gmail.com", "Female", "Vạn Kiếp, số 22", 2, 2, "", 135 },
                    { 27, "Generated", "0168311105", "ICB", "VietinBank", "4013803741", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1999, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "132@gmail.com", "Female", "Đào Duy Từ, số 47", 3, 2, "", 136 },
                    { 28, "Generated", "6824035662", "ICB", "VietinBank", "3431402244", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1992, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "133@gmail.com", "Female", "Phan Đình Phùng, số 67", 3, 2, "", 137 },
                    { 29, "Generated", "4148481113", "ICB", "VietinBank", "3613487603", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1978, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "134@gmail.com", "Female", "Lê Lai, số 40", 3, 2, "", 138 },
                    { 30, "Generated", "7382337260", "ICB", "VietinBank", "2024421647", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1976, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "135@gmail.com", "Female", "Nam Ngư, số 39", 1, 2, "", 139 },
                    { 31, "Generated", "4426775602", "ICB", "VietinBank", "1156654074", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2004, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "136@gmail.com", "Female", "Lý Đạo Thành, số 15", 3, 2, "", 140 },
                    { 32, "Generated", "3350702247", "ICB", "VietinBank", "5636611674", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "137@gmail.com", "Female", "Nguyễn Thái Học, số 46", 2, 2, "", 141 },
                    { 33, "Generated", "1258152211", "ICB", "VietinBank", "8604428310", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "138@gmail.com", "Female", "Đặng Thái Thân, số 59", 2, 2, "", 142 },
                    { 34, "Generated", "5124800137", "ICB", "VietinBank", "0510587334", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1975, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "139@gmail.com", "Female", "Phạm Sư Mạnh, số 81", 3, 2, "", 143 },
                    { 35, "Generated", "1483708214", "ICB", "VietinBank", "7716174081", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1974, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "140@gmail.com", "Female", "Đinh Lễ, số 95", 5, 2, "", 144 },
                    { 36, "Generated", "2126215016", "ICB", "VietinBank", "1067828036", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(2004, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "141@gmail.com", "Female", "Bạch Đằng, số 76", 1, 2, "", 145 },
                    { 37, "Generated", "8805631152", "ICB", "VietinBank", "6132852028", 2, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1980, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "142@gmail.com", "Female", "Hàng Giấy, số 2", 2, 2, "", 146 },
                    { 38, "Generated", "8723155306", "ICB", "VietinBank", "4267267656", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1976, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "143@gmail.com", "Female", "Ngõ Gạch, số 28", 1, 2, "", 147 },
                    { 39, "Generated", "5711877562", "ICB", "VietinBank", "5613818470", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1991, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "144@gmail.com", "Female", "Nhà Hỏa, số 46", 1, 2, "", 148 },
                    { 40, "Generated", "3337035417", "ICB", "VietinBank", "7550513083", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1984, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "145@gmail.com", "Female", "Lê Lai, số 91", 1, 2, "", 149 },
                    { 41, "Generated", "5847324103", "ICB", "VietinBank", "7138047631", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "146@gmail.com", "Female", "Đinh Tiên Hoàng, số 42", 5, 2, "", 150 },
                    { 42, "Generated", "6242471346", "ICB", "VietinBank", "0720356311", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1993, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "147@gmail.com", "Female", "Nguyễn Gia Thiều, số 4", 5, 2, "", 151 },
                    { 43, "Generated", "1124678705", "ICB", "VietinBank", "2413666751", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1995, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "148@gmail.com", "Female", "Ngô Thì Nhậm, số 38", 1, 2, "", 152 },
                    { 44, "Generated", "8163862026", "ICB", "VietinBank", "4688823353", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1997, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "149@gmail.com", "Female", "Bát Đàn, số 38", 3, 2, "", 153 },
                    { 45, "Generated", "2811882175", "ICB", "VietinBank", "5208660105", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1988, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "150@gmail.com", "Female", "Hàm Tử Quan, số 59", 3, 2, "", 154 },
                    { 46, "Generated", "5366381475", "ICB", "VietinBank", "3215083322", 1, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1979, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "151@gmail.com", "Female", "Dã Tượng, số 30", 1, 2, "", 155 },
                    { 47, "Generated", "4404681023", "ICB", "VietinBank", "2841553237", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1982, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), "152@gmail.com", "Female", "Hàng Cót, số 48", 4, 2, "", 156 },
                    { 48, "Generated", "3212424162", "ICB", "VietinBank", "3716718410", 3, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1985, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "153@gmail.com", "Female", "Trần Nhật Duật, số 38", 3, 2, "", 157 },
                    { 49, "Generated", "4146676816", "ICB", "VietinBank", "5826380016", 4, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1975, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "154@gmail.com", "Female", "Lý Thái Tổ, số 30", 4, 2, "", 158 },
                    { 50, "Generated", "5140375114", "ICB", "VietinBank", "0858476582", 5, "thanh_pho_ha_noi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", null, "quan_hoan_kiem", new DateTime(1987, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "155@gmail.com", "Female", "Thợ Nhuộm, số 51", 5, 2, "", 159 }
                });

            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "Id", "Address", "Deleted", "ItemCost", "OrderId", "SellerId", "ShippingCost", "Status" },
                values: new object[,]
                {
                    { 1, "Generated", null, 47736934L, 1, 153, 10000L, 0 },
                    { 2, "Generated", null, 44298144L, 2, 131, 10000L, 0 },
                    { 3, "Generated", null, 48904116L, 3, 159, 10000L, 0 },
                    { 4, "Generated", null, 49222360L, 3, 117, 10000L, 0 },
                    { 5, "Generated", null, 48502198L, 4, 120, 10000L, 0 },
                    { 6, "Generated", null, 44495530L, 4, 136, 10000L, 0 },
                    { 7, "Generated", null, 44937854L, 5, 150, 10000L, 0 },
                    { 8, "Generated", null, 41904900L, 6, 126, 10000L, 0 },
                    { 9, "Generated", null, 43771362L, 7, 118, 10000L, 0 },
                    { 10, "Generated", null, 46801194L, 7, 145, 10000L, 0 },
                    { 11, "Generated", null, 47108273L, 7, 142, 10000L, 0 },
                    { 12, "Generated", null, 45165315L, 8, 155, 10000L, 0 },
                    { 13, "Generated", null, 38885493L, 9, 155, 10000L, 0 },
                    { 14, "Generated", null, 45398006L, 10, 129, 10000L, 0 },
                    { 15, "Generated", null, 46525551L, 11, 147, 10000L, 0 },
                    { 16, "Generated", null, 45390668L, 12, 153, 10000L, 0 },
                    { 17, "Generated", null, 48698338L, 13, 124, 10000L, 0 },
                    { 18, "Generated", null, 46374211L, 14, 110, 10000L, 0 },
                    { 19, "Generated", null, 48188715L, 15, 116, 10000L, 0 },
                    { 20, "Generated", null, 48859261L, 16, 110, 10000L, 0 },
                    { 21, "Generated", null, 45765662L, 17, 156, 10000L, 0 },
                    { 22, "Generated", null, 41385541L, 18, 133, 10000L, 0 },
                    { 23, "Generated", null, 38745786L, 19, 142, 10000L, 0 },
                    { 24, "Generated", null, 48776499L, 20, 130, 10000L, 0 },
                    { 25, "Generated", null, 47696257L, 21, 123, 10000L, 0 },
                    { 26, "Generated", null, 49402929L, 22, 114, 10000L, 0 },
                    { 27, "Generated", null, 46187995L, 23, 151, 10000L, 0 },
                    { 28, "Generated", null, 43461445L, 24, 118, 10000L, 0 },
                    { 29, "Generated", null, 47062582L, 25, 142, 10000L, 0 },
                    { 30, "Generated", null, 49705642L, 26, 157, 10000L, 0 }
                });

            migrationBuilder.InsertData(
                table: "AuctionSessionItem",
                columns: new[] { "AuctionSessionsId", "ItemsId" },
                values: new object[,]
                {
                    { 6, 101 },
                    { 6, 102 },
                    { 6, 103 },
                    { 6, 104 },
                    { 6, 105 },
                    { 6, 106 },
                    { 6, 107 },
                    { 6, 108 },
                    { 6, 109 },
                    { 6, 110 },
                    { 6, 111 },
                    { 6, 112 },
                    { 6, 113 },
                    { 6, 114 },
                    { 6, 115 },
                    { 6, 116 },
                    { 6, 117 },
                    { 6, 118 },
                    { 6, 119 },
                    { 6, 120 },
                    { 6, 121 },
                    { 6, 122 },
                    { 6, 123 },
                    { 6, 124 },
                    { 6, 125 },
                    { 6, 126 },
                    { 6, 127 },
                    { 6, 128 },
                    { 6, 129 },
                    { 6, 130 },
                    { 6, 131 },
                    { 6, 132 },
                    { 6, 133 },
                    { 6, 134 },
                    { 6, 135 },
                    { 6, 136 },
                    { 6, 137 },
                    { 6, 138 },
                    { 6, 139 },
                    { 6, 140 },
                    { 6, 141 },
                    { 6, 142 },
                    { 6, 143 },
                    { 6, 144 },
                    { 6, 145 },
                    { 6, 146 },
                    { 6, 147 },
                    { 6, 148 },
                    { 6, 149 },
                    { 6, 150 }
                });

            migrationBuilder.InsertData(
                table: "ImageItem",
                columns: new[] { "ImagesId", "ItemsId" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 6, 6 },
                    { 6, 9 },
                    { 6, 13 },
                    { 6, 14 },
                    { 6, 16 },
                    { 6, 20 },
                    { 6, 21 },
                    { 6, 23 },
                    { 6, 34 },
                    { 6, 41 },
                    { 6, 45 },
                    { 6, 46 },
                    { 6, 64 },
                    { 6, 73 },
                    { 6, 88 },
                    { 6, 90 },
                    { 6, 101 },
                    { 6, 104 },
                    { 6, 112 },
                    { 6, 132 },
                    { 6, 135 },
                    { 6, 138 },
                    { 6, 143 },
                    { 6, 150 },
                    { 7, 12 },
                    { 7, 13 },
                    { 7, 14 },
                    { 7, 15 },
                    { 7, 22 },
                    { 7, 27 },
                    { 7, 30 },
                    { 7, 33 },
                    { 7, 36 },
                    { 7, 54 },
                    { 7, 65 },
                    { 7, 76 },
                    { 7, 104 },
                    { 7, 118 },
                    { 7, 125 },
                    { 7, 128 },
                    { 7, 134 },
                    { 7, 137 },
                    { 7, 142 },
                    { 7, 145 },
                    { 7, 146 },
                    { 8, 4 },
                    { 8, 15 },
                    { 8, 26 },
                    { 8, 30 },
                    { 8, 36 },
                    { 8, 41 },
                    { 8, 45 },
                    { 8, 67 },
                    { 8, 81 },
                    { 8, 101 },
                    { 8, 102 },
                    { 8, 110 },
                    { 8, 114 },
                    { 8, 123 },
                    { 8, 126 },
                    { 8, 138 },
                    { 9, 2 },
                    { 9, 11 },
                    { 9, 13 },
                    { 9, 23 },
                    { 9, 31 },
                    { 9, 32 },
                    { 9, 33 },
                    { 9, 39 },
                    { 9, 60 },
                    { 9, 62 },
                    { 9, 69 },
                    { 9, 72 },
                    { 9, 78 },
                    { 9, 85 },
                    { 9, 93 },
                    { 9, 101 },
                    { 9, 109 },
                    { 9, 112 },
                    { 9, 113 },
                    { 9, 116 },
                    { 9, 117 },
                    { 9, 124 },
                    { 9, 135 },
                    { 9, 140 },
                    { 9, 150 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 4 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 10 },
                    { 10, 12 },
                    { 10, 14 },
                    { 10, 17 },
                    { 10, 21 },
                    { 10, 31 },
                    { 10, 35 },
                    { 10, 41 },
                    { 10, 42 },
                    { 10, 45 },
                    { 10, 47 },
                    { 10, 48 },
                    { 10, 50 },
                    { 10, 54 },
                    { 10, 55 },
                    { 10, 57 },
                    { 10, 64 },
                    { 10, 66 },
                    { 10, 67 },
                    { 10, 79 },
                    { 10, 80 },
                    { 10, 84 },
                    { 10, 92 },
                    { 10, 95 },
                    { 10, 97 },
                    { 10, 98 },
                    { 10, 119 },
                    { 10, 125 },
                    { 10, 127 },
                    { 10, 131 },
                    { 10, 133 },
                    { 10, 134 },
                    { 10, 139 },
                    { 10, 142 },
                    { 10, 143 },
                    { 11, 6 },
                    { 11, 11 },
                    { 11, 13 },
                    { 11, 20 },
                    { 11, 21 },
                    { 11, 24 },
                    { 11, 28 },
                    { 11, 31 },
                    { 11, 32 },
                    { 11, 37 },
                    { 11, 47 },
                    { 11, 50 },
                    { 11, 65 },
                    { 11, 69 },
                    { 11, 73 },
                    { 11, 76 },
                    { 11, 77 },
                    { 11, 91 },
                    { 11, 95 },
                    { 11, 100 },
                    { 11, 134 },
                    { 11, 136 },
                    { 11, 144 },
                    { 12, 3 },
                    { 12, 20 },
                    { 12, 21 },
                    { 12, 22 },
                    { 12, 29 },
                    { 12, 35 },
                    { 12, 46 },
                    { 12, 51 },
                    { 12, 84 },
                    { 12, 89 },
                    { 12, 94 },
                    { 12, 96 },
                    { 12, 103 },
                    { 12, 119 },
                    { 12, 122 },
                    { 12, 138 },
                    { 12, 148 },
                    { 12, 149 },
                    { 13, 2 },
                    { 13, 7 },
                    { 13, 8 },
                    { 13, 10 },
                    { 13, 11 },
                    { 13, 17 },
                    { 13, 19 },
                    { 13, 24 },
                    { 13, 29 },
                    { 13, 36 },
                    { 13, 41 },
                    { 13, 46 },
                    { 13, 50 },
                    { 13, 51 },
                    { 13, 54 },
                    { 13, 59 },
                    { 13, 63 },
                    { 13, 68 },
                    { 13, 74 },
                    { 13, 76 },
                    { 13, 82 },
                    { 13, 85 },
                    { 13, 88 },
                    { 13, 93 },
                    { 13, 94 },
                    { 13, 113 },
                    { 13, 120 },
                    { 13, 139 },
                    { 13, 144 },
                    { 14, 10 },
                    { 14, 11 },
                    { 14, 12 },
                    { 14, 14 },
                    { 14, 15 },
                    { 14, 27 },
                    { 14, 28 },
                    { 14, 30 },
                    { 14, 31 },
                    { 14, 36 },
                    { 14, 37 },
                    { 14, 38 },
                    { 14, 43 },
                    { 14, 48 },
                    { 14, 53 },
                    { 14, 56 },
                    { 14, 63 },
                    { 14, 78 },
                    { 14, 79 },
                    { 14, 82 },
                    { 14, 102 },
                    { 14, 105 },
                    { 14, 110 },
                    { 14, 112 },
                    { 14, 117 },
                    { 14, 129 },
                    { 14, 135 },
                    { 14, 142 },
                    { 14, 148 },
                    { 14, 149 },
                    { 15, 27 },
                    { 15, 31 },
                    { 15, 35 },
                    { 15, 45 },
                    { 15, 48 },
                    { 15, 59 },
                    { 15, 65 },
                    { 15, 69 },
                    { 15, 70 },
                    { 15, 83 },
                    { 15, 84 },
                    { 15, 89 },
                    { 15, 90 },
                    { 15, 92 },
                    { 15, 93 },
                    { 15, 98 },
                    { 15, 99 },
                    { 15, 104 },
                    { 15, 106 },
                    { 15, 110 },
                    { 15, 113 },
                    { 15, 118 },
                    { 15, 119 },
                    { 15, 122 },
                    { 15, 129 },
                    { 15, 130 },
                    { 15, 132 },
                    { 15, 133 },
                    { 15, 145 },
                    { 16, 7 },
                    { 16, 8 },
                    { 16, 12 },
                    { 16, 14 },
                    { 16, 19 },
                    { 16, 22 },
                    { 16, 26 },
                    { 16, 28 },
                    { 16, 34 },
                    { 16, 38 },
                    { 16, 39 },
                    { 16, 48 },
                    { 16, 60 },
                    { 16, 72 },
                    { 16, 74 },
                    { 16, 75 },
                    { 16, 77 },
                    { 16, 94 },
                    { 16, 98 },
                    { 16, 100 },
                    { 16, 108 },
                    { 16, 113 },
                    { 16, 114 },
                    { 16, 127 },
                    { 16, 128 },
                    { 16, 130 },
                    { 16, 142 },
                    { 16, 147 },
                    { 17, 2 },
                    { 17, 18 },
                    { 17, 28 },
                    { 17, 32 },
                    { 17, 40 },
                    { 17, 41 },
                    { 17, 42 },
                    { 17, 44 },
                    { 17, 45 },
                    { 17, 49 },
                    { 17, 51 },
                    { 17, 52 },
                    { 17, 56 },
                    { 17, 57 },
                    { 17, 64 },
                    { 17, 66 },
                    { 17, 68 },
                    { 17, 75 },
                    { 17, 80 },
                    { 17, 81 },
                    { 17, 87 },
                    { 17, 95 },
                    { 17, 96 },
                    { 17, 100 },
                    { 17, 105 },
                    { 17, 111 },
                    { 17, 121 },
                    { 17, 141 },
                    { 17, 143 },
                    { 17, 147 },
                    { 18, 3 },
                    { 18, 10 },
                    { 18, 15 },
                    { 18, 16 },
                    { 18, 18 },
                    { 18, 26 },
                    { 18, 34 },
                    { 18, 50 },
                    { 18, 53 },
                    { 18, 55 },
                    { 18, 57 },
                    { 18, 59 },
                    { 18, 73 },
                    { 18, 86 },
                    { 18, 89 },
                    { 18, 91 },
                    { 18, 97 },
                    { 18, 100 },
                    { 18, 103 },
                    { 18, 115 },
                    { 18, 118 },
                    { 18, 121 },
                    { 18, 125 },
                    { 18, 129 },
                    { 18, 130 },
                    { 18, 131 },
                    { 18, 132 },
                    { 18, 134 },
                    { 18, 137 },
                    { 18, 139 },
                    { 18, 147 },
                    { 18, 149 },
                    { 19, 4 },
                    { 19, 17 },
                    { 19, 21 },
                    { 19, 26 },
                    { 19, 30 },
                    { 19, 32 },
                    { 19, 42 },
                    { 19, 47 },
                    { 19, 50 },
                    { 19, 57 },
                    { 19, 58 },
                    { 19, 59 },
                    { 19, 84 },
                    { 19, 86 },
                    { 19, 88 },
                    { 19, 92 },
                    { 19, 97 },
                    { 19, 98 },
                    { 19, 107 },
                    { 19, 120 },
                    { 19, 125 },
                    { 19, 129 },
                    { 19, 131 },
                    { 19, 140 },
                    { 20, 3 },
                    { 20, 18 },
                    { 20, 24 },
                    { 20, 29 },
                    { 20, 35 },
                    { 20, 39 },
                    { 20, 67 },
                    { 20, 70 },
                    { 20, 74 },
                    { 20, 75 },
                    { 20, 80 },
                    { 20, 90 },
                    { 20, 105 },
                    { 20, 109 },
                    { 20, 111 },
                    { 20, 112 },
                    { 20, 117 },
                    { 20, 122 },
                    { 20, 135 },
                    { 20, 148 },
                    { 21, 25 },
                    { 21, 42 },
                    { 21, 43 },
                    { 21, 54 },
                    { 21, 56 },
                    { 21, 58 },
                    { 21, 60 },
                    { 21, 62 },
                    { 21, 77 },
                    { 21, 82 },
                    { 21, 89 },
                    { 21, 91 },
                    { 21, 104 },
                    { 21, 108 },
                    { 21, 114 },
                    { 21, 115 },
                    { 21, 124 },
                    { 21, 133 },
                    { 21, 139 },
                    { 21, 140 },
                    { 21, 143 },
                    { 21, 147 },
                    { 21, 149 },
                    { 22, 4 },
                    { 22, 6 },
                    { 22, 7 },
                    { 22, 20 },
                    { 22, 28 },
                    { 22, 44 },
                    { 22, 46 },
                    { 22, 49 },
                    { 22, 61 },
                    { 22, 68 },
                    { 22, 69 },
                    { 22, 73 },
                    { 22, 79 },
                    { 22, 82 },
                    { 22, 90 },
                    { 22, 94 },
                    { 22, 105 },
                    { 22, 113 },
                    { 22, 114 },
                    { 22, 128 },
                    { 22, 138 },
                    { 22, 140 },
                    { 22, 144 },
                    { 22, 148 },
                    { 23, 2 },
                    { 23, 3 },
                    { 23, 5 },
                    { 23, 11 },
                    { 23, 13 },
                    { 23, 17 },
                    { 23, 19 },
                    { 23, 20 },
                    { 23, 25 },
                    { 23, 32 },
                    { 23, 40 },
                    { 23, 53 },
                    { 23, 58 },
                    { 23, 59 },
                    { 23, 63 },
                    { 23, 68 },
                    { 23, 70 },
                    { 23, 75 },
                    { 23, 81 },
                    { 23, 84 },
                    { 23, 88 },
                    { 23, 122 },
                    { 23, 123 },
                    { 23, 125 },
                    { 23, 127 },
                    { 23, 136 },
                    { 24, 1 },
                    { 24, 5 },
                    { 24, 8 },
                    { 24, 19 },
                    { 24, 26 },
                    { 24, 39 },
                    { 24, 52 },
                    { 24, 61 },
                    { 24, 71 },
                    { 24, 74 },
                    { 24, 75 },
                    { 24, 80 },
                    { 24, 83 },
                    { 24, 87 },
                    { 24, 91 },
                    { 24, 96 },
                    { 24, 103 },
                    { 24, 108 },
                    { 24, 120 },
                    { 24, 129 },
                    { 24, 141 },
                    { 24, 147 },
                    { 25, 15 },
                    { 25, 22 },
                    { 25, 23 },
                    { 25, 29 },
                    { 25, 37 },
                    { 25, 40 },
                    { 25, 43 },
                    { 25, 44 },
                    { 25, 66 },
                    { 25, 71 },
                    { 25, 79 },
                    { 25, 81 },
                    { 25, 83 },
                    { 25, 88 },
                    { 25, 89 },
                    { 25, 95 },
                    { 25, 100 },
                    { 25, 105 },
                    { 25, 106 },
                    { 25, 110 },
                    { 25, 112 },
                    { 25, 124 },
                    { 25, 130 },
                    { 25, 137 },
                    { 25, 140 },
                    { 26, 23 },
                    { 26, 40 },
                    { 26, 48 },
                    { 26, 51 },
                    { 26, 57 },
                    { 26, 58 },
                    { 26, 60 },
                    { 26, 62 },
                    { 26, 70 },
                    { 26, 71 },
                    { 26, 79 },
                    { 26, 80 },
                    { 26, 86 },
                    { 26, 95 },
                    { 26, 96 },
                    { 26, 97 },
                    { 26, 102 },
                    { 26, 107 },
                    { 26, 109 },
                    { 26, 118 },
                    { 26, 120 },
                    { 26, 139 },
                    { 26, 144 },
                    { 26, 145 },
                    { 26, 146 },
                    { 27, 4 },
                    { 27, 5 },
                    { 27, 8 },
                    { 27, 12 },
                    { 27, 16 },
                    { 27, 18 },
                    { 27, 33 },
                    { 27, 35 },
                    { 27, 38 },
                    { 27, 39 },
                    { 27, 43 },
                    { 27, 44 },
                    { 27, 46 },
                    { 27, 47 },
                    { 27, 49 },
                    { 27, 52 },
                    { 27, 62 },
                    { 27, 71 },
                    { 27, 72 },
                    { 27, 99 },
                    { 27, 104 },
                    { 27, 108 },
                    { 27, 109 },
                    { 27, 114 },
                    { 27, 116 },
                    { 27, 117 },
                    { 27, 119 },
                    { 27, 120 },
                    { 27, 121 },
                    { 27, 124 },
                    { 27, 128 },
                    { 27, 132 },
                    { 27, 134 },
                    { 27, 136 },
                    { 27, 137 },
                    { 27, 145 },
                    { 28, 1 },
                    { 28, 6 },
                    { 28, 9 },
                    { 28, 24 },
                    { 28, 25 },
                    { 28, 27 },
                    { 28, 33 },
                    { 28, 55 },
                    { 28, 61 },
                    { 28, 72 },
                    { 28, 76 },
                    { 28, 78 },
                    { 28, 82 },
                    { 28, 90 },
                    { 28, 92 },
                    { 28, 99 },
                    { 28, 106 },
                    { 28, 110 },
                    { 28, 111 },
                    { 28, 115 },
                    { 28, 121 },
                    { 28, 122 },
                    { 28, 130 },
                    { 28, 133 },
                    { 28, 136 },
                    { 28, 141 },
                    { 28, 146 },
                    { 28, 150 },
                    { 29, 9 },
                    { 29, 10 },
                    { 29, 18 },
                    { 29, 40 },
                    { 29, 42 },
                    { 29, 49 },
                    { 29, 54 },
                    { 29, 55 },
                    { 29, 56 },
                    { 29, 67 },
                    { 29, 69 },
                    { 29, 74 },
                    { 29, 78 },
                    { 29, 85 },
                    { 29, 87 },
                    { 29, 91 },
                    { 29, 101 },
                    { 29, 103 },
                    { 29, 106 },
                    { 29, 116 },
                    { 29, 118 },
                    { 29, 123 },
                    { 29, 141 },
                    { 29, 145 },
                    { 29, 149 },
                    { 29, 150 },
                    { 30, 3 },
                    { 30, 9 },
                    { 30, 34 },
                    { 30, 37 },
                    { 30, 44 },
                    { 30, 56 },
                    { 30, 61 },
                    { 30, 66 },
                    { 30, 73 },
                    { 30, 77 },
                    { 30, 83 },
                    { 30, 94 },
                    { 30, 99 },
                    { 30, 109 },
                    { 30, 126 },
                    { 30, 127 },
                    { 30, 131 },
                    { 30, 133 },
                    { 30, 138 },
                    { 31, 1 },
                    { 31, 9 },
                    { 31, 30 },
                    { 31, 33 },
                    { 31, 36 },
                    { 31, 38 },
                    { 31, 47 },
                    { 31, 52 },
                    { 31, 53 },
                    { 31, 60 },
                    { 31, 63 },
                    { 31, 65 },
                    { 31, 78 },
                    { 31, 83 },
                    { 31, 86 },
                    { 31, 98 },
                    { 31, 103 },
                    { 31, 106 },
                    { 31, 107 },
                    { 31, 111 },
                    { 31, 115 },
                    { 31, 116 },
                    { 31, 117 },
                    { 31, 119 },
                    { 31, 126 },
                    { 31, 127 },
                    { 31, 136 },
                    { 31, 142 },
                    { 31, 143 },
                    { 31, 148 },
                    { 32, 5 },
                    { 32, 7 },
                    { 32, 16 },
                    { 32, 17 },
                    { 32, 19 },
                    { 32, 22 },
                    { 32, 29 },
                    { 32, 43 },
                    { 32, 53 },
                    { 32, 62 },
                    { 32, 63 },
                    { 32, 64 },
                    { 32, 65 },
                    { 32, 66 },
                    { 32, 67 },
                    { 32, 68 },
                    { 32, 72 },
                    { 32, 76 },
                    { 32, 85 },
                    { 32, 87 },
                    { 32, 92 },
                    { 32, 93 },
                    { 32, 97 },
                    { 32, 126 },
                    { 32, 131 },
                    { 32, 132 },
                    { 32, 135 },
                    { 32, 146 },
                    { 33, 7 },
                    { 33, 8 },
                    { 33, 16 },
                    { 33, 23 },
                    { 33, 25 },
                    { 33, 37 },
                    { 33, 38 },
                    { 33, 52 },
                    { 33, 55 },
                    { 33, 58 },
                    { 33, 61 },
                    { 33, 81 },
                    { 33, 85 },
                    { 33, 86 },
                    { 33, 93 },
                    { 33, 96 },
                    { 33, 99 },
                    { 33, 101 },
                    { 33, 102 },
                    { 33, 107 },
                    { 33, 108 },
                    { 33, 111 },
                    { 33, 115 },
                    { 33, 121 },
                    { 33, 123 },
                    { 33, 126 },
                    { 33, 141 },
                    { 33, 146 },
                    { 33, 150 },
                    { 34, 24 },
                    { 34, 25 },
                    { 34, 27 },
                    { 34, 34 },
                    { 34, 49 },
                    { 34, 51 },
                    { 34, 64 },
                    { 34, 70 },
                    { 34, 71 },
                    { 34, 77 },
                    { 34, 87 },
                    { 34, 102 },
                    { 34, 107 },
                    { 34, 116 },
                    { 34, 123 },
                    { 34, 124 },
                    { 34, 128 },
                    { 34, 137 },
                    { 34, 144 }
                });

            migrationBuilder.InsertData(
                table: "ItemProperties",
                columns: new[] { "Id", "Deleted", "ItemId", "Label", "Value" },
                values: new object[,]
                {
                    { 1, null, 1, "Chiều dài", "28cm" },
                    { 2, null, 1, "Chiều rộng", "15cm" },
                    { 3, null, 1, "Chiều cao", "0cm" },
                    { 4, null, 1, "Cân nặng", "1242g" },
                    { 5, null, 2, "Chiều dài", "4cm" },
                    { 6, null, 2, "Chiều rộng", "2cm" },
                    { 7, null, 2, "Chiều cao", "2cm" },
                    { 8, null, 2, "Cân nặng", "4967g" },
                    { 9, null, 3, "Chiều dài", "14cm" },
                    { 10, null, 3, "Chiều rộng", "0cm" },
                    { 11, null, 3, "Chiều cao", "25cm" },
                    { 12, null, 3, "Cân nặng", "2336g" },
                    { 13, null, 4, "Chiều dài", "35cm" },
                    { 14, null, 4, "Chiều rộng", "7cm" },
                    { 15, null, 4, "Chiều cao", "24cm" },
                    { 16, null, 4, "Cân nặng", "3566g" },
                    { 17, null, 5, "Chiều dài", "30cm" },
                    { 18, null, 5, "Chiều rộng", "6cm" },
                    { 19, null, 5, "Chiều cao", "14cm" },
                    { 20, null, 5, "Cân nặng", "3989g" },
                    { 21, null, 6, "Chiều dài", "42cm" },
                    { 22, null, 6, "Chiều rộng", "17cm" },
                    { 23, null, 6, "Chiều cao", "36cm" },
                    { 24, null, 6, "Cân nặng", "4956g" },
                    { 25, null, 7, "Chiều dài", "7cm" },
                    { 26, null, 7, "Chiều rộng", "14cm" },
                    { 27, null, 7, "Chiều cao", "23cm" },
                    { 28, null, 7, "Cân nặng", "2917g" },
                    { 29, null, 8, "Chiều dài", "2cm" },
                    { 30, null, 8, "Chiều rộng", "17cm" },
                    { 31, null, 8, "Chiều cao", "10cm" },
                    { 32, null, 8, "Cân nặng", "3178g" },
                    { 33, null, 9, "Chiều dài", "38cm" },
                    { 34, null, 9, "Chiều rộng", "5cm" },
                    { 35, null, 9, "Chiều cao", "43cm" },
                    { 36, null, 9, "Cân nặng", "1391g" },
                    { 37, null, 10, "Chiều dài", "30cm" },
                    { 38, null, 10, "Chiều rộng", "12cm" },
                    { 39, null, 10, "Chiều cao", "22cm" },
                    { 40, null, 10, "Cân nặng", "998g" },
                    { 41, null, 11, "Chiều dài", "40cm" },
                    { 42, null, 11, "Chiều rộng", "1cm" },
                    { 43, null, 11, "Chiều cao", "3cm" },
                    { 44, null, 11, "Cân nặng", "4280g" },
                    { 45, null, 12, "Chiều dài", "46cm" },
                    { 46, null, 12, "Chiều rộng", "19cm" },
                    { 47, null, 12, "Chiều cao", "39cm" },
                    { 48, null, 12, "Cân nặng", "1671g" },
                    { 49, null, 13, "Chiều dài", "45cm" },
                    { 50, null, 13, "Chiều rộng", "1cm" },
                    { 51, null, 13, "Chiều cao", "35cm" },
                    { 52, null, 13, "Cân nặng", "1492g" },
                    { 53, null, 14, "Chiều dài", "16cm" },
                    { 54, null, 14, "Chiều rộng", "6cm" },
                    { 55, null, 14, "Chiều cao", "23cm" },
                    { 56, null, 14, "Cân nặng", "4985g" },
                    { 57, null, 15, "Chiều dài", "16cm" },
                    { 58, null, 15, "Chiều rộng", "14cm" },
                    { 59, null, 15, "Chiều cao", "43cm" },
                    { 60, null, 15, "Cân nặng", "4958g" },
                    { 61, null, 16, "Chiều dài", "40cm" },
                    { 62, null, 16, "Chiều rộng", "15cm" },
                    { 63, null, 16, "Chiều cao", "18cm" },
                    { 64, null, 16, "Cân nặng", "4965g" },
                    { 65, null, 17, "Chiều dài", "45cm" },
                    { 66, null, 17, "Chiều rộng", "16cm" },
                    { 67, null, 17, "Chiều cao", "24cm" },
                    { 68, null, 17, "Cân nặng", "3498g" },
                    { 69, null, 18, "Chiều dài", "47cm" },
                    { 70, null, 18, "Chiều rộng", "19cm" },
                    { 71, null, 18, "Chiều cao", "31cm" },
                    { 72, null, 18, "Cân nặng", "612g" },
                    { 73, null, 19, "Chiều dài", "30cm" },
                    { 74, null, 19, "Chiều rộng", "8cm" },
                    { 75, null, 19, "Chiều cao", "33cm" },
                    { 76, null, 19, "Cân nặng", "1126g" },
                    { 77, null, 20, "Chiều dài", "18cm" },
                    { 78, null, 20, "Chiều rộng", "12cm" },
                    { 79, null, 20, "Chiều cao", "32cm" },
                    { 80, null, 20, "Cân nặng", "1528g" },
                    { 81, null, 21, "Chiều dài", "32cm" },
                    { 82, null, 21, "Chiều rộng", "18cm" },
                    { 83, null, 21, "Chiều cao", "18cm" },
                    { 84, null, 21, "Cân nặng", "3416g" },
                    { 85, null, 22, "Chiều dài", "48cm" },
                    { 86, null, 22, "Chiều rộng", "2cm" },
                    { 87, null, 22, "Chiều cao", "37cm" },
                    { 88, null, 22, "Cân nặng", "714g" },
                    { 89, null, 23, "Chiều dài", "26cm" },
                    { 90, null, 23, "Chiều rộng", "12cm" },
                    { 91, null, 23, "Chiều cao", "47cm" },
                    { 92, null, 23, "Cân nặng", "4603g" },
                    { 93, null, 24, "Chiều dài", "24cm" },
                    { 94, null, 24, "Chiều rộng", "6cm" },
                    { 95, null, 24, "Chiều cao", "43cm" },
                    { 96, null, 24, "Cân nặng", "2478g" },
                    { 97, null, 25, "Chiều dài", "34cm" },
                    { 98, null, 25, "Chiều rộng", "7cm" },
                    { 99, null, 25, "Chiều cao", "17cm" },
                    { 100, null, 25, "Cân nặng", "3418g" },
                    { 101, null, 26, "Chiều dài", "17cm" },
                    { 102, null, 26, "Chiều rộng", "1cm" },
                    { 103, null, 26, "Chiều cao", "49cm" },
                    { 104, null, 26, "Cân nặng", "4503g" },
                    { 105, null, 27, "Chiều dài", "27cm" },
                    { 106, null, 27, "Chiều rộng", "18cm" },
                    { 107, null, 27, "Chiều cao", "25cm" },
                    { 108, null, 27, "Cân nặng", "732g" },
                    { 109, null, 28, "Chiều dài", "49cm" },
                    { 110, null, 28, "Chiều rộng", "15cm" },
                    { 111, null, 28, "Chiều cao", "41cm" },
                    { 112, null, 28, "Cân nặng", "4794g" },
                    { 113, null, 29, "Chiều dài", "1cm" },
                    { 114, null, 29, "Chiều rộng", "13cm" },
                    { 115, null, 29, "Chiều cao", "49cm" },
                    { 116, null, 29, "Cân nặng", "2354g" },
                    { 117, null, 30, "Chiều dài", "9cm" },
                    { 118, null, 30, "Chiều rộng", "14cm" },
                    { 119, null, 30, "Chiều cao", "46cm" },
                    { 120, null, 30, "Cân nặng", "2623g" },
                    { 121, null, 31, "Chiều dài", "31cm" },
                    { 122, null, 31, "Chiều rộng", "3cm" },
                    { 123, null, 31, "Chiều cao", "25cm" },
                    { 124, null, 31, "Cân nặng", "3576g" },
                    { 125, null, 32, "Chiều dài", "41cm" },
                    { 126, null, 32, "Chiều rộng", "4cm" },
                    { 127, null, 32, "Chiều cao", "33cm" },
                    { 128, null, 32, "Cân nặng", "2541g" },
                    { 129, null, 33, "Chiều dài", "30cm" },
                    { 130, null, 33, "Chiều rộng", "19cm" },
                    { 131, null, 33, "Chiều cao", "22cm" },
                    { 132, null, 33, "Cân nặng", "1621g" },
                    { 133, null, 34, "Chiều dài", "25cm" },
                    { 134, null, 34, "Chiều rộng", "3cm" },
                    { 135, null, 34, "Chiều cao", "9cm" },
                    { 136, null, 34, "Cân nặng", "4891g" },
                    { 137, null, 35, "Chiều dài", "39cm" },
                    { 138, null, 35, "Chiều rộng", "8cm" },
                    { 139, null, 35, "Chiều cao", "20cm" },
                    { 140, null, 35, "Cân nặng", "2998g" },
                    { 141, null, 36, "Chiều dài", "5cm" },
                    { 142, null, 36, "Chiều rộng", "1cm" },
                    { 143, null, 36, "Chiều cao", "31cm" },
                    { 144, null, 36, "Cân nặng", "4859g" },
                    { 145, null, 37, "Chiều dài", "47cm" },
                    { 146, null, 37, "Chiều rộng", "18cm" },
                    { 147, null, 37, "Chiều cao", "38cm" },
                    { 148, null, 37, "Cân nặng", "849g" },
                    { 149, null, 38, "Chiều dài", "8cm" },
                    { 150, null, 38, "Chiều rộng", "14cm" },
                    { 151, null, 38, "Chiều cao", "31cm" },
                    { 152, null, 38, "Cân nặng", "2060g" },
                    { 153, null, 39, "Chiều dài", "5cm" },
                    { 154, null, 39, "Chiều rộng", "4cm" },
                    { 155, null, 39, "Chiều cao", "13cm" },
                    { 156, null, 39, "Cân nặng", "592g" },
                    { 157, null, 40, "Chiều dài", "17cm" },
                    { 158, null, 40, "Chiều rộng", "11cm" },
                    { 159, null, 40, "Chiều cao", "40cm" },
                    { 160, null, 40, "Cân nặng", "2755g" },
                    { 161, null, 41, "Chiều dài", "27cm" },
                    { 162, null, 41, "Chiều rộng", "16cm" },
                    { 163, null, 41, "Chiều cao", "8cm" },
                    { 164, null, 41, "Cân nặng", "4469g" },
                    { 165, null, 42, "Chiều dài", "46cm" },
                    { 166, null, 42, "Chiều rộng", "11cm" },
                    { 167, null, 42, "Chiều cao", "39cm" },
                    { 168, null, 42, "Cân nặng", "1917g" },
                    { 169, null, 43, "Chiều dài", "7cm" },
                    { 170, null, 43, "Chiều rộng", "16cm" },
                    { 171, null, 43, "Chiều cao", "38cm" },
                    { 172, null, 43, "Cân nặng", "2049g" },
                    { 173, null, 44, "Chiều dài", "33cm" },
                    { 174, null, 44, "Chiều rộng", "2cm" },
                    { 175, null, 44, "Chiều cao", "46cm" },
                    { 176, null, 44, "Cân nặng", "3283g" },
                    { 177, null, 45, "Chiều dài", "13cm" },
                    { 178, null, 45, "Chiều rộng", "4cm" },
                    { 179, null, 45, "Chiều cao", "29cm" },
                    { 180, null, 45, "Cân nặng", "2511g" },
                    { 181, null, 46, "Chiều dài", "48cm" },
                    { 182, null, 46, "Chiều rộng", "13cm" },
                    { 183, null, 46, "Chiều cao", "10cm" },
                    { 184, null, 46, "Cân nặng", "2231g" },
                    { 185, null, 47, "Chiều dài", "25cm" },
                    { 186, null, 47, "Chiều rộng", "15cm" },
                    { 187, null, 47, "Chiều cao", "39cm" },
                    { 188, null, 47, "Cân nặng", "4837g" },
                    { 189, null, 48, "Chiều dài", "4cm" },
                    { 190, null, 48, "Chiều rộng", "16cm" },
                    { 191, null, 48, "Chiều cao", "18cm" },
                    { 192, null, 48, "Cân nặng", "4534g" },
                    { 193, null, 49, "Chiều dài", "23cm" },
                    { 194, null, 49, "Chiều rộng", "12cm" },
                    { 195, null, 49, "Chiều cao", "20cm" },
                    { 196, null, 49, "Cân nặng", "4882g" },
                    { 197, null, 50, "Chiều dài", "17cm" },
                    { 198, null, 50, "Chiều rộng", "19cm" },
                    { 199, null, 50, "Chiều cao", "21cm" },
                    { 200, null, 50, "Cân nặng", "1120g" },
                    { 201, null, 51, "Chiều dài", "21cm" },
                    { 202, null, 51, "Chiều rộng", "16cm" },
                    { 203, null, 51, "Chiều cao", "35cm" },
                    { 204, null, 51, "Cân nặng", "2626g" },
                    { 205, null, 52, "Chiều dài", "18cm" },
                    { 206, null, 52, "Chiều rộng", "5cm" },
                    { 207, null, 52, "Chiều cao", "36cm" },
                    { 208, null, 52, "Cân nặng", "2354g" },
                    { 209, null, 53, "Chiều dài", "38cm" },
                    { 210, null, 53, "Chiều rộng", "4cm" },
                    { 211, null, 53, "Chiều cao", "7cm" },
                    { 212, null, 53, "Cân nặng", "3793g" },
                    { 213, null, 54, "Chiều dài", "30cm" },
                    { 214, null, 54, "Chiều rộng", "16cm" },
                    { 215, null, 54, "Chiều cao", "4cm" },
                    { 216, null, 54, "Cân nặng", "4890g" },
                    { 217, null, 55, "Chiều dài", "23cm" },
                    { 218, null, 55, "Chiều rộng", "14cm" },
                    { 219, null, 55, "Chiều cao", "25cm" },
                    { 220, null, 55, "Cân nặng", "637g" },
                    { 221, null, 56, "Chiều dài", "49cm" },
                    { 222, null, 56, "Chiều rộng", "11cm" },
                    { 223, null, 56, "Chiều cao", "23cm" },
                    { 224, null, 56, "Cân nặng", "834g" },
                    { 225, null, 57, "Chiều dài", "17cm" },
                    { 226, null, 57, "Chiều rộng", "10cm" },
                    { 227, null, 57, "Chiều cao", "48cm" },
                    { 228, null, 57, "Cân nặng", "1367g" },
                    { 229, null, 58, "Chiều dài", "19cm" },
                    { 230, null, 58, "Chiều rộng", "3cm" },
                    { 231, null, 58, "Chiều cao", "15cm" },
                    { 232, null, 58, "Cân nặng", "4927g" },
                    { 233, null, 59, "Chiều dài", "44cm" },
                    { 234, null, 59, "Chiều rộng", "12cm" },
                    { 235, null, 59, "Chiều cao", "30cm" },
                    { 236, null, 59, "Cân nặng", "3857g" },
                    { 237, null, 60, "Chiều dài", "43cm" },
                    { 238, null, 60, "Chiều rộng", "1cm" },
                    { 239, null, 60, "Chiều cao", "40cm" },
                    { 240, null, 60, "Cân nặng", "4825g" },
                    { 241, null, 61, "Chiều dài", "47cm" },
                    { 242, null, 61, "Chiều rộng", "4cm" },
                    { 243, null, 61, "Chiều cao", "35cm" },
                    { 244, null, 61, "Cân nặng", "2859g" },
                    { 245, null, 62, "Chiều dài", "7cm" },
                    { 246, null, 62, "Chiều rộng", "14cm" },
                    { 247, null, 62, "Chiều cao", "49cm" },
                    { 248, null, 62, "Cân nặng", "1889g" },
                    { 249, null, 63, "Chiều dài", "35cm" },
                    { 250, null, 63, "Chiều rộng", "1cm" },
                    { 251, null, 63, "Chiều cao", "17cm" },
                    { 252, null, 63, "Cân nặng", "3806g" },
                    { 253, null, 64, "Chiều dài", "10cm" },
                    { 254, null, 64, "Chiều rộng", "17cm" },
                    { 255, null, 64, "Chiều cao", "1cm" },
                    { 256, null, 64, "Cân nặng", "1796g" },
                    { 257, null, 65, "Chiều dài", "5cm" },
                    { 258, null, 65, "Chiều rộng", "0cm" },
                    { 259, null, 65, "Chiều cao", "20cm" },
                    { 260, null, 65, "Cân nặng", "1986g" },
                    { 261, null, 66, "Chiều dài", "4cm" },
                    { 262, null, 66, "Chiều rộng", "11cm" },
                    { 263, null, 66, "Chiều cao", "43cm" },
                    { 264, null, 66, "Cân nặng", "2657g" },
                    { 265, null, 67, "Chiều dài", "9cm" },
                    { 266, null, 67, "Chiều rộng", "12cm" },
                    { 267, null, 67, "Chiều cao", "36cm" },
                    { 268, null, 67, "Cân nặng", "3471g" },
                    { 269, null, 68, "Chiều dài", "41cm" },
                    { 270, null, 68, "Chiều rộng", "3cm" },
                    { 271, null, 68, "Chiều cao", "14cm" },
                    { 272, null, 68, "Cân nặng", "4983g" },
                    { 273, null, 69, "Chiều dài", "21cm" },
                    { 274, null, 69, "Chiều rộng", "2cm" },
                    { 275, null, 69, "Chiều cao", "22cm" },
                    { 276, null, 69, "Cân nặng", "1757g" },
                    { 277, null, 70, "Chiều dài", "44cm" },
                    { 278, null, 70, "Chiều rộng", "13cm" },
                    { 279, null, 70, "Chiều cao", "32cm" },
                    { 280, null, 70, "Cân nặng", "3246g" },
                    { 281, null, 71, "Chiều dài", "18cm" },
                    { 282, null, 71, "Chiều rộng", "15cm" },
                    { 283, null, 71, "Chiều cao", "14cm" },
                    { 284, null, 71, "Cân nặng", "1614g" },
                    { 285, null, 72, "Chiều dài", "16cm" },
                    { 286, null, 72, "Chiều rộng", "12cm" },
                    { 287, null, 72, "Chiều cao", "34cm" },
                    { 288, null, 72, "Cân nặng", "3712g" },
                    { 289, null, 73, "Chiều dài", "17cm" },
                    { 290, null, 73, "Chiều rộng", "3cm" },
                    { 291, null, 73, "Chiều cao", "4cm" },
                    { 292, null, 73, "Cân nặng", "3220g" },
                    { 293, null, 74, "Chiều dài", "9cm" },
                    { 294, null, 74, "Chiều rộng", "8cm" },
                    { 295, null, 74, "Chiều cao", "10cm" },
                    { 296, null, 74, "Cân nặng", "1848g" },
                    { 297, null, 75, "Chiều dài", "41cm" },
                    { 298, null, 75, "Chiều rộng", "19cm" },
                    { 299, null, 75, "Chiều cao", "30cm" },
                    { 300, null, 75, "Cân nặng", "2785g" },
                    { 301, null, 76, "Chiều dài", "28cm" },
                    { 302, null, 76, "Chiều rộng", "17cm" },
                    { 303, null, 76, "Chiều cao", "25cm" },
                    { 304, null, 76, "Cân nặng", "3009g" },
                    { 305, null, 77, "Chiều dài", "39cm" },
                    { 306, null, 77, "Chiều rộng", "9cm" },
                    { 307, null, 77, "Chiều cao", "40cm" },
                    { 308, null, 77, "Cân nặng", "2024g" },
                    { 309, null, 78, "Chiều dài", "27cm" },
                    { 310, null, 78, "Chiều rộng", "6cm" },
                    { 311, null, 78, "Chiều cao", "28cm" },
                    { 312, null, 78, "Cân nặng", "3376g" },
                    { 313, null, 79, "Chiều dài", "30cm" },
                    { 314, null, 79, "Chiều rộng", "1cm" },
                    { 315, null, 79, "Chiều cao", "4cm" },
                    { 316, null, 79, "Cân nặng", "1254g" },
                    { 317, null, 80, "Chiều dài", "29cm" },
                    { 318, null, 80, "Chiều rộng", "7cm" },
                    { 319, null, 80, "Chiều cao", "49cm" },
                    { 320, null, 80, "Cân nặng", "4601g" },
                    { 321, null, 81, "Chiều dài", "48cm" },
                    { 322, null, 81, "Chiều rộng", "0cm" },
                    { 323, null, 81, "Chiều cao", "34cm" },
                    { 324, null, 81, "Cân nặng", "2789g" },
                    { 325, null, 82, "Chiều dài", "41cm" },
                    { 326, null, 82, "Chiều rộng", "16cm" },
                    { 327, null, 82, "Chiều cao", "19cm" },
                    { 328, null, 82, "Cân nặng", "3880g" },
                    { 329, null, 83, "Chiều dài", "31cm" },
                    { 330, null, 83, "Chiều rộng", "17cm" },
                    { 331, null, 83, "Chiều cao", "40cm" },
                    { 332, null, 83, "Cân nặng", "4495g" },
                    { 333, null, 84, "Chiều dài", "31cm" },
                    { 334, null, 84, "Chiều rộng", "18cm" },
                    { 335, null, 84, "Chiều cao", "32cm" },
                    { 336, null, 84, "Cân nặng", "1691g" },
                    { 337, null, 85, "Chiều dài", "48cm" },
                    { 338, null, 85, "Chiều rộng", "4cm" },
                    { 339, null, 85, "Chiều cao", "21cm" },
                    { 340, null, 85, "Cân nặng", "3147g" },
                    { 341, null, 86, "Chiều dài", "35cm" },
                    { 342, null, 86, "Chiều rộng", "9cm" },
                    { 343, null, 86, "Chiều cao", "6cm" },
                    { 344, null, 86, "Cân nặng", "4594g" },
                    { 345, null, 87, "Chiều dài", "13cm" },
                    { 346, null, 87, "Chiều rộng", "5cm" },
                    { 347, null, 87, "Chiều cao", "14cm" },
                    { 348, null, 87, "Cân nặng", "2980g" },
                    { 349, null, 88, "Chiều dài", "45cm" },
                    { 350, null, 88, "Chiều rộng", "16cm" },
                    { 351, null, 88, "Chiều cao", "41cm" },
                    { 352, null, 88, "Cân nặng", "3357g" },
                    { 353, null, 89, "Chiều dài", "23cm" },
                    { 354, null, 89, "Chiều rộng", "10cm" },
                    { 355, null, 89, "Chiều cao", "2cm" },
                    { 356, null, 89, "Cân nặng", "2115g" },
                    { 357, null, 90, "Chiều dài", "12cm" },
                    { 358, null, 90, "Chiều rộng", "2cm" },
                    { 359, null, 90, "Chiều cao", "8cm" },
                    { 360, null, 90, "Cân nặng", "1814g" },
                    { 361, null, 91, "Chiều dài", "6cm" },
                    { 362, null, 91, "Chiều rộng", "6cm" },
                    { 363, null, 91, "Chiều cao", "11cm" },
                    { 364, null, 91, "Cân nặng", "4218g" },
                    { 365, null, 92, "Chiều dài", "32cm" },
                    { 366, null, 92, "Chiều rộng", "4cm" },
                    { 367, null, 92, "Chiều cao", "35cm" },
                    { 368, null, 92, "Cân nặng", "1567g" },
                    { 369, null, 93, "Chiều dài", "21cm" },
                    { 370, null, 93, "Chiều rộng", "0cm" },
                    { 371, null, 93, "Chiều cao", "25cm" },
                    { 372, null, 93, "Cân nặng", "4811g" },
                    { 373, null, 94, "Chiều dài", "34cm" },
                    { 374, null, 94, "Chiều rộng", "10cm" },
                    { 375, null, 94, "Chiều cao", "24cm" },
                    { 376, null, 94, "Cân nặng", "3762g" },
                    { 377, null, 95, "Chiều dài", "39cm" },
                    { 378, null, 95, "Chiều rộng", "6cm" },
                    { 379, null, 95, "Chiều cao", "40cm" },
                    { 380, null, 95, "Cân nặng", "2111g" },
                    { 381, null, 96, "Chiều dài", "33cm" },
                    { 382, null, 96, "Chiều rộng", "18cm" },
                    { 383, null, 96, "Chiều cao", "5cm" },
                    { 384, null, 96, "Cân nặng", "2041g" },
                    { 385, null, 97, "Chiều dài", "47cm" },
                    { 386, null, 97, "Chiều rộng", "18cm" },
                    { 387, null, 97, "Chiều cao", "2cm" },
                    { 388, null, 97, "Cân nặng", "780g" },
                    { 389, null, 98, "Chiều dài", "13cm" },
                    { 390, null, 98, "Chiều rộng", "3cm" },
                    { 391, null, 98, "Chiều cao", "2cm" },
                    { 392, null, 98, "Cân nặng", "1844g" },
                    { 393, null, 99, "Chiều dài", "17cm" },
                    { 394, null, 99, "Chiều rộng", "17cm" },
                    { 395, null, 99, "Chiều cao", "26cm" },
                    { 396, null, 99, "Cân nặng", "1208g" },
                    { 397, null, 100, "Chiều dài", "43cm" },
                    { 398, null, 100, "Chiều rộng", "18cm" },
                    { 399, null, 100, "Chiều cao", "25cm" },
                    { 400, null, 100, "Cân nặng", "1263g" },
                    { 401, null, 101, "Chiều dài", "44cm" },
                    { 402, null, 101, "Chiều rộng", "16cm" },
                    { 403, null, 101, "Chiều cao", "2cm" },
                    { 404, null, 101, "Cân nặng", "3286g" },
                    { 405, null, 102, "Chiều dài", "32cm" },
                    { 406, null, 102, "Chiều rộng", "0cm" },
                    { 407, null, 102, "Chiều cao", "25cm" },
                    { 408, null, 102, "Cân nặng", "2498g" },
                    { 409, null, 103, "Chiều dài", "32cm" },
                    { 410, null, 103, "Chiều rộng", "9cm" },
                    { 411, null, 103, "Chiều cao", "45cm" },
                    { 412, null, 103, "Cân nặng", "3616g" },
                    { 413, null, 104, "Chiều dài", "14cm" },
                    { 414, null, 104, "Chiều rộng", "3cm" },
                    { 415, null, 104, "Chiều cao", "27cm" },
                    { 416, null, 104, "Cân nặng", "836g" },
                    { 417, null, 105, "Chiều dài", "17cm" },
                    { 418, null, 105, "Chiều rộng", "19cm" },
                    { 419, null, 105, "Chiều cao", "46cm" },
                    { 420, null, 105, "Cân nặng", "3250g" },
                    { 421, null, 106, "Chiều dài", "48cm" },
                    { 422, null, 106, "Chiều rộng", "8cm" },
                    { 423, null, 106, "Chiều cao", "10cm" },
                    { 424, null, 106, "Cân nặng", "593g" },
                    { 425, null, 107, "Chiều dài", "39cm" },
                    { 426, null, 107, "Chiều rộng", "7cm" },
                    { 427, null, 107, "Chiều cao", "45cm" },
                    { 428, null, 107, "Cân nặng", "1240g" },
                    { 429, null, 108, "Chiều dài", "31cm" },
                    { 430, null, 108, "Chiều rộng", "13cm" },
                    { 431, null, 108, "Chiều cao", "45cm" },
                    { 432, null, 108, "Cân nặng", "3242g" },
                    { 433, null, 109, "Chiều dài", "34cm" },
                    { 434, null, 109, "Chiều rộng", "1cm" },
                    { 435, null, 109, "Chiều cao", "39cm" },
                    { 436, null, 109, "Cân nặng", "2344g" },
                    { 437, null, 110, "Chiều dài", "34cm" },
                    { 438, null, 110, "Chiều rộng", "1cm" },
                    { 439, null, 110, "Chiều cao", "6cm" },
                    { 440, null, 110, "Cân nặng", "2292g" },
                    { 441, null, 111, "Chiều dài", "21cm" },
                    { 442, null, 111, "Chiều rộng", "15cm" },
                    { 443, null, 111, "Chiều cao", "18cm" },
                    { 444, null, 111, "Cân nặng", "4326g" },
                    { 445, null, 112, "Chiều dài", "10cm" },
                    { 446, null, 112, "Chiều rộng", "3cm" },
                    { 447, null, 112, "Chiều cao", "39cm" },
                    { 448, null, 112, "Cân nặng", "1233g" },
                    { 449, null, 113, "Chiều dài", "40cm" },
                    { 450, null, 113, "Chiều rộng", "19cm" },
                    { 451, null, 113, "Chiều cao", "8cm" },
                    { 452, null, 113, "Cân nặng", "4733g" },
                    { 453, null, 114, "Chiều dài", "15cm" },
                    { 454, null, 114, "Chiều rộng", "12cm" },
                    { 455, null, 114, "Chiều cao", "49cm" },
                    { 456, null, 114, "Cân nặng", "2100g" },
                    { 457, null, 115, "Chiều dài", "7cm" },
                    { 458, null, 115, "Chiều rộng", "4cm" },
                    { 459, null, 115, "Chiều cao", "12cm" },
                    { 460, null, 115, "Cân nặng", "4321g" },
                    { 461, null, 116, "Chiều dài", "33cm" },
                    { 462, null, 116, "Chiều rộng", "4cm" },
                    { 463, null, 116, "Chiều cao", "15cm" },
                    { 464, null, 116, "Cân nặng", "3389g" },
                    { 465, null, 117, "Chiều dài", "28cm" },
                    { 466, null, 117, "Chiều rộng", "11cm" },
                    { 467, null, 117, "Chiều cao", "36cm" },
                    { 468, null, 117, "Cân nặng", "2101g" },
                    { 469, null, 118, "Chiều dài", "1cm" },
                    { 470, null, 118, "Chiều rộng", "6cm" },
                    { 471, null, 118, "Chiều cao", "6cm" },
                    { 472, null, 118, "Cân nặng", "3904g" },
                    { 473, null, 119, "Chiều dài", "17cm" },
                    { 474, null, 119, "Chiều rộng", "2cm" },
                    { 475, null, 119, "Chiều cao", "10cm" },
                    { 476, null, 119, "Cân nặng", "3769g" },
                    { 477, null, 120, "Chiều dài", "5cm" },
                    { 478, null, 120, "Chiều rộng", "8cm" },
                    { 479, null, 120, "Chiều cao", "46cm" },
                    { 480, null, 120, "Cân nặng", "592g" },
                    { 481, null, 121, "Chiều dài", "12cm" },
                    { 482, null, 121, "Chiều rộng", "10cm" },
                    { 483, null, 121, "Chiều cao", "14cm" },
                    { 484, null, 121, "Cân nặng", "2945g" },
                    { 485, null, 122, "Chiều dài", "36cm" },
                    { 486, null, 122, "Chiều rộng", "2cm" },
                    { 487, null, 122, "Chiều cao", "49cm" },
                    { 488, null, 122, "Cân nặng", "1611g" },
                    { 489, null, 123, "Chiều dài", "30cm" },
                    { 490, null, 123, "Chiều rộng", "14cm" },
                    { 491, null, 123, "Chiều cao", "44cm" },
                    { 492, null, 123, "Cân nặng", "3334g" },
                    { 493, null, 124, "Chiều dài", "21cm" },
                    { 494, null, 124, "Chiều rộng", "18cm" },
                    { 495, null, 124, "Chiều cao", "4cm" },
                    { 496, null, 124, "Cân nặng", "3687g" },
                    { 497, null, 125, "Chiều dài", "39cm" },
                    { 498, null, 125, "Chiều rộng", "15cm" },
                    { 499, null, 125, "Chiều cao", "17cm" },
                    { 500, null, 125, "Cân nặng", "3602g" },
                    { 501, null, 126, "Chiều dài", "19cm" },
                    { 502, null, 126, "Chiều rộng", "3cm" },
                    { 503, null, 126, "Chiều cao", "32cm" },
                    { 504, null, 126, "Cân nặng", "2152g" },
                    { 505, null, 127, "Chiều dài", "43cm" },
                    { 506, null, 127, "Chiều rộng", "11cm" },
                    { 507, null, 127, "Chiều cao", "10cm" },
                    { 508, null, 127, "Cân nặng", "4362g" },
                    { 509, null, 128, "Chiều dài", "10cm" },
                    { 510, null, 128, "Chiều rộng", "12cm" },
                    { 511, null, 128, "Chiều cao", "40cm" },
                    { 512, null, 128, "Cân nặng", "2712g" },
                    { 513, null, 129, "Chiều dài", "48cm" },
                    { 514, null, 129, "Chiều rộng", "14cm" },
                    { 515, null, 129, "Chiều cao", "45cm" },
                    { 516, null, 129, "Cân nặng", "2211g" },
                    { 517, null, 130, "Chiều dài", "2cm" },
                    { 518, null, 130, "Chiều rộng", "0cm" },
                    { 519, null, 130, "Chiều cao", "27cm" },
                    { 520, null, 130, "Cân nặng", "2373g" },
                    { 521, null, 131, "Chiều dài", "16cm" },
                    { 522, null, 131, "Chiều rộng", "13cm" },
                    { 523, null, 131, "Chiều cao", "25cm" },
                    { 524, null, 131, "Cân nặng", "3242g" },
                    { 525, null, 132, "Chiều dài", "13cm" },
                    { 526, null, 132, "Chiều rộng", "14cm" },
                    { 527, null, 132, "Chiều cao", "46cm" },
                    { 528, null, 132, "Cân nặng", "1247g" },
                    { 529, null, 133, "Chiều dài", "36cm" },
                    { 530, null, 133, "Chiều rộng", "10cm" },
                    { 531, null, 133, "Chiều cao", "32cm" },
                    { 532, null, 133, "Cân nặng", "2491g" },
                    { 533, null, 134, "Chiều dài", "6cm" },
                    { 534, null, 134, "Chiều rộng", "11cm" },
                    { 535, null, 134, "Chiều cao", "30cm" },
                    { 536, null, 134, "Cân nặng", "758g" },
                    { 537, null, 135, "Chiều dài", "16cm" },
                    { 538, null, 135, "Chiều rộng", "6cm" },
                    { 539, null, 135, "Chiều cao", "35cm" },
                    { 540, null, 135, "Cân nặng", "711g" },
                    { 541, null, 136, "Chiều dài", "48cm" },
                    { 542, null, 136, "Chiều rộng", "3cm" },
                    { 543, null, 136, "Chiều cao", "15cm" },
                    { 544, null, 136, "Cân nặng", "1351g" },
                    { 545, null, 137, "Chiều dài", "38cm" },
                    { 546, null, 137, "Chiều rộng", "9cm" },
                    { 547, null, 137, "Chiều cao", "30cm" },
                    { 548, null, 137, "Cân nặng", "871g" },
                    { 549, null, 138, "Chiều dài", "10cm" },
                    { 550, null, 138, "Chiều rộng", "16cm" },
                    { 551, null, 138, "Chiều cao", "28cm" },
                    { 552, null, 138, "Cân nặng", "1407g" },
                    { 553, null, 139, "Chiều dài", "46cm" },
                    { 554, null, 139, "Chiều rộng", "8cm" },
                    { 555, null, 139, "Chiều cao", "29cm" },
                    { 556, null, 139, "Cân nặng", "2848g" },
                    { 557, null, 140, "Chiều dài", "33cm" },
                    { 558, null, 140, "Chiều rộng", "19cm" },
                    { 559, null, 140, "Chiều cao", "27cm" },
                    { 560, null, 140, "Cân nặng", "969g" },
                    { 561, null, 141, "Chiều dài", "11cm" },
                    { 562, null, 141, "Chiều rộng", "11cm" },
                    { 563, null, 141, "Chiều cao", "30cm" },
                    { 564, null, 141, "Cân nặng", "1307g" },
                    { 565, null, 142, "Chiều dài", "24cm" },
                    { 566, null, 142, "Chiều rộng", "18cm" },
                    { 567, null, 142, "Chiều cao", "30cm" },
                    { 568, null, 142, "Cân nặng", "702g" },
                    { 569, null, 143, "Chiều dài", "9cm" },
                    { 570, null, 143, "Chiều rộng", "11cm" },
                    { 571, null, 143, "Chiều cao", "15cm" },
                    { 572, null, 143, "Cân nặng", "1680g" },
                    { 573, null, 144, "Chiều dài", "46cm" },
                    { 574, null, 144, "Chiều rộng", "15cm" },
                    { 575, null, 144, "Chiều cao", "41cm" },
                    { 576, null, 144, "Cân nặng", "2263g" },
                    { 577, null, 145, "Chiều dài", "5cm" },
                    { 578, null, 145, "Chiều rộng", "7cm" },
                    { 579, null, 145, "Chiều cao", "43cm" },
                    { 580, null, 145, "Cân nặng", "1879g" },
                    { 581, null, 146, "Chiều dài", "49cm" },
                    { 582, null, 146, "Chiều rộng", "7cm" },
                    { 583, null, 146, "Chiều cao", "23cm" },
                    { 584, null, 146, "Cân nặng", "4037g" },
                    { 585, null, 147, "Chiều dài", "45cm" },
                    { 586, null, 147, "Chiều rộng", "1cm" },
                    { 587, null, 147, "Chiều cao", "11cm" },
                    { 588, null, 147, "Cân nặng", "2219g" },
                    { 589, null, 148, "Chiều dài", "40cm" },
                    { 590, null, 148, "Chiều rộng", "14cm" },
                    { 591, null, 148, "Chiều cao", "6cm" },
                    { 592, null, 148, "Cân nặng", "1837g" },
                    { 593, null, 149, "Chiều dài", "15cm" },
                    { 594, null, 149, "Chiều rộng", "3cm" },
                    { 595, null, 149, "Chiều cao", "40cm" },
                    { 596, null, 149, "Cân nặng", "2129g" },
                    { 597, null, 150, "Chiều dài", "1cm" },
                    { 598, null, 150, "Chiều rộng", "11cm" },
                    { 599, null, 150, "Chiều cao", "41cm" },
                    { 600, null, 150, "Cân nặng", "2017g" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "Deleted", "Description", "ExpertId", "HighestBidId", "Name", "OngoingSessionId", "OrderId", "PaymentDueDate", "SellerId", "ShipmentId", "Status", "ThumbnailId", "WonDate" },
                values: new object[,]
                {
                    { 151, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Xe 151", null, 19, null, 142, 23, 8, 21, null },
                    { 152, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Trang sức 152", null, 15, null, 116, 19, 8, 28, null },
                    { 153, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Văn tự 153", null, 25, null, 142, 29, 8, 23, null },
                    { 154, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Nội thất 154", null, 26, null, 157, 30, 8, 32, null },
                    { 155, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Tiền cổ 155", null, 3, null, 159, 3, 8, 25, null },
                    { 156, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Văn tự 156", null, 7, null, 118, 9, 8, 15, null },
                    { 159, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Trang sức 159", null, 11, null, 147, 15, 8, 10, null },
                    { 160, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Tranh 160", null, 12, null, 153, 16, 8, 18, null },
                    { 161, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Nội thất 161", null, 23, null, 151, 27, 8, 11, null },
                    { 162, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Trang phục 162", null, 4, null, 120, 5, 8, 18, null },
                    { 165, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Tiền cổ 165", null, 5, null, 150, 7, 8, 11, null },
                    { 168, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Khoáng sản 168", null, 10, null, 129, 14, 8, 24, null },
                    { 169, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Trang sức 169", null, 20, null, 130, 24, 8, 16, null },
                    { 171, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Trang sức 171", null, 4, null, 136, 6, 8, 16, null },
                    { 174, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Nội thất 174", null, 14, null, 110, 18, 8, 12, null },
                    { 176, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Văn tự 176", null, 13, null, 124, 17, 8, 6, null },
                    { 177, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Tiền cổ 177", null, 16, null, 110, 20, 8, 32, null },
                    { 180, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Trang sức 180", null, 2, null, 131, 2, 8, 28, null },
                    { 183, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Tiền cổ 183", null, 8, null, 155, 12, 8, 14, null },
                    { 185, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Khoáng sản 185", null, 1, null, 153, 1, 8, 13, null },
                    { 186, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Khoáng sản 186", null, 24, null, 118, 28, 8, 7, null },
                    { 187, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Văn tự 187", null, 3, null, 117, 4, 8, 23, null },
                    { 189, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Khoáng sản 189", null, 17, null, 156, 21, 8, 23, null },
                    { 190, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Tiền cổ 190", null, 9, null, 155, 13, 8, 25, null },
                    { 191, 10, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Văn tự 191", null, 6, null, 126, 8, 8, 6, null },
                    { 192, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Xe 192", null, 21, null, 123, 25, 8, 25, null },
                    { 193, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Nội thất 193", null, 22, null, 114, 26, 8, 20, null },
                    { 195, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Nội thất 195", null, 18, null, 133, 22, 8, 21, null },
                    { 196, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 165, null, "Nội thất 196", null, 7, null, 145, 10, 8, 6, null },
                    { 197, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Xe 197", null, 7, null, 142, 11, 8, 27, null }
                });

            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "Id", "Address", "Deleted", "ItemCost", "OrderId", "SellerId", "ShippingCost", "Status" },
                values: new object[,]
                {
                    { 31, "Generated", null, 48973574L, 27, 147, 10000L, 0 },
                    { 32, "Generated", null, 46351265L, 28, 153, 10000L, 0 },
                    { 33, "Generated", null, 48290375L, 29, 148, 10000L, 0 },
                    { 34, "Generated", null, 40534233L, 29, 137, 10000L, 0 },
                    { 35, "Generated", null, 48963395L, 30, 141, 10000L, 0 },
                    { 36, "Generated", null, 47835942L, 31, 142, 10000L, 0 },
                    { 37, "Generated", null, 44515881L, 31, 112, 10000L, 0 },
                    { 38, "Generated", null, 44316384L, 32, 159, 10000L, 0 },
                    { 39, "Generated", null, 48044474L, 33, 143, 10000L, 0 },
                    { 40, "Generated", null, 49051603L, 34, 128, 10000L, 0 },
                    { 41, "Generated", null, 43830057L, 35, 147, 10000L, 0 },
                    { 42, "Generated", null, 44384818L, 36, 134, 10000L, 0 },
                    { 43, "Generated", null, 42876067L, 37, 122, 10000L, 0 },
                    { 44, "Generated", null, 48973617L, 37, 130, 10000L, 0 },
                    { 45, "Generated", null, 49858963L, 38, 145, 10000L, 0 },
                    { 46, "Generated", null, 49793247L, 39, 128, 10000L, 0 },
                    { 47, "Generated", null, 45660250L, 40, 154, 10000L, 0 },
                    { 48, "Generated", null, 42196407L, 41, 119, 10000L, 0 },
                    { 49, "Generated", null, 32384732L, 41, 159, 10000L, 0 },
                    { 50, "Generated", null, 47207141L, 42, 111, 10000L, 0 }
                });

            migrationBuilder.InsertData(
                table: "StatusChanges",
                columns: new[] { "Id", "Deleted", "ItemId", "SellerApplicationId", "StatusChangeReason", "StatusChangedById", "StatusFrom", "StatusTo" },
                values: new object[,]
                {
                    { 1, null, null, 1, "Ok", 3, "PENDING", "APPROVED" },
                    { 2, null, null, 2, "Ok", 4, "PENDING", "APPROVED" },
                    { 3, null, null, 3, "Ok", 3, "PENDING", "APPROVED" },
                    { 4, null, null, 4, "Ok", 2, "PENDING", "APPROVED" },
                    { 5, null, null, 5, "Ok", 1, "PENDING", "APPROVED" },
                    { 6, null, null, 6, "Ok", 2, "PENDING", "APPROVED" },
                    { 7, null, null, 7, "Ok", 4, "PENDING", "APPROVED" },
                    { 8, null, null, 8, "Ok", 4, "PENDING", "APPROVED" },
                    { 9, null, null, 9, "Ok", 1, "PENDING", "APPROVED" },
                    { 10, null, null, 10, "Ok", 3, "PENDING", "APPROVED" },
                    { 11, null, null, 11, "Ok", 3, "PENDING", "APPROVED" },
                    { 12, null, null, 12, "Ok", 2, "PENDING", "APPROVED" },
                    { 13, null, null, 13, "Ok", 4, "PENDING", "APPROVED" },
                    { 14, null, null, 14, "Ok", 1, "PENDING", "APPROVED" },
                    { 15, null, null, 15, "Ok", 4, "PENDING", "APPROVED" },
                    { 16, null, null, 16, "Ok", 1, "PENDING", "APPROVED" },
                    { 17, null, null, 17, "Ok", 1, "PENDING", "APPROVED" },
                    { 18, null, null, 18, "Ok", 3, "PENDING", "APPROVED" },
                    { 19, null, null, 19, "Ok", 3, "PENDING", "APPROVED" },
                    { 20, null, null, 20, "Ok", 3, "PENDING", "APPROVED" },
                    { 21, null, null, 21, "Ok", 1, "PENDING", "APPROVED" },
                    { 22, null, null, 22, "Ok", 1, "PENDING", "APPROVED" },
                    { 23, null, null, 23, "Ok", 4, "PENDING", "APPROVED" },
                    { 24, null, null, 24, "Ok", 3, "PENDING", "APPROVED" },
                    { 25, null, null, 25, "Ok", 1, "PENDING", "APPROVED" },
                    { 26, null, null, 26, "Ok", 4, "PENDING", "APPROVED" },
                    { 27, null, null, 27, "Ok", 4, "PENDING", "APPROVED" },
                    { 28, null, null, 28, "Ok", 3, "PENDING", "APPROVED" },
                    { 29, null, null, 29, "Ok", 2, "PENDING", "APPROVED" },
                    { 30, null, null, 30, "Ok", 1, "PENDING", "APPROVED" },
                    { 31, null, null, 31, "Ok", 1, "PENDING", "APPROVED" },
                    { 32, null, null, 32, "Ok", 4, "PENDING", "APPROVED" },
                    { 33, null, null, 33, "Ok", 1, "PENDING", "APPROVED" },
                    { 34, null, null, 34, "Ok", 4, "PENDING", "APPROVED" },
                    { 35, null, null, 35, "Ok", 4, "PENDING", "APPROVED" },
                    { 36, null, null, 36, "Ok", 3, "PENDING", "APPROVED" },
                    { 37, null, null, 37, "Ok", 1, "PENDING", "APPROVED" },
                    { 38, null, null, 38, "Ok", 1, "PENDING", "APPROVED" },
                    { 39, null, null, 39, "Ok", 1, "PENDING", "APPROVED" },
                    { 40, null, null, 40, "Ok", 2, "PENDING", "APPROVED" },
                    { 41, null, null, 41, "Ok", 3, "PENDING", "APPROVED" },
                    { 42, null, null, 42, "Ok", 3, "PENDING", "APPROVED" },
                    { 43, null, null, 43, "Ok", 3, "PENDING", "APPROVED" },
                    { 44, null, null, 44, "Ok", 2, "PENDING", "APPROVED" },
                    { 45, null, null, 45, "Ok", 3, "PENDING", "APPROVED" },
                    { 46, null, null, 46, "Ok", 4, "PENDING", "APPROVED" },
                    { 47, null, null, 47, "Ok", 3, "PENDING", "APPROVED" },
                    { 48, null, null, 48, "Ok", 4, "PENDING", "APPROVED" },
                    { 49, null, null, 49, "Ok", 1, "PENDING", "APPROVED" },
                    { 50, null, null, 50, "Ok", 2, "PENDING", "APPROVED" },
                    { 51, null, 1, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 52, null, 2, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 53, null, 3, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 54, null, 4, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 55, null, 5, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 56, null, 6, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 57, null, 7, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 58, null, 8, null, "Không đạt tiêu chuẩn", 4, "EXAMINATION_PENDING", "REJECTED" },
                    { 59, null, 9, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 60, null, 10, null, "Không đạt tiêu chuẩn", 4, "EXAMINATION_PENDING", "REJECTED" },
                    { 61, null, 11, null, "Không đạt tiêu chuẩn", 4, "EXAMINATION_PENDING", "REJECTED" },
                    { 62, null, 12, null, "Không đạt tiêu chuẩn", 2, "EXAMINATION_PENDING", "REJECTED" },
                    { 63, null, 13, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 64, null, 14, null, "Không đạt tiêu chuẩn", 4, "EXAMINATION_PENDING", "REJECTED" },
                    { 65, null, 15, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 66, null, 16, null, "Không đạt tiêu chuẩn", 4, "EXAMINATION_PENDING", "REJECTED" },
                    { 67, null, 17, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 68, null, 18, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 69, null, 19, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 70, null, 20, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 71, null, 21, null, "Không đạt tiêu chuẩn", 4, "EXAMINATION_PENDING", "REJECTED" },
                    { 72, null, 22, null, "Không đạt tiêu chuẩn", 2, "EXAMINATION_PENDING", "REJECTED" },
                    { 73, null, 23, null, "Không đạt tiêu chuẩn", 2, "EXAMINATION_PENDING", "REJECTED" },
                    { 74, null, 24, null, "Không đạt tiêu chuẩn", 2, "EXAMINATION_PENDING", "REJECTED" },
                    { 75, null, 25, null, "Không đạt tiêu chuẩn", 2, "EXAMINATION_PENDING", "REJECTED" },
                    { 76, null, 26, null, "Không đạt tiêu chuẩn", 4, "EXAMINATION_PENDING", "REJECTED" },
                    { 77, null, 27, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 78, null, 28, null, "Không đạt tiêu chuẩn", 2, "EXAMINATION_PENDING", "REJECTED" },
                    { 79, null, 29, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 80, null, 30, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 81, null, 31, null, "Không đạt tiêu chuẩn", 4, "EXAMINATION_PENDING", "REJECTED" },
                    { 82, null, 32, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 83, null, 33, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 84, null, 34, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 85, null, 35, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 86, null, 36, null, "Không đạt tiêu chuẩn", 2, "EXAMINATION_PENDING", "REJECTED" },
                    { 87, null, 37, null, "Không đạt tiêu chuẩn", 2, "EXAMINATION_PENDING", "REJECTED" },
                    { 88, null, 38, null, "Không đạt tiêu chuẩn", 4, "EXAMINATION_PENDING", "REJECTED" },
                    { 89, null, 39, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 90, null, 40, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 91, null, 41, null, "Không đạt tiêu chuẩn", 4, "EXAMINATION_PENDING", "REJECTED" },
                    { 92, null, 42, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 93, null, 43, null, "Không đạt tiêu chuẩn", 2, "EXAMINATION_PENDING", "REJECTED" },
                    { 94, null, 44, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 95, null, 45, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 96, null, 46, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 97, null, 47, null, "Không đạt tiêu chuẩn", 2, "EXAMINATION_PENDING", "REJECTED" },
                    { 98, null, 48, null, "Không đạt tiêu chuẩn", 1, "EXAMINATION_PENDING", "REJECTED" },
                    { 99, null, 49, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 100, null, 50, null, "Không đạt tiêu chuẩn", 3, "EXAMINATION_PENDING", "REJECTED" },
                    { 101, null, 51, null, "Đã đạt tiêu chuẩn đấu giá", 163, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 102, null, 52, null, "Đã đạt tiêu chuẩn đấu giá", 166, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 103, null, 53, null, "Đã đạt tiêu chuẩn đấu giá", 169, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 104, null, 54, null, "Đã đạt tiêu chuẩn đấu giá", 169, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 105, null, 55, null, "Đã đạt tiêu chuẩn đấu giá", 167, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 106, null, 56, null, "Đã đạt tiêu chuẩn đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 107, null, 57, null, "Đã đạt tiêu chuẩn đấu giá", 164, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 108, null, 58, null, "Đã đạt tiêu chuẩn đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 109, null, 59, null, "Đã đạt tiêu chuẩn đấu giá", 168, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 110, null, 60, null, "Đã đạt tiêu chuẩn đấu giá", 168, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 111, null, 61, null, "Đã đạt tiêu chuẩn đấu giá", 164, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 112, null, 62, null, "Đã đạt tiêu chuẩn đấu giá", 168, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 113, null, 63, null, "Đã đạt tiêu chuẩn đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 114, null, 64, null, "Đã đạt tiêu chuẩn đấu giá", 166, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 115, null, 65, null, "Đã đạt tiêu chuẩn đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 116, null, 66, null, "Đã đạt tiêu chuẩn đấu giá", 160, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 117, null, 67, null, "Đã đạt tiêu chuẩn đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 118, null, 68, null, "Đã đạt tiêu chuẩn đấu giá", 168, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 119, null, 69, null, "Đã đạt tiêu chuẩn đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 120, null, 70, null, "Đã đạt tiêu chuẩn đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 121, null, 71, null, "Đã đạt tiêu chuẩn đấu giá", 168, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 122, null, 72, null, "Đã đạt tiêu chuẩn đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 123, null, 73, null, "Đã đạt tiêu chuẩn đấu giá", 163, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 124, null, 74, null, "Đã đạt tiêu chuẩn đấu giá", 169, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 125, null, 75, null, "Đã đạt tiêu chuẩn đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 126, null, 76, null, "Đã đạt tiêu chuẩn đấu giá", 163, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 127, null, 77, null, "Đã đạt tiêu chuẩn đấu giá", 164, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 128, null, 78, null, "Đã đạt tiêu chuẩn đấu giá", 160, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 129, null, 79, null, "Đã đạt tiêu chuẩn đấu giá", 167, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 130, null, 80, null, "Đã đạt tiêu chuẩn đấu giá", 163, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 131, null, 81, null, "Đã đạt tiêu chuẩn đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 132, null, 82, null, "Đã đạt tiêu chuẩn đấu giá", 167, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 133, null, 83, null, "Đã đạt tiêu chuẩn đấu giá", 167, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 134, null, 84, null, "Đã đạt tiêu chuẩn đấu giá", 160, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 135, null, 85, null, "Đã đạt tiêu chuẩn đấu giá", 169, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 136, null, 86, null, "Đã đạt tiêu chuẩn đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 137, null, 87, null, "Đã đạt tiêu chuẩn đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 138, null, 88, null, "Đã đạt tiêu chuẩn đấu giá", 160, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 139, null, 89, null, "Đã đạt tiêu chuẩn đấu giá", 164, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 140, null, 90, null, "Đã đạt tiêu chuẩn đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 141, null, 91, null, "Đã đạt tiêu chuẩn đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 142, null, 92, null, "Đã đạt tiêu chuẩn đấu giá", 166, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 143, null, 93, null, "Đã đạt tiêu chuẩn đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 144, null, 94, null, "Đã đạt tiêu chuẩn đấu giá", 169, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 145, null, 95, null, "Đã đạt tiêu chuẩn đấu giá", 160, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 146, null, 96, null, "Đã đạt tiêu chuẩn đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 147, null, 97, null, "Đã đạt tiêu chuẩn đấu giá", 169, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 148, null, 98, null, "Đã đạt tiêu chuẩn đấu giá", 164, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 149, null, 99, null, "Đã đạt tiêu chuẩn đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 150, null, 100, null, "Đã đạt tiêu chuẩn đấu giá", 163, "EXAMINATION_PENDING", "AUCTION_PENDING" },
                    { 151, null, 101, null, "Đang trong phiên đấu giá", 163, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 152, null, 102, null, "Đang trong phiên đấu giá", 169, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 153, null, 103, null, "Đang trong phiên đấu giá", 163, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 154, null, 104, null, "Đang trong phiên đấu giá", 167, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 155, null, 105, null, "Đang trong phiên đấu giá", 169, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 156, null, 106, null, "Đang trong phiên đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 157, null, 107, null, "Đang trong phiên đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 158, null, 108, null, "Đang trong phiên đấu giá", 168, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 159, null, 109, null, "Đang trong phiên đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 160, null, 110, null, "Đang trong phiên đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 161, null, 111, null, "Đang trong phiên đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 162, null, 112, null, "Đang trong phiên đấu giá", 169, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 163, null, 113, null, "Đang trong phiên đấu giá", 167, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 164, null, 114, null, "Đang trong phiên đấu giá", 166, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 165, null, 115, null, "Đang trong phiên đấu giá", 164, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 166, null, 116, null, "Đang trong phiên đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 167, null, 117, null, "Đang trong phiên đấu giá", 166, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 168, null, 118, null, "Đang trong phiên đấu giá", 168, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 169, null, 119, null, "Đang trong phiên đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 170, null, 120, null, "Đang trong phiên đấu giá", 167, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 171, null, 121, null, "Đang trong phiên đấu giá", 163, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 172, null, 122, null, "Đang trong phiên đấu giá", 160, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 173, null, 123, null, "Đang trong phiên đấu giá", 160, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 174, null, 124, null, "Đang trong phiên đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 175, null, 125, null, "Đang trong phiên đấu giá", 164, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 176, null, 126, null, "Đang trong phiên đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 177, null, 127, null, "Đang trong phiên đấu giá", 163, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 178, null, 128, null, "Đang trong phiên đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 179, null, 129, null, "Đang trong phiên đấu giá", 164, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 180, null, 130, null, "Đang trong phiên đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 181, null, 131, null, "Đang trong phiên đấu giá", 163, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 182, null, 132, null, "Đang trong phiên đấu giá", 169, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 183, null, 133, null, "Đang trong phiên đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 184, null, 134, null, "Đang trong phiên đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 185, null, 135, null, "Đang trong phiên đấu giá", 164, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 186, null, 136, null, "Đang trong phiên đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 187, null, 137, null, "Đang trong phiên đấu giá", 162, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 188, null, 138, null, "Đang trong phiên đấu giá", 167, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 189, null, 139, null, "Đang trong phiên đấu giá", 166, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 190, null, 140, null, "Đang trong phiên đấu giá", 164, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 191, null, 141, null, "Đang trong phiên đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 192, null, 142, null, "Đang trong phiên đấu giá", 168, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 193, null, 143, null, "Đang trong phiên đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 194, null, 144, null, "Đang trong phiên đấu giá", 169, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 195, null, 145, null, "Đang trong phiên đấu giá", 166, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 196, null, 146, null, "Đang trong phiên đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 197, null, 147, null, "Đang trong phiên đấu giá", 165, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 198, null, 148, null, "Đang trong phiên đấu giá", 168, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 199, null, 149, null, "Đang trong phiên đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" },
                    { 200, null, 150, null, "Đang trong phiên đấu giá", 161, "EXAMINATION_PENDING", "AUCTION_IN_PROGRESS" }
                });

            migrationBuilder.InsertData(
                table: "AuctionSessionItem",
                columns: new[] { "AuctionSessionsId", "ItemsId" },
                values: new object[,]
                {
                    { 6, 151 },
                    { 6, 152 },
                    { 6, 153 },
                    { 6, 154 },
                    { 6, 155 },
                    { 6, 156 },
                    { 6, 159 },
                    { 6, 160 },
                    { 6, 161 },
                    { 6, 162 },
                    { 6, 165 },
                    { 6, 168 },
                    { 6, 169 },
                    { 6, 171 },
                    { 6, 174 },
                    { 6, 176 },
                    { 6, 177 },
                    { 6, 180 },
                    { 6, 183 },
                    { 6, 185 },
                    { 6, 186 },
                    { 6, 187 },
                    { 6, 189 },
                    { 6, 190 },
                    { 6, 191 },
                    { 6, 192 },
                    { 6, 193 },
                    { 6, 195 },
                    { 6, 196 },
                    { 6, 197 }
                });

            migrationBuilder.InsertData(
                table: "Bids",
                columns: new[] { "Id", "Amount", "AuctionSessionId", "Deleted", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 1, 16574758L, 6, null, 151, 32 },
                    { 2, 37037877L, 6, null, 151, 166 },
                    { 3, 7914084L, 6, null, 151, 19 },
                    { 4, 15280362L, 6, null, 151, 17 },
                    { 5, 12683672L, 6, null, 151, 125 },
                    { 6, 38745786L, 6, null, 151, 70 },
                    { 7, 27034139L, 6, null, 151, 85 },
                    { 8, 26071540L, 6, null, 151, 35 },
                    { 9, 34552386L, 6, null, 151, 35 },
                    { 10, 18327548L, 6, null, 151, 73 },
                    { 11, 33875734L, 6, null, 152, 81 },
                    { 12, 5923149L, 6, null, 152, 133 },
                    { 13, 22740918L, 6, null, 152, 162 },
                    { 14, 41147220L, 6, null, 152, 85 },
                    { 15, 48188715L, 6, null, 152, 58 },
                    { 16, 5550662L, 6, null, 152, 97 },
                    { 17, 27489502L, 6, null, 152, 81 },
                    { 18, 14748159L, 6, null, 152, 102 },
                    { 19, 41116299L, 6, null, 152, 26 },
                    { 20, 3192258L, 6, null, 152, 148 },
                    { 21, 43158405L, 6, null, 153, 4 },
                    { 22, 20198390L, 6, null, 153, 71 },
                    { 23, 11861468L, 6, null, 153, 42 },
                    { 24, 27180327L, 6, null, 153, 157 },
                    { 25, 13916483L, 6, null, 153, 114 },
                    { 26, 47062582L, 6, null, 153, 102 },
                    { 27, 45384428L, 6, null, 153, 124 },
                    { 28, 24110371L, 6, null, 153, 68 },
                    { 29, 24230034L, 6, null, 153, 40 },
                    { 30, 24856894L, 6, null, 153, 47 },
                    { 31, 46480311L, 6, null, 154, 104 },
                    { 32, 13820181L, 6, null, 154, 35 },
                    { 33, 20951668L, 6, null, 154, 152 },
                    { 34, 41728123L, 6, null, 154, 58 },
                    { 35, 16155145L, 6, null, 154, 10 },
                    { 36, 33568005L, 6, null, 154, 33 },
                    { 37, 49705642L, 6, null, 154, 106 },
                    { 38, 12056031L, 6, null, 154, 142 },
                    { 39, 47244273L, 6, null, 154, 52 },
                    { 40, 34846427L, 6, null, 154, 115 },
                    { 41, 48904116L, 6, null, 155, 25 },
                    { 42, 10340189L, 6, null, 155, 38 },
                    { 43, 3328365L, 6, null, 155, 57 },
                    { 44, 33128771L, 6, null, 155, 158 },
                    { 45, 10591341L, 6, null, 155, 60 },
                    { 46, 22925616L, 6, null, 155, 142 },
                    { 47, 9999057L, 6, null, 155, 58 },
                    { 48, 37414115L, 6, null, 155, 116 },
                    { 49, 10766255L, 6, null, 155, 154 },
                    { 50, 36101931L, 6, null, 155, 49 },
                    { 51, 31729980L, 6, null, 156, 23 },
                    { 52, 31381646L, 6, null, 156, 127 },
                    { 53, 11043410L, 6, null, 156, 67 },
                    { 54, 525167L, 6, null, 156, 81 },
                    { 55, 43771362L, 6, null, 156, 31 },
                    { 56, 21608739L, 6, null, 156, 98 },
                    { 57, 610873L, 6, null, 156, 166 },
                    { 58, 24629873L, 6, null, 156, 64 },
                    { 59, 27495919L, 6, null, 156, 33 },
                    { 60, 26331282L, 6, null, 156, 125 },
                    { 81, 27909172L, 6, null, 159, 56 },
                    { 82, 3484823L, 6, null, 159, 58 },
                    { 83, 12253792L, 6, null, 159, 106 },
                    { 84, 46525551L, 6, null, 159, 52 },
                    { 85, 35648425L, 6, null, 159, 165 },
                    { 86, 2982703L, 6, null, 159, 59 },
                    { 87, 752505L, 6, null, 159, 160 },
                    { 88, 6599985L, 6, null, 159, 120 },
                    { 89, 27350727L, 6, null, 159, 166 },
                    { 90, 6061562L, 6, null, 159, 100 },
                    { 91, 45390668L, 6, null, 160, 55 },
                    { 92, 44279225L, 6, null, 160, 102 },
                    { 93, 39447556L, 6, null, 160, 124 },
                    { 94, 4499950L, 6, null, 160, 122 },
                    { 95, 16420282L, 6, null, 160, 75 },
                    { 96, 12146118L, 6, null, 160, 114 },
                    { 97, 42811634L, 6, null, 160, 92 },
                    { 98, 14934239L, 6, null, 160, 2 },
                    { 99, 31213914L, 6, null, 160, 27 },
                    { 100, 17190039L, 6, null, 160, 23 },
                    { 101, 45536198L, 6, null, 161, 22 },
                    { 102, 31731901L, 6, null, 161, 45 },
                    { 103, 5530081L, 6, null, 161, 130 },
                    { 104, 12753571L, 6, null, 161, 10 },
                    { 105, 43295907L, 6, null, 161, 142 },
                    { 106, 41691712L, 6, null, 161, 79 },
                    { 107, 36919521L, 6, null, 161, 45 },
                    { 108, 39374241L, 6, null, 161, 132 },
                    { 109, 46187995L, 6, null, 161, 93 },
                    { 110, 18041602L, 6, null, 161, 138 },
                    { 111, 23866357L, 6, null, 162, 160 },
                    { 112, 21125023L, 6, null, 162, 114 },
                    { 113, 38321000L, 6, null, 162, 89 },
                    { 114, 19078206L, 6, null, 162, 19 },
                    { 115, 3977189L, 6, null, 162, 54 },
                    { 116, 8883370L, 6, null, 162, 81 },
                    { 117, 8617314L, 6, null, 162, 157 },
                    { 118, 48502198L, 6, null, 162, 28 },
                    { 119, 38416116L, 6, null, 162, 16 },
                    { 120, 29331431L, 6, null, 162, 145 },
                    { 141, 35044086L, 6, null, 165, 162 },
                    { 142, 16757967L, 6, null, 165, 158 },
                    { 143, 43756213L, 6, null, 165, 24 },
                    { 144, 36681363L, 6, null, 165, 14 },
                    { 145, 24209148L, 6, null, 165, 21 },
                    { 146, 15068119L, 6, null, 165, 102 },
                    { 147, 36350053L, 6, null, 165, 162 },
                    { 148, 44937854L, 6, null, 165, 29 },
                    { 149, 30457778L, 6, null, 165, 139 },
                    { 150, 44212964L, 6, null, 165, 112 },
                    { 171, 13569926L, 6, null, 168, 125 },
                    { 172, 633471L, 6, null, 168, 94 },
                    { 173, 25457448L, 6, null, 168, 45 },
                    { 174, 11024533L, 6, null, 168, 69 },
                    { 175, 45398006L, 6, null, 168, 48 },
                    { 176, 2934252L, 6, null, 168, 58 },
                    { 177, 23004889L, 6, null, 168, 61 },
                    { 178, 2156240L, 6, null, 168, 13 },
                    { 179, 3715798L, 6, null, 168, 25 },
                    { 180, 42878202L, 6, null, 168, 84 },
                    { 181, 13485888L, 6, null, 169, 88 },
                    { 182, 9435134L, 6, null, 169, 157 },
                    { 183, 28021493L, 6, null, 169, 18 },
                    { 184, 34685717L, 6, null, 169, 94 },
                    { 185, 27338238L, 6, null, 169, 84 },
                    { 186, 30942038L, 6, null, 169, 159 },
                    { 187, 1669690L, 6, null, 169, 107 },
                    { 188, 16685094L, 6, null, 169, 109 },
                    { 189, 48776499L, 6, null, 169, 79 },
                    { 190, 45743217L, 6, null, 169, 154 },
                    { 201, 1262429L, 6, null, 171, 156 },
                    { 202, 27514612L, 6, null, 171, 136 },
                    { 203, 38563402L, 6, null, 171, 141 },
                    { 204, 44495530L, 6, null, 171, 28 },
                    { 205, 5902679L, 6, null, 171, 47 },
                    { 206, 22098734L, 6, null, 171, 58 },
                    { 207, 7844463L, 6, null, 171, 144 },
                    { 208, 29817188L, 6, null, 171, 37 },
                    { 209, 19538943L, 6, null, 171, 109 },
                    { 210, 19423285L, 6, null, 171, 20 },
                    { 231, 2973842L, 6, null, 174, 2 },
                    { 232, 17617681L, 6, null, 174, 64 },
                    { 233, 42573667L, 6, null, 174, 160 },
                    { 234, 36296074L, 6, null, 174, 147 },
                    { 235, 27905596L, 6, null, 174, 55 },
                    { 236, 20190720L, 6, null, 174, 104 },
                    { 237, 23089701L, 6, null, 174, 90 },
                    { 238, 28524002L, 6, null, 174, 108 },
                    { 239, 38320633L, 6, null, 174, 127 },
                    { 240, 46374211L, 6, null, 174, 57 },
                    { 251, 29796151L, 6, null, 176, 116 },
                    { 252, 21795680L, 6, null, 176, 31 },
                    { 253, 39402348L, 6, null, 176, 90 },
                    { 254, 24034978L, 6, null, 176, 46 },
                    { 255, 48698338L, 6, null, 176, 56 },
                    { 256, 36512541L, 6, null, 176, 120 },
                    { 257, 16435203L, 6, null, 176, 108 },
                    { 258, 23232296L, 6, null, 176, 96 },
                    { 259, 28781916L, 6, null, 176, 92 },
                    { 260, 27743978L, 6, null, 176, 109 },
                    { 261, 16774366L, 6, null, 177, 93 },
                    { 262, 44952706L, 6, null, 177, 94 },
                    { 263, 36717735L, 6, null, 177, 96 },
                    { 264, 39552954L, 6, null, 177, 152 },
                    { 265, 1277277L, 6, null, 177, 123 },
                    { 266, 5463568L, 6, null, 177, 153 },
                    { 267, 20500686L, 6, null, 177, 64 },
                    { 268, 48859261L, 6, null, 177, 62 },
                    { 269, 42551014L, 6, null, 177, 116 },
                    { 270, 22946384L, 6, null, 177, 27 },
                    { 291, 15949781L, 6, null, 180, 100 },
                    { 292, 28695457L, 6, null, 180, 99 },
                    { 293, 24630130L, 6, null, 180, 58 },
                    { 294, 33637235L, 6, null, 180, 102 },
                    { 295, 26266430L, 6, null, 180, 27 },
                    { 296, 44298144L, 6, null, 180, 18 },
                    { 297, 35528443L, 6, null, 180, 158 },
                    { 298, 23140898L, 6, null, 180, 63 },
                    { 299, 27607120L, 6, null, 180, 57 },
                    { 300, 2658774L, 6, null, 180, 141 },
                    { 321, 42639943L, 6, null, 183, 107 },
                    { 322, 6755045L, 6, null, 183, 164 },
                    { 323, 1378500L, 6, null, 183, 22 },
                    { 324, 20156720L, 6, null, 183, 111 },
                    { 325, 45165315L, 6, null, 183, 33 },
                    { 326, 5482229L, 6, null, 183, 159 },
                    { 327, 35636669L, 6, null, 183, 99 },
                    { 328, 9079813L, 6, null, 183, 141 },
                    { 329, 10896552L, 6, null, 183, 120 },
                    { 330, 5607189L, 6, null, 183, 121 },
                    { 341, 3421962L, 6, null, 185, 99 },
                    { 342, 1712998L, 6, null, 185, 120 },
                    { 343, 42163532L, 6, null, 185, 121 },
                    { 344, 900124L, 6, null, 185, 43 },
                    { 345, 31499078L, 6, null, 185, 122 },
                    { 346, 38919307L, 6, null, 185, 53 },
                    { 347, 47736934L, 6, null, 185, 2 },
                    { 348, 1579195L, 6, null, 185, 124 },
                    { 349, 5647476L, 6, null, 185, 163 },
                    { 350, 47196411L, 6, null, 185, 164 },
                    { 351, 22780892L, 6, null, 186, 35 },
                    { 352, 37006741L, 6, null, 186, 136 },
                    { 353, 3344400L, 6, null, 186, 44 },
                    { 354, 31228290L, 6, null, 186, 58 },
                    { 355, 43461445L, 6, null, 186, 99 },
                    { 356, 36080858L, 6, null, 186, 86 },
                    { 357, 5120906L, 6, null, 186, 91 },
                    { 358, 34485396L, 6, null, 186, 112 },
                    { 359, 41452431L, 6, null, 186, 73 },
                    { 360, 31709341L, 6, null, 186, 118 },
                    { 361, 11712739L, 6, null, 187, 87 },
                    { 362, 41188211L, 6, null, 187, 52 },
                    { 363, 46493356L, 6, null, 187, 12 },
                    { 364, 36089069L, 6, null, 187, 57 },
                    { 365, 32323188L, 6, null, 187, 151 },
                    { 366, 4856537L, 6, null, 187, 167 },
                    { 367, 38549737L, 6, null, 187, 167 },
                    { 368, 49222360L, 6, null, 187, 25 },
                    { 369, 17661931L, 6, null, 187, 86 },
                    { 370, 6866546L, 6, null, 187, 158 },
                    { 381, 20507703L, 6, null, 189, 150 },
                    { 382, 5761496L, 6, null, 189, 163 },
                    { 383, 12921628L, 6, null, 189, 168 },
                    { 384, 29717744L, 6, null, 189, 131 },
                    { 385, 968745L, 6, null, 189, 24 },
                    { 386, 45765662L, 6, null, 189, 65 },
                    { 387, 24183510L, 6, null, 189, 168 },
                    { 388, 1594059L, 6, null, 189, 139 },
                    { 389, 27824908L, 6, null, 189, 164 },
                    { 390, 32383431L, 6, null, 189, 93 },
                    { 391, 34966319L, 6, null, 190, 83 },
                    { 392, 5722881L, 6, null, 190, 90 },
                    { 393, 19540408L, 6, null, 190, 89 },
                    { 394, 33441875L, 6, null, 190, 141 },
                    { 395, 8746362L, 6, null, 190, 37 },
                    { 396, 368350L, 6, null, 190, 30 },
                    { 397, 8152017L, 6, null, 190, 96 },
                    { 398, 21526837L, 6, null, 190, 148 },
                    { 399, 38885493L, 6, null, 190, 47 },
                    { 400, 31160327L, 6, null, 190, 118 },
                    { 401, 35287377L, 6, null, 191, 134 },
                    { 402, 25797491L, 6, null, 191, 156 },
                    { 403, 15004344L, 6, null, 191, 32 },
                    { 404, 22719945L, 6, null, 191, 166 },
                    { 405, 35432335L, 6, null, 191, 66 },
                    { 406, 8214693L, 6, null, 191, 130 },
                    { 407, 32425553L, 6, null, 191, 59 },
                    { 408, 13806568L, 6, null, 191, 89 },
                    { 409, 6330145L, 6, null, 191, 169 },
                    { 410, 41904900L, 6, null, 191, 30 },
                    { 411, 7526923L, 6, null, 192, 80 },
                    { 412, 38486362L, 6, null, 192, 155 },
                    { 413, 47696257L, 6, null, 192, 83 },
                    { 414, 4710730L, 6, null, 192, 32 },
                    { 415, 35613844L, 6, null, 192, 118 },
                    { 416, 34126206L, 6, null, 192, 151 },
                    { 417, 18090213L, 6, null, 192, 114 },
                    { 418, 6904336L, 6, null, 192, 30 },
                    { 419, 26974073L, 6, null, 192, 82 },
                    { 420, 199702L, 6, null, 192, 18 },
                    { 421, 43683987L, 6, null, 193, 88 },
                    { 422, 29874723L, 6, null, 193, 33 },
                    { 423, 25837813L, 6, null, 193, 127 },
                    { 424, 49402929L, 6, null, 193, 89 },
                    { 425, 28767285L, 6, null, 193, 163 },
                    { 426, 26936088L, 6, null, 193, 109 },
                    { 427, 26969751L, 6, null, 193, 134 },
                    { 428, 46432312L, 6, null, 193, 18 },
                    { 429, 37928750L, 6, null, 193, 33 },
                    { 430, 9647559L, 6, null, 193, 85 },
                    { 441, 18075190L, 6, null, 195, 66 },
                    { 442, 26112756L, 6, null, 195, 51 },
                    { 443, 6890307L, 6, null, 195, 80 },
                    { 444, 34366107L, 6, null, 195, 145 },
                    { 445, 14884003L, 6, null, 195, 21 },
                    { 446, 7620827L, 6, null, 195, 78 },
                    { 447, 13539491L, 6, null, 195, 127 },
                    { 448, 41385541L, 6, null, 195, 69 },
                    { 449, 17707304L, 6, null, 195, 16 },
                    { 450, 24591161L, 6, null, 195, 81 },
                    { 451, 46427221L, 6, null, 196, 35 },
                    { 452, 46801194L, 6, null, 196, 31 },
                    { 453, 7297857L, 6, null, 196, 48 },
                    { 454, 16867574L, 6, null, 196, 143 },
                    { 455, 15163063L, 6, null, 196, 10 },
                    { 456, 35279068L, 6, null, 196, 76 },
                    { 457, 25218857L, 6, null, 196, 70 },
                    { 458, 15303802L, 6, null, 196, 87 },
                    { 459, 41887937L, 6, null, 196, 19 },
                    { 460, 43600146L, 6, null, 196, 3 },
                    { 461, 12903687L, 6, null, 197, 139 },
                    { 462, 32189081L, 6, null, 197, 80 },
                    { 463, 9604501L, 6, null, 197, 157 },
                    { 464, 11528965L, 6, null, 197, 25 },
                    { 465, 23011303L, 6, null, 197, 66 },
                    { 466, 340284L, 6, null, 197, 120 },
                    { 467, 16962131L, 6, null, 197, 114 },
                    { 468, 37999653L, 6, null, 197, 12 },
                    { 469, 47108273L, 6, null, 197, 31 },
                    { 470, 1178141L, 6, null, 197, 108 }
                });

            migrationBuilder.InsertData(
                table: "ImageItem",
                columns: new[] { "ImagesId", "ItemsId" },
                values: new object[,]
                {
                    { 6, 177 },
                    { 6, 185 },
                    { 6, 186 },
                    { 6, 187 },
                    { 6, 193 },
                    { 6, 195 },
                    { 6, 197 },
                    { 7, 154 },
                    { 7, 156 },
                    { 7, 169 },
                    { 7, 171 },
                    { 7, 174 },
                    { 7, 180 },
                    { 7, 183 },
                    { 7, 190 },
                    { 8, 159 },
                    { 8, 185 },
                    { 8, 191 },
                    { 8, 192 },
                    { 9, 159 },
                    { 10, 153 },
                    { 10, 159 },
                    { 10, 176 },
                    { 10, 195 },
                    { 11, 151 },
                    { 11, 153 },
                    { 11, 162 },
                    { 11, 168 },
                    { 11, 169 },
                    { 11, 191 },
                    { 11, 197 },
                    { 12, 154 },
                    { 12, 155 },
                    { 12, 160 },
                    { 12, 169 },
                    { 13, 161 },
                    { 13, 168 },
                    { 13, 176 },
                    { 13, 183 },
                    { 13, 192 },
                    { 14, 151 },
                    { 14, 154 },
                    { 14, 155 },
                    { 14, 176 },
                    { 14, 196 },
                    { 15, 152 },
                    { 15, 159 },
                    { 15, 168 },
                    { 15, 183 },
                    { 15, 185 },
                    { 15, 186 },
                    { 15, 190 },
                    { 15, 196 },
                    { 16, 192 },
                    { 16, 193 },
                    { 16, 195 },
                    { 17, 154 },
                    { 17, 193 },
                    { 17, 196 },
                    { 18, 156 },
                    { 18, 176 },
                    { 18, 180 },
                    { 18, 190 },
                    { 18, 195 },
                    { 19, 151 },
                    { 19, 162 },
                    { 19, 168 },
                    { 19, 171 },
                    { 19, 174 },
                    { 19, 187 },
                    { 19, 190 },
                    { 19, 192 },
                    { 20, 153 },
                    { 20, 162 },
                    { 20, 185 },
                    { 20, 189 },
                    { 20, 196 },
                    { 21, 152 },
                    { 21, 160 },
                    { 21, 161 },
                    { 21, 165 },
                    { 21, 174 },
                    { 21, 180 },
                    { 22, 152 },
                    { 22, 155 },
                    { 22, 161 },
                    { 22, 165 },
                    { 22, 168 },
                    { 22, 183 },
                    { 23, 155 },
                    { 23, 171 },
                    { 23, 186 },
                    { 23, 190 },
                    { 23, 191 },
                    { 24, 156 },
                    { 24, 162 },
                    { 24, 165 },
                    { 24, 169 },
                    { 24, 176 },
                    { 24, 177 },
                    { 24, 197 },
                    { 25, 160 },
                    { 25, 165 },
                    { 26, 156 },
                    { 26, 180 },
                    { 27, 174 },
                    { 27, 187 },
                    { 28, 151 },
                    { 28, 152 },
                    { 28, 154 },
                    { 28, 155 },
                    { 28, 161 },
                    { 28, 186 },
                    { 28, 189 },
                    { 28, 195 },
                    { 29, 171 },
                    { 29, 177 },
                    { 29, 185 },
                    { 29, 193 },
                    { 29, 197 },
                    { 30, 156 },
                    { 30, 189 },
                    { 30, 193 },
                    { 31, 165 },
                    { 31, 174 },
                    { 31, 177 },
                    { 31, 180 },
                    { 31, 183 },
                    { 31, 186 },
                    { 31, 187 },
                    { 32, 160 },
                    { 32, 161 },
                    { 32, 169 },
                    { 32, 187 },
                    { 32, 191 },
                    { 32, 192 },
                    { 33, 153 },
                    { 33, 159 },
                    { 33, 171 },
                    { 33, 189 },
                    { 33, 197 },
                    { 34, 151 },
                    { 34, 152 },
                    { 34, 153 },
                    { 34, 160 },
                    { 34, 162 },
                    { 34, 177 },
                    { 34, 189 },
                    { 34, 191 },
                    { 34, 196 }
                });

            migrationBuilder.InsertData(
                table: "ItemProperties",
                columns: new[] { "Id", "Deleted", "ItemId", "Label", "Value" },
                values: new object[,]
                {
                    { 601, null, 151, "Chiều dài", "12cm" },
                    { 602, null, 151, "Chiều rộng", "19cm" },
                    { 603, null, 151, "Chiều cao", "2cm" },
                    { 604, null, 151, "Cân nặng", "1195g" },
                    { 605, null, 152, "Chiều dài", "12cm" },
                    { 606, null, 152, "Chiều rộng", "6cm" },
                    { 607, null, 152, "Chiều cao", "16cm" },
                    { 608, null, 152, "Cân nặng", "1009g" },
                    { 609, null, 153, "Chiều dài", "26cm" },
                    { 610, null, 153, "Chiều rộng", "7cm" },
                    { 611, null, 153, "Chiều cao", "6cm" },
                    { 612, null, 153, "Cân nặng", "519g" },
                    { 613, null, 154, "Chiều dài", "19cm" },
                    { 614, null, 154, "Chiều rộng", "1cm" },
                    { 615, null, 154, "Chiều cao", "24cm" },
                    { 616, null, 154, "Cân nặng", "4503g" },
                    { 617, null, 155, "Chiều dài", "26cm" },
                    { 618, null, 155, "Chiều rộng", "16cm" },
                    { 619, null, 155, "Chiều cao", "5cm" },
                    { 620, null, 155, "Cân nặng", "2237g" },
                    { 621, null, 156, "Chiều dài", "7cm" },
                    { 622, null, 156, "Chiều rộng", "2cm" },
                    { 623, null, 156, "Chiều cao", "1cm" },
                    { 624, null, 156, "Cân nặng", "4189g" },
                    { 633, null, 159, "Chiều dài", "8cm" },
                    { 634, null, 159, "Chiều rộng", "5cm" },
                    { 635, null, 159, "Chiều cao", "34cm" },
                    { 636, null, 159, "Cân nặng", "2316g" },
                    { 637, null, 160, "Chiều dài", "8cm" },
                    { 638, null, 160, "Chiều rộng", "0cm" },
                    { 639, null, 160, "Chiều cao", "14cm" },
                    { 640, null, 160, "Cân nặng", "3291g" },
                    { 641, null, 161, "Chiều dài", "38cm" },
                    { 642, null, 161, "Chiều rộng", "5cm" },
                    { 643, null, 161, "Chiều cao", "44cm" },
                    { 644, null, 161, "Cân nặng", "539g" },
                    { 645, null, 162, "Chiều dài", "0cm" },
                    { 646, null, 162, "Chiều rộng", "8cm" },
                    { 647, null, 162, "Chiều cao", "32cm" },
                    { 648, null, 162, "Cân nặng", "1437g" },
                    { 657, null, 165, "Chiều dài", "26cm" },
                    { 658, null, 165, "Chiều rộng", "11cm" },
                    { 659, null, 165, "Chiều cao", "25cm" },
                    { 660, null, 165, "Cân nặng", "2535g" },
                    { 669, null, 168, "Chiều dài", "47cm" },
                    { 670, null, 168, "Chiều rộng", "3cm" },
                    { 671, null, 168, "Chiều cao", "47cm" },
                    { 672, null, 168, "Cân nặng", "3816g" },
                    { 673, null, 169, "Chiều dài", "33cm" },
                    { 674, null, 169, "Chiều rộng", "1cm" },
                    { 675, null, 169, "Chiều cao", "39cm" },
                    { 676, null, 169, "Cân nặng", "1735g" },
                    { 681, null, 171, "Chiều dài", "17cm" },
                    { 682, null, 171, "Chiều rộng", "8cm" },
                    { 683, null, 171, "Chiều cao", "21cm" },
                    { 684, null, 171, "Cân nặng", "4493g" },
                    { 693, null, 174, "Chiều dài", "40cm" },
                    { 694, null, 174, "Chiều rộng", "8cm" },
                    { 695, null, 174, "Chiều cao", "44cm" },
                    { 696, null, 174, "Cân nặng", "3493g" },
                    { 701, null, 176, "Chiều dài", "6cm" },
                    { 702, null, 176, "Chiều rộng", "6cm" },
                    { 703, null, 176, "Chiều cao", "18cm" },
                    { 704, null, 176, "Cân nặng", "2547g" },
                    { 705, null, 177, "Chiều dài", "32cm" },
                    { 706, null, 177, "Chiều rộng", "17cm" },
                    { 707, null, 177, "Chiều cao", "13cm" },
                    { 708, null, 177, "Cân nặng", "1913g" },
                    { 717, null, 180, "Chiều dài", "2cm" },
                    { 718, null, 180, "Chiều rộng", "16cm" },
                    { 719, null, 180, "Chiều cao", "19cm" },
                    { 720, null, 180, "Cân nặng", "4382g" },
                    { 729, null, 183, "Chiều dài", "43cm" },
                    { 730, null, 183, "Chiều rộng", "11cm" },
                    { 731, null, 183, "Chiều cao", "11cm" },
                    { 732, null, 183, "Cân nặng", "3449g" },
                    { 737, null, 185, "Chiều dài", "37cm" },
                    { 738, null, 185, "Chiều rộng", "13cm" },
                    { 739, null, 185, "Chiều cao", "35cm" },
                    { 740, null, 185, "Cân nặng", "1695g" },
                    { 741, null, 186, "Chiều dài", "44cm" },
                    { 742, null, 186, "Chiều rộng", "9cm" },
                    { 743, null, 186, "Chiều cao", "19cm" },
                    { 744, null, 186, "Cân nặng", "4405g" },
                    { 745, null, 187, "Chiều dài", "24cm" },
                    { 746, null, 187, "Chiều rộng", "3cm" },
                    { 747, null, 187, "Chiều cao", "48cm" },
                    { 748, null, 187, "Cân nặng", "4040g" },
                    { 753, null, 189, "Chiều dài", "27cm" },
                    { 754, null, 189, "Chiều rộng", "7cm" },
                    { 755, null, 189, "Chiều cao", "38cm" },
                    { 756, null, 189, "Cân nặng", "4102g" },
                    { 757, null, 190, "Chiều dài", "19cm" },
                    { 758, null, 190, "Chiều rộng", "1cm" },
                    { 759, null, 190, "Chiều cao", "2cm" },
                    { 760, null, 190, "Cân nặng", "1035g" },
                    { 761, null, 191, "Chiều dài", "11cm" },
                    { 762, null, 191, "Chiều rộng", "5cm" },
                    { 763, null, 191, "Chiều cao", "32cm" },
                    { 764, null, 191, "Cân nặng", "2408g" },
                    { 765, null, 192, "Chiều dài", "9cm" },
                    { 766, null, 192, "Chiều rộng", "15cm" },
                    { 767, null, 192, "Chiều cao", "22cm" },
                    { 768, null, 192, "Cân nặng", "1136g" },
                    { 769, null, 193, "Chiều dài", "18cm" },
                    { 770, null, 193, "Chiều rộng", "0cm" },
                    { 771, null, 193, "Chiều cao", "31cm" },
                    { 772, null, 193, "Cân nặng", "4204g" },
                    { 777, null, 195, "Chiều dài", "15cm" },
                    { 778, null, 195, "Chiều rộng", "13cm" },
                    { 779, null, 195, "Chiều cao", "1cm" },
                    { 780, null, 195, "Cân nặng", "2330g" },
                    { 781, null, 196, "Chiều dài", "11cm" },
                    { 782, null, 196, "Chiều rộng", "13cm" },
                    { 783, null, 196, "Chiều cao", "16cm" },
                    { 784, null, 196, "Cân nặng", "1017g" },
                    { 785, null, 197, "Chiều dài", "34cm" },
                    { 786, null, 197, "Chiều rộng", "15cm" },
                    { 787, null, 197, "Chiều cao", "12cm" },
                    { 788, null, 197, "Cân nặng", "4325g" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "Deleted", "Description", "ExpertId", "HighestBidId", "Name", "OngoingSessionId", "OrderId", "PaymentDueDate", "SellerId", "ShipmentId", "Status", "ThumbnailId", "WonDate" },
                values: new object[,]
                {
                    { 157, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Văn tự 157", null, 42, null, 111, 50, 8, 25, null },
                    { 158, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Đồ sưu tầm 158", null, 29, null, 148, 33, 8, 17, null },
                    { 163, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Nội thất 163", null, 30, null, 141, 35, 8, 6, null },
                    { 164, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Khoáng sản 164", null, 29, null, 137, 34, 8, 30, null },
                    { 166, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 162, null, "Tiền cổ 166", null, 31, null, 142, 36, 8, 32, null },
                    { 167, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Nội thất 167", null, 40, null, 154, 47, 8, 24, null },
                    { 170, 7, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Văn tự 170", null, 37, null, 122, 43, 8, 32, null },
                    { 172, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Trang phục 172", null, 27, null, 147, 31, 8, 32, null },
                    { 173, 6, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Khoáng sản 173", null, 41, null, 119, 48, 8, 25, null },
                    { 175, 9, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Đồ sưu tầm 175", null, 37, null, 130, 44, 8, 6, null },
                    { 178, 8, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 168, null, "Trang phục 178", null, 32, null, 159, 38, 8, 8, null },
                    { 179, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 166, null, "Nội thất 179", null, 34, null, 128, 40, 8, 31, null },
                    { 181, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Nội thất 181", null, 38, null, 145, 45, 8, 17, null },
                    { 182, 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 161, null, "Tiền cổ 182", null, 33, null, 143, 39, 8, 14, null },
                    { 184, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 163, null, "Xe 184", null, 28, null, 153, 32, 8, 31, null },
                    { 188, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 169, null, "Trang sức 188", null, 36, null, 134, 42, 8, 22, null },
                    { 194, 3, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 164, null, "Xe 194", null, 41, null, 159, 49, 8, 13, null },
                    { 198, 5, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Tranh 198", null, 31, null, 112, 37, 8, 7, null },
                    { 199, 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 160, null, "Nội thất 199", null, 39, null, 128, 46, 8, 33, null },
                    { 200, 4, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", 167, null, "Trang sức 200", null, 35, null, 147, 41, 8, 33, null }
                });

            migrationBuilder.InsertData(
                table: "StatusChanges",
                columns: new[] { "Id", "Deleted", "ItemId", "SellerApplicationId", "StatusChangeReason", "StatusChangedById", "StatusFrom", "StatusTo" },
                values: new object[,]
                {
                    { 201, null, 151, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 202, null, 152, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 203, null, 153, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 204, null, 154, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 205, null, 155, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 206, null, 156, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 209, null, 159, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 210, null, 160, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 211, null, 161, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 212, null, 162, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 215, null, 165, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 218, null, 168, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 219, null, 169, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 221, null, 171, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 224, null, 174, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 226, null, 176, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 227, null, 177, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 230, null, 180, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 233, null, 183, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 235, null, 185, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 236, null, 186, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 237, null, 187, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 239, null, 189, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 240, null, 190, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 241, null, 191, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 242, null, 192, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 243, null, 193, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 245, null, 195, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 246, null, 196, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 247, null, 197, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" }
                });

            migrationBuilder.InsertData(
                table: "AuctionSessionItem",
                columns: new[] { "AuctionSessionsId", "ItemsId" },
                values: new object[,]
                {
                    { 6, 157 },
                    { 6, 158 },
                    { 6, 163 },
                    { 6, 164 },
                    { 6, 166 },
                    { 6, 167 },
                    { 6, 170 },
                    { 6, 172 },
                    { 6, 173 },
                    { 6, 175 },
                    { 6, 178 },
                    { 6, 179 },
                    { 6, 181 },
                    { 6, 182 },
                    { 6, 184 },
                    { 6, 188 },
                    { 6, 194 },
                    { 6, 198 },
                    { 6, 199 },
                    { 6, 200 }
                });

            migrationBuilder.InsertData(
                table: "Bids",
                columns: new[] { "Id", "Amount", "AuctionSessionId", "Deleted", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 61, 44164831L, 6, null, 157, 118 },
                    { 62, 31729404L, 6, null, 157, 12 },
                    { 63, 23574418L, 6, null, 157, 118 },
                    { 64, 17126197L, 6, null, 157, 47 },
                    { 65, 2896490L, 6, null, 157, 164 },
                    { 66, 47207141L, 6, null, 157, 162 },
                    { 67, 10976476L, 6, null, 157, 37 },
                    { 68, 30688274L, 6, null, 157, 21 },
                    { 69, 46545227L, 6, null, 157, 2 },
                    { 70, 38665838L, 6, null, 157, 152 },
                    { 71, 45373014L, 6, null, 158, 26 },
                    { 72, 14642465L, 6, null, 158, 146 },
                    { 73, 15710613L, 6, null, 158, 17 },
                    { 74, 24392730L, 6, null, 158, 35 },
                    { 75, 23476136L, 6, null, 158, 21 },
                    { 76, 8390263L, 6, null, 158, 17 },
                    { 77, 43277276L, 6, null, 158, 37 },
                    { 78, 33055762L, 6, null, 158, 23 },
                    { 79, 48290375L, 6, null, 158, 121 },
                    { 80, 32201317L, 6, null, 158, 106 },
                    { 121, 13103164L, 6, null, 163, 54 },
                    { 122, 18299217L, 6, null, 163, 23 },
                    { 123, 7916995L, 6, null, 163, 4 },
                    { 124, 48963395L, 6, null, 163, 123 },
                    { 125, 34086161L, 6, null, 163, 162 },
                    { 126, 36077320L, 6, null, 163, 94 },
                    { 127, 4724581L, 6, null, 163, 1 },
                    { 128, 30077172L, 6, null, 163, 112 },
                    { 129, 38875587L, 6, null, 163, 111 },
                    { 130, 30893538L, 6, null, 163, 64 },
                    { 131, 7078598L, 6, null, 164, 114 },
                    { 132, 33411645L, 6, null, 164, 133 },
                    { 133, 32826325L, 6, null, 164, 155 },
                    { 134, 28151383L, 6, null, 164, 149 },
                    { 135, 14989481L, 6, null, 164, 128 },
                    { 136, 35011012L, 6, null, 164, 85 },
                    { 137, 4139693L, 6, null, 164, 151 },
                    { 138, 9173860L, 6, null, 164, 101 },
                    { 139, 40534233L, 6, null, 164, 121 },
                    { 140, 25043767L, 6, null, 164, 2 },
                    { 151, 15708239L, 6, null, 166, 67 },
                    { 152, 46708298L, 6, null, 166, 144 },
                    { 153, 32631101L, 6, null, 166, 159 },
                    { 154, 29395056L, 6, null, 166, 131 },
                    { 155, 47835942L, 6, null, 166, 133 },
                    { 156, 26433434L, 6, null, 166, 155 },
                    { 157, 21092232L, 6, null, 166, 75 },
                    { 158, 5909544L, 6, null, 166, 83 },
                    { 159, 27191313L, 6, null, 166, 34 },
                    { 160, 13750090L, 6, null, 166, 38 },
                    { 161, 34652662L, 6, null, 167, 73 },
                    { 162, 28774670L, 6, null, 167, 164 },
                    { 163, 15066542L, 6, null, 167, 162 },
                    { 164, 44064536L, 6, null, 167, 53 },
                    { 165, 44283565L, 6, null, 167, 100 },
                    { 166, 39920390L, 6, null, 167, 167 },
                    { 167, 27005814L, 6, null, 167, 43 },
                    { 168, 10018606L, 6, null, 167, 81 },
                    { 169, 3478942L, 6, null, 167, 58 },
                    { 170, 45660250L, 6, null, 167, 159 },
                    { 191, 5623429L, 6, null, 170, 17 },
                    { 192, 26812283L, 6, null, 170, 147 },
                    { 193, 7563713L, 6, null, 170, 97 },
                    { 194, 38666654L, 6, null, 170, 134 },
                    { 195, 20978127L, 6, null, 170, 110 },
                    { 196, 23059272L, 6, null, 170, 24 },
                    { 197, 19015578L, 6, null, 170, 77 },
                    { 198, 35577738L, 6, null, 170, 45 },
                    { 199, 28126855L, 6, null, 170, 49 },
                    { 200, 42876067L, 6, null, 170, 152 },
                    { 211, 37539422L, 6, null, 172, 63 },
                    { 212, 25989023L, 6, null, 172, 31 },
                    { 213, 22577435L, 6, null, 172, 135 },
                    { 214, 22386325L, 6, null, 172, 164 },
                    { 215, 37556495L, 6, null, 172, 69 },
                    { 216, 20893484L, 6, null, 172, 127 },
                    { 217, 19995536L, 6, null, 172, 129 },
                    { 218, 42474383L, 6, null, 172, 158 },
                    { 219, 48973574L, 6, null, 172, 114 },
                    { 220, 35464615L, 6, null, 172, 87 },
                    { 221, 19657844L, 6, null, 173, 71 },
                    { 222, 24602912L, 6, null, 173, 17 },
                    { 223, 1816991L, 6, null, 173, 159 },
                    { 224, 42196407L, 6, null, 173, 160 },
                    { 225, 6497304L, 6, null, 173, 105 },
                    { 226, 789597L, 6, null, 173, 4 },
                    { 227, 7181944L, 6, null, 173, 73 },
                    { 228, 9668670L, 6, null, 173, 104 },
                    { 229, 5594129L, 6, null, 173, 106 },
                    { 230, 3447611L, 6, null, 173, 65 },
                    { 241, 39239324L, 6, null, 175, 18 },
                    { 242, 20388944L, 6, null, 175, 143 },
                    { 243, 12387413L, 6, null, 175, 47 },
                    { 244, 33682805L, 6, null, 175, 61 },
                    { 245, 25070827L, 6, null, 175, 120 },
                    { 246, 9694629L, 6, null, 175, 60 },
                    { 247, 6590032L, 6, null, 175, 99 },
                    { 248, 48973617L, 6, null, 175, 152 },
                    { 249, 17088105L, 6, null, 175, 56 },
                    { 250, 18875526L, 6, null, 175, 50 },
                    { 271, 28279589L, 6, null, 178, 3 },
                    { 272, 42064180L, 6, null, 178, 166 },
                    { 273, 38191024L, 6, null, 178, 126 },
                    { 274, 4929566L, 6, null, 178, 104 },
                    { 275, 12745780L, 6, null, 178, 96 },
                    { 276, 44316384L, 6, null, 178, 136 },
                    { 277, 33407802L, 6, null, 178, 21 },
                    { 278, 20764801L, 6, null, 178, 72 },
                    { 279, 2611199L, 6, null, 178, 148 },
                    { 280, 12273322L, 6, null, 178, 80 },
                    { 281, 39126401L, 6, null, 179, 143 },
                    { 282, 41865267L, 6, null, 179, 83 },
                    { 283, 18790440L, 6, null, 179, 156 },
                    { 284, 39128782L, 6, null, 179, 115 },
                    { 285, 3045248L, 6, null, 179, 75 },
                    { 286, 49051603L, 6, null, 179, 143 },
                    { 287, 10358353L, 6, null, 179, 158 },
                    { 288, 28710788L, 6, null, 179, 83 },
                    { 289, 37647624L, 6, null, 179, 146 },
                    { 290, 27834294L, 6, null, 179, 93 },
                    { 301, 21342604L, 6, null, 181, 106 },
                    { 302, 49858963L, 6, null, 181, 153 },
                    { 303, 9051705L, 6, null, 181, 65 },
                    { 304, 11500955L, 6, null, 181, 147 },
                    { 305, 12027702L, 6, null, 181, 80 },
                    { 306, 15543357L, 6, null, 181, 19 },
                    { 307, 48892066L, 6, null, 181, 27 },
                    { 308, 47051398L, 6, null, 181, 103 },
                    { 309, 20977937L, 6, null, 181, 70 },
                    { 310, 3121384L, 6, null, 181, 42 },
                    { 311, 16034283L, 6, null, 182, 81 },
                    { 312, 22768184L, 6, null, 182, 66 },
                    { 313, 47711040L, 6, null, 182, 140 },
                    { 314, 48044474L, 6, null, 182, 140 },
                    { 315, 17357009L, 6, null, 182, 18 },
                    { 316, 38734546L, 6, null, 182, 77 },
                    { 317, 19610431L, 6, null, 182, 21 },
                    { 318, 6113922L, 6, null, 182, 83 },
                    { 319, 35620296L, 6, null, 182, 167 },
                    { 320, 23913748L, 6, null, 182, 137 },
                    { 331, 6948637L, 6, null, 184, 93 },
                    { 332, 24108948L, 6, null, 184, 167 },
                    { 333, 25653142L, 6, null, 184, 118 },
                    { 334, 43794439L, 6, null, 184, 17 },
                    { 335, 8082080L, 6, null, 184, 137 },
                    { 336, 46351265L, 6, null, 184, 120 },
                    { 337, 12747286L, 6, null, 184, 56 },
                    { 338, 41432398L, 6, null, 184, 131 },
                    { 339, 4248842L, 6, null, 184, 59 },
                    { 340, 16947341L, 6, null, 184, 22 },
                    { 371, 44384818L, 6, null, 188, 148 },
                    { 372, 1268748L, 6, null, 188, 147 },
                    { 373, 18052880L, 6, null, 188, 153 },
                    { 374, 18393425L, 6, null, 188, 155 },
                    { 375, 18382671L, 6, null, 188, 46 },
                    { 376, 29921855L, 6, null, 188, 55 },
                    { 377, 44155346L, 6, null, 188, 169 },
                    { 378, 31660629L, 6, null, 188, 62 },
                    { 379, 38420386L, 6, null, 188, 114 },
                    { 380, 21056677L, 6, null, 188, 160 },
                    { 431, 8403282L, 6, null, 194, 48 },
                    { 432, 32384732L, 6, null, 194, 160 },
                    { 433, 15006131L, 6, null, 194, 85 },
                    { 434, 16969543L, 6, null, 194, 36 },
                    { 435, 13587977L, 6, null, 194, 147 },
                    { 436, 9091920L, 6, null, 194, 96 },
                    { 437, 14502411L, 6, null, 194, 96 },
                    { 438, 22913951L, 6, null, 194, 78 },
                    { 439, 14138165L, 6, null, 194, 123 },
                    { 440, 1233681L, 6, null, 194, 119 },
                    { 471, 34476234L, 6, null, 198, 45 },
                    { 472, 29302222L, 6, null, 198, 114 },
                    { 473, 2332246L, 6, null, 198, 111 },
                    { 474, 8330992L, 6, null, 198, 110 },
                    { 475, 44515881L, 6, null, 198, 133 },
                    { 476, 15904215L, 6, null, 198, 59 },
                    { 477, 20700919L, 6, null, 198, 33 },
                    { 478, 15277161L, 6, null, 198, 94 },
                    { 479, 14274821L, 6, null, 198, 82 },
                    { 480, 6672308L, 6, null, 198, 163 },
                    { 481, 32311188L, 6, null, 199, 112 },
                    { 482, 20906974L, 6, null, 199, 33 },
                    { 483, 19354019L, 6, null, 199, 152 },
                    { 484, 25878442L, 6, null, 199, 146 },
                    { 485, 49400627L, 6, null, 199, 137 },
                    { 486, 49793247L, 6, null, 199, 157 },
                    { 487, 26111272L, 6, null, 199, 72 },
                    { 488, 23888651L, 6, null, 199, 148 },
                    { 489, 21070237L, 6, null, 199, 123 },
                    { 490, 48308179L, 6, null, 199, 149 },
                    { 491, 18468642L, 6, null, 200, 131 },
                    { 492, 26215113L, 6, null, 200, 151 },
                    { 493, 18348721L, 6, null, 200, 153 },
                    { 494, 28554669L, 6, null, 200, 106 },
                    { 495, 5351680L, 6, null, 200, 10 },
                    { 496, 12556424L, 6, null, 200, 85 },
                    { 497, 32491051L, 6, null, 200, 49 },
                    { 498, 11431666L, 6, null, 200, 15 },
                    { 499, 43830057L, 6, null, 200, 144 },
                    { 500, 20140070L, 6, null, 200, 14 }
                });

            migrationBuilder.InsertData(
                table: "ImageItem",
                columns: new[] { "ImagesId", "ItemsId" },
                values: new object[,]
                {
                    { 6, 182 },
                    { 6, 199 },
                    { 7, 163 },
                    { 7, 167 },
                    { 7, 170 },
                    { 7, 173 },
                    { 7, 178 },
                    { 7, 179 },
                    { 7, 188 },
                    { 8, 164 },
                    { 8, 173 },
                    { 9, 194 },
                    { 9, 199 },
                    { 10, 158 },
                    { 10, 164 },
                    { 10, 181 },
                    { 10, 194 },
                    { 10, 200 },
                    { 11, 163 },
                    { 11, 166 },
                    { 11, 170 },
                    { 11, 194 },
                    { 12, 158 },
                    { 13, 166 },
                    { 13, 175 },
                    { 13, 198 },
                    { 14, 166 },
                    { 14, 178 },
                    { 14, 181 },
                    { 15, 157 },
                    { 15, 158 },
                    { 15, 163 },
                    { 16, 157 },
                    { 16, 164 },
                    { 16, 167 },
                    { 16, 172 },
                    { 17, 175 },
                    { 17, 182 },
                    { 17, 199 },
                    { 17, 200 },
                    { 18, 181 },
                    { 18, 188 },
                    { 18, 199 },
                    { 19, 173 },
                    { 19, 184 },
                    { 20, 167 },
                    { 20, 173 },
                    { 20, 200 },
                    { 21, 158 },
                    { 21, 166 },
                    { 21, 170 },
                    { 21, 182 },
                    { 21, 184 },
                    { 21, 198 },
                    { 21, 200 },
                    { 22, 184 },
                    { 23, 175 },
                    { 23, 188 },
                    { 24, 163 },
                    { 24, 198 },
                    { 24, 200 },
                    { 25, 157 },
                    { 25, 158 },
                    { 25, 167 },
                    { 25, 172 },
                    { 25, 175 },
                    { 25, 184 },
                    { 26, 164 },
                    { 26, 170 },
                    { 26, 181 },
                    { 26, 184 },
                    { 27, 198 },
                    { 28, 163 },
                    { 28, 164 },
                    { 28, 179 },
                    { 28, 194 },
                    { 29, 157 },
                    { 29, 172 },
                    { 29, 175 },
                    { 29, 188 },
                    { 29, 198 },
                    { 30, 172 },
                    { 30, 178 },
                    { 30, 179 },
                    { 31, 166 },
                    { 31, 178 },
                    { 31, 179 },
                    { 31, 194 },
                    { 31, 199 },
                    { 32, 170 },
                    { 32, 178 },
                    { 32, 182 },
                    { 32, 188 },
                    { 33, 157 },
                    { 33, 179 },
                    { 33, 181 },
                    { 33, 182 },
                    { 34, 167 },
                    { 34, 172 },
                    { 34, 173 }
                });

            migrationBuilder.InsertData(
                table: "ItemProperties",
                columns: new[] { "Id", "Deleted", "ItemId", "Label", "Value" },
                values: new object[,]
                {
                    { 625, null, 157, "Chiều dài", "22cm" },
                    { 626, null, 157, "Chiều rộng", "3cm" },
                    { 627, null, 157, "Chiều cao", "24cm" },
                    { 628, null, 157, "Cân nặng", "913g" },
                    { 629, null, 158, "Chiều dài", "6cm" },
                    { 630, null, 158, "Chiều rộng", "4cm" },
                    { 631, null, 158, "Chiều cao", "36cm" },
                    { 632, null, 158, "Cân nặng", "1348g" },
                    { 649, null, 163, "Chiều dài", "20cm" },
                    { 650, null, 163, "Chiều rộng", "0cm" },
                    { 651, null, 163, "Chiều cao", "14cm" },
                    { 652, null, 163, "Cân nặng", "1461g" },
                    { 653, null, 164, "Chiều dài", "13cm" },
                    { 654, null, 164, "Chiều rộng", "12cm" },
                    { 655, null, 164, "Chiều cao", "10cm" },
                    { 656, null, 164, "Cân nặng", "552g" },
                    { 661, null, 166, "Chiều dài", "7cm" },
                    { 662, null, 166, "Chiều rộng", "12cm" },
                    { 663, null, 166, "Chiều cao", "6cm" },
                    { 664, null, 166, "Cân nặng", "2489g" },
                    { 665, null, 167, "Chiều dài", "22cm" },
                    { 666, null, 167, "Chiều rộng", "14cm" },
                    { 667, null, 167, "Chiều cao", "33cm" },
                    { 668, null, 167, "Cân nặng", "1667g" },
                    { 677, null, 170, "Chiều dài", "25cm" },
                    { 678, null, 170, "Chiều rộng", "13cm" },
                    { 679, null, 170, "Chiều cao", "9cm" },
                    { 680, null, 170, "Cân nặng", "3751g" },
                    { 685, null, 172, "Chiều dài", "21cm" },
                    { 686, null, 172, "Chiều rộng", "0cm" },
                    { 687, null, 172, "Chiều cao", "30cm" },
                    { 688, null, 172, "Cân nặng", "2670g" },
                    { 689, null, 173, "Chiều dài", "12cm" },
                    { 690, null, 173, "Chiều rộng", "9cm" },
                    { 691, null, 173, "Chiều cao", "37cm" },
                    { 692, null, 173, "Cân nặng", "3810g" },
                    { 697, null, 175, "Chiều dài", "34cm" },
                    { 698, null, 175, "Chiều rộng", "8cm" },
                    { 699, null, 175, "Chiều cao", "31cm" },
                    { 700, null, 175, "Cân nặng", "1001g" },
                    { 709, null, 178, "Chiều dài", "13cm" },
                    { 710, null, 178, "Chiều rộng", "11cm" },
                    { 711, null, 178, "Chiều cao", "28cm" },
                    { 712, null, 178, "Cân nặng", "4400g" },
                    { 713, null, 179, "Chiều dài", "41cm" },
                    { 714, null, 179, "Chiều rộng", "19cm" },
                    { 715, null, 179, "Chiều cao", "22cm" },
                    { 716, null, 179, "Cân nặng", "4884g" },
                    { 721, null, 181, "Chiều dài", "30cm" },
                    { 722, null, 181, "Chiều rộng", "14cm" },
                    { 723, null, 181, "Chiều cao", "25cm" },
                    { 724, null, 181, "Cân nặng", "1344g" },
                    { 725, null, 182, "Chiều dài", "35cm" },
                    { 726, null, 182, "Chiều rộng", "1cm" },
                    { 727, null, 182, "Chiều cao", "40cm" },
                    { 728, null, 182, "Cân nặng", "1356g" },
                    { 733, null, 184, "Chiều dài", "10cm" },
                    { 734, null, 184, "Chiều rộng", "8cm" },
                    { 735, null, 184, "Chiều cao", "13cm" },
                    { 736, null, 184, "Cân nặng", "2289g" },
                    { 749, null, 188, "Chiều dài", "10cm" },
                    { 750, null, 188, "Chiều rộng", "2cm" },
                    { 751, null, 188, "Chiều cao", "3cm" },
                    { 752, null, 188, "Cân nặng", "2893g" },
                    { 773, null, 194, "Chiều dài", "29cm" },
                    { 774, null, 194, "Chiều rộng", "2cm" },
                    { 775, null, 194, "Chiều cao", "42cm" },
                    { 776, null, 194, "Cân nặng", "4450g" },
                    { 789, null, 198, "Chiều dài", "0cm" },
                    { 790, null, 198, "Chiều rộng", "1cm" },
                    { 791, null, 198, "Chiều cao", "24cm" },
                    { 792, null, 198, "Cân nặng", "3077g" },
                    { 793, null, 199, "Chiều dài", "4cm" },
                    { 794, null, 199, "Chiều rộng", "0cm" },
                    { 795, null, 199, "Chiều cao", "31cm" },
                    { 796, null, 199, "Cân nặng", "3936g" },
                    { 797, null, 200, "Chiều dài", "24cm" },
                    { 798, null, 200, "Chiều rộng", "17cm" },
                    { 799, null, 200, "Chiều cao", "30cm" },
                    { 800, null, 200, "Cân nặng", "549g" }
                });

            migrationBuilder.InsertData(
                table: "StatusChanges",
                columns: new[] { "Id", "Deleted", "ItemId", "SellerApplicationId", "StatusChangeReason", "StatusChangedById", "StatusFrom", "StatusTo" },
                values: new object[,]
                {
                    { 207, null, 157, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 208, null, 158, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 213, null, 163, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 214, null, 164, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 216, null, 166, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 217, null, 167, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 220, null, 170, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 222, null, 172, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 223, null, 173, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 225, null, 175, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 228, null, 178, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 229, null, 179, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 231, null, 181, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 232, null, 182, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 234, null, 184, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 238, null, 188, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 244, null, 194, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 248, null, 198, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 249, null, 199, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" },
                    { 250, null, 200, null, "Đã bán", 1, "PAYMENT_PENDING", "PAID" }
                });

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

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 101 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 102 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 103 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 104 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 105 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 106 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 107 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 108 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 109 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 110 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 111 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 112 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 113 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 114 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 115 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 116 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 117 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 118 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 119 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 120 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 121 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 122 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 123 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 124 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 125 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 126 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 127 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 128 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 129 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 130 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 131 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 132 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 133 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 134 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 135 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 136 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 137 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 138 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 139 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 140 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 141 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 142 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 143 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 144 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 145 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 146 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 147 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 148 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 149 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 150 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 151 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 152 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 153 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 154 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 155 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 156 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 157 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 158 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 159 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 160 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 161 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 162 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 163 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 164 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 165 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 166 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 167 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 168 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 169 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 170 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 171 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 172 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 173 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 174 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 175 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 176 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 177 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 178 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 179 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 180 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 181 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 182 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 183 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 184 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 185 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 186 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 187 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 188 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 189 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 190 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 191 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 192 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 193 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 194 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 195 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 196 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 197 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 198 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 199 });

            migrationBuilder.DeleteData(
                table: "AuctionSessionItem",
                keyColumns: new[] { "AuctionSessionsId", "ItemsId" },
                keyValues: new object[] { 6, 200 });

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
                table: "Bids",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 20 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 21 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 23 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 34 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 41 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 45 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 46 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 64 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 73 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 88 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 90 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 101 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 104 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 112 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 132 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 135 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 138 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 143 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 150 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 177 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 182 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 185 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 186 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 187 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 193 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 195 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 197 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 6, 199 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 22 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 27 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 30 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 33 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 36 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 54 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 65 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 76 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 104 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 118 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 125 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 128 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 134 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 137 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 142 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 145 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 146 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 154 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 156 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 163 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 167 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 169 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 170 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 171 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 173 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 174 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 178 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 179 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 180 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 183 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 188 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 7, 190 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 26 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 30 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 36 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 41 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 45 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 67 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 81 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 101 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 102 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 110 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 114 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 123 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 126 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 138 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 159 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 164 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 173 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 185 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 191 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 8, 192 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 23 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 31 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 32 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 33 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 39 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 60 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 62 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 69 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 72 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 78 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 85 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 93 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 101 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 109 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 112 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 113 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 116 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 117 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 124 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 135 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 140 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 150 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 159 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 194 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 9, 199 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 21 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 31 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 35 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 41 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 42 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 45 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 47 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 48 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 50 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 54 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 55 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 57 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 64 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 66 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 67 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 79 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 80 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 84 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 92 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 95 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 97 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 98 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 119 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 125 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 127 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 131 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 133 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 134 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 139 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 142 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 143 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 153 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 158 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 159 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 164 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 176 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 181 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 194 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 195 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 10, 200 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 20 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 21 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 24 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 28 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 31 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 32 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 37 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 47 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 50 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 65 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 69 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 73 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 76 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 77 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 91 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 95 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 100 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 134 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 136 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 144 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 151 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 153 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 162 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 163 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 166 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 168 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 169 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 170 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 191 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 194 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 11, 197 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 20 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 21 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 22 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 29 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 35 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 46 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 51 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 84 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 89 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 94 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 96 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 103 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 119 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 122 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 138 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 148 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 149 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 154 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 155 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 158 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 160 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 12, 169 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 17 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 19 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 24 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 29 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 36 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 41 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 46 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 50 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 51 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 54 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 59 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 63 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 68 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 74 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 76 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 82 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 85 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 88 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 93 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 94 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 113 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 120 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 139 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 144 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 161 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 166 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 168 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 175 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 176 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 183 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 192 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 13, 198 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 12 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 15 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 27 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 28 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 30 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 31 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 36 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 37 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 38 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 43 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 48 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 53 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 56 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 63 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 78 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 79 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 82 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 102 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 105 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 110 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 112 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 117 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 129 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 135 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 142 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 148 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 149 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 151 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 154 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 155 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 166 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 176 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 178 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 181 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 14, 196 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 27 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 31 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 35 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 45 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 48 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 59 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 65 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 69 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 70 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 83 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 84 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 89 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 90 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 92 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 93 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 98 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 99 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 104 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 106 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 110 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 113 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 118 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 119 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 122 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 129 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 130 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 132 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 133 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 145 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 152 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 157 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 158 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 159 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 163 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 168 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 183 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 185 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 186 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 190 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 15, 196 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 14 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 19 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 22 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 26 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 28 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 34 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 38 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 39 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 48 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 60 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 72 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 74 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 75 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 77 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 94 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 98 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 100 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 108 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 113 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 114 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 127 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 128 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 130 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 142 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 147 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 157 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 164 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 167 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 172 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 192 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 193 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 16, 195 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 18 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 28 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 32 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 40 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 41 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 42 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 44 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 45 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 49 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 51 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 52 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 56 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 57 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 64 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 66 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 68 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 75 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 80 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 81 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 87 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 95 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 96 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 100 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 105 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 111 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 121 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 141 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 143 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 147 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 154 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 175 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 182 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 193 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 196 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 199 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 17, 200 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 15 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 16 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 18 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 26 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 34 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 50 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 53 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 55 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 57 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 59 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 73 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 86 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 89 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 91 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 97 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 100 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 103 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 115 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 118 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 121 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 125 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 129 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 130 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 131 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 132 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 134 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 137 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 139 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 147 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 149 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 156 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 176 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 180 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 181 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 188 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 190 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 195 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 18, 199 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 17 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 21 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 26 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 30 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 32 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 42 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 47 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 50 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 57 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 58 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 59 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 84 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 86 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 88 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 92 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 97 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 98 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 107 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 120 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 125 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 129 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 131 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 140 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 151 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 162 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 168 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 171 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 173 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 174 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 184 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 187 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 190 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 19, 192 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 18 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 24 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 29 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 35 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 39 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 67 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 70 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 74 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 75 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 80 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 90 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 105 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 109 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 111 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 112 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 117 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 122 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 135 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 148 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 153 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 162 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 167 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 173 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 185 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 189 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 196 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 20, 200 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 25 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 42 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 43 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 54 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 56 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 58 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 60 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 62 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 77 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 82 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 89 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 91 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 104 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 108 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 114 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 115 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 124 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 133 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 139 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 140 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 143 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 147 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 149 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 152 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 158 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 160 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 161 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 165 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 166 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 170 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 174 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 180 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 182 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 184 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 198 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 21, 200 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 7 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 20 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 28 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 44 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 46 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 49 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 61 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 68 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 69 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 73 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 79 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 82 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 90 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 94 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 105 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 113 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 114 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 128 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 138 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 140 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 144 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 148 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 152 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 155 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 161 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 165 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 168 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 183 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 22, 184 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 11 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 13 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 17 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 19 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 20 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 25 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 32 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 40 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 53 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 58 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 59 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 63 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 68 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 70 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 75 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 81 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 84 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 88 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 122 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 123 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 125 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 127 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 136 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 155 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 171 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 175 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 186 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 188 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 190 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 23, 191 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 8 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 19 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 26 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 39 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 52 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 61 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 71 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 74 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 75 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 80 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 83 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 87 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 91 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 96 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 103 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 108 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 120 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 129 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 141 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 147 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 156 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 162 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 163 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 165 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 169 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 176 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 177 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 197 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 198 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 24, 200 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 15 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 22 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 23 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 29 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 37 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 40 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 43 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 44 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 66 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 71 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 79 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 81 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 83 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 88 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 89 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 95 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 100 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 105 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 106 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 110 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 112 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 124 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 130 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 137 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 140 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 157 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 158 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 160 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 165 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 167 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 172 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 175 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 25, 184 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 23 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 40 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 48 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 51 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 57 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 58 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 60 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 62 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 70 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 71 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 79 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 80 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 86 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 95 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 96 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 97 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 102 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 107 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 109 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 118 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 120 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 139 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 144 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 145 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 146 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 156 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 164 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 170 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 180 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 181 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 26, 184 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 8 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 12 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 16 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 18 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 33 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 35 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 38 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 39 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 43 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 44 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 46 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 47 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 49 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 52 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 62 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 71 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 72 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 99 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 104 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 108 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 109 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 114 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 116 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 117 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 119 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 120 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 121 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 124 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 128 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 132 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 134 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 136 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 137 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 145 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 174 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 187 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 27, 198 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 6 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 9 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 24 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 25 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 27 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 33 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 55 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 61 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 72 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 76 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 78 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 82 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 90 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 92 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 99 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 106 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 110 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 111 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 115 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 121 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 122 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 130 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 133 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 136 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 141 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 146 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 150 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 151 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 152 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 154 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 155 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 161 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 163 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 164 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 179 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 186 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 189 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 194 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 28, 195 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 9 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 10 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 18 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 40 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 42 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 49 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 54 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 55 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 56 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 67 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 69 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 74 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 78 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 85 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 87 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 91 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 101 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 103 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 106 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 116 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 118 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 123 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 141 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 145 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 149 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 150 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 157 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 171 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 172 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 175 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 177 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 185 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 188 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 193 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 197 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 29, 198 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 9 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 34 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 37 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 44 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 56 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 61 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 66 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 73 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 77 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 83 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 94 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 99 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 109 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 126 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 127 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 131 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 133 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 138 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 156 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 172 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 178 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 179 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 189 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 30, 193 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 9 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 30 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 33 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 36 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 38 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 47 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 52 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 53 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 60 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 63 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 65 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 78 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 83 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 86 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 98 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 103 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 106 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 107 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 111 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 115 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 116 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 117 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 119 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 126 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 127 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 136 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 142 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 143 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 148 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 165 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 166 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 174 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 177 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 178 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 179 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 180 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 183 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 186 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 187 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 194 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 31, 199 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 7 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 16 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 17 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 19 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 22 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 29 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 43 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 53 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 62 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 63 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 64 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 65 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 66 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 67 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 68 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 72 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 76 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 85 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 87 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 92 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 93 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 97 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 126 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 131 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 132 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 135 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 146 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 160 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 161 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 169 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 170 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 178 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 182 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 187 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 188 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 191 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 32, 192 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 7 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 8 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 16 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 23 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 25 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 37 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 38 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 52 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 55 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 58 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 61 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 81 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 85 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 86 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 93 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 96 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 99 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 101 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 102 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 107 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 108 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 111 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 115 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 121 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 123 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 126 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 141 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 146 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 150 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 153 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 157 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 159 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 171 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 179 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 181 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 182 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 189 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 33, 197 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 24 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 25 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 27 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 34 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 49 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 51 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 64 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 70 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 71 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 77 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 87 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 102 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 107 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 116 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 123 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 124 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 128 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 137 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 144 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 151 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 152 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 153 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 160 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 162 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 167 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 172 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 173 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 177 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 189 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 191 });

            migrationBuilder.DeleteData(
                table: "ImageItem",
                keyColumns: new[] { "ImagesId", "ItemsId" },
                keyValues: new object[] { 34, 196 });

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "ItemProperties",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "StatusChanges",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 200);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

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
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

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
                keyValue: 40);

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
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

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
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

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
                keyValue: 94);

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
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101);

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
                table: "AuctionSessions",
                keyColumn: "Id",
                keyValue: 6);

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
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 135);

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
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 161);

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
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42);

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
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 126);

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
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 137);

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
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 147);

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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

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
                keyValue: 33);

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
                keyValue: 52);

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
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);

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
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 114);

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
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 140);

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
                keyValue: 148);

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
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 162);

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

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "ItemProperties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Doxx him John");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemProperties_Items_ItemId",
                table: "ItemProperties",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");
        }
    }
}
