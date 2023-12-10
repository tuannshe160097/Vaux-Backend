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
        public SmsRepo(VxDbc vxDbc)
        {
        }

        public void SendSms(string phone, string content)
        {
            string accountSid = "ACdb5cb630bc0d972abcc437d4c3d5c161";
            string authToken = "c375876a65b4c7e24199802d94ea5e73";
            string phoneNum =  "+84" + phone.Remove(0, 1);

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: content,
                from: new Twilio.Types.PhoneNumber("+12567279723"),
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
