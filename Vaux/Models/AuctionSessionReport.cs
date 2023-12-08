namespace Vaux.Models
{
    public class AuctionSessionReport : ModelBase
    {
        public int AuctionedItems { get; set; }
        public int UnauctionedItems { get; set; }
        public int SoldItems { get; set; }
        public int UnpaidItems { get; set; }
        public long TotalRevenue { get; set; }
        public int ActiveBidders { get; set; }
        public int ActiveSellers { get; set; }
        public int ActiveItems { get; set; }
        public int ActiveBids { get; set; }
    }
}
