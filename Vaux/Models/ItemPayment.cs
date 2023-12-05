using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;

namespace Vaux.Models
{
    public class ItemPayment : ModelBase
    {
        public long SellerPayout { get; set; }
        public long ExpertPayout { get; set; }
        public long Revenue { get; set; }

        public ItemPaymentStatus Status { get; set; }

        [ForeignKey(nameof(Item))]
        public int? ItemId { get; set; }
        public virtual Item? Item { get; set; }

        public int? ApprovedById { get; set; }
        public virtual User? ApprovedBy { get; set; }
    }
}
