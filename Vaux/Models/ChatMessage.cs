using System.ComponentModel.DataAnnotations.Schema;
namespace Vaux.Models
{
    public class ChatMessage : ModelBase
    {
        [ForeignKey(nameof(Sender))]
        public int? SenderId { get; set; }
        public virtual User? Sender { get; set; }

        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public string Content { get; set; }

        [ForeignKey(nameof(Image))]
        public int? ImageId { get; set; }
        public virtual Image? Image { get; set; }
    }
}
