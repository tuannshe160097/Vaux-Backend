using System.ComponentModel.DataAnnotations;
using Vaux.ValidationAttributes;

namespace Vaux.DTO
{
    public class UserWithPhotoDTO
    {
        [MaxLength(40, ErrorMessage = "Tên không thể quá 40 ký tự")]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Address { get; set; }
        public string CitizenId { get; set; }
        public string Gender { get; set; }
        public DateTime DoB { get; set; }
        public string BankAccountNum { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }

        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        [AllowedImageSize(20)]
        public IFormFile RawPortrait { get; set; }

        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        [AllowedImageSize(20)]
        public IFormFile RawCitizenIdImage { get; set; }
    }
}
