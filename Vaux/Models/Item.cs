using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class Item : ModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey(nameof(Seller))]
        public int SellerId { get; set; }
        public User Seller { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ItemProperty>? ItemProperties { get; set; }

        [ForeignKey(nameof(ThumbnailRef))]
        public int? Thumbnail { get; set; }
        public Image? ThumbnailRef { get; set; }

        public virtual ICollection<Image>? Images { get; set;}

        [ForeignKey(nameof(HighestBidRef))]
        public int? HighestBid { get; set; }
        public Bid? HighestBidRef { get; set; }

        [InverseProperty(nameof(Bid.Item))]
        public virtual ICollection<Bid>? Bids { get; set; }

        public virtual ICollection<Comment>? Comments { get; set; }
    }
}
