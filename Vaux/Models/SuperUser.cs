using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    using Microsoft.EntityFrameworkCore;

    [Index(nameof(Phone), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class SuperUser : ModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CitizenId { get; set; }

        public string? OtpHash { get; set; }
        public DateTime? OtpExpiry { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        [ForeignKey(nameof(Portrait))]
        public int? PortraitId { get; set; }
        public virtual Image? Portrait { get; set; }

        [ForeignKey(nameof(CitizenIdImage))]
        public int? CitizenIdImageId { get; set; }
        public virtual Image? CitizenIdImage { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
