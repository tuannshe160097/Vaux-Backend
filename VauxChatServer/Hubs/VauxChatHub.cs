using Vaux.Models;
using Microsoft.AspNetCore.SignalR;
using Vaux.Repositories;
using System.Linq.Expressions;
using Vaux.Repositories.Interface;
using Vaux.DTO;

namespace VauxChatServer.Hubs
{
    public class VauxChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Console.WriteLine("SignalR Connected");
            return Task.CompletedTask;
        }
        public async Task SendMessage(ChatMessageDTO message)
        {
            try
            {
                Console.WriteLine("Message Sent" + message.Content);
                await Clients.All.SendAsync("ReceiveVauxMessage", message);
                //await Clients.Users(message.Receivername,message.Sendername).SendAsync("ReceiveKaraMessage",message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to send message" + ex.StackTrace, "An error occurred");
            }
        }
    }
}
