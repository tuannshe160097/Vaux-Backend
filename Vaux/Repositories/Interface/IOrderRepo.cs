using System.Linq.Expressions;
using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IOrderRepo : IBaseRepo<Order>
    {
        public TOut Create<TOut>(int[] itemIds);
        public TOut ConfirmPaid<TOut>(Expression<Func<Order, bool>> predicate);
    }
}
