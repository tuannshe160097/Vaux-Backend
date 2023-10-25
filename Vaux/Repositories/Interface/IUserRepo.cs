using System.Linq.Expressions;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;

namespace Vaux.Repositories.Interface
{
    public interface IUserRepo : IBaseRepo<User>
    {
        public TOut Create<TOut>(UserStrictDTO user, RoleId role);
        public TOut Update<TOut, TIn>(Expression<Func<User, bool>> predicate, TIn user, RoleId role);
        public void VerifyAccount(int id);
        public void ChangeAccess(int id);

    }
}
