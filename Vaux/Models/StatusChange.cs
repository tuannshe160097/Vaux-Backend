using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class StatusChange : ModelBase
    {
        public string StatusChangeReason { get; set; }

        [ForeignKey(nameof(StatusChangedBy))]
        public int StatusChangedById { get; set; }
        public virtual User StatusChangedBy { get; set; }

        public string StatusFrom { get; set; }
        public string StatusTo { get; set; }

        public int? ItemId { get; set; }
        public virtual Item? Item { get; set; }

        public int? SellerApplicationId { get; set; }
        public virtual SellerApplication? SellerApplication { get; set; }
    }
}
