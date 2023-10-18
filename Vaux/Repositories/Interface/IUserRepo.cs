using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IUserRepo
    {
        public User? Get(int id);
        public User? GetByPhone(string phone);
        public User? GetByEmail(string email);
        public List<User> GetAll(int page, int ipp, string? search = null);
        public User Create(UserMinimalDTO user);
        public User Create(UserStrictDTO user, Models.Enums.Role role);
        public void VerifyAccount(int id);
        public void ChangeAccess(int id);
        public User Update(int id, UserMinimalDTO newData);
        public User Update(int id, UserStrictDTO newData);
    }
}
