namespace Vaux.DTO.Out
{
    public class NotificationOutDTO
    {
        public int Id { get; set; }
        public bool Seen { get; set; }
        public string Content { get; set; }
        public string? Redirect { get; set; }
    }
}
