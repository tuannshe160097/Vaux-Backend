using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Admin/User")]
    [ApiController]
    [Authorize(Roles = "ADMIN")]
    public class UserManagementController : ControllerBase
    {
        private IUserRepo _userRepo;

        public UserManagementController(IUserRepo userRepo) 
        { 
            _userRepo = userRepo;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult GetAll(int pageNum = 1, int pageSize = 30, string? search = null)
        {
            return Ok(_userRepo.GetAll(pageNum, pageSize, search));
        }

        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_userRepo.Get(id));
        }

        [HttpPatch]
        [Route("ChangeAccess/{id}")]
        public IActionResult ChangeAccess(int id)
        {
            _userRepo.ChangeAccess(id);

            return Ok();
        }
    }
}
