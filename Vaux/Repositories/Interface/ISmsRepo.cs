namespace Vaux.Repositories.Interface
{
    public interface ISmsRepo
    {
        public void SendSms(string phone, string content);
    }
}
