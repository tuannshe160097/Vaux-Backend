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
        private IConfiguration _configuration;

        public AuthRepo(VxDbc dbc, IConfiguration config) 
        {
            _vxDbc = dbc;
            _configuration = config;
        }

        public bool CheckOtp(int id, string otp)
        {
            var u = _vxDbc.Users.FirstOrDefault(u => u.Id == id);

            return BCrypt.Net.BCrypt.Verify(otp, u.OtpHash);
        }

        public string GenerateJWT(int id)
        {
            var u = _vxDbc.Users.FirstOrDefault(u => u.Id == id);

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, u.Phone),
                new Claim(ClaimTypes.Role, u.Role.Title),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Issuer"],
                claims: claims,
                signingCredentials: credentials);

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
