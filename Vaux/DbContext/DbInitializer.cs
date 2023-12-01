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

        static string[] ADDRESS = new string[]
        {
            ""
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
