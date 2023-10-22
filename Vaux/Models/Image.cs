using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class Image : ModelBase
    {
        public string Url { get; set; }
        public string? Note { get; set; }

        [InverseProperty(nameof(Item.Thumbnail))]
        public virtual ICollection<Item>? ItemThumbnails { get; set; }

        public virtual ICollection<Item>? Items { get; set; }
    }
}
