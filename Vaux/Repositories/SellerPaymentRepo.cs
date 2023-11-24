using AutoMapper;
using System.Linq;
using System.Linq.Expressions;
using Vaux.DbContext;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class SellerPaymentRepo : BaseRepo<SellerPayment>, ISellerPaymentRepo
    {
        public SellerPaymentRepo(VxDbc vxDbc, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(vxDbc, mapper, httpContextAccessor)
        {
        }

        public TOut ConfirmPaid<TOut>(Expression<Func<SellerPayment, bool>> predicate)
        {
            var res = _queryGlobal.FirstOrDefault(predicate);

            res.Status = SellerPaymentStatus.PAID;

            res.Item!.Seller.Notifications!.Add(new Notification()
            {
                Content = $"Thanh toán cho sản phẩm {res.Item.Name} đã được chuyển"
            });

            return Map<TOut>(res);
        }
    }
}
