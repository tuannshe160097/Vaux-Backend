namespace Vaux.Models
{
    public class Category : ModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
