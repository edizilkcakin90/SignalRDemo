using Microsoft.AspNetCore.SignalR;
using SignalRDemo.Models;
using System.Threading.Tasks;

namespace SignalRDemo.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) =>
            
            await Clients.All.SendAsync("receiveMessage", message);
    }
}
