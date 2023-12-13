using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO.In
{
    public class VerifyOTPDTO
    {
        [MaxLength(10)]
        [RegularExpression(@"^\d+$")]
        [Required(AllowEmptyStrings = false)]
        public string Phone { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Otp { get; set; }
    }
}
