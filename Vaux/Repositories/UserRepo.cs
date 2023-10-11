using Vaux.DbContext;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class UserRepo : IUserRepo
    {
        private VxDbc _vxDbc;

        public UserRepo(VxDbc dbc)
        {
            _vxDbc = dbc;
        }

        public void VerifyAccount(int id)
        {
            var u = _vxDbc.Users.FirstOrDefault(x => x.Id == id);
            u.IsVerified = true;

            _vxDbc.SaveChanges();
        }

        public User Create(string name, string phone)
        {
            var u = new User { Name = name, Phone = phone, RoleId = (int)Models.Enums.Role.BUYER };

            _vxDbc.Users.Add(u);
            _vxDbc.SaveChanges();

            return u;
        }

        public User? Get(string phone)
        {
            return _vxDbc.Users.FirstOrDefault(x => x.Phone == phone);
        }

        public User? Get(int id)
        {
            return _vxDbc.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
