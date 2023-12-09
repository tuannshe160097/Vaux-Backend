namespace Vaux.DTO.Out
{
    public class ChatMessageOutDTO
    {
        public int SenderId { get; set; }
        public string Sender { get; set; }
        public string Content { get; set; }
        public int ImageId { get; set; }
        public DateTime Created { get; set; }

    }
}
