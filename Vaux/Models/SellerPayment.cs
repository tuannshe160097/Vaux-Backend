namespace Vaux.Models
{
    public class SellerPayment : ModelBase
    {
        public int Id { get; set; }
        public long Amount { get; set; }

        public int ApprovedBy { get; set; }
        public SuperUser SuperUser { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
