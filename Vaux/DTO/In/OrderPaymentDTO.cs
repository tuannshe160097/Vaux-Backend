using System.ComponentModel.DataAnnotations;
using Vaux.Models;

namespace Vaux.DTO
{
    public class OrderPaymentDTO
    {
        [MaxLength(40)]
        [Required(AllowEmptyStrings = false)]
        public string ReceiverName { get; set; }

        [MaxLength(10)]
        [RegularExpression(@"^\d+$")]
        [Required(AllowEmptyStrings = false)]
        public string ReceiverPhone { get; set; }

        [MaxLength(256)]
        [Required(AllowEmptyStrings = false)]
        public string Address { get; set; }
    }
}
