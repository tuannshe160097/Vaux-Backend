using Vaux.Models;

namespace Vaux.DTO
{
    public class OrderOutDTO
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

        public int UserId { get; set; }
        public UserMinimalDTO User { get; set; }

        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }

        public long TotalCost { get; set; }

        public ICollection<ShipmentOutDTO> Shipment { get; set; }
    }
}
