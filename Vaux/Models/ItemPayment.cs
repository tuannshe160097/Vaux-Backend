using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;

namespace Vaux.Models
{
    public class ItemPayment : ModelBase
    {
        public long SellerPayout { get; set; }
        public long ExpertPayout { get; set; }
        public long Revenue { get; set; }

        public PaymentStatus ExpertPaymentStatus { get; set; }
        public PaymentStatus SellerPaymentStatus { get; set; }

        [ForeignKey(nameof(Item))]
        public int? ItemId { get; set; }
        public virtual Item? Item { get; set; }

        public int? ExpertPaymentApprovedById { get; set; }
        public virtual User? ExpertPaymentApprovedBy { get; set; }

        public int? SellerPaymentApprovedById { get; set; }
        public virtual User? SellerPaymentApprovedBy { get; set; }
    }
}
