namespace Vaux.Models
{
    public class AuctionSessionItem
    {
        public int Id { get; set; }
        public int AuctionSessionId { get; set; }
        public virtual AuctionSession AuctionSession { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
