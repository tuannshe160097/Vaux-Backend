using Vaux.Models.Enums;

namespace Vaux.DTO.Out
{
    public class AuctionSessionMinimalDTO
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public AuctionSessionStatus Status { get; set; }
        public DateTime EndDate { get; set; }

        public int ItemsInAuction { get; set; }
    }
}
