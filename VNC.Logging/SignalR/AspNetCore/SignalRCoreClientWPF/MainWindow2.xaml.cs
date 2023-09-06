using System;
using System.Data.Common;
using System.Diagnostics;
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
    public partial class MainWindow2 : Window
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

        public MainWindow2()
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
                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
                    Connection.InvokeAsync("SendUserMessage", UserName, TextBoxMessage.Text);
                }

                if ((bool)cbClearMessage.IsChecked)
                {
                    TextBoxMessage.Text = String.Empty;
                    TextBoxMessage.Focus();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnSendTimed_Click(object sender, RoutedEventArgs e)
        {
            SignalRTime signalRTime = new SignalRTime();

            try
            {
                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
                    Connection.InvokeAsync("SendUserMessage", UserName, TextBoxMessage.Text);
                }

                Connection.InvokeAsync("SendTimedMessage", TextBoxMessage.Text, signalRTime);

                if ((bool)cbClearMessage.IsChecked)
                {
                    TextBoxMessage.Text = String.Empty;
                    TextBoxMessage.Focus();
                }
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

                if ((bool)cbClearMessage.IsChecked)
                {
                    TextBoxMessage.Text = String.Empty;
                    TextBoxMessage.Focus();
                }
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

                if ((bool)cbClearMessage.IsChecked)
                {
                    TextBoxMessage.Text = String.Empty;
                    TextBoxMessage.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSendPriorityTimed_Click(object sender, RoutedEventArgs e)
        {
            SignalRTime signalRTime = new SignalRTime();

            try
            {
                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
                    Connection.InvokeAsync("SendPriorityMessage", TextBoxMessage.Text, Int32.Parse(Priority.Text));
                }

                Connection.InvokeAsync("SendTimedMessage", TextBoxMessage.Text, signalRTime);

                if ((bool)cbClearMessage.IsChecked)
                {
                    TextBoxMessage.Text = String.Empty;
                    TextBoxMessage.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSendLoggingPriorities_Click(object sender, RoutedEventArgs e)
        {
            SignalRTime signalRTime = new SignalRTime();

            Connection.InvokeAsync("SendPriorityMessage", "Critical", -10);
            Connection.InvokeAsync("SendPriorityMessage", "Error", -1);
            Connection.InvokeAsync("SendPriorityMessage", "Warning", 1);

            for (int i = 100; i < 105; i++)
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

            Log.Error("Error", Common.LOG_CATEGORY);
            Log.Warning("Warning", Common.LOG_CATEGORY);

            Log.Info("Info", Common.LOG_CATEGORY);
            Log.Info1("Info1", Common.LOG_CATEGORY);
            Log.Info2("Info2", Common.LOG_CATEGORY);
            Log.Info3("Info3", Common.LOG_CATEGORY);
            Log.Info4("Info4", Common.LOG_CATEGORY);

            Log.Debug("Debug", Common.LOG_CATEGORY);
            Log.Debug1("Debug1", Common.LOG_CATEGORY);
            Log.Debug2("Debug2", Common.LOG_CATEGORY);
            Log.Debug3("Debug3", Common.LOG_CATEGORY);
            Log.Debug4("Debug4", Common.LOG_CATEGORY);

            Log.Arch("Arch", Common.LOG_CATEGORY);
            Log.Arch1("Arch1", Common.LOG_CATEGORY);
            Log.Arch2("Arch2", Common.LOG_CATEGORY);
            Log.Arch3("Arch3", Common.LOG_CATEGORY);
            Log.Arch4("Arch4", Common.LOG_CATEGORY);
            Log.Arch5("Arch5", Common.LOG_CATEGORY);
            Log.Arch6("Arch6", Common.LOG_CATEGORY);
            Log.Arch7("Arch7", Common.LOG_CATEGORY);
            Log.Arch8("Arch8", Common.LOG_CATEGORY);
            Log.Arch9("Arch9", Common.LOG_CATEGORY);

            Log.Arch10("Arch10", Common.LOG_CATEGORY);
            Log.Arch11("Arch11", Common.LOG_CATEGORY);
            Log.Arch12("Arch12", Common.LOG_CATEGORY);
            Log.Arch13("Arch13", Common.LOG_CATEGORY);
            Log.Arch14("Arch14", Common.LOG_CATEGORY);
            Log.Arch15("Arch15", Common.LOG_CATEGORY);
            Log.Arch16("Arch16", Common.LOG_CATEGORY);
            Log.Arch17("Arch17", Common.LOG_CATEGORY);
            Log.Arch18("Arch18", Common.LOG_CATEGORY);
            Log.Arch19("Arch19", Common.LOG_CATEGORY);

            Log.Trace("Trace", Common.LOG_CATEGORY);
            Log.Trace1("Trace1", Common.LOG_CATEGORY);
            Log.Trace2("Trace2", Common.LOG_CATEGORY);
            Log.Trace3("Trace3", Common.LOG_CATEGORY);
            Log.Trace4("Trace4", Common.LOG_CATEGORY);
            Log.Trace5("Trace5", Common.LOG_CATEGORY);
            Log.Trace6("Trace6", Common.LOG_CATEGORY);
            Log.Trace7("Trace7", Common.LOG_CATEGORY);
            Log.Trace8("Trace8", Common.LOG_CATEGORY);
            Log.Trace9("Trace9", Common.LOG_CATEGORY);

            Log.Trace10("Trace10", Common.LOG_CATEGORY);
            Log.Trace11("Trace11", Common.LOG_CATEGORY);
            Log.Trace12("Trace12", Common.LOG_CATEGORY);
            Log.Trace13("Trace13", Common.LOG_CATEGORY);
            Log.Trace14("Trace14", Common.LOG_CATEGORY);
            Log.Trace15("Trace15", Common.LOG_CATEGORY);
            Log.Trace16("Trace16", Common.LOG_CATEGORY);
            Log.Trace17("Trace17", Common.LOG_CATEGORY);
            Log.Trace18("Trace18", Common.LOG_CATEGORY);
            Log.Trace19("Trace19", Common.LOG_CATEGORY);

            Log.Trace20("Trace20", Common.LOG_CATEGORY);
            Log.Trace21("Trace21", Common.LOG_CATEGORY);
            Log.Trace22("Trace22", Common.LOG_CATEGORY);
            Log.Trace23("Trace23", Common.LOG_CATEGORY);
            Log.Trace24("Trace24", Common.LOG_CATEGORY);
            Log.Trace25("Trace25", Common.LOG_CATEGORY);
            Log.Trace26("Trace26", Common.LOG_CATEGORY);
            Log.Trace27("Trace27", Common.LOG_CATEGORY);
            Log.Trace28("Trace28", Common.LOG_CATEGORY);
            Log.Trace29("Trace29", Common.LOG_CATEGORY);

            Connection.InvokeAsync("SendTimedMessage", TextBoxMessage.Text, signalRTime);
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
            {
                signalrtime.ClientReceivedTime = DateTime.Now;
                signalrtime.ClientReceivedTicks = Stopwatch.GetTimestamp();
                //this.Dispatcher.InvokeAsync(() =>
                //    rtbConsole.AppendText($"SendT:{signalrtime.SendTime:yyyy/MM/dd HH:mm:ss.ffff} Send:{signalrtime.SendTicks} HubRT:{signalrtime.HubReceivedTime:yyyy/MM/dd HH:mm:ss.ffff} HubR:{signalrtime.HubReceivedTicks} ClientRT:{signalrtime.ClientReceivedTime:yyyy/MM/dd HH:mm:ss.ffff} ClientR:{signalrtime.ClientReceivedTicks} ClientMT:{signalrtime.ClientMessageTime:yyyy/MM/dd HH:mm:ss.ffff} ClientM:{signalrtime.ClientMessageTicks} : {message}\r")
                //);
                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText($"{message}\r"));

                signalrtime.ClientMessageTime = DateTime.Now;
                signalrtime.ClientMessageTicks = Stopwatch.GetTimestamp();

                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText($"SendT:    {signalrtime.SendTime:yyyy/MM/dd HH:mm:ss.ffff} Send:{signalrtime.SendTicks}\r"));

                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText($"HubRT:    {signalrtime.HubReceivedTime:yyyy/MM/dd HH:mm:ss.ffff} - Duration:{(signalrtime.HubReceivedTicks - signalrtime.SendTicks) / (double)Stopwatch.Frequency}\r"));
                
                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText($"ClientRT: {signalrtime.ClientReceivedTime:yyyy/MM/dd HH:mm:ss.ffff} - Duration:{(signalrtime.ClientReceivedTicks - signalrtime.HubReceivedTicks) / (double)Stopwatch.Frequency}\r"));
                
                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText($"ClientMT: {signalrtime.ClientMessageTime:yyyy/MM/dd HH:mm:ss.ffff} - Duration:{(signalrtime.ClientMessageTicks - signalrtime.ClientReceivedTicks) / (double)Stopwatch.Frequency}\r"));
                
                this.Dispatcher.InvokeAsync(() =>
                    rtbConsole.AppendText($"Duration: {(signalrtime.ClientMessageTicks - signalrtime.SendTicks) / (double)Stopwatch.Frequency}\r"));

            });

            try
            {
                await Connection.StartAsync();
            }
            catch (HttpRequestException hre)
            {
                rtbConsole.AppendText( $"Unable to connect to server: Start server before connecting clients. {hre.Message}");
                //No connection: Don't enable Send button or show chat UI
                return;
            }
            catch (Exception ex)
            {
                rtbConsole.AppendText($"Unable to connect to server, ex: {ex.Message}");
                //No connection: Don't enable Send button or show chat UI
                return;
            }

            //Show chat UI; hide login UI

            //SignInPanel.Visibility = Visibility.Collapsed;
            //ChatPanel.Visibility = Visibility.Visible;

            ButtonSend.IsEnabled = true;
            ButtonSendTimed.IsEnabled = true;
            ButtonSendAnnoymous.IsEnabled = true;
            ButtonSendPriority.IsEnabled = true;
            ButtonSendPriorityTimed.IsEnabled = true;
            ButtonLoggingPriorities.IsEnabled = true;

            TextBoxMessage.Focus();

            rtbConsole.AppendText("Connected to server at " + ServerURI + "\r");
        }

        private Task Connection_Reconnecting(Exception? arg)
        {
            var dispatcher = Application.Current.Dispatcher;
            rtbConsole.AppendText($"Reconnecting {(arg is null ? "" : arg.Message)}.");

            return null;
        }

        private Task Connection_Reconnected(string? arg)
        {
            var dispatcher = Application.Current.Dispatcher;
            rtbConsole.AppendText($"Reconnected {arg}");

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
            dispatcher.InvokeAsync(() => ButtonSendTimed.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendAnnoymous.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendPriority.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendPriorityTimed.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonLoggingPriorities.IsEnabled = false);

            dispatcher.InvokeAsync(() => rtbConsole.AppendText($"Connection Closed {(arg is null ? "" : arg.Message)}."));
            //dispatcher.InvokeAsync(() => SignInPanel.Visibility = Visibility.Visible);

            return null;
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            UserName = UserNameTextBox.Text;

            if (!String.IsNullOrEmpty(UserName))
            {
                rtbConsole.AppendText("Connecting to server...");

                //StatusText.Visibility = Visibility.Visible;
                //StatusText.Text = "Connecting to server...";

                ConnectAsync();

                SignInButton.IsEnabled = false;
                SignOutButton.IsEnabled = true;
            }
            else
            {
                rtbConsole.AppendText("Must enter UserName");
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

                rtbConsole.AppendText("Signed out of Server");
            }

            SignOutButton.IsEnabled = false;
            SignInButton.IsEnabled = true;
        }

    }
}
