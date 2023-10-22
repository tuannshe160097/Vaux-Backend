using Microsoft.AspNetCore.Mvc.Formatters;
using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IItemRepo : IBaseRepo<Item>
    {
        public TOut Create<TOut, TIn>(TIn item, int seller);
    }
}
