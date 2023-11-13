using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Vaux.DbContext;

namespace Vaux.Hubs
{
    public class BidHub : Hub
    {
        private VxDbc _vxDbc;
        public static readonly string BID_ROOM_FORMAT = "item_bid_{0}";

        public BidHub(VxDbc vxDbc)
        {
            _vxDbc = vxDbc;
        }

        public void JoinBid(int itemId)
        {
            var item = _vxDbc.Items.FirstOrDefault(e => e.Id == itemId);
            if (item == null)
            {
                throw new HubException("400");
            }
            Groups.AddToGroupAsync(Context.ConnectionId, string.Format(BID_ROOM_FORMAT, item.Id));
        }
    }
}