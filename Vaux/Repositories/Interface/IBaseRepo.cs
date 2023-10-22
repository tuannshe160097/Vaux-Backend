using Microsoft.AspNetCore.Mvc.Formatters;
using System.Linq.Expressions;
using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IBaseRepo<TEntity> where TEntity : ModelBase
    {
        public TOut? Get<TOut>(Expression<Func<TEntity, bool>> predicate);
        public List<TOut> GetAll<TOut>(int skip = 0, int take = -1);
        public List<TOut> GetAll<TOut>(
            Expression<Func<TEntity, bool>>? predicate,
            Expression<Func<TEntity, object>>? orderBy,
            int skip = 0,
            int take = -1);
        public TOut Create<TOut, TIn>(TIn data);
        public TOut Update<TOut, TIn>(Expression<Func<TEntity, bool>> predicate, TIn data);
        public TOut Delete<TOut>(Expression<Func<TEntity, bool>> predicate);
    }
}
