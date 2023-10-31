using System.Linq.Expressions;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IAuctionSessionRepo : IBaseRepo<AuctionSession>
    {
        public TOut Create<TOut, TIn>(TIn data, ICollection<int> itemIds);
        public TOut Update<TOut, TIn>(Expression<Func<AuctionSession, bool>> predicate, TIn data, ICollection<int> itemIds);
    }
}
