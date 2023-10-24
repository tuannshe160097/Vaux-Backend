﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Vaux.Models;
using Vaux.ValidationAttributes;

namespace Vaux.DTO
{
    public class SellerApplicationDTO
    {
        public int? UserId { get; set; }
        public string CitizenId { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Gender { get; set; }
        public DateTime DoB { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg"})]
        public IFormFile RawPortrait { get; set; }
        public Image? Portrait { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg",})]
        public IFormFile RawCitizenIdImage { get; set; }
        public Image? CitizenIdImage { get; set; }
    }
}