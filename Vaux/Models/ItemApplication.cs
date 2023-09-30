using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class ItemApplication : ModelBase
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? StatusChangeReason { get; set; }

        [ForeignKey(nameof(User))]
        public int? SellerId { get; set; }
        public User? User { get; set; }

        [ForeignKey(nameof(StatusChangedByRef))]
        public int? StatusChangedBy { get; set; }
        public SuperUser? StatusChangedByRef { get; set; }

        public virtual ICollection<Image>? Images { get; set;}
    }
}
