using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Vaux.DbContext;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class AuthRepo : IAuthRepo
    {
        private VxDbc _vxDbc;
        private IConfiguration _config;
        private ISmsRepo _smsRepo;

        public AuthRepo(VxDbc dbc, IConfiguration config, ISmsRepo smsRepo) 
        {
            _vxDbc = dbc;
            _config = config;
            _smsRepo = smsRepo;
        }

        public bool CheckOtp(int id, string otp)
        {
            var u = _vxDbc.Users.FirstOrDefault(u => u.Id == id);

            if (u == null || u.OtpHash == null)
            {
                return false;
            }

            var res = BCrypt.Net.BCrypt.Verify(otp, u.OtpHash);

            if (res)
            {
                u.OtpHash = null;
                u.OtpExpiry = null;

                _vxDbc.SaveChanges();
            }

            return res;
        }

        public string GenerateJWT(int id)
        {
            var u = _vxDbc.Users.FirstOrDefault(u => u.Id == id);
            var expiry = DateTime.Now;
            if (u.RoleId == (int)RoleId.BUYER || u.RoleId == (int)RoleId.SELLER || u.RoleId == (int)RoleId.EXPERT)
            {
                expiry = expiry.AddYears(1);
            }
            else
            {
                expiry = expiry.AddMinutes(30);
            }

            return new JwtSecurityTokenHandler().WriteToken(BuildJwt(u.Id.ToString(), u.Role.Title, expiry));
        }

        public void GenerateAndSendOtp(int id)
        {
            var u = _vxDbc.Users.FirstOrDefault(u => u.Id == id);

            Random rng = new();
            string otp = rng.Next(0, 1000000).ToString("D6");

            //_smsRepo.SendSms(u.Phone, "Otp của bạn là: " + otp);
            Console.WriteLine(otp);

            u.OtpHash = BCrypt.Net.BCrypt.HashPassword(otp);
            u.OtpExpiry = DateTime.Now.AddMinutes(30);

            _vxDbc.SaveChanges();
        }

        private JwtSecurityToken BuildJwt(string id, string role, DateTime expiry)
        {
            var authClaims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, id),
                new(ClaimTypes.Name, id),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(ClaimTypes.Role, role),
            };

            var key = Encoding.UTF8.GetBytes(_config["JWT:Secret"]!);

            var token = new JwtSecurityToken(
                issuer: _config["JWT:Issuer"],
                audience: _config["JWT:Audience"],
                expires: expiry,
                claims: authClaims,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            );

            return token;
        }
    }
}
