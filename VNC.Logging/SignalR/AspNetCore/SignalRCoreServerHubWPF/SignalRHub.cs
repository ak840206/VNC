using System;
using System.Threading.Tasks;
using System.Windows;

using Microsoft.AspNetCore.SignalR;

namespace SignalRCoreServerHubWPF
{

    public class SignalRHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("AddMessage", message);
        }

        public async void SendPriorityMessage(string message, Int32 priority)
        {
            try
            {
                await Clients.All.SendAsync("AddPriorityMessage", message, priority);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }

        public async void SendTimedMessage(string message, SignalRTime signalRTime)
        {
            try
            {
                signalRTime.HubReceivedTime = DateTime.Now;
                signalRTime.HubReceivedTicks = 33;
                await Clients.All.SendAsync("AddTimedMessage", message, signalRTime);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }

        public async Task SendUserMessage(string userName, string message)
        {
            await Clients.All.SendAsync("AddUserMessage", userName, message);          
        }

        public override Task OnConnectedAsync()
        {
            //Use Application.Current.Dispatcher to access UI thread from outside the MainWindow class
            Application.Current.Dispatcher.Invoke(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole("Client connected: " + Context.ConnectionId));

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            //Use Application.Current.Dispatcher to access UI thread from outside the MainWindow class
            Application.Current?.Dispatcher.Invoke(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole("Client disconnected: " + Context.ConnectionId));

            return base.OnDisconnectedAsync(exception);
        }
    }
}
