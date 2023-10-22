using AutoMapper;
using System.Linq.Expressions;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class ItemRepo : BaseRepo<Item>, IItemRepo
    {
        public ItemRepo(VxDbc vxDbc, IMapper mapper) : base(vxDbc, mapper)
        {

        }

        public TOut Create<TOut, TIn>(TIn item, int seller)
        {
            var i = base.Create(item);
            i.SellerId = seller;

            Save();

            return _mapper.Map<TOut>(i);
        }

        public override TOut Delete<TOut>(Expression<Func<Item, bool>> predicate)
        {
            var item = base.Delete(predicate);
            item.Status = ItemStatus.REMOVED;

            Save();

            return _mapper.Map<TOut>(item);
        }

        public override TOut Update<TOut, TIn>(Expression<Func<Item, bool>> predicate, TIn data)
        {
            var i = Get<Item>(predicate);
            _vxDbc.ItemProperties.RemoveRange(i.ItemProperties);

            return base.Update<TOut, TIn>(predicate, data);
        }
    }
}
