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
        //[Authorize(Roles = nameof(RoleId.EXPERT))]
        [Route("/api/Chat/Send")]
        public async Task <IActionResult> Create([FromForm] ChatMessageDTO chatMessage)
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
            var message = _chatRepo.Create<ChatMessage, ChatMessageDTO>(chatMessage);
            var u = _userRepo.Get<User>(e => e.Id == chatMessage.SenderId);
            if (chatMessage.RawImage != null)
            {
                chatMessage.ImageId = _photoRepo.Create<Image>(chatMessage.RawImage).Id;
                await _hubContext.Clients.All.SendAsync("VauxItemMessage", u!.Name, message.Image);
                return Ok();
            }
            await _hubContext.Clients.Groups("ItemApplication_id" + chatMessage.ItemId).SendAsync("VauxItemMessage", u!.Name, message.Content);
            return Ok();
        }
    }
}
