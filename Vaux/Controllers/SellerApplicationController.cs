using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("/api/Seller/Application")]
    [ApiController]
    public class SellerApplicationController : ControllerBase
    {
        private ISellerApplicationRepo _sellerApplicationRepo;
        private IPhotoRepo _photoRepo;
        private IUserRepo _userRepo;
        private IBaseRepo<Notification> _notificationRepo;

        public SellerApplicationController(ISellerApplicationRepo sellerApplicationRepo, IPhotoRepo photoRepo, IUserRepo userRepo, IBaseRepo<Notification> notificationRepo)
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
            var sa = _sellerApplicationRepo.Get<SellerApplication>(e => e.UserId == int.Parse(User.Identity.Name));
            if (sa != null && sa.Status == SellerApplicationStatus.PENDING)
            {
                return BadRequest("Application already existed");
            }
            sellerApplication.PortraitId = _photoRepo.Create<Image>(sellerApplication.RawPortrait).Id;
            sellerApplication.CitizenIdImageId = _photoRepo.Create<Image>(sellerApplication.RawCitizenIdImage).Id;
            sellerApplication.UserId = int.Parse(User.Identity.Name);
            var result = _sellerApplicationRepo.Create<SellerApplication, SellerApplicationDTO>(sellerApplication);
            return Ok(result);
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/Get/{id}")]
        public IActionResult Get(int id)
        {
            var u = _sellerApplicationRepo.Get<SellerApplication>(e => e.Id == id);
            if (u == null)
            {
                return BadRequest("Application does not exist");
            }
            var s = _sellerApplicationRepo.Get<SellerApplicationOutDTO>(e => e.Id == id);
            return Ok(s);
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/GetByUserId/{id}")]
        public IActionResult GetByUserId(int id)
        {
            var u = _sellerApplicationRepo.Get<SellerApplication>(e => e.UserId == id);
            if (u == null)
            {
                return BadRequest("Application does not exist");
            }
            var s = _sellerApplicationRepo.Get<SellerApplicationOutDTO>(e => e.Id == id);
            return Ok(s);
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/GetAll")]
        public IActionResult GetAll()
        {
            var s = _sellerApplicationRepo.GetAll<SellerApplicationOutDTO>(e => e.Status);
            return Ok(s);
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
                return BadRequest("Unauthorized");
            }
            if(i.PortraitId != imageId && i.CitizenIdImageId != imageId)
            {
                return BadRequest("Unauthorized");
            }
            MemoryStream image = _photoRepo.Get(imageId);
            if (image == null)
            {
                return BadRequest("Image does not exist");
            }
            byte[] bytes = image.ToArray();
            return File(bytes, "image/jpeg");
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/Get/Image/{imageId}")]
        public IActionResult GetImage(int imageId)
        {
            MemoryStream image = _photoRepo.Get(imageId);
            if (image == null)
            {
                return BadRequest("Image does not exist");
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
                return BadRequest("No such pending item");
            }

            i.Status = SellerApplicationStatus.APPROVED;

            _notificationRepo.Create<Notification, Notification>(new Notification()
            {
                UserId = i.UserId,
                Content = $"Đăng ký tài khoản người bán cho \"{i.User.Name}\" đã được phê duyệt"
            });

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
                return BadRequest("No such pending item");
            }

            i.Status = SellerApplicationStatus.DENIED;

            _notificationRepo.Create<Notification, Notification>(new Notification()
            {
                UserId = i.UserId,
                Content = $"Đăng ký tài khoản người bán cho \"{i.User.Name}\" đã bị từ chối"
            });

            return Ok(_sellerApplicationRepo.Update<SellerApplicationOutDTO, SellerApplication>(e => e.Id == i.Id, i, reason));
        }
    }
}
