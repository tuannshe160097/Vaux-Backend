using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class SellerApplication : ModelBase
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string CitizenId { get; set; }
        public string Content { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Portrait))]
        public int? PortraitId { get; set; }
        public Image? Portrait { get; set; }

        [ForeignKey(nameof(CitizenIdImage))]
        public int? CitizenIdImageId { get; set; }
        public Image? CitizenIdImage { get; set; }

        public virtual ICollection<StatusChange> StatusChanges { get; set; }
    }
}
