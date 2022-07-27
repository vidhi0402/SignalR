using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Hubs
{
    public class MyHub : Hub
    {
        public static void NotifyClientsAsync()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
            context.Clients.All.updatedClients();
        }
    }
}