namespace Vaux.Models
{
    public class Category : ModelBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Item>? Items { get; set; }
    }
}
