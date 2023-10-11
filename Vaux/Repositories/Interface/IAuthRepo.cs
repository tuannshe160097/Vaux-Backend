using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IAuthRepo
    {
        public string GenerateJWT(int id);
        public void GenerateAndSendOtp(int id);
        public bool CheckOtp(int id, string otp);
    }
}
