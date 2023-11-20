using System.Net;
using System.Text.RegularExpressions;
using Vaux.DbContext;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class SmsRepo : ISmsRepo
    {
        private VxDbc _vxDbc;

        public SmsRepo(VxDbc vxDbc)
        {
            _vxDbc = vxDbc;
        }
        public void SendSms(string phone, string content)
        {
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

            string apiUrl = $"http://api.abenla.com/api2/SendSms?loginName=ABRR1HE&sign=610534c66912f752088903afe34ff18b&serviceTypeId=535&phoneNumber={phone}&message={content}&brandName=Verify3&callBack=false&smsGuid=1";
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
                Console.WriteLine(content);
                string strOutputXml = reader.ReadToEnd();
                Console.WriteLine(strOutputXml);
            }
        }

        public bool PhoneNumberCheck(string phone)
        {
            return Regex.IsMatch(phone, "/(84|0[3|5|7|8|9])+([0-9]{ 8})\b/g");
        }
    }
}
