using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO
{
    public class RegisterDTO
    {
        [MaxLength(40, ErrorMessage = "Tên không thể quá 40 ký tự")]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [MaxLength(10)]
        [RegularExpression(@"^\d+$")]
        [Required(AllowEmptyStrings = false)]
        public string Phone { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ReCaptcha { get; set; }
    }
}
