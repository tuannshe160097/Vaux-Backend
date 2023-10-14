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
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_userRepo.GetAll());
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Get(int id)
        {
            return Ok(_userRepo.Get(id));
        }
    }
}
