using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;

namespace Vaux.Models
{
    public class Order : ModelBase
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public OrderStatus Status { get; set; }

        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }

        public long TotalCost { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Shipment> Shipment { get; set; }
    }
}
