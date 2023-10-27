using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Numerics;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Admin/Account")]
    [Authorize(Roles = nameof(RoleId.ADMIN))]
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
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult GetAll(int pageNum = 1, int pageSize = 30, string? search = null)
        {
            return Ok(_userRepo.GetAll<User>(e => search.IsNullOrEmpty() ? true : (e.Email != null && e.Email.Contains(search)) || e.Phone.Contains(search) || e.Name.Contains(search), e => e.Id, (pageNum-1) * pageSize, pageSize));
        }

        [HttpGet]
        [Route("/api/Mod/Account/{id}")]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult Get(int id)
        {
            return Ok(_userRepo.Get<User>(e => e.Id == id));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] UserStrictDTO profile)
        {
            var u = _userRepo.Get<User>(e => e.Id == id);
            if (u == null)
            {
                return BadRequest("User does not exist");
            }
            if (u.Phone != profile.Phone && _userRepo.Get<User>(e => e.Phone == profile.Phone) != null)
            {
                return BadRequest("Phone number already taken");
            }
            if (u.Email != profile.Email && _userRepo.Get<User>(e => e.Email == profile.Email) != null)
            {
                return BadRequest("Email already taken");
            }

            var res = _userRepo.Update<User, UserStrictDTO>(e => e.Id == id, profile);
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
        [Authorize($"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult ChangeAccess(int id)
        {
            var u = _userRepo.Get<User>(e => e.Id == id);
            if (u == null)
            {
                return BadRequest("User not found");
            }
            if (u.RoleId == (int)RoleId.ADMIN || u.RoleId == (int)RoleId.MODERATOR)
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
            var u = _userRepo.Get<User>(e => e.Id == id);
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
            if (_userRepo.Get<User>(e => e.Phone == superUser.Phone || e.Email == superUser.Email) != null)
            {
                return BadRequest("User already exists");
            }

            var res = _userRepo.Create<User>(superUser, RoleId.MODERATOR);

            return Ok(res);
        }

        [HttpPost]
        [Route("/api/Mod/Account/CreateExpert")]
        public IActionResult CreateExpert(UserStrictDTO superUser)
        {
            if (_userRepo.Get<User>(e => e.Phone == superUser.Phone || e.Email == superUser.Email) != null)
            {
                return BadRequest("User already exists");
            }

            var res = _userRepo.Create<User>(superUser, RoleId.MODERATOR);

            return Ok(res);
        }
    }
}
