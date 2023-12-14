using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO.Out;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationRepo _notificationRepo;

        public NotificationController(INotificationRepo notificationRepo) 
        {
            _notificationRepo = notificationRepo;
        }

        [HttpPatch]
        [Route("{id}/MarkAsRead")]
        public IActionResult MarkAsRead(int id)
        {
            return Ok(_notificationRepo.MarkAsRead<NotificationOutDTO>(e => e.Id == id));
        }
    }
}
