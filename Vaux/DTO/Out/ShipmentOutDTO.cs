using Vaux.Models;
using Vaux.Models.Enums;

namespace Vaux.DTO.Out
{
    public class ShipmentOutDTO
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

        public ShipmentStatus Status { get; set; }
        public string ShipmentStatusStrinng { get; set; }

        public string? Address { get; set; }

        public long ShippingCost { get; set; }
        public long ItemCost { get; set; }
        public long BuyerProtectionFee { get; set; }

        public UserOutMinimalDTO? Seller { get; set; }

        public ICollection<ItemOutDTO> Items { get; set; }
    }
}
