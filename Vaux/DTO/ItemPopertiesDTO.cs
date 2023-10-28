using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;
using Vaux.Models;

namespace Vaux.DTO
{
    public class ItemPropertiesDTO
    {
        public List<ItemPropertyDTO>? ItemProperties { get; set; }
    }
}
