﻿namespace Vaux.Models
{
    public class Comment : ModelBase
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int? UserId { get; set; }
        public virtual User? User { get; set; }

        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
