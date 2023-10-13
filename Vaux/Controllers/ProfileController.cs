using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private IAuthRepo _authRepo;
        private IUserRepo _userRepo;

        public ProfileController(IAuthRepo authRepo, IUserRepo userRepo)
        {
            _authRepo = authRepo;
            _userRepo = userRepo;
        }

        [HttpGet]
        [Route("/profile")]
        public IActionResult ViewProfile(int id)
        {
            User u = _userRepo.Get(id);

            if (u == null)
            {
                return BadRequest("User does not exist");
            }

            return Ok(u);
        }

        [HttpGet]
        [Route("/profile/update")]
        public IActionResult UpdateProfile(int id)
        {
            User u = _userRepo.Get(id);

            if (u == null)
            {
                return BadRequest("User does not exist");
            }

            return Ok(u);
        }
    }
}