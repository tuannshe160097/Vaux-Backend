using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Drawing.Printing;
using Vaux.DTO;
using Vaux.Hubs;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;
using static Twilio.Rest.Insights.V1.ConferenceResource;

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

        private static object GetBidLocker(int index)
        {
            return _bidLockPool[index % BID_LOCK_POOL_SIZE];
        }

        private readonly IItemRepo _itemRepo;
        private readonly IPhotoRepo _photoRepo;
        private readonly IBaseRepo<Comment> _commentRepo;
        private readonly IBaseRepo<Bid> _bidRepo;
        private readonly IHubContext<BidHub> _bidHub;
        private readonly ILogger<ItemController> _logger;

        public ItemController(IItemRepo itemRepo, IPhotoRepo photoRepo, IBaseRepo<Comment> commentRepo, IBaseRepo<Bid> bidRepo, IHubContext<BidHub> hubContext, ILogger<ItemController> logger)
        {
            _itemRepo = itemRepo;
            _photoRepo = photoRepo;
            _commentRepo = commentRepo;
            _bidRepo = bidRepo;
            _bidHub = hubContext;
            _logger = logger;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_itemRepo.Get<ItemOutDTO>(e => e.Id == id && e.Status == ItemStatus.AUCTION_IN_PROGRESS));
        }

        [HttpGet]
        public IActionResult GetAll(int pageNum = 1, int pageSize = -1, string? search = null, int? category = null)
        {
            var query = _itemRepo.Query().Where(e => e.Status == ItemStatus.AUCTION_IN_PROGRESS);
            query = query.OrderByDescending(e => e.ExpertId != null ? 1 : 0).ThenByDescending(e => e.Id);
            if (search != null)
            {
                query = query.Where(e => e.Name.Contains(search));
            }
            if (category != null)
            {
                query = query.Where(e => e.CategoryId == category);
            }
            return Ok(_itemRepo.WrapListResult<ItemOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpGet]
        [Route("Approved")]
        public IActionResult GetApproved(string? search = null, int? category = null)
        {
            var query = _itemRepo.Query();
            query = query.Where(e => e.Status == ItemStatus.AUCTION_PENDING && e.AuctionSessions!.All(auc => auc.Status == AuctionSessionStatus.FINISHED));
            if (search != null)
            {
                query = query.Where(e => e.Name.Contains(search));
            }
            if (category != null)
            {
                query = query.Where(e => e.CategoryId == category);
            }
            return Ok(_itemRepo.WrapListResult<ItemOutDTO>(query));
        }

        [HttpGet]
        [Authorize]
        [Route("WonItems")]
        public IActionResult WonItems()
        {
            return Ok(_itemRepo.GetAll<ItemOutDTO>(e => e.HighestBid!.UserId.ToString() == User.Identity!.Name && e.Status == ItemStatus.PAYMENT_PENDING && e.OrderId != null));
        }

        [HttpGet]
        [Route("{id}/Comments")]
        public IActionResult GetComments(int id, int pageNum = 1, int pageSize = 30)
        {
            return Ok(_commentRepo.GetAll<CommentOutDTO>(e => e.ItemId == id, e => e.Id, false, (pageNum-1) * pageSize, pageSize));
        }

        [HttpPost]
        [Authorize]
        [Route("{id}/Comments")]
        public IActionResult AddComment(int id, [FromBody] CommentInDTO comment)
        {
            var item = _itemRepo.Get<Item>(e => e.Id == id);
            if (item == null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            Comment c = new()
            {
                Content = comment.Content,
                UserId = int.Parse(User.Identity!.Name!),
                ItemId = id
            };

            var res = _commentRepo.Create<CommentOutDTO, Comment>(c);

            return Ok(res);
        }

        [HttpGet]
        [Route("{id}/Images/{imageId}")]
        public IActionResult GetImage(int id, int imageId)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null) return NotFound("Sản phẩm không tồn tại!");
            if (i.Images!.FirstOrDefault(e => e.Id == imageId) == null && i.ThumbnailId != imageId)
            {
                return NotFound("Ảnh không tồn tại!");
            }
            var res = _photoRepo.Get(imageId)?.ToArray();
            if (res == null)
            {
                return BadRequest("Đã có lỗi xảy ra!");
            }

            return File(res, "image/jpeg");
        }

        [HttpGet]
        [Route("{id}/Bids")]
        public IActionResult GetBids(int id)
        {
            return Ok(_bidRepo.GetAll<BidOutDTO>(e => e.ItemId == id && e.AuctionSessionId == e.Item!.OngoingSessionId));
        }

        [HttpPost]
        [Authorize]
        [Route("{id}/Bid")]
        public IActionResult Bid(int id, BidInDto bid)
        {
            _logger.LogInformation($"Request from user {User.Identity!.Name!} at {DateTime.Now:HH:mm:ss.ffffff} for item {id} with {bid.Amount}");
            var item = _itemRepo.Get<Item>(e => e.Id == id);
            if (item == null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            var locker = GetBidLocker(item.Id);
            lock(locker)
            {
                _itemRepo.Reload(item);

                if (bid.Amount < item.HighestBid?.Amount + 10000)
                {
                    _logger.LogInformation($"Response for user {User.Identity.Name} at {DateTime.Now:HH:mm:ss.ffffff} for item {id} with {bid.Amount}/too low");
                    return BadRequest("Giá được trả phái lớn hơn giá hiện tại ít nhất 10.000 VND");
                }

                var b = new Bid
                {
                    ItemId = item.Id,
                    Amount = bid.Amount,
                    UserId = int.Parse(User.Identity!.Name!),
                    AuctionSessionId = item.OngoingSessionId,
                };
                var res = _bidRepo.Create<Bid, Bid>(b);

                item.HighestBidId = res.Id;
                _itemRepo.Update<Item, Item>(e => e.Id == item.Id, item);

                string group = string.Format(BidHub.BID_ROOM_FORMAT, item.Id);
                _bidHub.Clients.Group(group).SendAsync(group, User.Identity.Name, bid.Amount);

                _logger.LogInformation($"Response for user {User.Identity.Name} at {DateTime.Now:HH:mm:ss.ffffff} for item {id} with {bid.Amount}/ok");
                return Ok();
            }
        }
    }
}
