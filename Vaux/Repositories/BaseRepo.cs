using AutoMapper;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Security.Claims;
using Twilio.TwiML.Voice;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Vaux.Repositories
{
    public class BaseRepo<TEntity> : IBaseRepo<TEntity> where TEntity : ModelBase
    {
        protected VxDbc _vxDbc;
        protected DbSet<TEntity> _dbSet;
        protected IMapper _mapper;
        protected IQueryable<TEntity> _queryGlobal;
        protected readonly IHttpContextAccessor? _httpContextAccessor;
        protected readonly ClaimsPrincipal? _user;

        public BaseRepo(VxDbc vxDbc, IMapper mapper)
        {
            _vxDbc = vxDbc;
            _mapper = mapper;
            _dbSet = vxDbc.Set<TEntity>();
            _queryGlobal = _dbSet.AsQueryable();
            _httpContextAccessor = null;
            _user = null;
        }

        public BaseRepo(VxDbc vxDbc, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _vxDbc = vxDbc;
            _mapper = mapper;
            _dbSet = vxDbc.Set<TEntity>();
            _queryGlobal = _dbSet.AsQueryable();
            _httpContextAccessor = httpContextAccessor;
            _user = _httpContextAccessor.HttpContext?.User;
        }

        public virtual TOut? Get<TOut>(Expression<Func<TEntity, bool>> predicate)
        {
            var res = _queryGlobal.FirstOrDefault(predicate);

            return _mapper.Map<TOut>(res);
        }

        public virtual ResultListDTO<TOut> GetAll<TOut>(Expression<Func<TEntity, object>>? orderBy)
        {
            return GetAll<TOut>(null, orderBy);
        }

        public virtual ResultListDTO<TOut> GetAll<TOut>(Expression<Func<TEntity, object>>? orderBy, int skip, int take)
        {
            return GetAll<TOut>(null, orderBy, skip, take);
        }

        public virtual ResultListDTO<TOut> GetAll<TOut>(
            Expression<Func<TEntity, bool>>? predicate = null,
            Expression<Func<TEntity, object>>? orderBy = null,
            int skip = 0,
            int take = -1)
        {
            var query = _queryGlobal;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                query = query.OrderBy(orderBy);
            }

            return WrapListResult<TOut>(query, skip, take);
        }

        public ResultListDTO<TOut> Search<TOut>(string[]? filterEntities, string[]? filterValues, string orderBy = "Id", int skip = 0, int take = -1)
        {
            filterEntities = filterEntities ?? new string[0];
            filterValues = filterValues ?? new string[0];
            var query = _queryGlobal;

            for (int i = 0; i < filterEntities.Length; i++)
            {
                var colName = filterEntities[i];
                var colValue = filterValues[i];
                if (typeof(TEntity).GetProperty(colName) == null) continue;
                query = query.Where(e => colValue.Contains(EF.Property<object>(e, colName)!.ToString()!));
            }

            if (typeof(TEntity).GetProperty(orderBy) != null)
            {
                query = query.OrderBy(e => EF.Property<object>(e, orderBy)).ThenBy(e => e.Id);
            }
            else
            {
                query = query.OrderBy(e => e.Id);
            }

            return WrapListResult<TOut>(query, skip, take);
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

        public virtual TOut DeletePerma<TOut>(Expression<Func<TEntity, bool>> predicate)
        {
            var e = DeletePerma(predicate);

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

        protected virtual TEntity DeletePerma(Expression<Func<TEntity, bool>> predicate)
        {
            var e = _queryGlobal.FirstOrDefault(predicate);
            _dbSet.Remove(e);

            return e;
        }

        protected virtual void Save()
        {
            _vxDbc.SaveChanges();
        }

        public ResultListDTO<TOut> WrapListResult<TOut>(IQueryable<TEntity> query, int skip = 0, int take = -1)
        {
            var result = new ResultListDTO<TOut>();

            result.TotalRecords = query.Count();

            query = query.OrderBy(e => e.Id);

            query = query.Skip(skip < 0 ? 0 : skip);
            if (take > 0)
            {
                query = query.Take(take);
            }

            result.Records = _mapper.Map<List<TOut>>(query.ToList());
            result.RecordsTaken = result.Records.Count;
            result.RecordsSkipped = skip;

            return result;
        }

        public virtual IQueryable<TEntity> Query()
        {
            return _queryGlobal;
        }

        public TOut Map<TOut, TIn>(TIn data)
        {
            return _mapper.Map<TOut>(data);
        }

        public TOut Map<TOut>(TEntity data)
        {
            return _mapper.Map<TOut>(data);
        }

        public TEntity Map<TIn>(TIn data)
        {
            return _mapper.Map<TEntity>(data);
        }

        public void Reload(TEntity entity)
        {
            _dbSet.Entry(entity).Reload();
        }
    }
}
