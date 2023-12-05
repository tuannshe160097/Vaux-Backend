using AutoMapper;
using System.Linq;
using System.Linq.Expressions;
using Vaux.DbContext;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class ItemPaymentRepo : BaseRepo<ItemPayment>, IItemPaymentRepo
    {
        public ItemPaymentRepo(VxDbc vxDbc, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(vxDbc, mapper, httpContextAccessor)
        {
        }
    }
}
