using Vaux.ValidationAttributes;
using System.ComponentModel.DataAnnotations;
namespace Vaux.DTO
{
    public class ChatMessageDTO
    {
        public int? SenderId { get; set; }
        public int ItemId { get; set; }
        public string? Content { get; set; }
        public int? ImageId { get; set; }
        [Display(Name = "Image")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        [AllowedImageSize(10)]
        public IFormFile? RawImage { get; set; }

    }
}
