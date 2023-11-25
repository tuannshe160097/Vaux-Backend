using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;

namespace Vaux.Models
{
    public class Shipment : ModelBase
    {
        public ShipmentStatus Status { get; set; }

        public long ShippingCost { get; set; }
        public long ItemCost { get; set; }

        [ForeignKey(nameof(Seller))]
        public int? SellerId { get; set; }
        public virtual User? Seller { get; set; }

        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
