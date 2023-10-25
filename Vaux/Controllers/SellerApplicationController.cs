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

        public SellerApplicationController(ISellerApplicationRepo sellerApplicationRepo, IPhotoRepo photoRepo)
        {
            _sellerApplicationRepo = sellerApplicationRepo;
            _photoRepo = photoRepo;
        }

        [HttpPost]
        [Authorize(Roles = nameof(RoleId.BUYER))]
        [Route("/api/Seller/Application/Create")]
        public IActionResult Create([FromForm] SellerApplicationDTO sellerApplication)
        {
            Image portraitImg = new Image();
            Image citizenidImg = new Image();
            portraitImg.Url = _photoRepo.DriveUpload(sellerApplication.RawPortrait, "Vaux-portrait").Result;
            citizenidImg.Url = _photoRepo.DriveUpload(sellerApplication.RawCitizenIdImage, "Vaux-citizenId").Result;
            sellerApplication.Portrait = portraitImg;
            sellerApplication.CitizenIdImage = citizenidImg;
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
            var s = _sellerApplicationRepo.Get<SellerApplicationDTO>(e => e.Id == id);
            return Ok(s);
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/Get/Image")]
        public IActionResult GetImage(string fileId)
        {
            MemoryStream image = _photoRepo.Get(id);
            if (image == null)
            {
                return BadRequest("Image does not exist");
            }
            byte[] bytes = image.ToArray();
            return File(bytes, "image/jpeg");
        }
    }
}
