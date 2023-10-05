namespace Vaux.Models
{
    public class SellerPayment : ModelBase
    {
        public int Id { get; set; }
        public long Amount { get; set; }

        public int ApprovedById { get; set; }
        public SuperUser ApprovedBy { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
