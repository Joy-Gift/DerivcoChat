using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppWinterSchool.Hubs
{
    public class ChatHub : Hub
    {
        public ChatHub(IChatSystemStore iChatSystemStore)
            :base()
        {

        }

    }
}
