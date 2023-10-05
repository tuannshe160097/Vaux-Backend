using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class StatusChange : ModelBase
    {
        public int Id { get; set; }
        public string StatusChangeReason { get; set; }

        [ForeignKey(nameof(StatusChangedBy))]
        public int StatusChangedById { get; set; }
        public SuperUser StatusChangedBy { get; set; }

        public string StatusFrom { get; set; }
        public string StatusTo { get; set; }

        public int? ItemId { get; set; }
        public Item? Item { get; set; }

        public int? SellerApplicationId { get; set; }
        public SellerApplication? SellerApplication { get; set; }
    }
}
