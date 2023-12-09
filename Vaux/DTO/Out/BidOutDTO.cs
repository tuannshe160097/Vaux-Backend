namespace Vaux.DTO.Out
{
    public class BidOutDTO
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public long Amount { get; set; }
        public UserOutMinimalDTO User { get; set; }
    }
}
