using MailKit.Net.Smtp;
using MimeKit;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class EmailRepo : IEmailRepo
    {
        private readonly IConfiguration _config;
        public EmailRepo(IConfiguration configuration) 
        {
            _config = configuration;
        }

        public void SendEmail(string to, string subject, string body)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Vaux", "haipham02122002@gmail.com"));
            message.To.Add(MailboxAddress.Parse(to));
            message.Subject = subject;
            message.Body = new TextPart("plain")
            {
                Text = body
            };
            SmtpClient smtpClient = new SmtpClient();

            try
            {
                smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.AuthenticationMechanisms.Remove("NTLM");
                smtpClient.Authenticate("haipham02122002@gmail.com", _config["Email:ApplicationPass"]);
                smtpClient.Send(message);
                Console.WriteLine("Email sent");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                smtpClient.Disconnect(true);
                smtpClient.Dispose();
            }
        }
    }
}
