﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("/api/Profile")]
    [Authorize]
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
        public IActionResult UpdateProfile(UserMinimalDTO profile)
        {
            var u = _userRepo.Get(int.Parse(User.Identity.Name));
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

            _userRepo.Update(u.Id, profile);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = "EXPERT,ADMIN,MODERATOR")]
        [Route("/api/Mod/Profile")]
        public IActionResult UpdateProfile(UserStrictDTO profile)
        {
            var u = _userRepo.Get(int.Parse(User.Identity.Name));
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

            _userRepo.Update(u.Id, profile);
            return Ok();
        }
    }
}