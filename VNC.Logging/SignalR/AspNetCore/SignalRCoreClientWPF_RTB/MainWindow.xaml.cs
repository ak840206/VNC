using System;
using System.Drawing;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Threading;

using Microsoft.AspNetCore.SignalR.Client;

using VNC;

namespace SignalRCoreClientWPF_RTB
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

        private async void btnSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await Connection.InvokeAsync("SendUserMessage", UserName, TextBoxMessage.Text);
                TextBoxMessage.Text = String.Empty;
                TextBoxMessage.Focus();
            }
            catch (Exception ex)
            {
                
            }
        }

        private async void btnSendAnoymous_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await Connection.InvokeAsync("SendMessage", TextBoxMessage.Text);
                TextBoxMessage.Text = String.Empty;
                TextBoxMessage.Focus();
            }
            catch (Exception ex)
            {
                
            }
        }

        private async void btnSendPriority_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await Connection.InvokeAsync("SendPriorityMessage", TextBoxMessage.Text, Int32.Parse(Priority.Text));
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

            //Connection.On<string, Int32>("AddPriorityMessage", (message, priority) =>
            //    this.Dispatcher.InvokeAsync(() =>
            //        rtbConsole.AppendText($"P{priority}: {message}\r")
            //    )
            //);

            //Connection.On<string, Int32>("AddPriorityMessage", (message, priority) =>
            //    this.Dispatcher.InvokeAsync(() =>
            //       AppendColorText($"P{priority}: {message}\r", System.Windows.Media.Color.FromArgb(255, 255, 40, 60))
            //       )
            //);

            Connection.On<string, Int32>("AddPriorityMessage", (message, priority) =>
            {
                switch (priority)
                {
                    case 0: // Black
                        AppendColorText($"P{priority}: {message}\r", System.Windows.Media.Color.FromArgb(255, 0, 0,0));
                        break;

                    case 1: // Red
                        AppendColorText($"P{priority}: {message}\r", System.Windows.Media.Color.FromArgb(255, 255, 40, 60));
                        break;

                    case 2: // Green
                        AppendColorText($"P{priority}: {message}\r", System.Windows.Media.Color.FromArgb(255, 0, 255, 0));
                        break;

                    case 3: // Blue
                        ColorFormatMessageAndAppend($"P{priority}: {message}\r", System.Drawing.Color.Lavender);
                        break;

                    case 100:
                        ColorFormatMessageAndAppend($"P{priority}: {message}\r", System.Drawing.Color.LightBlue);
                        break;

                    case 10011:
                        ColorFormatMessageAndAppend($"P{priority}: {message}\r", System.Drawing.Color.Orange);
                        break;

                    default:
                        AppendColorText($"P{priority}: {message}\r", System.Drawing.Color.Pink);
                        break;
                }

            }
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

            TextBoxMessage.Focus();

            rtbConsole.AppendText("Connected to server at " + ServerURI + "\r");
            Status.Text = $"Connected to server at {ServerURI}";
        }

        private void ColorFormatMessageAndAppend(string formattedMessage, System.Drawing.Color color)
        {
            int messageIndex = 0;

            messageIndex = GetNthIndex2(formattedMessage, '|', 3);
            try
            {
                if (messageIndex++ > 0)
                {
                    string prefixMessage = formattedMessage.Substring(0, messageIndex);
                    AppendColorText(prefixMessage, System.Drawing.Color.Black);

                    string colorMessage = formattedMessage.Substring(messageIndex);
                    AppendColorText(colorMessage, color);
                }
                else
                {
                    AppendColorText(formattedMessage, color);
                }
            }
            catch (Exception ex)
            {
                AppendColorText(ex.ToString(), System.Drawing.Color.Red);
            }

            //return displayMessage;
        }

        private int GetNthIndex(string s, char c, int n)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    count++;
                    if (count == n)
                    {
                        return i;
                    }
                }
            }
            return -1;
            // = s.TakeWhile(c => n -= (c == t ? 1 : 0)) > 0).Count();
        }



        private int GetNthIndex2(string s, char c, int n)
        {
            var idx = s.IndexOf(c, 0);

            while(idx >=0 && --n > 0)
            { 
                idx = s.IndexOf(c, idx + 1);
            }

            return idx;
        }

        private void AppendColorText(string message, System.Windows.Media.Color color)
        {
            //BrushConverter bc = new BrushConverter();
            //Brush newBrush = (Brush)bc.ConvertFrom(color);
            SolidColorBrush newBrush = new SolidColorBrush(color);

            TextRange tr = new TextRange(rtbConsole.Document.ContentEnd, rtbConsole.Document.ContentEnd);
            tr.Text = message;
            tr.ApplyPropertyValue(TextElement.ForegroundProperty, newBrush);

            //rtbConsole.AppendText(message);   
        }

        private void AppendColorText(string message, System.Drawing.Color color)
        {
            //BrushConverter bc = new BrushConverter();
            //Brush newBrush = (Brush)bc.ConvertFrom(color);
            SolidColorBrush newBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B));

            TextRange tr = new TextRange(rtbConsole.Document.ContentEnd, rtbConsole.Document.ContentEnd);
            tr.Text = message;
            tr.ApplyPropertyValue(TextElement.ForegroundProperty, newBrush);

            //rtbConsole.AppendText(message);   
        }

        private Task? Connection_Reconnecting(Exception? arg)
        {
            var dispatcher = Application.Current.Dispatcher;
            dispatcher.InvokeAsync(() => StatusText.Text = $"Reconnecting {(arg is null ? "" : arg.Message)}.");

            return null;
        }

        private Task? Connection_Reconnected(string? arg)
        {
            var dispatcher = Application.Current.Dispatcher;
            dispatcher.InvokeAsync(() => StatusText.Text = $"Reconnected {arg}");

            return null;
        }

        /// <summary>
        /// If the server is stopped, the connection will time out after 30 seconds (default), 
        /// and the Closed event will fire.
        /// </summary>
        Task? Connection_Closed(Exception? arg)
        {
            //Hide chat UI; show login UI
            var dispatcher = Application.Current.Dispatcher;

            //dispatcher.InvokeAsync(() => ChatPanel.Visibility = Visibility.Collapsed);
            dispatcher.InvokeAsync(() => ButtonSend.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendAnoymous.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendPriority.IsEnabled = false);

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
