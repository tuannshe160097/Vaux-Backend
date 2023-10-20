using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IItemRepo
    {
        Item? Get(int id);
        Item? GetByUser(int id);
        List<Item> GetAll();
        Item Create(int seller, ItemApplicationDTO item);
        Item Update(int id, ItemApplicationDTO item);
        Item Delete(int id);
    }
}
