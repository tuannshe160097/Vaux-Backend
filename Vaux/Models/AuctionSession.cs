namespace Vaux.Models
{
    public class AuctionSession : ModelBase
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<AuctionSessionItem>? AuctionSessionItems { get; set; }
        public virtual ICollection<Item>? Items { get; set; }
    }
}
