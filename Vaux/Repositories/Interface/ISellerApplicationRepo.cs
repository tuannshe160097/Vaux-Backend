using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface ISellerApplicationRepo
    {
        public SellerApplication SendApplication(SellerApplicationDTO application);

        public SellerApplication UpdateApplication(SellerApplicationDTO application);
    }
}
