using AutoMapper;
using System.Linq.Expressions;
using Twilio.TwiML.Voice;
using Vaux.DbContext;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class AuctionSessionRepo : BaseRepo<AuctionSession>, IAuctionSessionRepo
    {
        public AuctionSessionRepo(VxDbc vxDbc, IMapper mapper) : base(vxDbc, mapper)
        {
        }

        public TOut Create<TOut, TIn>(TIn data, ICollection<int> itemIds)
        {
            var auc = Create(data);

            auc.Items = _vxDbc.Items.Where(e => itemIds.Contains(e.Id) && e.Status == ItemStatus.AUCTION_PENDING && e.AuctionSessions!.All(auc => auc.Status == AuctionSessionStatus.FINISHED)).ToList();

            Save();
            return _mapper.Map<TOut>(auc);
        }

        public TOut Update<TOut, TIn>(Expression<Func<AuctionSession, bool>> predicate, TIn data, ICollection<int> itemIds)
        {
            var auc = Update(predicate, data);

            auc.AuctionSessionItems?.Clear();

            auc.Items = _vxDbc.Items.Where(e => itemIds.Contains(e.Id) && e.Status == ItemStatus.AUCTION_PENDING && e.AuctionSessions!.All(auc => auc.Status == AuctionSessionStatus.FINISHED)).ToList();

            Save();

            return _mapper.Map<TOut>(auc);
        }

        protected override AuctionSession Create<TIn>(TIn data)
        {
            var auc = base.Create(data);
            auc.StartDate = auc.StartDate.Date.AddHours(7);
            auc.EndDate = auc.EndDate.Date.AddHours(19);

            return auc;
        }

        protected override AuctionSession Update<TIn>(Expression<Func<AuctionSession, bool>> predicate, TIn data)
        {
            var auc = base.Update(predicate, data);
            auc.StartDate = auc.StartDate.Date.AddHours(7);
            auc.EndDate = auc.EndDate.Date.AddHours(19);

            return auc;
        }
    }
}
