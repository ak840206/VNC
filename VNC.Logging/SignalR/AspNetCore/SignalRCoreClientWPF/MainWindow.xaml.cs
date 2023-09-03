﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

using Microsoft.AspNetCore.SignalR.Client;

using SignalRCoreServerHubWPF;

using VNC;

namespace SignalRCoreClientWPF
{
    /// <summary>
    /// SignalR client hosted in a WPF application. The client
    /// lets the user pick a user name, connect to the server asynchronously
    /// to not block the UI thread, and send chat messages to all connected 
    /// clients whether they are hosted in WinForms, WPF, or a web application.
    /// For simplicity, MVVM will not be used for this sample.
    /// </summary>
    public partial class MainWindow : Window
    {
        const string LOG_APPNAME = "SIMPLE";

        /// <summary>
        /// This name is simply added to sent messages to identify the user; this 
        /// sample does not include authentication.
        /// </summary>
        public String UserName { get; set; }

        // NOTE(crhodes)
        // This is gone in Asp.Net Core SignalR

        //public IHubProxy HubProxy { get; set; }
        //const string ServerURI = "https://localhost:5001/chatHub";
        const string ServerURI = "http://localhost:58195/signalR";
        public HubConnection Connection { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            tbServerURI.Text = ServerURI;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
                    Connection.InvokeAsync("SendUserMessage", UserName, TextBoxMessage.Text);
                }
                
                TextBoxMessage.Text = String.Empty;
                TextBoxMessage.Focus();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnSendAnoymous_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
                    Connection.InvokeAsync("SendMessage", TextBoxMessage.Text);
                }

