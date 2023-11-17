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
    [Route("/api/Chat")]
    [ApiController]
    public class ChatMessageController : ControllerBase
    {
        private IPhotoRepo _photoRepo;
        private IUserRepo _userRepo;
        private IItemRepo _itemRepo;
        private IChatRepo _chatRepo;
        private readonly IHubContext<VauxChatHub> _hubContext;
        public ChatMessageController(IItemRepo itemRepo, IPhotoRepo photoRepo, IUserRepo userRepo, IChatRepo chatRepo, IHubContext<VauxChatHub> hubContext)
        {
            _itemRepo = itemRepo;
            _photoRepo = photoRepo;
            _userRepo = userRepo;
            _chatRepo = chatRepo;
            _hubContext = hubContext;
        }
        [HttpPost]
        [Authorize]
        [Route("/api/Chat/{id}")]
        public IActionResult GetAll(int id)
        {
            var c = _itemRepo.Get<Item>(e => e.Id == id);
            if (c == null)
            {
                return BadRequest("Item does not exist");
            }
            if (User.Identity.Name != c.ExpertId.ToString() && User.Identity.Name != c.SellerId.ToString())
            {
                return Unauthorized("Blud got rejected 💀");
            }
            return Ok(_chatRepo.GetAll<ChatMessageOutDTO>(e => e.ItemId == id));
        }
        [HttpPost]
        [Authorize]
        [Route("/api/Chat")]
        public async Task <IActionResult> Send([FromForm] ChatMessageDTO chatMessage)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == chatMessage.ItemId);
            if(i == null)
            {
                return BadRequest("Item does not exist");
            }
            if (User.Identity.Name != i.ExpertId.ToString() && User.Identity.Name != i.SellerId.ToString())
            {
                return Unauthorized("Blud got rejected 💀");
            }
            if (chatMessage.RawImage == null && chatMessage.Content == null)
            {
                return BadRequest("Must send content or image");
            }
            if (chatMessage.RawImage != null)
            {
                chatMessage.ImageId = _photoRepo.Create<Image>(chatMessage.RawImage).Id;
            }
            var message = _chatRepo.Create<ChatMessageOutDTO, ChatMessageDTO>(chatMessage);
            var u = _userRepo.Get<User>(e => e.Id == chatMessage.SenderId);
            await _hubContext.Clients.Groups("ItemApplication_id" + chatMessage.ItemId).SendAsync("VauxItemMessage", u!.Name, message);
            return Ok();
        }

        [HttpGet]
        [Authorize]
        [Route("/api/Chat/{itemid}/Image/{imageid}")]
        public IActionResult GetImage(int itemId, int imageId)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == itemId);
            if (i == null)
            {
                return BadRequest("Item does not exist");
            }
            if (User!.Identity!.Name != i.ExpertId.ToString() && User.Identity.Name != i.SellerId.ToString())
            {
                return Unauthorized("Blud got rejected 💀");
            }
            MemoryStream image = _photoRepo.Get(imageId);
            if (image == null)
            {
                return BadRequest("Image does not exist");
            }
            byte[] bytes = image.ToArray();
            return File(bytes, "image/jpeg");
        }
    }
}
