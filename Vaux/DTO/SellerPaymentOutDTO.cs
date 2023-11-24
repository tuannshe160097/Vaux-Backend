using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;
using Vaux.Models;

namespace Vaux.DTO
{
    public class SellerPaymentOutDTO
    {
        public int Id { get; set; }
        public long Amount { get; set; }
        public SellerPaymentStatus Status { get; set; }
        public UserMinimalDTO? ApprovedBy { get; set; }
    }
}
