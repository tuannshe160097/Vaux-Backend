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
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public string Phone { get; set; }
        public string? OtpHash { get; set; }
        public string? Email { get; set; }
        public string? CitizenId { get; set; }
        public string? DeletedReason { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set;}

        [ForeignKey(nameof(Portrait))]
        public int? PortraitId { get; set; }
        public Image? Portrait { get; set; }

        [ForeignKey(nameof(CitizenIdImage))]
        public int? CitizenIdImageId { get; set; }
        public Image? CitizenIdImage { get; set; }

        public virtual ICollection<Notification>? Notifications { get; set; }
    }
}