using AutoMapper;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;
using Vaux.Models.Enums;
using System.Linq.Expressions;

namespace Vaux.Repositories
{
    public class SellerApplicationRepo : BaseRepo<SellerApplication>, ISellerApplicationRepo
    {
        public SellerApplicationRepo(VxDbc vxDbc, IMapper mapper) : base(vxDbc, mapper)
        {
        }


        public override TOut Create<TOut, TIn>(TIn data)
        {
            var a = Create(data);
            a.Status = SellerApplicationStatus.PENDING;
            Save();          
            return Map<TOut>(a);
        }

        public TOut Update<TOut, TIn>(Expression<Func<SellerApplication, bool>> predicate, TIn data, string changeReason)
        {
            var oldAppli = Get<SellerApplication>(predicate);
            var newAppli = Update(predicate, data);

            if (oldAppli.Status != newAppli.Status && _user != null)
            {
                newAppli.StatusChanges.Add(new StatusChange
                {
                    StatusFrom = nameof(oldAppli.Status),
                    StatusTo = nameof(newAppli.Status),

                    StatusChangedById = int.Parse(_user.Identity!.Name!),
                    StatusChangeReason = changeReason
                });
            }

            Save();

            return Map<TOut>(newAppli);
        }
    }
}
