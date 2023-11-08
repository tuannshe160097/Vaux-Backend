using Microsoft.AspNetCore.Mvc.Formatters;
using System.Linq.Expressions;
using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IBaseRepo<TEntity> where TEntity : ModelBase
    {
        public TOut? Get<TOut>(Expression<Func<TEntity, bool>> predicate);
        public ResultListDTO<TOut> GetAll<TOut>(Expression<Func<TEntity, object>>? orderBy);
        public ResultListDTO<TOut> GetAll<TOut>(Expression<Func<TEntity, object>>? orderBy, int skip, int take);
        public ResultListDTO<TOut> GetAll<TOut>(
            Expression<Func<TEntity, bool>>? predicate = null,
            Expression<Func<TEntity, object>>? orderBy = null,
            int skip = 0,
            int take = -1);
        public ResultListDTO<TOut> Search<TOut>(string[]? filterEntities, string[]? filterValues, string orderBy = "Id", int skip = 0, int take = -1);
        public TOut Create<TOut, TIn>(TIn data);
        public TOut Update<TOut, TIn>(Expression<Func<TEntity, bool>> predicate, TIn data);
        public TOut Delete<TOut>(Expression<Func<TEntity, bool>> predicate);
        public TOut DeletePerma<TOut>(Expression<Func<TEntity, bool>> predicate);
        public TOut Map<TOut, TIn>(TIn data);
    }
}
