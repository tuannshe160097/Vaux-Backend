using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO
{
    public class ItemPropertyDTO
    {
        [MaxLength(256)]
        public string Label { get; set; }

        [MaxLength(256)]
        public string Value { get; set; }
    }
}
