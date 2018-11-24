﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace NotificationPoc
{
    public class NotificationHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("Notification", user, message);
        }
    }
}
