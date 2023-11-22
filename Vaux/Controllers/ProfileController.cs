using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("/api/Profile")]
    [Authorize]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IUserRepo _userRepo;

        public ProfileController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public IActionResult ViewProfile()
        {
            //User u = _userRepo.Get(int.Parse(User.Identity.Name));
            var u = _userRepo.Get<UserOutDTO>(e => e.Id.ToString() == User.Identity!.Name);

            if (u == null)
            {
                return BadRequest("User does not exist");
            }

            return Ok(u);
        }

        [HttpPut]
        [Authorize(Roles = $"{nameof(RoleId.BUYER)},{nameof(RoleId.SELLER)}")]
        public IActionResult UpdateProfile(UserMinimalDTO profile)
        {
            var u = _userRepo.Get<User>(e => e.Id.ToString() == User.Identity!.Name);
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

            return Ok(_userRepo.Update<UserOutDTO, UserMinimalDTO>(e => e.Id == u.Id, profile));
        }

        [HttpPut]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)},{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [Route("/api/Mod/Profile")]
        public IActionResult UpdateProfile(UserStrictDTO profile)
        {
            var u = _userRepo.Get<User>(e => e.Id.ToString() == User.Identity!.Name);
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

            return Ok(_userRepo.Update<UserOutDTO, UserStrictDTO>(e => e.Id == u.Id, profile));
        }
    }
}