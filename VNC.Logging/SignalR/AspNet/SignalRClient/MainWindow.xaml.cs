﻿using System;
using System.Net.Http;
using System.Threading;
using System.Windows;
using Microsoft.AspNet.SignalR.Client;

using VNC;

namespace SignalRClient
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
        public IHubProxy HubProxy { get; set; }
        const string ServerURI = "http://localhost:8095/signalr";
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
                HubProxy.Invoke("SendUserMessage", UserName, TextBoxMessage.Text);
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
                HubProxy.Invoke("SendMessage", TextBoxMessage.Text);
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
                HubProxy.Invoke("SendPriorityMessage", TextBoxMessage.Text, Int32.Parse(Priority.Text));
                TextBoxMessage.Text = String.Empty;
                TextBoxMessage.Focus();
            }
            catch (Exception ex)
            {
                
            }
        }

        /// <summary>
        /// Creates and connects the hub connection and hub proxy. This method
        /// is called asynchronously from SignInButton_Click.
        /// </summary>
        private async void ConnectAsync()
        {
            Connection = new HubConnection(ServerURI);
            Connection.Closed += Connection_Closed;
            HubProxy = Connection.CreateHubProxy("SignalRHub");

            //Handle incoming event from server: use Invoke to write to console from SignalR's thread

            HubProxy.On<string>("AddMessage", (message) =>
                this.Dispatcher.Invoke(() =>
                    RichTextBoxConsole.AppendText(String.Format("{0}\r", message))
                )
            );

            HubProxy.On<string, string>("AddUserMessage", (name, message) =>
                this.Dispatcher.Invoke(() =>
                    RichTextBoxConsole.AppendText(String.Format("{0}: {1}\r", name, message))
                )
            );

            HubProxy.On<string, Int32>("AddPriorityMessage", (message, priority) =>
                this.Dispatcher.Invoke(() =>
                    RichTextBoxConsole.AppendText($"P{priority}: {message}\r")
                )
            );

            try
            {
                await Connection.Start();
            }
            catch (HttpRequestException)
            {
                StatusText.Content = "Unable to connect to server: Start server before connecting clients.";
                //No connection: Don't enable Send button or show chat UI
                return;
            }

            //Show chat UI; hide login UI

            SignInPanel.Visibility = Visibility.Collapsed;
            ChatPanel.Visibility = Visibility.Visible;

            ButtonSend.IsEnabled = true;
            ButtonSendAnoymous.IsEnabled = true;
            ButtonSendPriority.IsEnabled = true;

            TextBoxMessage.Focus();

            RichTextBoxConsole.AppendText("Connected to server at " + ServerURI + "\r");
        }

        /// <summary>
        /// If the server is stopped, the connection will time out after 30 seconds (default), and the 
        /// Closed event will fire.
        /// </summary>
        void Connection_Closed()
        {
            //Hide chat UI; show login UI
            var dispatcher = Application.Current.Dispatcher;
            dispatcher.Invoke(() => ChatPanel.Visibility = Visibility.Collapsed);
            dispatcher.Invoke(() => ButtonSend.IsEnabled = false);
            dispatcher.Invoke(() => StatusText.Content = "You have been disconnected.");
            dispatcher.Invoke(() => SignInPanel.Visibility = Visibility.Visible);
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            UserName = UserNameTextBox.Text;
            //Connect to server (use async method to avoid blocking UI thread)
            if (!String.IsNullOrEmpty(UserName))
            {     
                StatusText.Visibility = Visibility.Visible;
                StatusText.Content = "Connecting to server...";

                ConnectAsync();
            }
        }

        private void WPFClient_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Connection != null)
            {
                Connection.Stop();
                Connection.Dispose();
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
    }
}
