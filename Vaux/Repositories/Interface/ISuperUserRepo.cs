using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface ISuperUserRepo
    {
        public SuperUser? Get(int id);
        public SuperUser? Get(string phone);
        public SuperUser CreateAdmin(AdminCreateDTO user);
    }
}
