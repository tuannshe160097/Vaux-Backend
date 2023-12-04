using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class ItemProperty : ModelBase
    {
        public string Label { get; set; }
        public string Value { get; set; }

        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
