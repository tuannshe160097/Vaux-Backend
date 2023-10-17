using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using Vaux.DTO;
using Vaux.Repositories;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Admin/Management")]
    [Authorize(Roles = "ADMIN")]
    [ApiController]
    public class SuperUserManagementController : ControllerBase
    {
        private ISuperUserRepo _userRepo;

        public SuperUserManagementController(ISuperUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        [Route("")]
        [Authorize(Roles = "MODERATOR,ADMIN")]
        public IActionResult GetAll(int pageNum = 1, int pageSize = 30, string? search = null)
        {
            return Ok(_userRepo.GetAll(pageNum, pageSize, search));
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "MODERATOR,ADMIN")]
        public IActionResult Get(int id)
        {
            return Ok(_userRepo.Get(id));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] SuperUserDTO profile)
        {
            var u = _userRepo.Get(id);
            if (u == null)
            {
                return BadRequest("User does not exist");
            }
            if (u.Phone != profile.Phone && _userRepo.Get(profile.Phone) != null)
            {
                return BadRequest("Phone number already taken");
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
        [Route("ChangeAccess/{id}")]
        public IActionResult ChangeAccess(int id)
        {
            _userRepo.ChangeAccess(id);

            return Ok();
        }

        [HttpPost]
        [Route("CreateModerator")]
        public IActionResult CreateMod(SuperUserDTO superUser)
        {
            if (_userRepo.Get(superUser.Phone) != null)
            {
                return BadRequest("User already exists");
            }

            var res = _userRepo.CreateModerator(superUser);

            return Ok(res);
        }
    }
}
