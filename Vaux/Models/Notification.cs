namespace Vaux.Models
{
    public class Notification : ModelBase
    {
        public int Id { get; set; }
        public bool Seen { get; set; }
        public string Content { get; set; }
        public string? Redirect { get; set; }
    }
}
