namespace Vaux.Models
{
    public class Shipment : ModelBase
    {
        public int Id { get; set; }
        public int Status { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
