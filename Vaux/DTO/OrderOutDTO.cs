using Vaux.Migrations;
using Vaux.Models;

namespace Vaux.DTO
{
    public class OrderOutDTO
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public OrderStatus Status { get; set; }

        public int UserId { get; set; }
        public UserMinimalDTO User { get; set; }

        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string Address { get; set; }

        public long TotalCost { get; set; }

        public ICollection<ShipmentOutDTO> Shipment { get; set; }
    }
}
