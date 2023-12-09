using System.ComponentModel.DataAnnotations;
using Vaux.Models;

namespace Vaux.DTO
{
    public class OrderPaymentDTO
    {
        [MaxLength(40)]
        public string ReceiverName { get; set; }

        [MaxLength(10)]
        [RegularExpression(@"^\d+$")]
        public string ReceiverPhone { get; set; }

        [MaxLength(256)]
        public string Address { get; set; }
    }
}
