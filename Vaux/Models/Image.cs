using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string? Note { get; set; }

        [InverseProperty(nameof(Item.ThumbnailRef))]
        public virtual ICollection<Item>? ItemThumbnailRef { get; set; }

        public virtual ICollection<Item>? Items { get; set; }
        public virtual ICollection<ItemApplication>? ItemApplications { get; set; }
    }
}
