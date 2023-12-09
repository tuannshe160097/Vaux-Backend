using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthRepo _authRepo;
        private readonly IUserRepo _userRepo;

        public AuthenticationController(IAuthRepo authRepo, IUserRepo userRepo)
        {
            _authRepo = authRepo;
            _userRepo = userRepo;
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(UserMinimalNonOptionalDTO user)
        {
            var u = _userRepo.Get<User>(e => e.Phone == user.Phone);
            if (u != null && u.IsVerified)
            {
                return BadRequest("Tài khoản đã tồn tại!");
            }

            if (u != null)
            {
                _userRepo.DeletePerma<User>(e => e.Id == u.Id);
            }

            var res = _userRepo.Create<User, UserMinimalNonOptionalDTO>(user);
            _authRepo.GenerateAndSendOtp(res.Id);

            return Ok();
        }

        [HttpPost]
        [Route("SendOtp")]
        public IActionResult SendOtp(string phone)
        {
            var u = _userRepo.Get<User>(e => e.Phone == phone);
            if (u == null)
            {
                return BadRequest("Tài khoản không tồn tại!");
            }

            if (u.Deleted != null)
            {
                return BadRequest("Tài khoản đã bị cấm!");
            }

            _authRepo.GenerateAndSendOtp(u.Id);

            return Ok();
        }

        [HttpPost]
        [Route("VerifyOtp")]
        public IActionResult VerifyOtp(string phone, string otp)
        {
            var u = _userRepo.Get<User>(e => e.Phone == phone);

            if (u == null)
            {
                return BadRequest("Tài khoản không tồn tại!");
            }

            if (u.OtpExpiry < DateTime.Now)
            {
                return BadRequest("OTP đã hết hạn!");
            }

            if (!_authRepo.CheckOtp(u.Id, otp))
            {
                return BadRequest("OTP không hợp lệ!");
            }

            if (!u.IsVerified)
            {
                _userRepo.VerifyAccount(u.Id);
            }

            var res = new AuthorizationDTO
            {
                JWT = _authRepo.GenerateJWT(u.Id),
                User = _userRepo.Map<UserOutDTO>(u),
                Role = u.Role
            };
            return Ok(res);
        }

        [HttpGet]
        [Authorize]
        [Route("RefreshToken")]
        public IActionResult RefreshToken()
        {
            var u = _userRepo.Get<User>(e => e.Id == int.Parse(User.Identity!.Name!));

            var res = new AuthorizationDTO
            {
                JWT = _authRepo.GenerateJWT(u!.Id),
                User = _userRepo.Map<UserOutDTO>(u),
                Role = u.Role
            };
            return Ok(res);
        }
    }
}
