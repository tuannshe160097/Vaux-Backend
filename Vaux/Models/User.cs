using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    using Microsoft.EntityFrameworkCore;

    [Index(nameof(Phone), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class User : ModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? CitizenId { get; set; }
        public string? DeletedReason { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set;}

        [ForeignKey(nameof(FaceImageRef))]
        public int? FaceImage { get; set; }
        public Image? FaceImageRef { get; set; }

        [ForeignKey(nameof(CitizenIdImageRef))]
        public int? CitizenIdImage { get; set; }
        public Image? CitizenIdImageRef { get; set; }

        public virtual ICollection<Notification>? Notifications { get; set; }
        public virtual ICollection<Payment>? Payments { get; set; }
    }
}