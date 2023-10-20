using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface ISellerApplicationRepo
    {
        public void SendApplication(SellerApplicationDTO application);

        public void UpdateApplication(SellerApplicationDTO application);
    }
}
