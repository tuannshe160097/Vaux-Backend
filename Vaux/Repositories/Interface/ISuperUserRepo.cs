using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface ISuperUserRepo
    {
        SuperUser? Get(int id);
        SuperUser? Get(string phone);
        SuperUser CreateModerator(SuperUserDTO user);
        SuperUser Update(int id, SuperUserDTO profile);
        List<SuperUser> GetAll(int pageNum, int pageSize, string? search = null);
        void ChangeAccess(int id);
    }
}
