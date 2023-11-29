using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    using Microsoft.EntityFrameworkCore;

    [Index(nameof(Phone), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class User : ModelBase
    {
        public string Name { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public string Phone { get; set; }
        public string? Gender { get; set; }
        public DateTime? DoB { get; set; }
        public string? OtpHash { get; set; }
        public DateTime? OtpExpiry { get; set; }
        public string? Email { get; set; }
        public string? CitizenId { get; set; }
        public string? DeletedReason { get; set; }

        public bool IsVerified { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set;}

        [ForeignKey(nameof(Portrait))]
        public int? PortraitId { get; set; }
        public virtual Image? Portrait { get; set; }

        [ForeignKey(nameof(CitizenIdImage))]
        public int? CitizenIdImageId { get; set; }
        public virtual Image? CitizenIdImage { get; set; }
        public string? BankAccountNum { get; set; }
        public string? BankCode { get; set; }
        public string? BankName { get; set; }
        public virtual ICollection<Notification>? Notifications { get; set; }
    }
}