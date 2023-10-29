using Vaux.Models;

namespace Vaux.DTO
{
    public class AuctionSessionIFullDTO
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<ItemDTO>? Items { get; set; }
    }
}
