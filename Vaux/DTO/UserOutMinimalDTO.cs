using Vaux.Models;

namespace Vaux.DTO
{
    public class UserOutMinimalDTO 
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime? Deleted { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
