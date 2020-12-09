using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace QuizAppGameApi.Hubs
{
    public class GameHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
