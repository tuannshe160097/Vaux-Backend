namespace Vaux.Models
{
    public class Shipment : ModelBase
    {
        public int Id { get; set; }
        public int Status { get; set; }

        public long ShipmentCost { get; set; }
        public long ItemCost { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
