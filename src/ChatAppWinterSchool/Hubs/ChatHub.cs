using Microsoft.AspNetCore.SignalR;

namespace ChatAppWinterSchool.Hubs
{
    public class ChatHub : Hub
    {
        public ChatHub(IChatSystemStore iChatSystemStore)
            : base()
        {

        }

    }
}
