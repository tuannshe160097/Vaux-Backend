using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;
using Vaux.Models;

namespace Vaux.DTO.Out
{
    public class ItemPaymentOutDTO
    {
        public int Id { get; set; }

        public long SellerPayout { get; set; }
        public long ExpertPayout { get; set; }
        public long Revenue { get; set; }
        public long BuyerProtectionFee { get; set; }
        public long BidAmount { get; set; }

        public PaymentStatus ExpertPaymentStatus { get; set; }
        public PaymentStatus SellerPaymentStatus { get; set; }

        public int? ItemId { get; set; }

        public int? ExpertPaymentApprovedById { get; set; }
        public UserOutMinimalDTO? ExpertPaymentApprovedBy { get; set; }

        public int? SellerPaymentApprovedById { get; set; }
        public UserOutMinimalDTO? SellerPaymentApprovedBy { get; set; }
    }
}
