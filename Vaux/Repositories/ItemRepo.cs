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
        private IPhotoRepo _photoRepo;

        public ItemRepo(VxDbc vxDbc, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(vxDbc, mapper, httpContextAccessor)
        {
            _photoRepo = new PhotoRepo(vxDbc, mapper);
        }

        public TOut Create<TOut, TIn>(TIn item, int seller)
        {
            var i = Create(item);
            i.SellerId = seller;
            i.Status = ItemStatus.EXAMINATION_PENDING;

            Save();

            return _mapper.Map<TOut>(i);
        }

        public override TOut Update<TOut, TIn>(Expression<Func<Item, bool>> predicate, TIn data)
        {
            var oldItem = Get<Item>(predicate);
            var newItem = Update(predicate, data);

            if (oldItem.Status != newItem.Status && _user != null)
            {
                StatusChange sc = new StatusChange();
                sc.StatusFrom = nameof(oldItem.Status);
                sc.StatusFrom = nameof(newItem.Status);

                sc.StatusChangedById = int.Parse(_user.Identity.Name);
                sc.StatusChangeReason = $"Changed status from {nameof(oldItem.Status)} to {nameof(newItem.Status)}";
            }

            return _mapper.Map<TOut>(newItem);
        }

        public TOut Update<TOut, TIn>(Expression<Func<Item, bool>> predicate, TIn data, string changeReason)
        {
            var oldItem = Get<Item>(predicate);
            var newItem = Update(predicate, data);

            if (oldItem.Status != newItem.Status && _user != null)
            {
                StatusChange sc = new StatusChange();
                sc.StatusFrom = nameof(oldItem.Status);
                sc.StatusFrom = nameof(newItem.Status);

                sc.StatusChangedById = int.Parse(_user.Identity.Name);
                sc.StatusChangeReason = changeReason;
            }

            return _mapper.Map<TOut>(newItem);
        }

        protected override Item Delete(Expression<Func<Item, bool>> predicate)
        {
            var item = base.Delete(predicate);
            item.Status = ItemStatus.REMOVED;

            return item;
        }

        public TOut AddImages<TOut>(Expression<Func<Item, bool>> predicate, List<IFormFile> images)
        {
            var i = Get<Item>(predicate);

            foreach (var image in images)
            {
                i.Images.Add(_photoRepo.Create<Image>(image));
            }

            Save();

            return _mapper.Map<TOut>(i);
        }

        public TOut RemoveImages<TOut>(Expression<Func<Item, bool>> predicate, ICollection<int> imageIds)
        {
            var i = Get<Item>(predicate);

            foreach (var image in i.Images)
            {
                if (imageIds.Contains(image.Id))
                {
                    i.Images.Remove(_photoRepo.Delete<Image>(image.Id));
                }
            }

            Save();

            return _mapper.Map<TOut>(i);
        }
    }
}
