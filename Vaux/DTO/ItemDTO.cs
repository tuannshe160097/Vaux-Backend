using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;
using Vaux.Models;

namespace Vaux.DTO
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ItemStatus Status { get; set; }
        public string StatusString { get; set; }
        public int ReservePrice { get; set; }
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }

        public int SellerId { get; set; }
        public UserMinimalDTO Seller { get; set; }

        public int? ExpertId { get; set; }
        public UserMinimalDTO? Expert { get; set; }

        public string Description { get; set; }

        public List<ItemPropertyDTO>? ItemProperties { get; set; }
    }
}
