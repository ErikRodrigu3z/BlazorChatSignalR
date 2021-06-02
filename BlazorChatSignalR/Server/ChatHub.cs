using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatSignalR.Server
{
    public class ChatHub : Hub
    {
        public async Task Send(string text)
        {
            await Clients.All.SendAsync("RecibeMessage", text);
        }


    }
}
