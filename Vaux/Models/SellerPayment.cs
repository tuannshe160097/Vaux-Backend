using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;

namespace Vaux.Models
{
    public class SellerPayment : ModelBase
    {
        public long Amount { get; set; }
        public SellerPaymentStatus Status { get; set; }

        [ForeignKey(nameof(Item))]
        public int? ItemId { get; set; }
        public virtual Item? Item { get; set; }

        public int? ApprovedById { get; set; }
        public virtual User? ApprovedBy { get; set; }
    }
}
