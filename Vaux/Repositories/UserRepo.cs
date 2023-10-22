using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Numerics;
using Twilio.TwiML.Voice;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        public UserRepo(VxDbc vxDbc, IMapper mapper) : base(vxDbc, mapper)
        {
            _queryGlobal = _queryGlobal.IgnoreQueryFilters();
        }

        public void VerifyAccount(int id)
        {
            var u = _dbSet.FirstOrDefault(x => x.Id == id);
            u.IsVerified = true;
            Save();
        }

        public void ChangeAccess(int id)
        {
            var u = _queryGlobal.FirstOrDefault(e => e.Id == id);

            if (u.Deleted == null)
            {
                u.Deleted = DateTime.Now;
            }
            else
            {
                u.Deleted = null;
            }

            Save();
        }

        public override TOut Create<TOut, TIn>(TIn user)
        {
            var u = base.Create(user);
            u.RoleId = (int)RoleId.BUYER;

            Save();

            return _mapper.Map<TOut>(u);
        }

        public TOut Create<TOut>(UserStrictDTO user, RoleId role)
        {
            var u = base.Create(user);
            u.RoleId = (int)role;

            Save();

            return _mapper.Map<TOut>(u);
        }
    }
}
