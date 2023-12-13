using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;
using Vaux.Models;
using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO
{
    public class ItemApplicationDTO
    {
        [MaxLength(100)]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }

        [Range(0, int.MaxValue)]
        public long ReservePrice { get; set; }
        public List<ItemPropertyDTO>? ItemProperties { get; set; }
    }
}
