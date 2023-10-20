using AutoMapper;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class ItemRepo : IItemRepo
    {
        private VxDbc _vxDbc;
        private IMapper _mapper;

        public ItemRepo(VxDbc vxDbc, IMapper mapper)
        {
            _vxDbc = vxDbc;
            _mapper = mapper;
        }

        public Item Create(int seller, ItemApplicationDTO item)
        {
            var i = _mapper.Map<Item>(item);
            i.SellerId = seller;

            _vxDbc.Items.Add(i);
            _vxDbc.SaveChanges();

            return i;
        }

        public Item Delete(int id)
        {
            var item = _vxDbc.Items.FirstOrDefault(i => i.Id == id);
            item.Status = ItemStatus.REMOVED;
            item.Deleted = DateTime.Now;

            _vxDbc.SaveChanges();

            return item;
        }

        public Item? GetByUser(int id)
        {
            return _vxDbc.Items.FirstOrDefault(i => i.SellerId == id);
        }

        public Item? Get(int id)
        {
            return _vxDbc.Items.FirstOrDefault(i => i.Id == id);
        }

        public List<Item> GetAll()
        {
            return _vxDbc.Items.ToList();
        }

        public Item Update(int id, ItemApplicationDTO item)
        {
            var i = _vxDbc.Items.FirstOrDefault(c => c.Id == id);

            _vxDbc.ItemProperties.RemoveRange(i.ItemProperties);

            _mapper.Map(item, i);
            _vxDbc.SaveChanges();

            return i;
        }
    }
}
