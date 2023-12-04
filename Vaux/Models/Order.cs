using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;

namespace Vaux.Models
{
    public class Order : ModelBase
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public OrderStatus Status { get; set; }

        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string? Address { get; set; }

        public long TotalCost { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Shipment> Shipment { get; set; }
    }
}
