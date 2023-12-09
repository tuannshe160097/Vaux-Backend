using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Vaux.DTO.In;
using Vaux.DTO.Out;
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
        private readonly IPhotoRepo _photoRepo;
        private readonly IUserRepo _userRepo;
        private readonly IItemRepo _itemRepo;
        private readonly IChatRepo _chatRepo;
        private readonly IHubContext<VauxChatHub> _hubContext;
        public ChatMessageController(IItemRepo itemRepo, IPhotoRepo photoRepo, IUserRepo userRepo, IChatRepo chatRepo, IHubContext<VauxChatHub> hubContext)
        {
            _itemRepo = itemRepo;
            _photoRepo = photoRepo;
            _userRepo = userRepo;
            _chatRepo = chatRepo;
            _hubContext = hubContext;
        }
        
        [HttpGet]
        [Authorize]
        [Route("/api/Chat/{id}")]
        public IActionResult GetAll(int id)
        {
            var c = _itemRepo.Get<Item>(e => e.Id == id);
            if (c == null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }
            if (User.Identity!.Name != c.ExpertId.ToString() && User.Identity.Name != c.SellerId.ToString())
            {
                return Unauthorized("Tài khoản không hợp lệ!");
            }
            return Ok(_chatRepo.GetAll<ChatMessageOutDTO>(e => e.ItemId == id, e => e.Created, false));
        }

        [HttpPost]
        [Authorize]
        [Route("/api/Chat")]
        public async Task <IActionResult> Send([FromForm] ChatMessageDTO chatMessage)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == chatMessage.ItemId);
            if(i == null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }
            if (User!.Identity!.Name != i.ExpertId.ToString() && User.Identity.Name != i.SellerId.ToString())
            {
                return Unauthorized("Tài khoản không hợp lệ!");
            }
            if (chatMessage.RawImage == null && chatMessage.Content == null)
            {
                return BadRequest("Nội dung gửi không hợp lệ!");
            }
            if (chatMessage.RawImage != null)
            {
                chatMessage.ImageId = _photoRepo.Create<Image>(chatMessage.RawImage).Id;
            }
            chatMessage.SenderId = int.Parse(User!.Identity!.Name!);
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
            MemoryStream? image = _photoRepo.Get(imageId);
            if (image == null)
            {
                return BadRequest("Image does not exist");
            }
            byte[] bytes = image.ToArray();
            return File(bytes, "image/jpeg");
        }
    }
}
