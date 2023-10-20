using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
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

        public User? GetByEmail(string email)
        {
            return _vxDbc.Users.IgnoreQueryFilters().FirstOrDefault(x => x.Email == email);
        }

        public User? GetByPhone(string phone)
        {
            return _vxDbc.Users.IgnoreQueryFilters().FirstOrDefault(x => x.Phone == phone);
        }

        public User? Get(int id)
        {
            return _vxDbc.Users.IgnoreQueryFilters().IgnoreQueryFilters().FirstOrDefault(x => x.Id == id);
        }

        public User Update(int id, UserMinimalDTO newData)
        {
            User user = _vxDbc.Users.IgnoreQueryFilters().FirstOrDefault(x => x.Id == id);
            _mapper.Map(newData, user);
            _vxDbc.SaveChanges();

            return user;
        }

        public User Update(int id, UserStrictDTO newData)
        {
            User user = _vxDbc.Users.IgnoreQueryFilters().FirstOrDefault(x => x.Id == id);
            _mapper.Map(newData, user);
            _vxDbc.SaveChanges();

            return user;
        }

        public User Update(int id, SellerApplicationDTO newData)
        {
            User user = _vxDbc.Users.IgnoreQueryFilters().FirstOrDefault(x => x.Id == id);
            _mapper.Map(newData, user);
            _vxDbc.SaveChanges();

            return user;
        }

        public List<User> GetAll(int pageNum, int pageSize, string? search = null)
        {
            var res = _vxDbc.Users.IgnoreQueryFilters().AsQueryable();

            if (search != null)
            {
                res = res.Where(x => x.Name.Contains(search) || (x.Email != null && x.Email.Contains(search)) || x.Phone.Contains(search));
            }

            res = res.Skip((pageNum-1) * pageSize).Take(pageSize);

            return res.ToList();
        }

        public void ChangeAccess(int id)
        {
            var u = _vxDbc.Users.IgnoreQueryFilters().FirstOrDefault(x => x.Id == id);

            if (u.Deleted == null)
            {
                u.Deleted = DateTime.Now;
            }
            else
            {
                u.Deleted = null;
            }

            _vxDbc.SaveChanges();
        }

        public User Create(UserMinimalDTO user)
        {
            var u = _mapper.Map<User>(user);
            u.RoleId = (int)RoleId.BUYER;

            _vxDbc.Users.Add(u);
            _vxDbc.SaveChanges();

            return u;
        }

        public User Create(UserStrictDTO user, RoleId role)
        {
            var u = _mapper.Map<User>(user);
            u.RoleId = (int)role;

            _vxDbc.Users.Add(u);
            _vxDbc.SaveChanges();

            return u;
        }
    }
}
