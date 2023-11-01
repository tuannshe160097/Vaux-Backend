using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
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

        public ResultListDTO<TOut> Search<TOut>(string? search, int? role, int skip = 0, int take = -1)
        {
            var result = new ResultListDTO<TOut>();
            var query = _queryGlobal;

            if (search != null && search != string.Empty)
            {
                query = query.Where(e => (e.Email != null && e.Email.Contains(search)) || e.Phone.Contains(search) || e.Name.Contains(search));
            }

            if (role != null)
            {
                query = query.Where(e => e.RoleId == role);
            }
            
            query = query.OrderBy(e => e.Id);

            result.TotalRecords = query.Count();

            query = query.Skip(skip);
            if (take > 0)
            {
                query = query.Take(take);
            }

            result.Records = _mapper.Map<List<TOut>>(query.ToList());
            result.RecordsTaken = result.Records.Count;
            result.RecordsSkipped = skip;

            return result;
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

        public TOut Update<TOut, TIn>(Expression<Func<User, bool>> predicate, TIn user, RoleId role)
        {
            var u = base.Update(predicate, user);
            u.RoleId = (int)role;
            Save();

            return _mapper.Map<TOut>(u);
        }
        
        protected override User Create<TIn>(TIn data)
        {
            var newUser = _mapper.Map<User>(data);
            var user = _dbSet.FirstOrDefault(e => e.Phone == newUser.Phone);
            if (user != null)
            {
                _mapper.Map(newUser, user);
            }
            else
            {
                _dbSet.Add(newUser);
                user = newUser;
            }

            return user;
        }
    }
}
