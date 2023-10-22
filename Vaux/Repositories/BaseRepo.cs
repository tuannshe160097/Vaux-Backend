using AutoMapper;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class BaseRepo<TEntity> : IBaseRepo<TEntity> where TEntity : ModelBase
    {
        protected VxDbc _vxDbc;
        protected DbSet<TEntity> _dbSet;
        protected IMapper _mapper;
        protected IQueryable<TEntity> _queryGlobal;

        public BaseRepo(VxDbc vxDbc, IMapper mapper)
        {
            _vxDbc = vxDbc;
            _mapper = mapper;
            _dbSet = vxDbc.Set<TEntity>();
            _queryGlobal = _dbSet.AsQueryable();
        }

        public virtual TOut? Get<TOut>(Expression<Func<TEntity, bool>> predicate)
        {
            var res = _queryGlobal.FirstOrDefault(predicate);

            return _mapper.Map<TOut>(res);
        }

        public virtual List<TOut> GetAll<TOut>(int skip = 0, int take = -1)
        {
            var res = _queryGlobal.Skip(skip);
            if (take  > 0)
            {
                res = res.Take(take);
            }

            return _mapper.Map<List<TOut>>(res);
        }

        public virtual List<TOut> GetAll<TOut>(
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, object>>? orderBy = null,
            int skip = 0,
            int take = -1)
        {
            var res = _queryGlobal.Where(predicate);

            if (orderBy != null)
            {
                res = res.OrderBy(orderBy);
            }

            res = res.Skip(skip);
            if (take > 0)
            {
                res = res.Take(take);
            }

            return _mapper.Map<List<TOut>>(res);
        }

        public virtual TOut Create<TOut, TIn>(TIn data)
        {
            var e = Create(data);
            Save();

            return _mapper.Map<TOut>(e);
        }

        public virtual TOut Update<TOut, TIn>(Expression<Func<TEntity, bool>> predicate, TIn data)
        {
            var e = Update(predicate, data);
            Save();

            return _mapper.Map<TOut>(e);
        }

        public virtual TOut Delete<TOut>(Expression<Func<TEntity, bool>> predicate)
        {
            var e = Delete(predicate);

            Save();

            return _mapper.Map<TOut>(e);
        }

        protected virtual TEntity Create<TIn>(TIn data)
        {
            var e = _mapper.Map<TEntity>(data);
            _dbSet.Add(e);

            return e;
        }

        protected virtual TEntity Update<TIn>(Expression<Func<TEntity, bool>> predicate, TIn data)
        {
            var e = _queryGlobal.FirstOrDefault(predicate);
            _mapper.Map(data, e);

            return e;
        }

        protected virtual TEntity Delete(Expression<Func<TEntity, bool>> predicate)
        {
            var e = _queryGlobal.FirstOrDefault(predicate);
            e.Deleted = DateTime.Now;

            return e;
        }

        protected virtual void Save()
        {
            _vxDbc.SaveChanges();
        }

        /*protected virtual TOut Map<TOut>(object data)
        {
            return _mapper.Map<TOut>(data);
        }*/
    }
}
