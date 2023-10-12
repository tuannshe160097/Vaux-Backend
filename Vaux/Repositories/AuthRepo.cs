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

            return BCrypt.Net.BCrypt.Verify(otp, u.OtpHash);
        }

        public string GenerateJWT(int id)
        {
            var u = _vxDbc.Users.FirstOrDefault(u => u.Id == id);

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, u.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, u.Phone),
                new Claim(ClaimTypes.Name, u.Name),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, u.Role.Title),
            };

            var key = Encoding.UTF8.GetBytes(_config["JWT:Secret"]);

            var token = new JwtSecurityToken(
                issuer: _config["JWT:Issuer"],
                audience: _config["JWT:Audience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
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
    }
}
