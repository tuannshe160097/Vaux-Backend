using Vaux.ValidationAttributes;

namespace Vaux.DTO
{
    public class ImageDTO
    {
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile Image { get; set; }
    }
}
