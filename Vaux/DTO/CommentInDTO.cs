using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO
{
    public class CommentInDTO
    {
        [MaxLength(256)]
        public string Content { get; set; }
    }
}
