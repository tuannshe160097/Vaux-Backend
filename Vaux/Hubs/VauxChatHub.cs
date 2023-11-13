using Vaux.Models;
using Microsoft.AspNetCore.SignalR;
using Vaux.Repositories;
using System.Linq.Expressions;
using Vaux.Repositories.Interface;
using Vaux.DTO;
using Vaux.DbContext;

namespace Vaux.Hubs
{
    public class VauxChatHub : Hub
    {
        private VxDbc _context;
        public VauxChatHub (VxDbc VxDbc)
        {
            _context = VxDbc;
        }
        public override Task OnConnectedAsync()
        {
            Console.WriteLine("SignalR Connected");
            return Task.CompletedTask;
        }
        public void JoinRoom(string roomName, int itemId)
        {
            var item = _context.Items.FirstOrDefault(e => e.Id == itemId);
            //var accessToken = Context.GetHttpContext().Request.Query["access_token"];
            Groups.AddToGroupAsync(Context.ConnectionId, roomName);
            Console.WriteLine("Joined group: " + roomName + "\n"
                              +"Item name: " + item.Name + "\n");
        }

        public Task LeaveRoom(string roomName)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        }
    }
}
