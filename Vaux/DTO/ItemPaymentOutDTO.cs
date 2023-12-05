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
        public ItemPaymentStatus Status { get; set; }
        public UserMinimalDTO? ApprovedBy { get; set; }
    }
}
