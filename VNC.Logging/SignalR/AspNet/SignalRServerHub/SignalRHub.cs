using Microsoft.AspNet.SignalR;

using System;
using System.Threading.Tasks;
using System.Windows;

namespace SignalRServerHub
{
    /// <summary>
    /// Echoes messages sent using the Send message by calling the
    /// addMessage method on the client. Also reports to the console
    /// when clients connect and disconnect.
    /// </summary>
    public class SignalRHub : Hub
    {
        public void SendMessage(string message)
        {
            Clients.All.addMessage(message);
        }

        public void SendPriorityMessage(string message, Int32 priority)
        {
            Clients.All.addPriorityMessage(message, priority);
        }

        public void SendUserMessage(string name, string message)
        {
            Clients.All.addUserMessage(name, message);
        }

        public override Task OnConnected()
        {
            //Use Application.Current.Dispatcher to access UI thread from outside the MainWindow class
            Application.Current.dispatcher.InvokeAsync(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole("Client connected: " + Context.ConnectionId));

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            //Use Application.Current.Dispatcher to access UI thread from outside the MainWindow class
            Application.Current.dispatcher.InvokeAsync(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole("Client disconnected: " + Context.ConnectionId));

            return base.OnDisconnected(stopCalled);
        }
        //public override Task OnDisconnected()
        //{


        //    return base.OnDisconnected();
        //}

    }
}
