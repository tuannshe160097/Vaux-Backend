using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IUserRepo
    {
        public User? Get(int id);
        public User? Get(string phone);
        public List<User> GetAll();
        public User Create(string name, string phone);
        public void VerifyAccount(int id);
    }
}
