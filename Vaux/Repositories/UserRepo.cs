using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class UserRepo : IUserRepo
    {
        private VxDbc _vxDbc;
        private IMapper _mapper;

        public UserRepo(VxDbc dbc, IMapper mapper)
        {
            _vxDbc = dbc;
            _mapper = mapper;
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

        public void UpdateProfile(int id ,ProfileUpdateDTO profileUpdate)
        {
            User user = _vxDbc.Users.FirstOrDefault(x => x.Id == id);
            _mapper.Map(profileUpdate, user);
            _vxDbc.SaveChanges();
        }

        public List<User> GetAll(int pageNum, int pageSize, string? search = null)
        {
            return _vxDbc.Users.ToList();
        }
    }
}
