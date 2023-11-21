using AutoMapper;
using Vaux.DbContext;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        public OrderRepo(VxDbc vxDbc, IMapper mapper) : base(vxDbc, mapper)
        {
        }
    }
}
