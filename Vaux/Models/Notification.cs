using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class Notification : ModelBase
    {
        public bool Seen { get; set; }
        public string Content { get; set; }
        public string? Redirect { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
