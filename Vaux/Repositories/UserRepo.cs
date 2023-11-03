using AutoMapper;
using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;
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
            var u = Create(user);
            u.RoleId = (int)RoleId.BUYER;

            Save();

            return _mapper.Map<TOut>(u);
        }

        public TOut Create<TOut>(UserStrictDTO user, RoleId role)
        {
            var u = Create(user);
            u.RoleId = (int)role;

            Save();

            return _mapper.Map<TOut>(u);
        }

        public TOut Update<TOut, TIn>(Expression<Func<User, bool>> predicate, TIn user, RoleId role)
        {
            var u = Update(predicate, user);
            u.RoleId = (int)role;
            Save();

            return _mapper.Map<TOut>(u);
        }
    }
}
