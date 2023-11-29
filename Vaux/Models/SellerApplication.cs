using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models.Enums;

namespace Vaux.Models
{
    public class SellerApplication : ModelBase
    {
        public SellerApplicationStatus Status { get; set; }
        public string CitizenId { get; set; }
        public string Content { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime DoB { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey(nameof(Portrait))]
        public int? PortraitId { get; set; }
        public virtual Image? Portrait { get; set; }

        [ForeignKey(nameof(CitizenIdImage))]
        public int? CitizenIdImageId { get; set; }
        public virtual Image? CitizenIdImage { get; set; }
        public string BankAccountNum { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public virtual ICollection<StatusChange> StatusChanges { get; set; }
    }
}
