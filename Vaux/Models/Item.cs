using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;

namespace Vaux.Models
{
    public class Item : ModelBase
    {
        public string Name { get; set; }
        public ItemStatus Status { get; set; }
        public long ReservePrice { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey(nameof(Seller))]
        public int SellerId { get; set; }
        public virtual User Seller { get; set; }


        [ForeignKey(nameof(Expert))]
        public int? ExpertId { get; set; }
        public virtual User? Expert { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ItemProperty>? ItemProperties { get; set; }

        [ForeignKey(nameof(Thumbnail))]
        public int? ThumbnailId { get; set; }
        public virtual Image? Thumbnail { get; set; }

        public virtual ICollection<Image>? Images { get; set;}

        [InverseProperty(nameof(Bid.Item))]
        public virtual ICollection<Bid>? Bids { get; set; }

        public virtual ICollection<Comment>? Comments { get; set; }

        public virtual ICollection<AuctionSessionItem>? AuctionSessionItems { get; set; }
        public virtual ICollection<AuctionSession>? AuctionSessions { get; set; }

        public int? OrderId { get; set; }
        public virtual Order? Order { get; set; }

        public int? ShipmentId { get; set; }
        public virtual Shipment? Shipment { get; set; }

        public virtual ICollection<StatusChange>? StatusChanges { get; set; }
    }
}
