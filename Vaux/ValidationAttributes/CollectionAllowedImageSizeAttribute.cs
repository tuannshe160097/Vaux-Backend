using System.ComponentModel.DataAnnotations;

namespace Vaux.ValidationAttributes
{
    public class CollectionAllowedImageSizeAttribute : AllowedImageSizeAttribute
    {
        public CollectionAllowedImageSizeAttribute(int size) : base(size)
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var files = value as ICollection<IFormFile>;

            if (files == null)
            {
                return ValidationResult.Success;
            }

            foreach (var e in files)
            {
                var res = base.IsValid(e, validationContext);
                if (res != ValidationResult.Success)
                {
                    return res;
                }
            }

            return ValidationResult.Success;
        }
    }
}
