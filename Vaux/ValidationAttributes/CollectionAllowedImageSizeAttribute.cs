using System.ComponentModel.DataAnnotations;

namespace Vaux.ValidationAttributes
{
    public class CollectionAllowedImageSizeAttribute : AllowedImageSizeAttribute
    {
        public CollectionAllowedImageSizeAttribute(int size) : base(size)
        {
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is not ICollection<IFormFile> files)
            {
                return ValidationResult.Success!;
            }

            foreach (var e in files)
            {
                var res = base.IsValid(e, validationContext);
                if (res != ValidationResult.Success)
                {
                    return res;
                }
            }

            return ValidationResult.Success!;
        }
    }
}
