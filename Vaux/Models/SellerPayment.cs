﻿namespace Vaux.Models
{
    public class SellerPayment : ModelBase
    {
        public int Id { get; set; }
        public long Amount { get; set; }
        public int Status { get; set; }

        public int? OrderId { get; set; }
        public virtual Order? Order { get; set; }

        public int? ApprovedById { get; set; }
        public virtual SuperUser? ApprovedBy { get; set; }

        public int? UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