                TextBoxMessage.Text = String.Empty;
                TextBoxMessage.Focus();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnSendPriority_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
                    Connection.InvokeAsync("SendPriorityMessage", TextBoxMessage.Text, Int32.Parse(Priority.Text));
                }
                
                TextBoxMessage.Text = String.Empty;
                TextBoxMessage.Focus();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSendTimed_Click(object sender, RoutedEventArgs e)
        {
            SignalRTime signalRTime = new SignalRTime();
            signalRTime.SendTime = 1;
            signalRTime.HubReceivedTime = 2;
            signalRTime.ClientReceivedTime = 3;
            signalRTime.ClientMessageTime = 4;

            try
            {
                Connection.InvokeAsync("SendTimedMessage", TextBoxMessage.Text, signalRTime);

                TextBoxMessage.Text = String.Empty;
                TextBoxMessage.Focus();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSendLoggingPriorities_Click(object sender, RoutedEventArgs e)
        {
             Connection.InvokeAsync("SendPriorityMessage", "Error", -1);

            for (int i = 0; i < 5; i++)
            {
                 Connection.InvokeAsync("SendPriorityMessage", $"Info{i}", i);
            }

            for (int i = 1000; i < 1005; i++)
            {
                 Connection.InvokeAsync("SendPriorityMessage", $"Debug{i}", i);
            }

            for (int i = 9000; i < 9020; i++)
            {
                 Connection.InvokeAsync("SendPriorityMessage", $"Arch{i}", i);
            }

            for (int i = 10000; i < 10030; i++)
            {
                Connection.InvokeAsync("SendPriorityMessage", $"Trace{i}", i);
            }
        }

        /// <summary>
        /// Creates and connects the hub connection and hub proxy. This method
        /// is called asynchronously from SignInButton_Click.
        /// Use async to avoid blocking UI
        /// </summary>
        private async void ConnectAsync()
        {
            Connection = new HubConnectionBuilder()
                .WithUrl(tbServerURI.Text)
                .Build();

            Connection.Closed += Connection_Closed;
            Connection.Reconnecting += Connection_Reconnecting;
            Connection.Reconnected += Connection_Reconnected;

            //Handle incoming event from server: use Invoke to write to console from SignalR's thread

            Connection.On<string>("AddMessage", (message) =>
                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText($"{message}\r")
                )
            );

            Connection.On<string, string>("AddUserMessage", (name, message) =>
                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText($"{name}: {message}\r")
                )
            );

            Connection.On<string, Int32>("AddPriorityMessage", (message, priority) =>
                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText($"P{priority}: {message}\r")
                )
            );

            Connection.On<string, SignalRTime>("AddTimedMessage", (message, signalrtime) =>
                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText($"Send:{signalrtime.SendTime} HubR:{signalrtime.HubReceivedTime} ClientR:{signalrtime.ClientReceivedTime} ClientM:{signalrtime.ClientMessageTime} : {message}\r")
                )
            );

            try
            {
                await Connection.StartAsync();
            }
            catch (HttpRequestException hre)
            {
                Status.Text = $"Unable to connect to server: Start server before connecting clients. {hre.Message}";
                //No connection: Don't enable Send button or show chat UI
                return;
            }
            catch (Exception ex)
            {
                Status.Text = $"Unable to connect to server, ex: {ex.Message}";
                //No connection: Don't enable Send button or show chat UI
                return;
            }

            //Show chat UI; hide login UI

            //SignInPanel.Visibility = Visibility.Collapsed;
            //ChatPanel.Visibility = Visibility.Visible;

            ButtonSend.IsEnabled = true;
            ButtonSendAnoymous.IsEnabled = true;
            ButtonSendPriority.IsEnabled = true;
            ButtonSendTimed.IsEnabled = true;
            ButtonLoggingPriorities.IsEnabled = true;

            TextBoxMessage.Focus();

            rtbConsole.AppendText("Connected to server at " + ServerURI + "\r");
            Status.Text = $"Connected to server at {ServerURI}";
        }

        private Task Connection_Reconnecting(Exception? arg)
        {
            var dispatcher = Application.Current.Dispatcher;
            dispatcher.InvokeAsync(() => StatusText.Text = $"Reconnecting {(arg is null ? "" : arg.Message)}.");

            return null;
        }

        private Task Connection_Reconnected(string? arg)
        {
            var dispatcher = Application.Current.Dispatcher;
            dispatcher.InvokeAsync(() => StatusText.Text = $"Reconnected {arg}");

            return null;
        }

        /// <summary>
        /// If the server is stopped, the connection will time out after 30 seconds (default), 
        /// and the Closed event will fire.
        /// </summary>
        Task Connection_Closed(Exception? arg)
        {
            //Hide chat UI; show login UI
            var dispatcher = Application.Current.Dispatcher;

            //dispatcher.InvokeAsync(() => ChatPanel.Visibility = Visibility.Collapsed);
            dispatcher.InvokeAsync(() => ButtonSend.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendAnoymous.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendPriority.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendTimed.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonLoggingPriorities.IsEnabled = false);

            dispatcher.InvokeAsync(() => Status.Text = $"Connection Closed {(arg is null ? "" : arg.Message)}.");
            //dispatcher.InvokeAsync(() => SignInPanel.Visibility = Visibility.Visible);

            return null;
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            UserName = UserNameTextBox.Text;

            if (!String.IsNullOrEmpty(UserName))
            {
                Status.Text = "Connecting to server...";

                //StatusText.Visibility = Visibility.Visible;
                //StatusText.Text = "Connecting to server...";

                ConnectAsync();

                SignInButton.IsEnabled = false;
                SignOutButton.IsEnabled = true;
            }
            else
            {
                Status.Text = "Must enter UserName";
            }
        }

        private async void WPFClient_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Connection != null)
            {
                await Connection.StopAsync();
                //Connection.Stop();
                await Connection.DisposeAsync();
                //Connection.Dispose();
            }
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            Log.Info("SignalR Delay", LOG_APPNAME, 0);
            Thread.Sleep(125);

            long startTicks;

            Log.Info("Good Everything", LOG_APPNAME, 0);
            Log.EVENT_HANDLER("High Five", LOG_APPNAME, 0);

            startTicks = Log.Trace("Start", LOG_APPNAME);

            Thread.Sleep(750);

            Log.Trace("End", LOG_APPNAME, startTicks);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            rtbConsole.Document.Blocks.Clear();
        }

        private async void SignOutButton_Click(object sender, RoutedEventArgs e)
        {
            if (Connection != null)
            {
                await Connection.StopAsync();
                //Connection.Stop();
                await Connection.DisposeAsync();
                //Connection.Dispose();

                Status.Text = "Signed out of Server";
            }

            SignOutButton.IsEnabled = false;
            SignInButton.IsEnabled = true;
        }

    }
}
