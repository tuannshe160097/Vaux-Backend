﻿using Microsoft.AspNetCore.Mvc.Formatters;
using System.Linq.Expressions;
using Vaux.DTO.Out;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IBaseRepo<TEntity> where TEntity : ModelBase
    {
        public TOut? Get<TOut>(Expression<Func<TEntity, bool>> predicate);

        public ResultListDTO<TOut> GetAll<TOut>(Expression<Func<TEntity, object>>? orderBy, bool ascending = true);

        public ResultListDTO<TOut> GetAll<TOut>(Expression<Func<TEntity, object>>? orderBy, bool ascending, int skip, int take);

        public ResultListDTO<TOut> GetAll<TOut>(
            Expression<Func<TEntity, bool>>? predicate = null,
            Expression<Func<TEntity, object>>? orderBy = null,
            bool ascending = true,
            int skip = 0,
            int take = -1);

        [Obsolete("Use GetAll() or construct a query using Query() instead")]
        public ResultListDTO<TOut> Search<TOut>(string[]? filterEntities, string[]? filterValues, string orderBy = "Id", int skip = 0, int take = -1);

        public TOut Create<TOut, TIn>(TIn data);

        public TOut Update<TOut, TIn>(Expression<Func<TEntity, bool>> predicate, TIn data);

        public TOut Delete<TOut>(Expression<Func<TEntity, bool>> predicate);

        public TOut DeletePerma<TOut>(Expression<Func<TEntity, bool>> predicate);

        public IQueryable<TEntity> Query();

        public ResultListDTO<TOut> WrapListResult<TOut>(IQueryable<TEntity> query, int skip = 0, int take = -1);

        public TOut Map<TOut>(object data);

        public TOut Map<TOut>(TEntity data);

        public TEntity Map<TIn>(TIn data);

        public void Reload(TEntity entity);
    }
}
