using Microsoft.EntityFrameworkCore;
using Vaux.Models.Enums;
using Vaux.Models;

namespace Vaux.DbContext
{
    public static class DbInitializer
    {
        static Random _random = new Random("Vaux".Sum(c => c));

        static readonly string[] ID_URLS = new string[]
        {
            "1fDReENNEAcCtkvWpvMwiF_HnqCdfHIOE",
            "1VQyOksZ9hyEd3L84xEg2sbPy8-zsJWtG",
            "1K1eSFe7JESqKVoj89U2cDKG76piC-29p",
            "1zvORDR3ME5QAVdpdkvVhqC1I-cftwmeP",
            "1DOJgh8UniAvTGW6inoLYgjN68XIlHTyR",
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

        static string ITEM_DESCRIPTION = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur mattis elit in erat dapibus ornare. Donec nec facilisis sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum malesuada risus non sodales. Morbi vitae rutrum leo, nec eleifend nunc. Praesent bibendum tincidunt sapien. Nulla nec gravida lectus, ac auctor justo. Donec eleifend, sapien vel varius euismod, lorem enim facilisis nisl, vitae porta urna nisl nec lectus. Maecenas laoreet metus quis libero pharetra tempor. Nulla facilisi. Aenean dictum non augue eu faucibus. Nam quis viverra leo, imperdiet convallis leo. Morbi vitae ipsum purus. In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.";

        public static void Seed(ModelBuilder modelBuilder)
        {
            Role[] roles = new Role[] {
                new()
                {
                    Id = (int)RoleId.MODERATOR,
                    Title = nameof(RoleId.MODERATOR)
                },
                new()
                {
                    Id = (int)RoleId.EXPERT,
                    Title = nameof(RoleId.EXPERT)
                },
                new()
                {
                    Id = (int)RoleId.SELLER,
                    Title = nameof(RoleId.SELLER)
                },
                new()
                {
                    Id = (int)RoleId.BUYER,
                    Title = nameof(RoleId.BUYER)
                },
                new()
                {
                    Id = (int)RoleId.ADMIN,
                    Title = nameof(RoleId.ADMIN)
                }
            };


            Category[] categories = new Category[]
            {
                new()
                {
                    Id = 1,
                    Name = "Tiền cổ"
                },
                new()
                {
                    Id = 2,
                    Name = "Nội thất"
                },
                new()
                {
                    Id = 3,
                    Name = "Xe"
                },
                new()
                {
                    Id = 4,
                    Name = "Trang sức"
                },
                new()
                {
                    Id = 5,
                    Name = "Tranh"
                },
                new()
                {
                    Id = 6,
                    Name = "Khoáng sản"
                },
                new()
                {
                    Id = 7,
                    Name = "Văn tự"
                },
                new()
                {
                    Id = 8,
                    Name = "Trang phục"
                },
                new()
                {
                    Id = 9,
                    Name = "Đồ sưu tầm"
                },
                new()
                {
                    Id = 10,
                    Name = "Văn tự"
                },
            };

            List<AuctionSession> auctionSessions = new();
            List<AuctionSessionReport> auctionSessionsReport = new();
            DateTime start = new DateTime(2023, 12, 4).Date;
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
            auctionSessions.Add(new AuctionSession()
            {
                Id = 6,
                StartDate = start.AddHours(7),
                EndDate = new DateTime(2024, 1, 1).AddHours(19),
                Status = AuctionSessionStatus.ONGOING,
            });

            List<AuctionSession> endedAuctions = new();
            endedAuctions.Add(new AuctionSession()
            {
                Id = 7,
                StartDate = start.AddHours(7),
                EndDate = start.AddDays(6).AddHours(19),
                Status = AuctionSessionStatus.FINISHED,
                ReportId = auctionSessionsReport.Count() + 1
            });
            auctionSessionsReport.Add(new AuctionSessionReport()
            {
                Id = auctionSessionsReport.Count() + 1,
            });

            endedAuctions.Add(new AuctionSession()
            {
                Id = 8,
                StartDate = start.AddHours(7),
                EndDate = start.AddDays(7 + 6).AddHours(19),
                Status = AuctionSessionStatus.FINISHED,
                ReportId = auctionSessionsReport.Count() + 1
            });
            auctionSessionsReport.Add(new AuctionSessionReport()
            {
                Id = auctionSessionsReport.Count() + 1,
            });

            endedAuctions.Add(new AuctionSession()
            {
                Id = 9,
                StartDate = start.AddHours(7),
                EndDate = start.AddDays(14 + 6).AddHours(19),
                Status = AuctionSessionStatus.FINISHED,
                ReportId = auctionSessionsReport.Count() + 1
            });
            auctionSessionsReport.Add(new AuctionSessionReport()
            {
                Id = auctionSessionsReport.Count() + 1,
            });

            auctionSessions.AddRange(endedAuctions);

            List<User> users = new List<User>
            {
                new User()
                {
                    Id = 1,
                    RoleId = (int)RoleId.ADMIN,
                    Name = "Admin",
                    Phone = "0855068490",
                    Email = "tuannshe160097@fpt.edu.vn"
                },
                new User()
                {
                    Id = 2,
                    RoleId = (int)RoleId.MODERATOR,
                    Name = "Admin",
                    Phone = "08550684901",
                    Email = "1@fpt.edu.vn"
                },
                new User()
                {
                    Id = 3,
                    RoleId = (int)RoleId.MODERATOR,
                    Name = "Admin",
                    Phone = "08550684902",
                    Email = "2@fpt.edu.vn"
                },
                new User()
                {
                    Id = 4,
                    RoleId = (int)RoleId.MODERATOR,
                    Name = "Admin",
                    Phone = "08550684903",
                    Email = "3@fpt.edu.vn"
                },
                new User()
                {
                    Id = 5,
                    RoleId = (int)RoleId.MODERATOR,
                    Name = "Admin",
                    Phone = "08550684904",
                    Email = "4@fpt.edu.vn"
                }
            };

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

            for (int i = 0; i < 100; i++)
            {
                var phone = GeneratePhone();
                while (users.FirstOrDefault(e => e.Phone == phone) != null)
                {
                    phone = GeneratePhone();
                }
                var user = new User()
                {
                    Id = users.Count + 5,
                    RoleId = (int)RoleId.BUYER,
                    Name = ConstructName(),
                    Phone = phone,
                    IsVerified = true,
                    City = "thanh_pho_ha_noi",
                    District = "quan_hoan_kiem",
                    Street = "",
                    HouseNumber = RandomElement(ADDRESS) + _random.Next(100),
                    Address = "Generated",
                };
                users.Add(user);
            }

            List<StatusChange> statusChanges = new();
            List<SellerApplication> sellerApplications = new();
            for (int i = 0; i < 50; i++)
            {
                var phone = GeneratePhone();
                while (users.FirstOrDefault(e => e.Phone == phone) != null)
                {
                    phone = GeneratePhone();
                }
                var idImage = RandomElement(idImages.ToArray());
                var user = new User()
                {
                    Id = users.Count + 5,
                    RoleId = (int)RoleId.SELLER,
                    Name = ConstructName(),
                    Phone = phone,
                    Email = $"{users.Count + 1}@gmail.com",
                    IsVerified = true,
                    City = "thanh_pho_ha_noi",
                    District = "quan_hoan_kiem",
                    Street = "",
                    HouseNumber = RandomElement(ADDRESS) + _random.Next(100),
                    Address = "Generated",
                    Gender = _random.Next(1) == 1 ? "Male" : "Female",
                    DoB = RandomDate(),
                    CitizenId = GeneratePhone(),
                    CitizenIdImageId = idImage.Id,
                    PortraitId = idImage.Id,
                    BankAccountNum = GeneratePhone(),
                    BankCode = "ICB",
                    BankName = "VietinBank"
                };
                users.Add(user);

                SellerApplication sellerApplication = new()
                {
                    Id = i + 1,
                    UserId = user.Id,
                    Gender = user.Gender,
                    CitizenId = user.CitizenId,
                    Content = ITEM_DESCRIPTION,
                    Email = user.Email,
                    BankAccountNum = user.BankAccountNum,
                    BankCode = user.BankCode,
                    BankName = user.BankName,
                    CitizenIdImageId = user.CitizenIdImageId,
                    City = user.City,
                    District = user.District,
                    Street = user.Street,
                    HouseNumber = user.HouseNumber,
                    Address = user.Address,
                    DoB = user.DoB ?? new DateTime(2000, 1, 1),
                    PortraitId = user.PortraitId,
                    Status = SellerApplicationStatus.APPROVED,
                };
                sellerApplications.Add(sellerApplication);

                StatusChange statusChange = new()
                {
                    Id = statusChanges.Count + 1,
                    SellerApplicationId = i + 1,
                    StatusChangedById = _random.Next(1, 5),
                    StatusFrom = SellerApplicationStatus.PENDING.ToString(),
                    StatusTo = SellerApplicationStatus.APPROVED.ToString(),
                    StatusChangeReason = "Ok"
                };
                statusChanges.Add(statusChange);
            }

            for (int i = 0; i < 10; i++)
            {
                var phone = GeneratePhone();
                while (users.FirstOrDefault(e => e.Phone == phone) != null)
                {
                    phone = GeneratePhone();
                }
                var idImage = RandomElement(idImages.ToArray());
                var user = new User()
                {
                    Id = users.Count + 5,
                    RoleId = (int)RoleId.EXPERT,
                    Name = ConstructName(),
                    Phone = phone,
                    Email = $"{users.Count + 1}@gmail.com",
                    IsVerified = true,
                    City = "thanh_pho_ha_noi",
                    District = "quan_hoan_kiem",
                    Street = "",
                    HouseNumber = RandomElement(ADDRESS) + _random.Next(100),
                    Address = "Generated",
                    Gender = _random.Next(1) == 1 ? "Male" : "Female",
                    DoB = RandomDate(),
                    CitizenId = GeneratePhone(),
                    CitizenIdImageId = idImage.Id,
                    PortraitId = idImage.Id,
                    BankAccountNum = GeneratePhone(),
                    BankCode = "ICB",
                    BankName = "VietinBank"
                };
                users.Add(user);
            }

            List<Item> items = new List<Item>();
            List<ItemProperty> itemProperties = new();
            List<Object> imageItemsTable = new();
            List<Object> auctionSessionItemTable = new();
            User[] sellers = users.Where(e => e.RoleId == (int)RoleId.SELLER).ToArray();
            User[] experts = users.Where(e => e.RoleId == (int)RoleId.EXPERT).ToArray();
            for (int i = 0; i < 50; i++)
            {
                var category = RandomElement(categories);
                var expert = RandomElement(experts);
                var id = items.Count + 1;

                var item = new Item()
                {
                    Id = id,
                    Status = ItemStatus.REJECTED,
                    SellerId = RandomElement(sellers).Id,
                    ExpertId = expert.Id,
                    CategoryId = category.Id,
                    Name = category.Name + " " + id,
                    Description = ITEM_DESCRIPTION,
                    ThumbnailId = RandomElement(itemImages.ToArray()).Id,
                };
                items.Add(item);

                var properties = new ItemProperty[]
                {
                    new()
                    {
                        Id = itemProperties.Count + 1,
                        Label = "Chiều dài",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 2,
                        Label = "Chiều rộng",
                        Value = $"{_random.Next(20)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 3,
                        Label = "Chiều cao",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 4,
                        Label = "Cân nặng",
                        Value = $"{_random.Next(500, 5000)}g",
                        ItemId = id,
                    },
                };
                itemProperties.AddRange(properties);

                Image[] images = RandomElements(itemImages.ToArray(), 5);
                for (int j = 0; j < 5; j++)
                {
                    var imageItem = new
                    {
                        ImagesId = images[j].Id,
                        ItemsId = id,
                    };
                    imageItemsTable.Add(imageItem);
                }

                var statusChange = new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = _random.Next(1, 5),
                    StatusFrom = ItemStatus.EXAMINATION_PENDING.ToString(),
                    StatusTo = ItemStatus.REJECTED.ToString(),
                    StatusChangeReason = "Không đạt tiêu chuẩn"
                };
                statusChanges.Add(statusChange);
            }

            for (int i = 0; i < 50; i++)
            {
                var category = RandomElement(categories);
                var id = items.Count + 1;

                var item = new Item()
                {
                    Id = id,
                    Status = ItemStatus.EXAMINATION_PENDING,
                    SellerId = RandomElement(sellers).Id,
                    CategoryId = category.Id,
                    Name = category.Name + " " + id,
                    Description = ITEM_DESCRIPTION,
                    ThumbnailId = RandomElement(itemImages.ToArray()).Id,
                };
                items.Add(item);

                var properties = new ItemProperty[]
                {
                    new()
                    {
                        Id = itemProperties.Count + 1,
                        Label = "Chiều dài",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 2,
                        Label = "Chiều rộng",
                        Value = $"{_random.Next(20)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 3,
                        Label = "Chiều cao",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 4,
                        Label = "Cân nặng",
                        Value = $"{_random.Next(500, 5000)}g",
                        ItemId = id,
                    },
                };
                itemProperties.AddRange(properties);

                Image[] images = RandomElements(itemImages.ToArray(), 5);
                for (int j = 0; j < 5; j++)
                {
                    var imageItem = new
                    {
                        ImagesId = images[j].Id,
                        ItemsId = id,
                    };
                    imageItemsTable.Add(imageItem);
                }
            }

            for (int i = 0; i < 50; i++)
            {
                var category = RandomElement(categories);
                var expert = RandomElement(experts);
                var id = items.Count + 1;

                var item = new Item()
                {
                    Id = id,
                    Status = ItemStatus.AUCTION_PENDING,
                    SellerId = RandomElement(sellers).Id,
                    ExpertId = expert.Id,
                    CategoryId = category.Id,
                    Name = category.Name + " " + id,
                    Description = ITEM_DESCRIPTION,
                    ThumbnailId = RandomElement(itemImages.ToArray()).Id,
                };
                items.Add(item);

                var properties = new ItemProperty[]
                {
                    new()
                    {
                        Id = itemProperties.Count + 1,
                        Label = "Chiều dài",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 2,
                        Label = "Chiều rộng",
                        Value = $"{_random.Next(20)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 3,
                        Label = "Chiều cao",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 4,
                        Label = "Cân nặng",
                        Value = $"{_random.Next(500, 5000)}g",
                        ItemId = id,
                    },
                };
                itemProperties.AddRange(properties);

                Image[] images = RandomElements(itemImages.ToArray(), 5);
                for (int j = 0; j < 5; j++)
                {
                    var imageItem = new
                    {
                        ImagesId = images[j].Id,
                        ItemsId = id,
                    };
                    imageItemsTable.Add(imageItem);
                }

                var statusChange = new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = expert.Id,
                    StatusFrom = ItemStatus.EXAMINATION_PENDING.ToString(),
                    StatusTo = ItemStatus.AUCTION_PENDING.ToString(),
                    StatusChangeReason = "Đã đạt tiêu chuẩn đấu giá"
                };
                statusChanges.Add(statusChange);
            }

