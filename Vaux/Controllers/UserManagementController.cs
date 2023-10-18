using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using Vaux.DTO;
using Vaux.Repositories;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Admin/Account")]
    [Authorize(Roles = "ADMIN")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        private IUserRepo _userRepo;

        public UserManagementController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        [Route("/api/Mod/Account")]
        [Authorize(Roles = "MODERATOR,ADMIN")]
        public IActionResult GetAll(int pageNum = 1, int pageSize = 30, string? search = null)
        {
            return Ok(_userRepo.GetAll(pageNum, pageSize, search));
        }

        [HttpGet]
        [Route("/api/Mod/Account/{id}")]
        [Authorize(Roles = "MODERATOR,ADMIN")]
        public IActionResult Get(int id)
        {
            return Ok(_userRepo.Get(id));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] UserStrictDTO profile)
        {
            var u = _userRepo.Get(id);
            if (u == null)
            {
                return BadRequest("User does not exist");
            }
            if (u.Phone != profile.Phone && _userRepo.GetByPhone(profile.Phone) != null)
            {
                return BadRequest("Phone number already taken");
            }
            if (u.Email != profile.Email && _userRepo.GetByEmail(profile.Email) != null)
            {
                return BadRequest("Email already taken");
            }

            var res = _userRepo.Update(id, profile);
            return Ok(res);
        }

        [HttpPost]
        [Route("{id}/CitizenIdImage")]
        public IActionResult UpdateCitizenIdImage(int id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("{id}/FaceImage")]
        public IActionResult UpdateFaceImage(int id)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("/api/Mod/Account/ChangeAccess/{id}")]
        [Authorize("MODERATOR,ADMIN")]
        public IActionResult ChangeAccess(int id)
        {
            var u = _userRepo.Get(id);
            if (u == null)
            {
                return BadRequest("User not found");
            }
            if (u.RoleId == (int)Models.Enums.Role.ADMIN || u.RoleId == (int)Models.Enums.Role.MODERATOR)
            {
                return Forbid();
            }

            _userRepo.ChangeAccess(id);

            return Ok();
        }

        [HttpPatch]
        [Route("ChangeAccess/{id}")]
        public IActionResult AdminChangeAccess(int id)
        {
            var u = _userRepo.Get(id);
            if (u == null)
            {
                return BadRequest("User not found");
            }
            _userRepo.ChangeAccess(id);

            return Ok();
        }

        [HttpPost]
        [Route("CreateModerator")]
        public IActionResult CreateMod(UserStrictDTO superUser)
        {
            if (_userRepo.GetByPhone(superUser.Phone) != null)
            {
                return BadRequest("User already exists");
            }

            var res = _userRepo.Create(superUser, Models.Enums.Role.MODERATOR);

            return Ok(res);
        }
    }
}
