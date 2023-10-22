using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;

namespace Vaux.Repositories.Interface
{
    public interface IUserRepo : IBaseRepo<User>
    {
        public TOut Create<TOut>(UserStrictDTO user, RoleId role);
        public void VerifyAccount(int id);
        public void ChangeAccess(int id);
    }
}
