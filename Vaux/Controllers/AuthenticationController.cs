using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthRepo _authRepo;
        private IUserRepo _userRepo;

        public AuthenticationController(IAuthRepo authRepo, IUserRepo userRepo) 
        {
            _authRepo = authRepo;
            _userRepo = userRepo;
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(string name, string phone)
        {
            if (_userRepo.Get(phone) != null)
            {
                return BadRequest("User already exists");
            }

            User u = _userRepo.Create(name, phone);
            _authRepo.GenerateAndSendOtp(u.Id);

            return Ok();
        }

        [HttpPost]
        [Route("SendOtp")]
        public IActionResult SendOtp(string phone)
        {
            var u = _userRepo.Get(phone);
            if (u == null)
            {
                return BadRequest("User not found");
            }

            if (u.Deleted != null)
            {
                return BadRequest("User banned");
            }

            _authRepo.GenerateAndSendOtp(u.Id);

            return Ok();
        }

        [HttpPost]
        [Route("VerifyOtp")]
        public IActionResult VerifyOtp(string phone, string otp)
        {
            var u = _userRepo.Get(phone);

            if (u == null)
            {
                return BadRequest("User not found");
            }

            if (u.OtpExpiry < DateTime.Now)
            {
                return BadRequest("OTP has expired");
            }

            if (!_authRepo.CheckOtp(u.Id, otp))
            {
                return BadRequest("Wrong OTP");
            }

            if (!u.IsVerified)
            {
                _userRepo.VerifyAccount(u.Id);
            }

            return Ok(_authRepo.GenerateJWT(u.Id));
        }

        [HttpGet]
        [Authorize(Roles = "BUYER")]
        [Route("/protected")]
        public IActionResult Protected() 
        {
            return Ok("Authorized");
        }
    }
}
