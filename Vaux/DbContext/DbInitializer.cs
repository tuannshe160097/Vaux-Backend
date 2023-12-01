using Microsoft.EntityFrameworkCore;
using Vaux.Models.Enums;
using Vaux.Models;
using Vaux.DTO;
using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.AspNetCore.SignalR;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System;
using Twilio.TwiML.Voice;

namespace Vaux.DbContext
{
    public static class DbInitializer
    {
        static Random _random = new Random("Vaux".Sum(c => c));

        static readonly string[] ID_URLS = new string[]
        {
            ""
        };

        static readonly string[] IMAGE_URLS = new string[]
        {
            "1fDReENNEAcCtkvWpvMwiF_HnqCdfHIOE",
            "1VQyOksZ9hyEd3L84xEg2sbPy8-zsJWtG",
            "1K1eSFe7JESqKVoj89U2cDKG76piC-29p",
            "1zvORDR3ME5QAVdpdkvVhqC1I-cftwmeP",
            "1DOJgh8UniAvTGW6inoLYgjN68XIlHTyR",
            "1lQ1eUCDXVnMnDqxPa3RTztk0N3qsHyvP",
            "1upsVLimN8xaZ3peARfPntWJu4Gj7P1WP",
            "1A5-phXoxhKIRiqj8YnoD5oWqk2Ua629C",
            "100fLwWf0t5_EYifXqeAjS5DmEBHRNpYg",
            "1cRRj3h8NXCRTsMAilFVDSORt3Txx0bwb",
            "162A-xxZ8q1K5E5ehkWfCBgtn9VlVs4dD",
            "1sCVdJSyIRpE2n6IJSnbExc13g6F8RA-T",
            "119tVm9ti33pV3Zk_C4cfdLu5mGFZXZiF",
            "1q4jdxdrd7FQ5YEj4LWkegJf5nuTk3BfH",
            "1qD6au1YKFsojnM5Mt2NjFYR4KJDaCik4",
            "1r4m0I9fD26xSpajZ4Qu73fzxVaKQeJlS",
            "178SmSAqmPuGEyQPyJCyd5THNPlEgTE4Z",
            "1nohUVvOL337CV23LZZsnT5D56uobcnZ9",
            "17xEyhtmDMs9JneeDF6TkH3jJWK9MDzS5",
            "1qzvXnG78BxPyC5PxKnUIHWRYI0ufqloP",
            "147tE9lV93qgZomyJVb86jmxD4cnAqJ0Z",
            "1P1veS-lU9Fv0xdJOHGzct4DsXk1EfS1F",
            "18qsoYjvijfns4VY5XxmVNFI7tNcG2GrA",
            "1H5lFn65qyRs9x0nsmt4K8iZczjTpQEEE",
            "1WJsssktOTp07ZqOnbXuRoohL9YZs4w",
            "1f4LwIzuVi23ZW0mWqqkpN2jfNo9-x72y",
            "1A0N3nCeubMNex28OyATYhgst5ViJYKoc",
            "1spuK7h5S2P0IqCuj0tHGi5smcNl5q792",
            "1ovvnNMv0008C_Q1pwbxhN8ER-wI4xF",
        };

        static readonly string[] FIRST_NAMES = new string[]
        {
            "Nguyễn",
            "Trần",
            "Lê",
            "Phạm",
            "Hoàng",
            "Huỳnh",
            "Vũ",
            "Võ",
            "Phan",
            "Trương",
            "Bùi",
            "Đặng",
            "Đỗ",
            "Ngô",
            "Hồ",
            "Dương",
            "Đinh",
        };

