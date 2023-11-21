using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IOrderRepo : IBaseRepo<Order>
    {
        public ICollection<ShippingCostDTO> CalculateShip(ICollection<int> itemIds);
    }
}
