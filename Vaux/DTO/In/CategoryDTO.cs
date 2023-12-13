using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO.In
{
    public class CategoryDTO
    {
        [MaxLength(30)]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string? Description { get; set; }
    }
}