        static readonly string[] LAST_NAMES = new string[]
        {
            "An",
            "Anh",
            "Bảo",
            "Bích",
            "Bình",
            "Cam",
            "Châu",
            "Chi",
            "Chí",
            "Công",
            "Cúc",
            "Đạt",
            "Diệp",
            "Diệu",
            "Đình",
            "Đức",
            "Dũng",
            "Dương",
            "Giang",
            "Hà",
            "Hải",
            "Hằng",
            "Hào",
            "Hiếu",
            "Hoa",
            "Hồng",
            "Huệ",
            "Hùng",
            "Hương",
            "Hường",
            "Hữu",
            "Huy",
            "Khánh",
            "Kim",
            "Lan",
            "Lành",
            "Liêm",
            "Liên",
            "Linh",
            "Loan",
            "Long",
            "Mai",
            "Minh",
            "Mỹ",
            "Nam",
            "Ngải",
            "Ngọc",
            "Nguyên",
            "Nguyệt",
            "Nhung",
            "Phúc",
            "Phương",
            "Phượng",
            "Quân",
            "Quang",
            "Quý",
            "Quyên",
            "Quyền",
            "Quỳnh",
            "Sơn",
            "Thanh",
            "Thảo",
            "Thi",
            "Thị",
            "From",
            "Thu",
            "Thuần",
            "Thùy",
            "Tiên",
            "Trai",
            "Trang",
            "Trí",
            "Trinh",
            "Trúc",
            "Tú",
            "Tuân",
            "Tuấn",
            "Tuyến",
            "Tuyết",
            "Vân",
            "Văn",
            "Viên",
            "Viện",
            "Vinh",
            "Xuân",
            "Yên",
        };

