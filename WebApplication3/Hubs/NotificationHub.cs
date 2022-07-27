using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Hubs
{
    public class NotificationHub : Hub
    {
      
        public override Task OnConnectedAsync()
        {
            ConnectedUser.Ids.Add(Context.ConnectionId);
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            ConnectedUser.Ids.Remove(Context.ConnectionId);

            return base.OnDisconnectedAsync(exception);
        }
    }
}
