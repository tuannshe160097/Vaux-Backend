using Vaux.Models;

namespace Vaux.DTO.Out
{
    public class AuthorizationDTO
    {
        public string JWT { get; set; }
        public UserOutMinimalDTO User { get; set; }
        public Role Role { get; set; }
    }
}
