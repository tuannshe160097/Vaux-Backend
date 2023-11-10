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

        public SellerApplicationController(ISellerApplicationRepo sellerApplicationRepo, IPhotoRepo photoRepo, IUserRepo userRepo)
        {
            _sellerApplicationRepo = sellerApplicationRepo;
            _photoRepo = photoRepo;
            _userRepo = userRepo;
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
        [Route("/api/Seller/Application/Get")]
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
        [Route("/api/Seller/Application/Get")]
        public IActionResult GetAll(int id)
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
        public IActionResult ApproveApplication(int applicationId)
        {
            var u = _sellerApplicationRepo.Get<SellerApplication>(e => e.Id == applicationId);
            if (u == null || u.Status != SellerApplicationStatus.PENDING)
            {
                return BadRequest("Application does not exist");
            }
            u.Status = SellerApplicationStatus.APPROVED;
            _sellerApplicationRepo.Update<SellerApplication, SellerApplication>(e => e.Id == u.Id, u);
            var result = _userRepo.Update<User, SellerApplication>(e => e.Id == u.UserId, u, RoleId.SELLER);
            return Ok(result);
        }

        [HttpPatch]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/Deny")]
        public IActionResult DenyApplication(int applicationId)
        {
            var u = _sellerApplicationRepo.Get<SellerApplication>(e => e.Id == applicationId);
            if (u == null || u.Status != SellerApplicationStatus.PENDING)
            {
                return BadRequest("Application does not exist");
            }
            u.Status = SellerApplicationStatus.DENIED;
            var result =_sellerApplicationRepo.Update<SellerApplication, SellerApplication>(e => e.Id == u.Id, u);
            return Ok(result);
        }
    }
}
