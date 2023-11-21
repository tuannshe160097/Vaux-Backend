using AutoMapper;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        public OrderRepo(VxDbc vxDbc, IMapper mapper) : base(vxDbc, mapper)
        {
        }

        public ICollection<ShippingCostDTO> CalculateShip(ICollection<int> itemIds)
        {
            var items = _vxDbc.Items.Where(e => itemIds.Contains(e.Id) && e.Status == ItemStatus.PAYMENT_PENDING);
            List<ShippingCostDTO> res = new();
            List<int> sellerIds = new();
            foreach (var item in items)
            {
                if (sellerIds.Contains(item.SellerId))
                {
                    continue;
                }

                sellerIds.Add(item.SellerId);

            }

            return res;
        }
    }
}
