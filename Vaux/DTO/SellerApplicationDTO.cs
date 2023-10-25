using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Vaux.Models;
using Vaux.ValidationAttributes;

namespace Vaux.DTO
{
    public class SellerApplicationDTO
    {
        [JsonIgnore]
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
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png"})]
        public IFormFile RawPortrait { get; set; }

        [JsonIgnore]
        public int? PortraitId { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile RawCitizenIdImage { get; set; }

        [JsonIgnore]
        public int? CitizenIdImageId { get; set; }
    }
}
