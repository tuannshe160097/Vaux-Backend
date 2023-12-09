using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO
{
    public class UserMinimalNonOptionalDTO
    {
        [MaxLength(40, ErrorMessage = "Tên không thể quá 40 ký tự")]
        public string Name { get; set; }

        [MaxLength(10)]
        [RegularExpression(@"^\d+$")]
        public string Phone { get; set; }
    }
}
