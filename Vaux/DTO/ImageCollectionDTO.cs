using Vaux.ValidationAttributes;

namespace Vaux.DTO
{
    public class ImageCollectionDTO
    {
        [CollectionAllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        [CollectionAllowedImageSize(10)]
        public List<IFormFile> Images { get; set; }
    }
}
