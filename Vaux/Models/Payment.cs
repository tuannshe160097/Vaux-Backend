namespace Vaux.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public long Amount { get; set; }
        public DateTime Created { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
