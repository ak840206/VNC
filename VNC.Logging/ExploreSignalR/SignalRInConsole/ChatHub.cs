
using Microsoft.AspNetCore.SignalR;

namespace SignalRCoreServerHubConsole
{
    public class ChatHub : Hub
    {
        public async Task Send(string userName, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", userName, message);

            if (userName == "")
            {
                await Clients.All.SendAsync("AddMessage", message);
            }
            else
            {
                await Clients.All.SendAsync("AddUserMessage", userName, message);
            }
            
        }

        //public async Task AddUserMessage(string userName, string message)
        //{
        //    await Clients.All.SendAsync("AddUserMessage", userName, message);
        //    await Clients.All.SendAsync("AddMessage", message);
        //}

        //public async Task AddMessage(string message)
        //{
        //    await Clients.All.SendAsync("AddMessage", message);
        //}
    }
}
