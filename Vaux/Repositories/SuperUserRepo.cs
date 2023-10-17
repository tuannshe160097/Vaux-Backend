using AutoMapper;
using System.Numerics;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class SuperUserRepo : ISuperUserRepo
    {
        private VxDbc _vxDbc;
        private IMapper _mapper;

        public SuperUserRepo(VxDbc dbc, IMapper mapper)
        {
            _vxDbc = dbc;
            _mapper = mapper;
        }

        public void ChangeAccess(int id)
        {
            var u = _vxDbc.SuperUsers.FirstOrDefault(x => x.Id == id);

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

        public SuperUser CreateModerator(SuperUserDTO user)
        {
            var u = _mapper.Map<SuperUser>(user);
            u.RoleId = (int)Models.Enums.Role.MODERATOR;

            _vxDbc.SuperUsers.Add(u);
            _vxDbc.SaveChanges();

            return u;
        }

        public SuperUser? Get(int id)
        {
            return _vxDbc.SuperUsers.FirstOrDefault(x => x.Id == id);
        }

        public SuperUser? Get(string phone)
        {
            return _vxDbc.SuperUsers.FirstOrDefault(x => x.Phone == phone);
        }
        public SuperUser Update(int id, SuperUserDTO profile)
        {
            SuperUser u = _vxDbc.SuperUsers.FirstOrDefault(x => x.Id == id);
            _mapper.Map(profile, u);
            _vxDbc.SaveChanges();

            return u;
        }

        public List<SuperUser> GetAll(int pageNum, int pageSize, string? search = null)
        {
            var res = _vxDbc.SuperUsers.AsQueryable();

            if (search != null)
            {
                res = res.Where(x => x.Name.Contains(search) || (x.Email != null && x.Email.Contains(search)) || x.Phone.Contains(search));
            }

            res = res.Skip((pageNum - 1) * pageSize).Take(pageSize);

            return res.ToList();
        }
    }
}
