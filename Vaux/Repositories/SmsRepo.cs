using System.Net;
using System.Text.RegularExpressions;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Vaux.DbContext;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class SmsRepo : ISmsRepo
    {
        private readonly IConfiguration _config;

        public SmsRepo(IConfiguration config)
        {
            _config = config;
        }

        public void SendSms(string phone, string content)
        {
            string accountSid = _config["Twilio:SID"]!;
            string authToken = _config["Twilio:Auth"]!;
            string phoneNum =  "+84" + phone.Remove(0, 1);

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: content,
                from: new Twilio.Types.PhoneNumber(_config["Twilio:From"]),
                to: new Twilio.Types.PhoneNumber(phoneNum)
            );

            Console.WriteLine(message.Sid + "\n" + message.Body + "\n" + phone);
        }

        public bool PhoneNumberCheck(string phone)
        {
            return Regex.IsMatch(phone, "/(84|0[3|5|7|8|9])+([0-9]{8})\b/g");
        }
    }
}
