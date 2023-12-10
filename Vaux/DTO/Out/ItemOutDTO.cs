using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;
using Vaux.Models;
using Vaux.DTO.In;

namespace Vaux.DTO.Out
{
    public class ItemOutDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ItemStatus Status { get; set; }
        public string StatusString { get; set; }
        public long ReservePrice { get; set; }
        public int CategoryId { get; set; }
        public CategoryOutDTO Category { get; set; }

        public int SellerId { get; set; }
        public UserOutMinimalDTO Seller { get; set; }

        public int? ExpertId { get; set; }
        public UserOutMinimalDTO? Expert { get; set; }

        public string Description { get; set; }

        public List<ItemPropertyDTO>? ItemProperties { get; set; }

        public BidOutDTO? HighestBid { get; set; }

        public AuctionSessionMinimalDTO? OngoingSession { get; set; }
        public ICollection<AuctionSessionMinimalDTO>? AuctionSessions { get; set; }

        public List<int>? Images { get; set; }

        public int? ThumbnailId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime? WonDate { get; set; }
        public DateTime? PaymentDueDate { get; set; }
    }
}
