using GoogleReCaptcha.V3.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using Vaux.DTO;
using Vaux.DTO.In;
using Vaux.DTO.Out;
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
        private readonly ICaptchaValidator _captchaValidator;

        public AuthenticationController(IAuthRepo authRepo, IUserRepo userRepo, ICaptchaValidator captchaValidator)
        {
            _authRepo = authRepo;
            _userRepo = userRepo;
            _captchaValidator = captchaValidator;
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
        public IActionResult SendOtp(SendOTPDTO sendOTPDTO)
        {
            if (!_captchaValidator.IsCaptchaPassedAsync(sendOTPDTO.ReCaptcha).Result)
            {
                return BadRequest("Lỗi ReCaptcha");
            }

            var u = _userRepo.Get<User>(e => e.Phone == sendOTPDTO.Phone);
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
        public IActionResult VerifyOtp(VerifyOTPDTO verifyOTPDTO)
        {
            var u = _userRepo.Get<User>(e => e.Phone == verifyOTPDTO.Phone);

            if (u == null)
            {
                return BadRequest("Tài khoản không tồn tại!");
            }

            if (u.OtpExpiry < DateTime.Now)
            {
                return BadRequest("OTP đã hết hạn!");
            }

            if (!_authRepo.CheckOtp(u.Id, verifyOTPDTO.Otp))
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
                User = _userRepo.Map<UserOutMinimalDTO>(u),
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
                User = _userRepo.Map<UserOutMinimalDTO>(u),
                Role = u.Role
            };
            return Ok(res);
        }
    }
}
