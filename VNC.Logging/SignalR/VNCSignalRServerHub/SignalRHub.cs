using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

#if NET48
using Microsoft.AspNet.SignalR;
#else
using Microsoft.AspNetCore.SignalR;
#endif

namespace VNCSignalRServerHub
{

    public class SignalRHub : Hub
    {
#if NET48
        public void SendMessage(string message)
        {
            Clients.All.addMessage(message);
        }
#else
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("AddMessage", message);
        }
#endif

#if NET48
        public void SendPriorityMessage(string message, Int32 priority)
        {
            Clients.All.addPriorityMessage(message, priority);
        }
#else
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
#endif

#if NET48

#else
        public async void SendTimedMessage(string message, SignalRTime signalRTime)
        {
            try
            {
                signalRTime.HubReceivedTime = DateTime.Now;
                signalRTime.HubReceivedTicks = Stopwatch.GetTimestamp();
                await Clients.All.SendAsync("AddTimedMessage", message, signalRTime);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }
#endif

#if NET48
        public void SendUserMessage(string name, string message)
        {
            Clients.All.addUserMessage(name, message);
        }
#else
        public async Task SendUserMessage(string userName, string message)
        {
            await Clients.All.SendAsync("AddUserMessage", userName, message);
        }
#endif

#if NET48
        public override Task OnConnected()
        {
            //Use Application.Current.Dispatcher to access UI thread from outside the MainWindow class
            Application.Current.Dispatcher.InvokeAsync(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole("Client connected: " + Context.ConnectionId));

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            //Use Application.Current.Dispatcher to access UI thread from outside the MainWindow class
            Application.Current.Dispatcher.InvokeAsync(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole("Client disconnected: " + Context.ConnectionId));

            return base.OnDisconnected(stopCalled);
        }
#else
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
#endif

    }
}
