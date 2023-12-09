using Vaux.Models;

namespace Vaux.DTO
{
    public class AuthorizationDTO
    {
        public string JWT { get; set; }
        public UserOutDTO User { get; set; }
        public Role Role { get; set; }
    }
}
