using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
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

            return new JwtSecurityTokenHandler().WriteToken(BuildJwt(u.Id.ToString(), u.Role.Title, DateTime.Now.AddYears(1)));
        }

        public void GenerateAndSendOtp(int id)
        {
            var u = _vxDbc.Users.FirstOrDefault(u => u.Id == id);

            Random rng = new Random();
            string otp = rng.Next(0, 1000000).ToString("D6");

            string accountSid = "ACdb5cb630bc0d972abcc437d4c3d5c161";
            string authToken = "eb103e79f1c4ec2262afb4394890cf4e";
            //string phone =  "+84" + u.Phone.Remove(0, 1);

            /*            TwilioClient.Init(accountSid, authToken);

                        var message = MessageResource.Create(
                            body: otp,
                            from: new Twilio.Types.PhoneNumber("+12567279723"),
                            to: new Twilio.Types.PhoneNumber("+84858617701") //Replace with phone number when account is upgraded
                        );

                        Console.WriteLine(message.Sid + "\n" + message.Body + "\n" + phone);*/

            string number = u.Phone;
            string apiUrl = $"http://api.abenla.com/api2/SendSms?loginName=ABRR1HE&sign=610534c66912f752088903afe34ff18b&serviceTypeId=535&phoneNumber={number}&message={otp}&brandName=Verify3&callBack=false&smsGuid=1";
            Uri address = new Uri(apiUrl);

            // Create the web request
            HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;

            // Set type to POST
            request.Method = "GET";
            request.ContentType = "application/json";

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream
                StreamReader reader = new StreamReader(response.GetResponseStream());

                // Console application output
                Console.WriteLine(otp);
                string strOutputXml = reader.ReadToEnd();
                Console.WriteLine(strOutputXml);
            }

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

            return new JwtSecurityTokenHandler().WriteToken(BuildJwt(u.Id.ToString(), u.Role.Title, DateTime.Now.AddHours(1)));
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

        private JwtSecurityToken BuildJwt(string id, string role, DateTime expiry)
        {
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, id),
                new Claim(ClaimTypes.Name, id),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, role),
            };

            var key = Encoding.UTF8.GetBytes(_config["JWT:Secret"]);

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
