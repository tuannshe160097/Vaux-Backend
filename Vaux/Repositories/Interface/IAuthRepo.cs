using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IAuthRepo
    {
        public string GenerateJWT(int id);
        public void GenerateAndSendOtp(int id);
        public bool CheckOtp(int id, string otp);
        public string GenerateJWTAdmin(int id);
        public void GenerateAndSendOtpAdmin(int id);
        public bool CheckOtpAdmin(int id, string otp);
    }
}
