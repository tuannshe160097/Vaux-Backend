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
            portraitImg.Url = Upload(sellerApplication.RawPortrait, "Vaux-portrait");
            citizenidImg.Url = Upload(sellerApplication.RawCitizenIdImage, "Vaux-citizenId");
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
            var s = _sellerApplicationRepo.Get<SellerApplicationDTO>(e => e.Id == id);
            return Ok(s);
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Seller/Application/Get/Image")]
        public IActionResult GetImage(string fileId)
        {
            MemoryStream ms = _photoRepo.DriveDownloadFile(fileId);
            byte[] bytes = ms.ToArray();
            return File(bytes, "image/jpeg");
        }


        private string Upload(IFormFile formFile, string name)
        {
            long length = formFile.Length;
            if (length < 0)
                return "Failed";
            using var filestream = formFile.OpenReadStream();
            byte[] bytes = new byte[length];
            filestream.Read(bytes, 0, (int)length);
            MemoryStream stream = new MemoryStream(bytes);
            return _photoRepo.DriveUpload(stream, name).Result;
        }
    }
}
