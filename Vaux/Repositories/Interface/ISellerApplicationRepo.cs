using System.Linq.Expressions;
using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface ISellerApplicationRepo : IBaseRepo<SellerApplication>
    {
        public TOut Update<TOut, TIn>(Expression<Func<SellerApplication, bool>> predicate, TIn data, string changeReason);
    }
}