            for (int i = 0; i < 50; i++)
            {
                var category = RandomElement(categories);
                var expert = RandomElement(experts);
                var id = items.Count + 1;

                var item = new Item()
                {
                    Id = id,
                    Status = ItemStatus.AUCTION_IN_PROGRESS,
                    SellerId = RandomElement(sellers).Id,
                    ExpertId = expert.Id,
                    CategoryId = category.Id,
                    Name = category.Name + " " + id,
                    Description = ITEM_DESCRIPTION,
                    ThumbnailId = RandomElement(itemImages.ToArray()).Id,
                    OngoingSessionId = 6
                };
                items.Add(item);
                var auctionSessionItem = new
                {
                    AuctionSessionsId = 6,
                    ItemsId = id,
                };
                auctionSessionItemTable.Add(auctionSessionItem);
                var properties = new ItemProperty[]
                {
                    new()
                    {
                        Id = itemProperties.Count + 1,
                        Label = "Chiều dài",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 2,
                        Label = "Chiều rộng",
                        Value = $"{_random.Next(20)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 3,
                        Label = "Chiều cao",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 4,
                        Label = "Cân nặng",
                        Value = $"{_random.Next(500, 5000)}g",
                        ItemId = id,
                    },
                };
                itemProperties.AddRange(properties);

                Image[] images = RandomElements(itemImages.ToArray(), 5);
                for (int j = 0; j < 5; j++)
                {
                    var imageItem = new
                    {
                        ImagesId = images[j].Id,
                        ItemsId = id,
                    };
                    imageItemsTable.Add(imageItem);
                }

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = expert.Id,
                    StatusFrom = ItemStatus.EXAMINATION_PENDING.ToString(),
                    StatusTo = ItemStatus.AUCTION_PENDING.ToString(),
                    StatusChangeReason = "Đã đạt tiêu chuẩn đấu giá"
                });

