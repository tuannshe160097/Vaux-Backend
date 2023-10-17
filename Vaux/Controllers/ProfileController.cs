using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("/api")]
    [Authorize]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private IAuthRepo _authRepo;
        private IUserRepo _userRepo;
        private ISuperUserRepo _superUserRepo;

        public ProfileController(IAuthRepo authRepo, IUserRepo userRepo, ISuperUserRepo superUserRepo)
        {
            _authRepo = authRepo;
            _userRepo = userRepo;
            _superUserRepo = superUserRepo;
        }

        [HttpGet]
        [Route("Profile")]
        public IActionResult ViewProfile()
        {
            User u = _userRepo.Get(int.Parse(User.Identity.Name));

            if (u == null)
            {
                return BadRequest("User does not exist");
            }

            return Ok(u);
        }

        [HttpPut]
        [Authorize(Roles = "BUYER,SELLER")]
        [Route("Profile")]
        public IActionResult UpdateProfile(ProfileUpdateDTO profileUpdate)
        {
            if (profileUpdate.Name == null)
            {
                return BadRequest("Name cannot be null");
            }
            _userRepo.UpdateProfile(int.Parse(User.Identity.Name), profileUpdate);
            return Ok();
        }

        [HttpPut]
        [Authorize (Roles = "EXPERT,ADMIN,MODERATOR")]
        [Route("Admin/Profile")]
        public IActionResult UpdateProfile(SuperUserDTO profileUpdate)
        {
            if (profileUpdate.Name == null)
            {
                return BadRequest("Name cannot be null");
            }
            _superUserRepo.Update(int.Parse(User.Identity.Name), profileUpdate);
            return Ok();
        }
    }
}