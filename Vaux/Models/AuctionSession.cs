namespace Vaux.Models
{
    public class AuctionSession : ModelBase
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