                var statusChange = new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = expert.Id,
                    StatusFrom = ItemStatus.AUCTION_PENDING.ToString(),
                    StatusTo = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                    StatusChangeReason = "Start auction"
                };
                statusChanges.Add(statusChange);
            }

            List<Bid> bids = new();
            for (int i = 0; i < 50; i++)
            {
                var category = RandomElement(categories);
                var expert = RandomElement(experts);
                var id = items.Count + 1;

                var item = new Item()
                {
                    Id = id,
                    Status = ItemStatus.PAID,
                    SellerId = RandomElement(sellers).Id,
                    ExpertId = expert.Id,
                    CategoryId = category.Id,
                    Name = category.Name + " " + id,
                    Description = ITEM_DESCRIPTION,
                    ThumbnailId = RandomElement(itemImages.ToArray()).Id,
                };
                items.Add(item);

                var session = RandomElement(endedAuctions.ToArray());
                var report = auctionSessionsReport.First(e => e.Id == session.ReportId);

                List<Bid> bidsLocal = new();
                for (int j = 0; j < 50; j++)
                {
                    var bid = new Bid()
                    {
                        Id = bids.Count + 1,
                        ItemId = item.Id,
                        Amount = _random.Next(50000, 50000000),
                        AuctionSessionId = session.Id,
                        UserId = RandomElement(users.ToArray()).Id
                    };
                    bids.Add(bid);
                    bidsLocal.Add(bid);
                    report.ActiveBids++;
                }

                item.HighestBidId = bidsLocal.Aggregate((i1, i2) => i1.Amount > i2.Amount ? i1 : i2).Id;

                var auctionSessionItem = new
                {
                    AuctionSessionsId = session.Id,
                    ItemsId = id,
                };
                auctionSessionItemTable.Add(auctionSessionItem);

                var properties = new ItemProperty[]
                {
                    new()
                    {
                        Id = itemProperties.Count + 1,
                        Label = "Chiều dài",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 2,
                        Label = "Chiều rộng",
                        Value = $"{_random.Next(20)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 3,
                        Label = "Chiều cao",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 4,
                        Label = "Cân nặng",
                        Value = $"{_random.Next(500, 5000)}g",
                        ItemId = id,
                    },
                };
                itemProperties.AddRange(properties);

                Image[] images = RandomElements(itemImages.ToArray(), 5);
                for (int j = 0; j < 5; j++)
                {
                    var imageItem = new
                    {
                        ImagesId = images[j].Id,
                        ItemsId = id,
                    };
                    imageItemsTable.Add(imageItem);
                }

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = expert.Id,
                    StatusFrom = ItemStatus.EXAMINATION_PENDING.ToString(),
                    StatusTo = ItemStatus.AUCTION_PENDING.ToString(),
                    StatusChangeReason = "Đã đạt tiêu chuẩn đấu giá"
                });

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = 1,
                    StatusFrom = ItemStatus.AUCTION_PENDING.ToString(),
                    StatusTo = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                    StatusChangeReason = "Start auction"
                });

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = 1,
                    StatusFrom = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                    StatusTo = ItemStatus.PAYMENT_PENDING.ToString(),
                    StatusChangeReason = $"Item won by user {bids.First(e => e.Id == item.HighestBidId).UserId}"
                });

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = 1,
                    StatusFrom = ItemStatus.PAYMENT_PENDING.ToString(),
                    StatusTo = ItemStatus.PAID.ToString(),
                    StatusChangeReason = $"Changed status from {nameof(ItemStatus.PAYMENT_PENDING)} to {nameof(ItemStatus.PAID)}"
                });

                report.AuctionedItems++;
                report.SoldItems++;
                report.ActiveItems++;
            }

            for (int i = 0; i < 50; i++)
            {
                var category = RandomElement(categories);
                var expert = RandomElement(experts);
                var id = items.Count + 1;

                var item = new Item()
                {
                    Id = id,
                    Status = ItemStatus.RE_AUCTION_PENDING,
                    SellerId = RandomElement(sellers).Id,
                    ExpertId = expert.Id,
                    CategoryId = category.Id,
                    Name = category.Name + " " + id,
                    Description = ITEM_DESCRIPTION,
                    ThumbnailId = RandomElement(itemImages.ToArray()).Id,
                };
                items.Add(item);

                var session = RandomElement(endedAuctions.ToArray());
                var auctionSessionItem = new
                {
                    AuctionSessionsId = session.Id,
                    ItemsId = id,
                };
                auctionSessionItemTable.Add(auctionSessionItem);

                var properties = new ItemProperty[]
                {
                    new()
                    {
                        Id = itemProperties.Count + 1,
                        Label = "Chiều dài",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 2,
                        Label = "Chiều rộng",
                        Value = $"{_random.Next(20)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 3,
                        Label = "Chiều cao",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 4,
                        Label = "Cân nặng",
                        Value = $"{_random.Next(500, 5000)}g",
                        ItemId = id,
                    },
                };
                itemProperties.AddRange(properties);

                Image[] images = RandomElements(itemImages.ToArray(), 5);
                for (int j = 0; j < 5; j++)
                {
                    var imageItem = new
                    {
                        ImagesId = images[j].Id,
                        ItemsId = id,
                    };
                    imageItemsTable.Add(imageItem);
                }

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = expert.Id,
                    StatusFrom = ItemStatus.EXAMINATION_PENDING.ToString(),
                    StatusTo = ItemStatus.AUCTION_PENDING.ToString(),
                    StatusChangeReason = "Đã đạt tiêu chuẩn đấu giá"
                });

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = 1,
                    StatusFrom = ItemStatus.AUCTION_PENDING.ToString(),
                    StatusTo = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                    StatusChangeReason = "Start auction"
                });

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = 1,
                    StatusFrom = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                    StatusTo = ItemStatus.RE_AUCTION_PENDING.ToString(),
                    StatusChangeReason = $"Item auction failed"
                });

                var report = auctionSessionsReport.First(e => e.Id == session.ReportId);
                report.UnauctionedItems++;
                report.ActiveItems++;
            }


            for (int i = 0; i < 50; i++)
            {
                var category = RandomElement(categories);
                var expert = RandomElement(experts);
                var id = items.Count + 1;

                var item = new Item()
                {
                    Id = id,
                    Status = ItemStatus.RE_AUCTION_PENDING,
                    SellerId = RandomElement(sellers).Id,
                    ExpertId = expert.Id,
                    CategoryId = category.Id,
                    Name = category.Name + " " + id,
                    Description = ITEM_DESCRIPTION,
                    ThumbnailId = RandomElement(itemImages.ToArray()).Id,
                };
                items.Add(item);

                var session = RandomElement(endedAuctions.ToArray());
                var report = auctionSessionsReport.First(e => e.Id == session.ReportId);

                List<Bid> bidsLocal = new();
                for (int j = 0; j < 50; j++)
                {
                    var bid = new Bid()
                    {
                        Id = bids.Count + 1,
                        ItemId = item.Id,
                        Amount = _random.Next(50000, 50000000),
                        AuctionSessionId = session.Id,
                        UserId = RandomElement(users.ToArray()).Id
                    };
                    bids.Add(bid);
                    bidsLocal.Add(bid);
                    report.ActiveBids++;
                }

                item.HighestBidId = bidsLocal.Aggregate((i1, i2) => i1.Amount > i2.Amount ? i1 : i2).Id;

                var auctionSessionItem = new
                {
                    AuctionSessionsId = session.Id,
                    ItemsId = id,
                };
                auctionSessionItemTable.Add(auctionSessionItem);

                var properties = new ItemProperty[]
                {
                    new()
                    {
                        Id = itemProperties.Count + 1,
                        Label = "Chiều dài",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 2,
                        Label = "Chiều rộng",
                        Value = $"{_random.Next(20)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 3,
                        Label = "Chiều cao",
                        Value = $"{_random.Next(50)}cm",
                        ItemId = id,
                    },
                    new()
                    {
                        Id = itemProperties.Count + 4,
                        Label = "Cân nặng",
                        Value = $"{_random.Next(500, 5000)}g",
                        ItemId = id,
                    },
                };
                itemProperties.AddRange(properties);

                Image[] images = RandomElements(itemImages.ToArray(), 5);
                for (int j = 0; j < 5; j++)
                {
                    var imageItem = new
                    {
                        ImagesId = images[j].Id,
                        ItemsId = id,
                    };
                    imageItemsTable.Add(imageItem);
                }

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = expert.Id,
                    StatusFrom = ItemStatus.EXAMINATION_PENDING.ToString(),
                    StatusTo = ItemStatus.AUCTION_PENDING.ToString(),
                    StatusChangeReason = "Đã đạt tiêu chuẩn đấu giá"
                });

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = 1,
                    StatusFrom = ItemStatus.AUCTION_PENDING.ToString(),
                    StatusTo = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                    StatusChangeReason = "Start auction"
                });

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = 1,
                    StatusFrom = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                    StatusTo = ItemStatus.PAYMENT_PENDING.ToString(),
                    StatusChangeReason = $"Item won by user {bids.First(e => e.Id == item.HighestBidId).UserId}"
                });

                statusChanges.Add(new StatusChange()
                {
                    Id = statusChanges.Count + 1,
                    ItemId = id,
                    StatusChangedById = 1,
                    StatusFrom = ItemStatus.PAYMENT_PENDING.ToString(),
                    StatusTo = ItemStatus.RE_AUCTION_PENDING.ToString(),
                    StatusChangeReason = $"User {bids.First(e => e.Id == item.HighestBidId).UserId} did not pay"
                });

                report.AuctionedItems++;
                report.UnpaidItems++;
                report.ActiveItems++;
            }

            List<Order> orders = new();
            List<Item> soldItems = items.Where(e => e.Status == ItemStatus.PAID).ToList();
            List<User> wonUsers = users.Where(e => bids.Where(b => soldItems.Select(i => i.HighestBidId).Contains(b.Id)).Select(b => b.UserId).Contains(e.Id)).ToList();
            List<Shipment> shipments = new();
            List<ItemPayment> itemPayments = new();
            for (int i = 0; i < wonUsers.Count; i++)
            {
                var user = wonUsers[i];
                var id = i + 1;
                List<Item> orderItems = soldItems.Where(e => bids.First(b => b.Id == e.HighestBidId).UserId == user.Id).ToList();
                var order = new Order()
                {
                    Id = id,
                    UserId = user.Id,
                    Status = OrderStatus.PAID,
                    ReceiverName = user.Name,
                    ReceiverPhone = user.Phone,
                    Address = user.Address,
                };
                List<Shipment> localShipments = new();
                foreach (var item in orderItems)
                {
                    var shipment = localShipments.FirstOrDefault(e => e.SellerId == item.SellerId);
                    if (shipment == null)
                    {
                        shipment = new();
                        shipment.Id = shipments.Count + 1;
                        shipment.Status = ShipmentStatus.SHIPPED;
                        shipment.OrderId = order.Id;
                        shipment.ItemCost = 0;
                        shipment.ShippingCost = 0;
                        shipment.SellerId = item.SellerId;
                        shipment.Address = sellers.First(e => e.Id == item!.SellerId).Address;
                        shipments.Add(shipment);
                        localShipments.Add(shipment);
                    }
                    shipment.ShippingCost += 40000;
                    var highestBid = bids.First(e => e.Id == item.HighestBidId);
                    shipment.ItemCost += highestBid.Amount + CalculateBuyerProtectionFee(highestBid.Amount);
                    order.TotalCost += shipment.ItemCost + shipment.ShippingCost;
                    item.ShipmentId = shipment.Id;
                    item.OrderId = order.Id;

                    ItemPayment itemPayment = new()
                    {
                        Id = itemPayments.Count + 1,
                        ItemId = item.Id,
                        SellerPayout = CalculateSellerPayment(highestBid.Amount),
                        ExpertPayout = CalculateExpertPayment(highestBid.Amount),
                        Revenue = CalculateRevenue(highestBid.Amount),
                    };
                    itemPayments.Add(itemPayment);

                    var report = auctionSessionsReport.First(e => e.Id == auctionSessions.First(e => e.Id == highestBid.AuctionSessionId).ReportId);
                    report.TotalRevenue += itemPayment.Revenue;
                }
                orders.Add(order);
            }

            foreach (var item in items.Where(e => e.Status == ItemStatus.PAID || e.Status == ItemStatus.RE_AUCTION_PENDING))
            {
                if (item.HighestBidId == null) continue;
                var highestBid = bids.First(e => e.Id == item.HighestBidId);
                var date = auctionSessions.First(e => e.Id == highestBid.AuctionSessionId).EndDate;
                item.WonDate = date;
            }

            foreach (var auc in endedAuctions)
            {
                var report = auctionSessionsReport.First(e => e.Id == auc.ReportId);
                report.ActiveSellers = items.Where(e => bids.FirstOrDefault(b => b.Id == e.HighestBidId)?.AuctionSessionId == auc.Id).GroupBy(e => e.SellerId).Count();
                report.ActiveBidders = bids.Where(e => e.AuctionSessionId == auc.Id).GroupBy(e => e.UserId).Count();
            }

            /*
             * Due to circular reference between Bid.ItemId and Item.HighestBidId, the migration cannot be created.
             * I settled for the next best thing which was to accept some inconsistencies in our data by setting Iten.HighestBidId to null (Bid.ItemId was more important)
             */
            /*foreach (var i in items)
            {
                i.HighestBidId = null;
            }*/

            modelBuilder.Entity<Role>().HasData(roles);
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<AuctionSession>().HasData(auctionSessions);
            modelBuilder.Entity<AuctionSessionReport>().HasData(auctionSessionsReport);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Image>().HasData(idImages);
            modelBuilder.Entity<SellerApplication>().HasData(sellerApplications);
            modelBuilder.Entity<Image>().HasData(itemImages);
            modelBuilder.Entity<Order>().HasData(orders);
            modelBuilder.Entity<Shipment>().HasData(shipments);
            modelBuilder.Entity<Item>().HasData(items);
            modelBuilder.Entity<StatusChange>().HasData(statusChanges);
            modelBuilder.Entity<ItemProperty>().HasData(itemProperties);
            modelBuilder.Entity("ImageItem").HasData(imageItemsTable);
            modelBuilder.Entity("AuctionSessionItem").HasData(auctionSessionItemTable);
            modelBuilder.Entity<Bid>().HasData(bids);
            modelBuilder.Entity<ItemPayment>().HasData(itemPayments);
        }

        private static T RandomElement<T>(T[] array)
        {
            return array[_random.Next(array.Length)];
        }

        private static T[] RandomElements<T>(T[] array, int count) 
        {
            if (count >= array.Length) return array;

            Dictionary<int, T> res = new();
            for (int i = 0; i < count; i++)
            {
                var index = _random.Next(array.Length);
                while (!res.TryAdd(index, array[index]))
                {
                    index = _random.Next(array.Length);
                }
            }

            return res.Values.ToArray();
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
        private static long CalculateBuyerProtectionFee(long bidAmount)
        {
            return (long)(bidAmount * 0.09);
        }

        private static long CalculateSellerPayment(long bidAmount)
        {
            return (long)(bidAmount * 0.87);
        }

        private static long CalculateExpertPayment(long bidAmount)
        {
            return 20000 + (long)(bidAmount * 0.05);
        }

        private static long CalculateRevenue(long bidAmount)
        {
            return bidAmount + CalculateBuyerProtectionFee(bidAmount) - CalculateSellerPayment(bidAmount) - CalculateExpertPayment(bidAmount);
        }
    }
}
