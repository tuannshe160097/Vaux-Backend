using Vaux.Models.Enums;
using Vaux.Models;

namespace Vaux.DTO.Out
{
    public class OrderOutDTO
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public OrderStatus Status { get; set; }

        public int UserId { get; set; }
        public UserOutMinimalDTO User { get; set; }

        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string Address { get; set; }

        public long TotalCost { get; set; }

        public ICollection<ShipmentOutDTO> Shipment { get; set; }
    }
}
