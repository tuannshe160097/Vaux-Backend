namespace Vaux.Models
{
    public class Order : ModelBase
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }

        public long Amount { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Shipment> Shipment { get; set; }
    }
}
