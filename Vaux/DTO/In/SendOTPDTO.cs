using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO.In
{
    public class SendOTPDTO
    {
        [MaxLength(10)]
        [RegularExpression(@"^\d+$")]
        [Required(AllowEmptyStrings = false)]
        public string Phone {  get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ReCaptcha { get; set; }
    }
}
