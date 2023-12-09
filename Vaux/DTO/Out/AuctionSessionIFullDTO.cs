using Vaux.Models;
using Vaux.Models.Enums;

namespace Vaux.DTO.Out
{
    public class AuctionSessionIFullDTO
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public AuctionSessionStatus Status { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<ItemOutDTO>? Items { get; set; }
    }
}
