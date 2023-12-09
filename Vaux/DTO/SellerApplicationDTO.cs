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

        [MaxLength(13)]
        [RegularExpression(@"^\d+$")]
        public string CitizenId { get; set; }

        [MaxLength(256)]
        public string Content { get; set; }

        [MaxLength(64)]
        [RegularExpression(@"@")]
        public string Email { get; set; }

        [MaxLength(100)]
        public string? City { get; set; }

        [MaxLength(100)]
        public string? District { get; set; }

        [MaxLength(100)]
        public string? Street { get; set; }

        [MaxLength(100)]
        public string? HouseNumber { get; set; }

        [MaxLength(20)]
        public string Gender { get; set; }
        public DateTime DoB { get; set; }

        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png"})]
        [AllowedImageSize(20)]
        public IFormFile RawPortrait { get; set; }

        [JsonIgnore]
        public int? PortraitId { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        [AllowedImageSize(20)]
        public IFormFile RawCitizenIdImage { get; set; }

        [JsonIgnore]
        public int? CitizenIdImageId { get; set; }

        [MaxLength(20)]
        public string BankAccountNum { get; set; }

        [MaxLength(20)]
        public string BankCode { get; set; }

        [MaxLength(20)]
        public string BankName { get; set; }
    }
}
