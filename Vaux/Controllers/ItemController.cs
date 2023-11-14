using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Vaux.DTO;
using Vaux.Hubs;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Item")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        //Values are empty objects used to lock up bidding execution block
        //Do not access value directly
        //private static readonly ConcurrentDictionary<int, object> _bidLockPool = new();
        private const int BID_LOCK_POOL_SIZE = 64;
        private static readonly List<object> _bidLockPool = Enumerable.Repeat(new object(), BID_LOCK_POOL_SIZE).ToList();

        private object GetBidLocker(int index)
        {
            return _bidLockPool[index % BID_LOCK_POOL_SIZE];
        }

        private IItemRepo _itemRepo;
        private IPhotoRepo _photoRepo;
        private IBaseRepo<Comment> _commentRepo;
        private IBaseRepo<Bid> _bidRepo;
        private IHubContext<BidHub> _bidHub;

        public ItemController(IItemRepo itemRepo, IPhotoRepo photoRepo, IBaseRepo<Comment> commentRepo, IBaseRepo<Bid> bidRepo, IHubContext<BidHub> hubContext)
        {
            _itemRepo = itemRepo;
            _photoRepo = photoRepo;
            _commentRepo = commentRepo;
            _bidRepo = bidRepo;
            _bidHub = hubContext;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_itemRepo.Get<ItemDTO>(e => e.Id == id && e.Status == ItemStatus.AUCTION_IN_PROGRESS));
        }

        [HttpGet]
        public IActionResult GetAll(int pageNum = 1, int pageSize = 30, [FromQuery] string[]? filterEntities = null, [FromQuery] string[]? filterValues = null, string orderBy = "Id")
        {
            filterEntities = filterEntities ?? new string[1];
            filterValues = filterValues ?? new string[1];
            filterEntities[filterEntities.Length - 1] = "Status";
            filterValues[filterValues.Length - 1] = $"{ItemStatus.AUCTION_IN_PROGRESS}";
            var res = _itemRepo.Search<ItemDTO>(filterEntities, filterValues, orderBy, (pageNum - 1) * pageSize, pageSize);
            return Ok(res);
        }

        [HttpGet]
        [Route("Approved")]
        public IActionResult GetApproved()
        {
            return Ok(_itemRepo.Get<ItemDTO>(e => e.Status == ItemStatus.AUCTION_PENDING && e.AuctionSessions!.All(auc => auc.Status == AuctionSessionStatus.FINISHED)));
        }

        [HttpGet]
        [Route("{id}/Comments")]
        public IActionResult GetComments(int id, int pageNum = 1, int pageSize = 30)
        {
            return Ok(_commentRepo.GetAll<CommentOutDTO>(e => e.ItemId == id, e => e.Id, (pageNum-1) * pageSize, pageSize));
        }

        [HttpPost]
        [Authorize]
        [Route("{id}/Comments")]
        public IActionResult AddComment(int id, [FromBody] CommentInDTO comment)
        {
            var item = _itemRepo.Get<Item>(e => e.Id == id);
            if (item == null)
            {
                return BadRequest();
            }

            Comment c = new();
            c.Content = comment.Content;
            c.UserId = int.Parse(User.Identity.Name);
            c.ItemId = id;
            
            var res = _commentRepo.Create<CommentOutDTO, Comment>(c);

            return Ok(res);
        }

        [HttpGet]
        [Route("{id}/Images/{imageId}")]
        public IActionResult GetImage(int id, int imageId)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i?.Images?.FirstOrDefault(e => e.Id == imageId) == null)
            {
                return BadRequest();
            }

            return File(_photoRepo.Get(id).ToArray(), "image/jpeg");
        }

        [HttpGet]
        [Route("{id}/Bids")]
        public IActionResult GetBids(int id)
        {
            return Ok(_bidRepo.GetAll<BidDTO>(e => e.ItemId == id));
        }

        [HttpPost]
        [Authorize]
        [Route("{id}/Bid")]
        public IActionResult Bid(int id, BidInDto bid)
        {
            Console.WriteLine($"Request from user {User.Identity.Name} at {DateTime.Now.ToString("HH:mm:ss.ffffff")} for item {id} with {bid.Amount}");
            var item = _itemRepo.Get<Item>(e => e.Id == id);
            if (item == null)
            {
                return BadRequest();
            }

            //object bidLocker = new object();
            //lock (_bidLockPool.GetOrAdd(item.Id, bidLocker))
            var locker = GetBidLocker(item.Id);
            lock(locker)
            {
                _itemRepo.Reload(item);

                if (bid.Amount <= item.Bids?.Last().Amount + 10000)
                {
                    Console.WriteLine($"Response for user {User.Identity.Name} at {DateTime.Now.ToString("HH:mm:ss.ffffff")} for item {id} with {bid.Amount}/too low");
                    return BadRequest("Bid must be 10k higher than curreent bid");
                }

                var b = new Bid();
                b.ItemId = item.Id;
                b.Amount = bid.Amount;
                b.UserId = int.Parse(User.Identity.Name);
                var res = _bidRepo.Create<Bid, Bid>(b);

                string group = string.Format(BidHub.BID_ROOM_FORMAT, item.Id);
                _bidHub.Clients.Group(group).SendAsync(group, User.Identity.Name, bid.Amount);

                Console.WriteLine($"Response for user {User.Identity.Name} at {DateTime.Now.ToString("HH:mm:ss.ffffff")} for item {id} with {bid.Amount}/ok");
                return Ok(res);
            }
        }
    }
}
