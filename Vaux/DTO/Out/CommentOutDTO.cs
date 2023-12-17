namespace Vaux.DTO.Out
{
    public class CommentOutDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int? UserId { get; set; }
        public DateTime Created { get; set; }
    }
}
