using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class SellerApplication
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string CitizenId { get; set; }
        public string Content { get; set; }
        public string? StatusChangeReason { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        [ForeignKey(nameof(StatusChangedByRef))]
        public int? StatusChangedBy { get; set; }
        public SuperUser? StatusChangedByRef { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(FaceImageRef))]
        public int? FaceImage { get; set; }
        public Image? FaceImageRef { get; set; }

        [ForeignKey(nameof(CitizenIdImageRef))]
        public int? CitizenIdImage { get; set; }
        public Image? CitizenIdImageRef { get; set; }
    }
}
