﻿using System.ComponentModel.DataAnnotations;

namespace Vaux.ValidationAttributes
{
    public class AllowedImageSizeAttribute : ValidationAttribute
    {
        private readonly int _size;

        public AllowedImageSizeAttribute(int size)
        {
            _size = size;
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is not IFormFile file)
            {
                return ValidationResult.Success!;
            }
            var size = file.Length;
            if (size > _size * 1024 * 1024)
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success!;
        }

        public string GetErrorMessage()
        {
            return $"Your image's filetype is not valid.";
        }
    }
}
