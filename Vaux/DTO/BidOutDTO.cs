namespace Vaux.DTO
{
    public class BidOutDTO
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public long Amount { get; set; }
        public UserMinimalDTO User { get; set; }
    }
}
