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

        public SuperUser CreateAdmin(AdminCreateDTO user)
        {
            var u = _mapper.Map<SuperUser>(user);
            u.RoleId = (int)Models.Enums.Role.ADMIN;

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
    }
}
