namespace Vaux.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
