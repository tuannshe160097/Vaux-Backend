using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;
using Vaux.Models;

namespace Vaux.DTO
{
    public class ItemPaymentOutDTO
    {
        public int Id { get; set; }

        public long SellerPayout { get; set; }
        public long ExpertPayout { get; set; }
        public long Revenue { get; set; }

        public PaymentStatus ExpertPaymentStatus { get; set; }
        public PaymentStatus SellerPaymentStatus { get; set; }

        public int? ItemId { get; set; }
        //public ItemOutDTO? Item { get; set; }

        public int? ExpertPaymentApprovedById { get; set; }
        public UserMinimalDTO? ExpertPaymentApprovedBy { get; set; }

        public int? SellerPaymentApprovedById { get; set; }
        public UserMinimalDTO? SellerPaymentApprovedBy { get; set; }
    }
}
