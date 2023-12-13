using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO
{
    public class ItemPropertyDTO
    {
        [MaxLength(256)]
        [Required(AllowEmptyStrings = false)]
        public string Label { get; set; }

        [MaxLength(256)]
        [Required(AllowEmptyStrings = false)]
        public string Value { get; set; }
    }
}
