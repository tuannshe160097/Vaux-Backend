using Vaux.Models.Enums;

namespace Vaux.Models
{
    public class AuctionSession : ModelBase
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public AuctionSessionStatus Status { get; set; }

        public int? ReportId { get; set; }
        public virtual AuctionSessionReport? Report { get; set; }

        public virtual ICollection<Item>? Items { get; set; }
    }
}
