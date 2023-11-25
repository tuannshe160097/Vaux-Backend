namespace Vaux.Repositories.Interface
{
    public interface IEmailRepo
    {
        public void SendEmail(string to, string subject, string body);
    }
}
