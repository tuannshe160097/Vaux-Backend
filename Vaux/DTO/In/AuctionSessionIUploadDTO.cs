using Vaux.Models;

namespace Vaux.DTO.In
{
    public class AuctionSessionUploadDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<int> ItemIds { get; set; }
    }
}
