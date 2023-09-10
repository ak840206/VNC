using System;
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

        /// <summary>
        /// This name is simply added to sent messages to identify the user; this 
        /// sample does not include authentication.
        /// </summary>
        public String UserName { get; set; }
        public IHubProxy HubProxy { get; set; }
        const string ServerURI = "http://localhost:58095/signalr";
        public HubConnection Connection { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            tbServerURI.Text = ServerURI;
        }

        public string RuntimeVersion { get => Common.RuntimeVersion; }
        public string FileVersion { get => Common.FileVersion; }
        public string ProductVersion { get => Common.ProductVersion; }
        public string ProductName { get => Common.ProductName; }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string message = TextBoxMessage.Text;

                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
                    HubProxy.Invoke("SendUserMessage", UserName, message);
                }                

                if ((bool)cbClearMessage.IsChecked)
                {
                    TextBoxMessage.Text = String.Empty;
                    TextBoxMessage.Focus();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, Common.LOG_CATEGORY);
            }
        }

        private void btnSendAnoymous_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string message = TextBoxMessage.Text;

                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
                    HubProxy.Invoke("SendMessage", message);
                }

                if ((bool)cbClearMessage.IsChecked)
                {
                    TextBoxMessage.Text = String.Empty;
                    TextBoxMessage.Focus();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, Common.LOG_CATEGORY);
            }
        }

        private void btnSendPriority_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string message = TextBoxMessage.Text;
                Int32 priority = Int32.Parse(Priority.Text);

                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
                    HubProxy.Invoke("SendPriorityMessage", message, priority);
                }

                if ((bool)cbClearMessage.IsChecked)
                {
                    TextBoxMessage.Text = String.Empty;
                    TextBoxMessage.Focus();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, Common.LOG_CATEGORY);
            }
        }

        /// <summary>
        /// Creates and connects the hub connection and hub proxy. This method
        /// is called asynchronously from SignInButton_Click.
        /// </summary>
        private async void ConnectAsync()
        {
            Connection = new HubConnection(tbServerURI.Text);
            Connection.Closed += Connection_Closed;
            HubProxy = Connection.CreateHubProxy("SignalRHub");

            //Handle incoming event from server: use Invoke to write to console from SignalR's thread

            HubProxy.On<string>("AddMessage", (message) =>
                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText(String.Format("{0}\r", message))
                )
            );

            HubProxy.On<string, string>("AddUserMessage", (name, message) =>
                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText(String.Format("{0}: {1}\r", name, message))
                )
            );

            HubProxy.On<string, Int32>("AddPriorityMessage", (message, priority) =>
                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText($"P{priority}: {message}\r")
                )
            );

            try
            {
                await Connection.Start();
            }
            catch (HttpRequestException hre)
            {
                rtbConsole.AppendText($"Unable to connect to server: Start server before connecting clients. {hre.Message}");
                //No connection: Don't enable Send button or show chat UI
                return;
            }
            catch (Exception ex)
            {
                rtbConsole.AppendText($"Unable to connect to server, ex: {ex.Message}");
                //No connection: Don't enable Send button or show chat UI
                return;
            }

            ButtonSend.IsEnabled = true;
            ButtonSendTimed.IsEnabled = true;
            ButtonSendAnnoymous.IsEnabled = true;
            ButtonSendPriority.IsEnabled = true;
            ButtonSendPriorityTimed.IsEnabled = true;
            ButtonLoggingPriorities.IsEnabled = true;

            rtbConsole.AppendText("Connected to server at " + tbServerURI.Text + "\r");
        }

        /// <summary>
        /// If the server is stopped, the connection will time out after 30 seconds (default), and the 
        /// Closed event will fire.
        /// </summary>
        void Connection_Closed()
        {
            var dispatcher = Application.Current.Dispatcher;

            //dispatcher.InvokeAsync(() => ChatPanel.Visibility = Visibility.Collapsed);
            dispatcher.InvokeAsync(() => ButtonSend.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendTimed.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendAnnoymous.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendPriority.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendPriorityTimed.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonLoggingPriorities.IsEnabled = false);

            dispatcher.InvokeAsync(() => rtbConsole.AppendText($"Connection Closed {(arg is null ? "" : arg.Message)}."));
            //dispatcher.InvokeAsync(() => SignInPanel.Visibility = Visibility.Visible);

            //return null;
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            UserName = UserNameTextBox.Text;

            if (!String.IsNullOrEmpty(UserName))
            {
                rtbConsole.AppendText("Connecting to server...");

                ConnectAsync();

                SignInButton.IsEnabled = false;
                SignOutButton.IsEnabled = true;
            }
            else
            {
                rtbConsole.AppendText("Must enter UserName");
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            rtbConsole.Document.Blocks.Clear();
        }

        private void SignOutButton_Click(object sender, RoutedEventArgs e)
        {
            if (Connection != null)
            {
                Connection.Stop();
                Connection.Dispose();

                rtbConsole.AppendText("Signed out of ServerHub");
            }

            SignOutButton.IsEnabled = false;
            SignInButton.IsEnabled = true;
        }
    }
}
