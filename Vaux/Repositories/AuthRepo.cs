using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Vaux.DbContext;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class AuthRepo : IAuthRepo
    {
        private VxDbc _vxDbc;
        private IConfiguration _config;

        public AuthRepo(VxDbc dbc, IConfiguration config) 
        {
            _vxDbc = dbc;
            _config = config;
        }

        public bool CheckOtp(int id, string otp)
        {
            var u = _vxDbc.Users.FirstOrDefault(u => u.Id == id);

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

            return new JwtSecurityTokenHandler().WriteToken(BuildJwt(u.Id.ToString(), u.Role.Title));
        }

        public void GenerateAndSendOtp(int id)
        {
            var u = _vxDbc.Users.FirstOrDefault(u => u.Id == id);

            Random rng = new Random();
            string otp = rng.Next(0, 1000000).ToString("D6");

            Console.WriteLine(otp);

            u.OtpHash = BCrypt.Net.BCrypt.HashPassword(otp);
            u.OtpExpiry = DateTime.Now.AddMinutes(30);

            _vxDbc.SaveChanges();
        }

        public bool CheckOtpAdmin(int id, string otp)
        {
            var u = _vxDbc.SuperUsers.FirstOrDefault(u => u.Id == id);

            var res = BCrypt.Net.BCrypt.Verify(otp, u.OtpHash);

            if (res)
            {
                u.OtpHash = null;
                u.OtpExpiry = null;

                _vxDbc.SaveChanges();
            }

            return res;
        }

        public string GenerateJWTAdmin(int id)
        {
            var u = _vxDbc.SuperUsers.FirstOrDefault(u => u.Id == id);

            return new JwtSecurityTokenHandler().WriteToken(BuildJwt(u.Id.ToString(), u.Role.Title));
        }

        public void GenerateAndSendOtpAdmin(int id)
        {
            var u = _vxDbc.SuperUsers.FirstOrDefault(u => u.Id == id);

            Random rng = new Random();
            string otp = rng.Next(0, 1000000).ToString("D6");

            Console.WriteLine(otp);

            u.OtpHash = BCrypt.Net.BCrypt.HashPassword(otp);
            u.OtpExpiry = DateTime.Now.AddMinutes(30);

            _vxDbc.SaveChanges();
        }

        private JwtSecurityToken BuildJwt(string id, string role)
        {
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, id),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, role),
            };

            var key = Encoding.UTF8.GetBytes(_config["JWT:Secret"]);

            var token = new JwtSecurityToken(
                issuer: _config["JWT:Issuer"],
                audience: _config["JWT:Audience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            );

            return token;
        }
    }
}
