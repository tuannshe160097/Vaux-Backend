using AutoMapper;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        private VxDbc _vxDbc;
        private IMapper _mapper;

        public CategoryRepo(VxDbc vxDbc, IMapper mapper)
        {
            _vxDbc = vxDbc;
            _mapper = mapper;
        }

        public CategoryDTO Create(CategoryDTO category)
        {
            var c = _mapper.Map<Category>(category);
            _vxDbc.Categories.Add(c);
            _vxDbc.SaveChanges();

            return _mapper.Map<CategoryDTO>(c);
        }

        public CategoryDTO Get(int id)
        {
            var c = _vxDbc.Categories.FirstOrDefault(c => c.Id == id);

            return _mapper.Map<CategoryDTO>(c);
        }

        public List<CategoryDTO> GetAll(int pageNum, int pageSize, string? search = null)
        {
            var res = _vxDbc.Categories.AsQueryable();

            if (search != null)
            {
                res = res.Where(x => x.Name.Contains(search));
            }

            res = res.Skip((pageNum - 1) * pageSize).Take(pageSize);

            return _mapper.Map<List<CategoryDTO>>(res);
        }

        public CategoryDTO Update(int id, CategoryDTO category)
        {
            var c = _vxDbc.Categories.FirstOrDefault(c => c.Id == id);
            _mapper.Map(category, c);
            _vxDbc.SaveChanges();

            return _mapper.Map<CategoryDTO>(c);
        }
    }
}
