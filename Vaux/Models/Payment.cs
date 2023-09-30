namespace Vaux.Models
{
    public class Payment : ModelBase
    {
        public int Id { get; set; }
        public long Amount { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
