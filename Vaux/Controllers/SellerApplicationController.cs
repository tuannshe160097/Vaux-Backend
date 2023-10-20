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
    [Authorize]
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
        public IActionResult Create(SellerApplicationDTO application)
        {
            return Ok("I hate niggas");
        }
    }
}
