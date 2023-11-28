﻿using Microsoft.AspNetCore.Authorization;
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
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        private readonly IUserRepo _userRepo;

        public UserManagementController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        [Route("/api/Mod/Account")]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        [AllowAnonymous]
        public IActionResult GetAll(int pageNum = 1, int pageSize = -1, string? search = null, int? role = null, bool? banned = null)
        {
            var query = _userRepo.Query();
            query.OrderByDescending(e => e.Id);
            if (search != null)
            {
                query = query.Where(e => e.Email!.Contains(search) || e.Name.Contains(search) || e.Phone.Contains(search));
            }
            if (role != null)
            {
                query = query.Where(e => e.RoleId == role);
            }
            if (banned != null)
            {
                if (banned == true)
                {
                    query = query.Where(e => e.Deleted != null);
                }
                else
                {
                    query = query.Where(e => e.Deleted == null);
                }
            }
            return Ok(_userRepo.WrapListResult<UserOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
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
        [Authorize(Roles = nameof(RoleId.ADMIN))]
        public IActionResult Update(int id, [FromBody] UserStrictDTO profile)
        {
            var u = _userRepo.Get<User>(e => e.Id == id);
            if (u == null)
            {
                return BadRequest("Tài khoản không tồn tại!");
            }
            if (u.Phone != profile.Phone && _userRepo.Get<User>(e => e.Phone == profile.Phone) != null)
            {
                return BadRequest("Số điện thoại đã được sử dụng!");
            }
            if (u.Email != profile.Email && _userRepo.Get<User>(e => e.Email == profile.Email) != null)
            {
                return BadRequest("Email đã được sử dụng!");
            }

            var res = _userRepo.Update<User, UserStrictDTO>(e => e.Id == id, profile);
            return Ok(res);
        }

        [HttpPatch]
        [Route("/api/Mod/Account/ChangeAccess/{id}")]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult ChangeAccess(int id)
        {
            var u = _userRepo.Get<User>(e => e.Id == id);
            var user = _userRepo.Get<User>(e => e.Id.ToString() == User.Identity!.Name);
            if (u == null)
            {
                return BadRequest("Tài khoản không tồn tại!");
            }
            if (user?.RoleId != (int)RoleId.ADMIN && (u.RoleId == (int)RoleId.ADMIN || u.RoleId == (int)RoleId.MODERATOR))
            {
                return Forbid();
            }

            _userRepo.ChangeAccess(id);

            return Ok();
        }

        [HttpPatch]
        [Route("ChangeAccess/{id}")]
        [Authorize(Roles = nameof(RoleId.ADMIN))]
        public IActionResult AdminChangeAccess(int id)
        {
            var u = _userRepo.Get<User>(e => e.Id == id);
            if (u == null)
            {
                return BadRequest("Tài khoản không tồn tại!");
            }
            _userRepo.ChangeAccess(id);

            return Ok();
        }

        [HttpPost]
        [Route("CreateModerator")]
        [Authorize(Roles = nameof(RoleId.ADMIN))]
        public IActionResult CreateMod(UserStrictDTO superUser)
        {
            if (_userRepo.Get<User>(e => e.Phone == superUser.Phone || e.Email == superUser.Email) != null)
            {
                return BadRequest("Tài khoản không tồn tại!");
            }

            var res = _userRepo.Create<User>(superUser, RoleId.MODERATOR);

            return Ok(res);
        }

        [HttpPost]
        [Route("/api/Mod/Account/CreateExpert")]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult CreateExpert(UserStrictDTO superUser)
        {
            if (_userRepo.Get<User>(e => e.Phone == superUser.Phone || e.Email == superUser.Email) != null)
            {
                return BadRequest("Tài khoản không tồn tại!");
            }

            var res = _userRepo.Create<User>(superUser, RoleId.EXPERT);

            return Ok(res);
        }
    }
}
