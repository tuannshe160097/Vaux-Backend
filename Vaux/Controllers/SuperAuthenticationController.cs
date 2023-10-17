using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using Vaux.DTO;
using Vaux.Repositories;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Admin/")]
    [ApiController]
    public class SuperAuthenticationController : ControllerBase
    {
        private ISuperUserRepo _superUserRepo;
        private IAuthRepo _authRepo;

        public SuperAuthenticationController(IAuthRepo authRepo, ISuperUserRepo superUserRepo)
        {
            _authRepo = authRepo;
            _superUserRepo = superUserRepo;
        }

        [HttpPost]
        [Route("SendOtp")]
        public IActionResult SendOtp(string phone)
        {
            var u = _superUserRepo.Get(phone);
            if (u == null)
            {
                return BadRequest("User not found");
            }

            if (u.Deleted != null)
            {
                return BadRequest("User banned");
            }

            _authRepo.GenerateAndSendOtpAdmin(u.Id);

            return Ok();
        }

        [HttpPost]
        [Route("VerifyOtp")]
        public IActionResult VerifyOtp(string phone, string otp)
        {
            var u = _superUserRepo.Get(phone);

            if (u == null)
            {
                return BadRequest("User not found");
            }

            if (u.OtpExpiry < DateTime.Now)
            {
                return BadRequest("OTP has expired");
            }

            if (!_authRepo.CheckOtpAdmin(u.Id, otp))
            {
                return BadRequest("Wrong OTP");
            }

            return Ok(_authRepo.GenerateJWTAdmin(u.Id));
        }

        [HttpPost]
        [Route("CreateAdmin")]
        public IActionResult CreateAdmin(AdminCreateDTO adminDTO)
        {
            if (_superUserRepo.Get(adminDTO.Phone) != null)
            {
                return BadRequest("User already exists");
            }

            var res = _superUserRepo.CreateModerator(adminDTO);

            return Ok(res);
        }
    }
}
