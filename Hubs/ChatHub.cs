using api_chatroom.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace api_chatroom.Hubs {
    public class ChatHub : Hub {
        public async Task SendMessage(Message message) {
            await Clients.All.SendAsync("NewMessage", message);
        }
    }
}