        static readonly string[] ADDRESS = new string[]
        {
            "Hàng Bè, số ",
            "Phố Huế, số ",
            "Nhà Hỏa, số ",
            "Ấu Triệu, số ",
            "Hàng Bồ, số ",
            "Lãn Ông, số ",
            "Nhà thờ, số ",
            "Bà Triệu, số ",
            "Hàng Bông, số ",
            "Lê Duẩn, số ",
            "Ô Quan Chưởng, số ",
            "Bạch Đằng, số ",
            "Hàng Buồm, số ",
            "Lê Lai, số ",
            "Phạm Ngũ Lão, số ",
            "Bảo Khánh, số ",
            "Hàng Bút, số ",
            "Lê Phụng Hiểu, số ",
            "Phạm Sư Mạnh, số ",
            "Bảo Linh, số ",
            "Hàng Cá, số ",
            "Lê Thạch, số ",
            "Phan Bội Châu, số ",
            "Bát Đàn, số ",
            "Hàng Cân, số ",
            "Lê Thái Tổ, số ",
            "Phan Chu Trinh, số ",
            "Bát Sứ, số ",
            "Hàng Chai, số ",
            "Lê Thánh Tông, số ",
            "Phan Đình Phùng, số ",
            "Cao Thắng, số ",
            "Hàng Chiếu, số ",
            "Lê Văn Hưu, số ",
            "Phan Huy Chú, số ",
            "Cầu Đất, số ",
            "Hàng Chĩnh, số ",
            "Lê Văn Linh, số ",
            "Phủ Doãn, số ",
            "Cầu Đông, số ",
            "Hàng Cót, số ",
            "Liên Trì, số ",
            "Phúc Tân, số ",
            "Cầu Gỗ, số ",
            "Hàng Da, số ",
            "Lò Rèn, số ",
            "Phùng Hưng, số ",
            "Chả Cá, số ",
            "Hàng Đào, số ",
            "Lò Sũ, số ",
            "Quán Sứ, số ",
            "Chân Cầm, số ",
            "Hàng Đậu, số ",
            "Lương Ngọc Quyến, số ",
            "Quang Trung, số ",
            "Chợ Gạo, số ",
            "Hàng Điếu, số ",
            "Lương Văn Can, số ",
            "Tạ Hiện, số ",
            "Chương Dương Độ, số ",
            "Hàng Đồng, số ",
            "Lý Đạo Thành, số ",
            "Thanh Hà, số ",
            "Cổ Tân, số ",
            "Hàng Đường, số ",
            "Lý Nam Đế, số ",
            "Thanh Yên, số ",
            "Cổng Đục, số ",
            "Hàng Gà, số ",
            "Lý Quốc Sư, số ",
            "Thợ Nhuộm, số ",
            "Cửa Đông, số ",
            "Hàng Gai, số ",
            "Lý Thái Tổ, số ",
            "Thuốc Bắc, số ",
            "Cửa Nam, số ",
            "Hàng Giầy, số ",
            "Lý Thường Kiệt, số ",
            "Tô Tịch, số ",
            "Dã Tượng, số ",
            "Hàng Giấy, số ",
            "Mã Mây, số ",
            "Tôn Thất Thiệp, số ",
            "Đặng Thái Thân, số ",
            "Hàng Hòm, số ",
            "Nam Ngư, số ",
            "Tông Đản, số ",
            "Đào Duy Từ, số ",
            "Hàng Khay, số ",
            "Ngõ Gạch, số ",
            "Tống Duy Tân, số ",
            "Điện Biên Phủ, số ",
            "Hàng Khoai, số ",
            "Ngô Quyền, số ",
            "Trần Bình Trọng, số ",
            "Đinh Công Tráng, số ",
            "Hàng Lược, số ",
            "Ngô Thì Nhậm, số ",
            "Trần Hưng Đạo, số ",
            "Đinh Lễ, số ",
            "Hàng Mã, số ",
            "Ngõ Trạm, số ",
            "Trần Khánh Dư, số ",
            "Đinh Liệt, số ",
            "Hàng Mắm, số ",
            "Ngô Văn Sở, số ",
            "Trần Nguyên Hãn, số ",
            "Đình Ngang, số ",
            "Hàng Mành, số ",
            "Nguyễn Chế Nghĩa, số ",
            "Trần Nhật Duật, số ",
            "Đinh Tiên Hoàng, số ",
            "Hàng Muối, số ",
            "Nguyễn Du, số ",
            "Trần Phú, số ",
            "Đoàn Nhữ Hài, số ",
            "Hàng Ngang, số ",
            "Nguyễn Gia Thiều, số ",
            "Trần Quang Khải, số ",
            "Đông Thái, số ",
            "Hàng Nón, số ",
            "Nguyễn Hữu Huân, số ",
            "Trần Quốc Toản, số ",
            "Đồng Xuân, số ",
            "Hàng Quạt, số ",
            "Nguyễn Khắc Cần, số ",
            "Tràng Thi, số ",
            "Đường Thành, số ",
            "Hàng Rươi, số ",
            "Nguyên Khiết, số ",
            "Tràng Tiền, số ",
            "Gầm Cầu, số ",
            "Hàng Thiếc, số ",
            "Nguyễn Quang Bích, số ",
            "Triệu Quốc Đạt, số ",
            "Gia Ngư, số ",
            "Hàng Thùng, số ",
            "Nguyễn Siêu, số ",
            "Trương Hán Siêu, số ",
            "Hà Trung, số ",
            "Hàng Tre, số ",
            "Nguyễn Thái Học, số ",
            "Vạn Kiếp, số ",
            "Hai Bà Trưng, số ",
            "Hàng Trống, số ",
            "Nguyễn Thiện Thuật, số ",
            "Vọng Đức, số ",
            "Hàm Long, số ",
            "Hàng Vải, số ",
            "Nguyễn Thiếp, số ",
            "Vọng Hà, số ",
            "Hàm Tử Quan, số ",
            "Hàng Vôi, số ",
            "Nguyễn Tư Giản, số ",
            "Yết Kiêu, số ",
            "Hàn Thuyên, số ",
            "Hồ Hoàn Kiếm, số ",
            "Nguyễn Văn Tố, số ",
            "Hàng Bạc, số ",
            "Hỏa Lò, số ",
            "Nguyễn Xí, số ",
            "Hàng Bài, số ",
            "Hồng Hà, số ",
            "Nhà Chung, số ",
        };

