using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public long Amount { get; set; }

        public int? ItemId { get; set; }
        public Item? Item { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
