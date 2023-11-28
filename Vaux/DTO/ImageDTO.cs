using Vaux.ValidationAttributes;

namespace Vaux.DTO
{
    public class ImageDTO
    {
        [AllowedImageSize(20)]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile Image { get; set; }
    }
}