        static readonly string[] COMMENTS = new string[]
        {
            "Món này giá cuối không thể quá 10tr được",
            "Trông anh hơi mờ nhỉ, không biết có uy tín không",
            "Anh em dẹp hết ra tôi all-in món này",
            "Vcl con này 100tr là ít",
            "Sắp hết phiên rồi mà chưa thấy ai ra giá nhỉ?",
            "Đúng món mình còn thiếu luôn!",
            "Anh em nhường mình món này mua tặng vợ nhé",
            "Vl biếu sếp con này chắc phải tăng 3 bậc lương!",
            "Có thật là đồ cổ không thế, trông mới lắm",
            "Mua một món bé thế này mà bằng 10 bữa thịt chó cơ à?",
            "Lần đầu tiên trái thanh long có trong mỳ tôm",
            "Đang săn con này mà lại thiếu tiền mới cay chứ :v",
            "Món này trên TikTok thấy đầy á",
            "Đẹp dã man luôn!",
            "Món này 10 điểm nha!",
            "Ui hồi xưa ở nhà thấy cái này suốt",
            "Cái này hồi xưa rẻ như cho",
            "Giá sàn bằng 2 tháng lương thế này thì theo sao nổi?",
            "Mấy cái comment trông như bot ấy",
            "Ảnh trông tối quá",
            "Ảnh chụp mờ quá",
            "Đồ này trông hay mà ít người theo nhỉ?",
            "Món này trông có vẻ hot nè",
            "Tôi quen người bán cái này bà con không lo bị scam nha",
            "Ai thẩm định món này mà để giá sàn cao thế?",
            "Ai thẩm định món này mà để giá sàn thấp thế?",
            "Chơi môn này áp lực ngang cớ bạc!",
            "Mọi người muốn mua thêm mấy món thế này thì đợi phiên tiếp theo mua của mình nha",
            "Hội mua mấy món như này chắc cũng phải U50 hết nhỉ?",
            "Đồ cổ kiểu này tìm ngoài đời khó thật sự, lên đây tìm một tí thấy luôn tiện thật",
            "Web này đảm bảo an toàn nhé mình có mua đồ rồi",
            "Người bán trước đây có bán gì khác chưa?",
            "Món này ai thẩm định vậy?",
            "Đồ rất đẹp mình cho 1 like",
            "Món này mình thích nhưng hơi xước quá rồi nên nhường mọi người đó",
            "Phiên mới lên nhanh thế?",
            "Mãi mới tới phiên có đồ hay",
            "Đồ rẻ quá mình xin bỏ nha",
            "Đồ vô nghĩa quá chắc thôi",
            "Mua món này bán lại có khi nhà lầu xe hơi đấy",
            "Có khi nào mấy món này để rửa tiền không?",
            "Đồ đắt thật, đúng web cho giới nhà giàu",
            "Bán một món này có khi tiền ăn cả đời không hết",
            "Web trung gian bán mấy món thế này chắc giàu nhanh lắm nhỉ",
            "Ai tiền nhiều thì cứ sưu tầm cái này đi",
            "Mình trốn vợ mua cái này về chơi chắc không biết đâu nhỉ?",
            "Trông sang chảnh thật!",
            "Đồ cổ mà trông hơi phén",
            "Ai phải biết cảm nhận mới thấy món này giá trị",
            "Thẩm định được món này chắc phải đỉnh lắm",
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            Role[] roles = new Role[] {
                new Role()
                {
                    Id = (int)RoleId.MODERATOR,
                    Title = nameof(RoleId.MODERATOR)
                },
                new Role()
                {
                    Id = (int)RoleId.EXPERT,
                    Title = nameof(RoleId.EXPERT)
                },
                new Role()
                {
                    Id = (int)RoleId.SELLER,
                    Title = nameof(RoleId.SELLER)
                },
                new Role()
                {
                    Id = (int)RoleId.BUYER,
                    Title = nameof(RoleId.BUYER)
                },
                new Role()
                {
                    Id = (int)RoleId.ADMIN,
                    Title = nameof(RoleId.ADMIN)
                }
            };
            modelBuilder.Entity<Role>().HasData(roles);

            List<User> users = new List<User>();
            users.Add(new User()
            {
                Id = 1,
                RoleId = (int)RoleId.ADMIN,
                Name = "Admin",
                Phone = "0855068490",
                Email = "tuannshe160097@fpt.edu.vn"
            });

            List<Image> idImages = new();
            foreach (var image in ID_URLS)
            {
                idImages.Add(new Image()
                {
                    Id = idImages.Count + 1,
                    Url = image,
                    Note = "Generated"
                });
            }
            modelBuilder.Entity<Image>().HasData(idImages);

            List<Image> itemImages = new();
            foreach (var image in IMAGE_URLS)
            {
                itemImages.Add(new Image()
                {
                    Id = idImages.Count + itemImages.Count + 1,
                    Url = image,
                    Note = "Generated"
                });
            }
            modelBuilder.Entity<Image>().HasData(itemImages);

            for (int i = 0; i < 100; i++)
            {
                var phone = GeneratePhone();
                while (users.FirstOrDefault(e => e.Phone == phone) != null)
                {
                    phone = GeneratePhone();
                }
                users.Add(new User()
                {
                    Id = users.Count + 1,
                    RoleId = (int)RoleId.BUYER,
                    Name = ConstructName(),
                    Phone = phone,
                    IsVerified = true,
                    City = "thanh_pho_ha_noi",
                    District = "quan_ba_dinh",
                    Street = "phuong_giang_vo",
                    HouseNumber = RandomElement(ADDRESS),
                });
            }

            for (int i = 0; i < 50; i++)
            {
                var phone = GeneratePhone();
                while (users.FirstOrDefault(e => e.Phone == phone) != null)
                {
                    phone = GeneratePhone();
                }
                var idImage = RandomElement(idImages.ToArray()).Id;
                users.Add(new User()
                {
                    Id = users.Count + 1,
                    RoleId = (int)RoleId.SELLER,
                    Name = ConstructName(),
                    Phone = phone,
                    Email = $"{users.Count + 1}@gmail.com",
                    IsVerified = true,
                    City = "thanh_pho_ha_noi",
                    District = "quan_ba_dinh",
                    Street = "phuong_giang_vo",
                    HouseNumber = RandomElement(ADDRESS),
                    Gender = _random.Next(1) == 1 ? "Male" : "Female",
                    DoB = RandomDate(),
                    CitizenId = GeneratePhone(),
                    CitizenIdImageId = idImage,
                    PortraitId = idImage,
                    BankAccountNum = GeneratePhone(),
                    BankCode = "ICB",
                    BankName = "VietinBank"
                });
            }

            for (int i = 0; i < 10; i++)
            {
                var phone = GeneratePhone();
                while (users.FirstOrDefault(e => e.Phone == phone) != null)
                {
                    phone = GeneratePhone();
                }
                var idImage = RandomElement(idImages.ToArray()).Id;
                users.Add(new User()
                {
                    Id = users.Count + 1,
                    RoleId = (int)RoleId.EXPERT,
                    Name = ConstructName(),
                    Phone = phone,
                    Email = $"{users.Count + 1}@gmail.com",
                    IsVerified = true,
                    City = "thanh_pho_ha_noi",
                    District = "quan_ba_dinh",
                    Street = "phuong_giang_vo",
                    HouseNumber = RandomElement(ADDRESS),
                    Gender = _random.Next(1) == 1 ? "Male" : "Female",
                    DoB = RandomDate(),
                    CitizenId = GeneratePhone(),
                    CitizenIdImageId = idImage,
                    PortraitId = idImage,
                    BankAccountNum = GeneratePhone(),
                    BankCode = "ICB",
                    BankName = "VietinBank"
                });
            }

            modelBuilder.Entity<User>().HasData(users);

            List<AuctionSession> auctionSessions = new();
            DateTime start = new DateTime(2023, 12, 4);
            for (int i = 0; i < 5; i++)
            {
                auctionSessions.Add(new AuctionSession()
                {
                    Id = i + 1,
                    StartDate = start.AddDays(i * 7).AddHours(7),
                    EndDate = start.AddDays(i * 7 + 6).AddHours(19),
                    Status = AuctionSessionStatus.PENDING,
                });
            }
        }

        private static T RandomElement<T>(T[] array)
        {
            return array[_random.Next(array.Length)];
        }

        private static string ConstructName()
        {
            return $"{RandomElement(FIRST_NAMES)} {RandomElement(FIRST_NAMES)} {RandomElement(LAST_NAMES)}";
        }

        private static string GeneratePhone()
        {
            string phone = "";
            for (int i = 0; i < 10; i++)
            {
                phone += _random.Next(9);
            }

            return phone;
        }

        private static DateTime RandomDate()
        {
            return DateTime.Today.AddDays(-_random.Next(365 * 18, 365 * 50));
        }
    }
}
