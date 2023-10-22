namespace Vaux.Models
{
    public class Notification : ModelBase
    {
        public bool Seen { get; set; }
        public string Content { get; set; }
        public string? Redirect { get; set; }
    }
}
