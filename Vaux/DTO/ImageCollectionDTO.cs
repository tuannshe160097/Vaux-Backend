using Vaux.ValidationAttributes;

namespace Vaux.DTO
{
    public class ImageCollectionDTO
    {
        [CollectionAllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        [CollectionAllowedImageSize(20)]
        public List<IFormFile> Images { get; set; }
    }
}
