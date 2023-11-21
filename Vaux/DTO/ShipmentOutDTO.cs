using Vaux.Models;
using Vaux.Models.Enums;

namespace Vaux.DTO
{
    public class ShipmentOutDTO
    {
        public ShipmentStatus Status { get; set; }
        public string ShipmentStatusStrinng { get; set; }

        public long ShippingCost { get; set; }
        public long ItemCost { get; set; }

        public ICollection<ItemOutDTO> Items { get; set; }
    }
}
