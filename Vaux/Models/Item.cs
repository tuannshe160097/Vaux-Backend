using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class Item : ModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int ReservePrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey(nameof(Seller))]
        public int SellerId { get; set; }
        public User Seller { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ItemProperty>? ItemProperties { get; set; }

        [ForeignKey(nameof(Thumbnail))]
        public int? ThumbnailId { get; set; }
        public Image? Thumbnail { get; set; }

        public virtual ICollection<Image>? Images { get; set;}

        [ForeignKey(nameof(HighestBid))]
        public int? HighestBidId { get; set; }
        public Bid? HighestBid { get; set; }

        [InverseProperty(nameof(Bid.Item))]
        public virtual ICollection<Bid>? Bids { get; set; }

        public virtual ICollection<Comment>? Comments { get; set; }

        public virtual ICollection<AuctionSession>? AuctionSessions { get; set; }

        public int? OrderId { get; set; }
        public Order? Order { get; set; }

        public int? ShipmentId { get; set; }
        public Shipment? Shipment { get; set; }

        public virtual ICollection<StatusChange> StatusChanges { get; set; }
    }
}
