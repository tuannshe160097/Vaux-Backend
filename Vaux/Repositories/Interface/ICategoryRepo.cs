using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface ICategoryRepo
    {
        List<CategoryDTO> GetAll(int pageNum, int pageSize, string? search = null);
        CategoryDTO Get(int id);
        CategoryDTO Create(CategoryDTO category);
        CategoryDTO Update(int id, CategoryDTO category);
    }
}
