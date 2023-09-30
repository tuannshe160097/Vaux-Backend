namespace Vaux.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public bool Seen { get; set; }
        public string Content { get; set; }
        public string? Redirect { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
