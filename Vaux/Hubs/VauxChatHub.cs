using Vaux.Models;
using Microsoft.AspNetCore.SignalR;
using Vaux.Repositories;
using System.Linq.Expressions;
using Vaux.Repositories.Interface;
using Vaux.DTO;
using Vaux.DbContext;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Vaux.Hubs
{
    public class VauxChatHub : Hub
    {
        private readonly VxDbc _context;
        protected readonly IHttpContextAccessor? _httpContextAccessor;
        protected readonly ClaimsPrincipal? _user;

        public VauxChatHub (VxDbc VxDbc, IHttpContextAccessor httpContextAccessor)
        {
            _context = VxDbc;
            _httpContextAccessor = httpContextAccessor;
            _user = _httpContextAccessor.HttpContext?.User;
        }

        public override Task OnConnectedAsync()
        {
            Console.WriteLine("SignalR Connected");
            return Task.CompletedTask;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public void JoinRoom(string roomName, int itemId)
        {
            var item = _context.Items.FirstOrDefault(e => e.Id == itemId);
            if(_user!.Identity!.Name == item?.SellerId.ToString() || _user.Identity.Name == item?.ExpertId.ToString())
            {
                Groups.AddToGroupAsync(Context.ConnectionId, roomName);
                Console.WriteLine("Joined group: " + roomName + "\n" + "Item name: " + item!.Name + "\n");
            }
            return;
        }

        public Task LeaveRoom(string roomName)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        }
    }
}
