using System.Linq.Expressions;
using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface ISellerPaymentRepo : IBaseRepo<SellerPayment>
    {
        public TOut ConfirmPaid<TOut>(Expression<Func<SellerPayment, bool>> predicate);
    }
}
