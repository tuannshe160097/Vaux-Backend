﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Vaux.DTO;
using Vaux.DTO.Out;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("/api/Seller/Application")]
    [ApiController]
    public class SellerApplicationController : ControllerBase
    {
        private readonly ISellerApplicationRepo _sellerApplicationRepo;
        private readonly IPhotoRepo _photoRepo;
        private readonly IUserRepo _userRepo;
        private readonly INotificationRepo _notificationRepo;

        public SellerApplicationController(ISellerApplicationRepo sellerApplicationRepo, IPhotoRepo photoRepo, IUserRepo userRepo, INotificationRepo notificationRepo)
        {
            _sellerApplicationRepo = sellerApplicationRepo;
            _photoRepo = photoRepo;
            _userRepo = userRepo;
            _notificationRepo = notificationRepo;
        }

        [HttpPost]
        [Authorize(Roles = nameof(RoleId.BUYER))]
        [Route("/api/Seller/Application/Create")]
        public IActionResult Create([FromForm] SellerApplicationDTO sellerApplication)
        {
            var sa = _sellerApplicationRepo.Get<SellerApplication>(e => e.UserId == int.Parse(User.Identity!.Name!));
            if (sa != null && sa.Status == SellerApplicationStatus.PENDING)
            {
                return BadRequest("Đơn đăng ký đã tồn tại!");
            }
            var sam = _userRepo.Get<User>(e => e.Email == sellerApplication.Email && e.Id.ToString() != User.Identity!.Name);
            if(sam != null)
            {
                return BadRequest("Email đã được sử dụng!");
            }
            sellerApplication.PortraitId = _photoRepo.Create<Image>(sellerApplication.RawPortrait).Id;
            sellerApplication.CitizenIdImageId = _photoRepo.Create<Image>(sellerApplication.RawCitizenIdImage).Id;
            sellerApplication.UserId = int.Parse(User.Identity!.Name!);
            var result = _sellerApplicationRepo.Create<SellerApplication, SellerApplicationDTO>(sellerApplication);
            return Ok(result);
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/Get/{id}")]
        public IActionResult Get(int id)
        {
            var u = _sellerApplicationRepo.Get<SellerApplicationOutDTO>(e => e.Id == id);
            if (u == null)
            {
                return BadRequest("Đơn đăng ký không tồn tại!");
            }
            return Ok(u);
        }

        [HttpGet]
        [Authorize]
        [Route("/api/Seller/Application/GetByUserId/{id}")]
        public IActionResult GetByUserId(int id)
        {
            var u = _sellerApplicationRepo.Get<SellerApplicationOutDTO>(e => e.UserId == id && e.Status == SellerApplicationStatus.PENDING);
            return Ok(u);
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/GetAll")]
        public IActionResult GetAll(int pageNum = 1, int pageSize = -1, string? search = null, int? status = null)
        {
            var query = _sellerApplicationRepo.Query();
            if (search != null)
            {
                query = query.Where(e => e.User.Email.Contains(search) || e.User.Name.Contains(search) || e.User.Phone.Contains(search));
            }
            if (status != null)
            {
                query = query.Where(e => (int)e.Status == status);
            }
            query = query.OrderBy(e => e.Status).ThenByDescending(e => e.Id);
            return Ok(_sellerApplicationRepo.WrapListResult<SellerApplicationOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/Get/Image")]
        public IActionResult GetImage()
        {
            var s = _sellerApplicationRepo.GetAll<SellerApplicationOutDTO>(e => e.Status);
            return Ok(s);
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.SELLER)}")]
        [Route("/api/Seller/Application/Get/{id}/Image/{imageId}")]
        public IActionResult GetImage(int id, int imageId)
        {
            var i = _sellerApplicationRepo.Get<SellerApplication>(e => e.Id == id);
            if (i?.UserId.ToString() != User.Identity.Name)
            {
                return BadRequest("Tài khoản không hợp lệ!");
            }
            if(i.PortraitId != imageId && i.CitizenIdImageId != imageId)
            {
                return BadRequest("Tài khoản không hợp lệ!");
            }
            MemoryStream? image = _photoRepo.Get(imageId);
            if (image == null)
            {
                return BadRequest("Ảnh không tồn tại!");
            }
            byte[] bytes = image.ToArray();
            return File(bytes, "image/jpeg");
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/Get/Image/{imageId}")]
        public IActionResult GetImage(int imageId)
        {
            MemoryStream? image = _photoRepo.Get(imageId);
            if (image == null)
            {
                return BadRequest("Ảnh không tồn tại!");
            }
            byte[] bytes = image.ToArray();
            return File(bytes, "image/jpeg");
        }

        [HttpPatch]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/Approve")]
        public IActionResult ApproveApplication(int applicationId, [FromBody] string reason)
        {
            var i = _sellerApplicationRepo.Get<SellerApplication>(e => e.Id == applicationId);
            if (i == null || i.Status != SellerApplicationStatus.PENDING)
            {
                return BadRequest("Đơn đăng ký không tồn tại!");
            }
            var sam = _userRepo.Get<User>(e => e.Email == i.Email && e.Id != i.UserId);
            if (sam != null)
            {
                return BadRequest("Email đã được sử dụng!");
            }
            i.Status = SellerApplicationStatus.APPROVED;

            _notificationRepo.Create<Notification>(e => e.Id == i.UserId, $"Đăng ký tài khoản người bán cho \"{i.User.Name}\" đã được phê duyệt");

            _userRepo.Update<User, SellerApplication>(e => e.Id == i.UserId, i, RoleId.SELLER);
            return Ok(_sellerApplicationRepo.Update<SellerApplicationOutDTO, SellerApplication>(e => e.Id == i.Id, i, reason));
        }

        [HttpPatch]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/Deny")]
        public IActionResult DenyApplication(int applicationId, [FromBody] string reason)
        {
            var i = _sellerApplicationRepo.Get<SellerApplication>(e => e.Id == applicationId);
            if (i == null || i.Status != SellerApplicationStatus.PENDING)
            {
                return BadRequest("Đơn đăng ký không tồn tại!");
            }

            i.Status = SellerApplicationStatus.DENIED;


            _notificationRepo.Create<Notification>(e => e.Id == i.UserId, $"Đăng ký tài khoản người bán cho \"{i.User.Name}\" đã bị từ chối");

            return Ok(_sellerApplicationRepo.Update<SellerApplicationOutDTO, SellerApplication>(e => e.Id == i.Id, i, reason));
        }
    }
}
