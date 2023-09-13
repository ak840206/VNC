using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

using SignalRCoreServerHub;

#if NET48
using Microsoft.AspNet.SignalR.Client;
#else
using Microsoft.AspNetCore.SignalR.Client;
#endif

using VNC;

namespace VNCSignalRClient
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
#if NET48
        private string serverURI = "http://localhost:58095";

        public IDisposable SignalR { get; set; }

        public IHubProxy HubProxy { get; set; }

        public HubConnection Connection { get; set; }
#else
        private string serverURI = "http://localhost:58195/signalR";

        public HubConnection Connection { get; set; }
#endif


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string ServerURI { get => serverURI; set => serverURI = value; }

        /// <summary>
        /// This name is simply added to sent messages to identify the user; this 
        /// sample does not include authentication.
        /// </summary>
        public String UserName { get; set; }

        public string RuntimeVersion { get => Common.RuntimeVersion; }
        public string FileVersion { get => Common.FileVersion; }
        public string ProductVersion { get => Common.ProductVersion; }
        public string ProductName { get => Common.ProductName; }

#if NET48

#else

#endif

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Boolean sendAsync = (bool)cbSendAsync.IsChecked;
#if NET48
                string message = TextBoxMessage.Text;
#else
                string message = TextBoxMessage.Text + (sendAsync ? " SA" : " IA");
#endif

                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
#if NET48
                    HubProxy.Invoke("SendUserMessage", UserName, message);
#else
                    if (sendAsync)
                    {
                        Connection.SendAsync("SendUserMessage", UserName, message);
                    }
                    else
                    {
                        Connection.InvokeAsync("SendUserMessage", UserName, message);
                    }
#endif

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

        private void btnSendTimed_Click(object sender, RoutedEventArgs e)
        {
            SignalRTime signalRTime = new SignalRTime();

            try
            {
                Boolean sendAsync = (bool)cbSendAsync.IsChecked;
#if NET48
                string message = TextBoxMessage.Text;
#else
                string message = TextBoxMessage.Text + (sendAsync ? " SA" : " IA");
#endif

#if NET48
                // TODO(crhodes)
                // Need to implement
#else
                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
                    if (sendAsync)
                    {
                        Connection.SendAsync("SendUserMessage", UserName, message);
                    }
                    else
                    {
                        Connection.InvokeAsync("SendUserMessage", UserName, message);
                    }
                }

                if (sendAsync)
                {
                    Connection.SendAsync("SendTimedMessage", "TimingInfo", signalRTime);
                }
                else
                {
                    Connection.InvokeAsync("SendTimedMessage", "TimingInfo", signalRTime);
                }
#endif


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

        private void btnSendAnnoymous_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Boolean sendAsync = (bool)cbSendAsync.IsChecked;
#if NET48
                string message = TextBoxMessage.Text;
#else
                string message = TextBoxMessage.Text + (sendAsync ? " SA" : " IA");
#endif

                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
#if NET48
                    HubProxy.Invoke("SendMessage", message);
#else
                    if (sendAsync)
                    {
                        Connection.SendAsync("SendMessage", message);
                    }
                    else
                    {
                        Connection.InvokeAsync("SendMessage", message);
                    }
#endif

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
                Boolean sendAsync = (bool)cbSendAsync.IsChecked;
#if NET48
                string message = TextBoxMessage.Text;
#else
                string message = TextBoxMessage.Text + (sendAsync ? " SA" : " IA");
#endif
                Int32 priority = Int32.Parse(Priority.Text);

                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
#if NET48
                    HubProxy.Invoke("SendPriorityMessage", message, priority);
#else
                    if (sendAsync)
                    {
                        Connection.SendAsync("SendPriorityMessage", message, priority);
                    }
                    else
                    {
                        Connection.InvokeAsync("SendPriorityMessage", message, priority);
                    }
#endif

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

        private void btnSendPriorityTimed_Click(object sender, RoutedEventArgs e)
        {
            SignalRTime signalRTime = new SignalRTime();

            try
            {
                Boolean sendAsync = (bool)cbSendAsync.IsChecked;
#if NET48
                string message = TextBoxMessage.Text;
#else
                string message = TextBoxMessage.Text + (sendAsync ? " SA" : " IA");
#endif   
                Int32 priority = Int32.Parse(Priority.Text);

#if NET48
                // TODO(crhodes)
                // Need to implement
#else
                for (int i = 0; i < Int32.Parse(Count.Text); i++)
                {
                    if (sendAsync)
                    {
                        Connection.SendAsync("SendPriorityMessage", message, priority);
                    }
                    else
                    {
                        Connection.InvokeAsync("SendPriorityMessage", message, priority);
                    }
                }

                if (sendAsync)
                {
                    Connection.SendAsync("SendTimedMessage", "TimingInfo", signalRTime);
                }
                else
                {
                    Connection.InvokeAsync("SendTimedMessage", "TimingInfo", signalRTime);
                }
#endif



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

        private void btnSendLoggingPriorities_Click(object sender, RoutedEventArgs e)
        {
            SignalRTime signalRTime = new SignalRTime();

            Boolean sendAsync = (bool)cbSendAsync.IsChecked;

#if NET48
             // TODO(crhodes)
             // Need to implement
             return;
#else


            try
            {
                if (sendAsync)
                {
                    Connection.SendAsync("SendPriorityMessage", "Critical SA", -10);
                    Connection.SendAsync("SendPriorityMessage", "Error SA", -1);
                    Connection.SendAsync("SendPriorityMessage", "Warning SA", 1);
                }
                else
                {
                    Connection.InvokeAsync("SendPriorityMessage", "Critical IA", -10);
                    Connection.InvokeAsync("SendPriorityMessage", "Error IA", -1);
                    Connection.InvokeAsync("SendPriorityMessage", "Warning IA", 1);
                }

                for (int i = 100; i < 105; i++)
                {
                    if (sendAsync)
                    {
                        Connection.SendAsync("SendPriorityMessage", $"Info{i} SA", i);
                    }
                    else
                    {
                        Connection.InvokeAsync("SendPriorityMessage", $"Info{i} IA", i);
                    }                   
                }

                for (int i = 1000; i < 1005; i++)
                {
                    if (sendAsync)
                    {
                        Connection.SendAsync("SendPriorityMessage", $"Debug{i} SA", i);
                    }
                    else
                    {
                        Connection.InvokeAsync("SendPriorityMessage", $"Debug{i} IA", i);
                    }
                }

                for (int i = 9000; i < 9020; i++)
                {
                    if (sendAsync)
                    {
                        Connection.SendAsync("SendPriorityMessage", $"Arch{i} SA", i);
                    }
                    else
                    {
                        Connection.InvokeAsync("SendPriorityMessage", $"Arch{i} IA", i);
                    }
                }

                for (int i = 10000; i < 10030; i++)
                {
                    if (sendAsync)
                    {
                        Connection.SendAsync("SendPriorityMessage", $"Trace{i} SA", i);
                    }
                    else
                    {
                        Connection.InvokeAsync("SendPriorityMessage", $"Trace{i} IA", i);
                    }
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
                //Connection.SendAsync("SendTimedMessage", TextBoxMessage.Text, signalRTime);
            }
            catch (Exception ex)
            {
                Log.Error(ex, Common.LOG_CATEGORY);
            }
#endif
        }

        /// <summary>
        /// Creates and connects the hub connection and hub proxy. This method
        /// is called asynchronously from SignInButton_Click.
        /// Use async to avoid blocking UI
        /// </summary>
        private async void ConnectAsync()
        {
#if NET48
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
#else
            Connection = new HubConnectionBuilder()
                .WithUrl(ServerURI)
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

#endif

#if NET48
            // TODO(crhodes)
            // Implement
#else
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
#endif

            try
            {
#if NET48
                await Connection.Start();
#else
                await Connection.StartAsync();
#endif
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

            ButtonSend.IsEnabled = true;
            ButtonSendTimed.IsEnabled = true;
            ButtonSendAnnoymous.IsEnabled = true;
            ButtonSendPriority.IsEnabled = true;
            ButtonSendPriorityTimed.IsEnabled = true;
            ButtonLoggingPriorities.IsEnabled = true;

            rtbConsole.AppendText("Connected to server at " + ServerURI + "\r");
        }

#if NET48

#else
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
#endif

#if NET48
        /// <summary>
        /// If the server is stopped, the connection will time out after 30 seconds (default), 
        /// and the Closed event will fire.
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

            dispatcher.InvokeAsync(() => rtbConsole.AppendText($"Connection Closed."));
            //dispatcher.InvokeAsync(() => SignInPanel.Visibility = Visibility.Visible);

            //return null;
        }
#else

        /// <summary>
        /// If the server is stopped, the connection will time out after 30 seconds (default), 
        /// and the Closed event will fire.
        /// </summary>
        Task Connection_Closed(Exception? arg)
        {
            var dispatcher = Application.Current.Dispatcher;

            dispatcher.InvokeAsync(() => ButtonSend.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendTimed.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendAnnoymous.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendPriority.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonSendPriorityTimed.IsEnabled = false);
            dispatcher.InvokeAsync(() => ButtonLoggingPriorities.IsEnabled = false);

            dispatcher.InvokeAsync(() => rtbConsole.AppendText($"Connection Closed {(arg is null ? "" : arg.Message)}."));

            return null;
        }
#endif

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

        private async void WPFClient_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Connection != null)
            {
#if NET48
                Connection.Stop();
                Connection.Dispose();
#else
                await Connection.StopAsync();
                await Connection.DisposeAsync();
#endif
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            rtbConsole.Document.Blocks.Clear();
        }

        private async void SignOutButton_Click(object sender, RoutedEventArgs e)
        {
            if (Connection != null)
            {
#if NET48
                Connection.Stop();
                Connection.Dispose();
#else
                await Connection.StopAsync();
                await Connection.DisposeAsync();
#endif


                rtbConsole.AppendText("Signed out of ServerHub");
            }

            SignOutButton.IsEnabled = false;
            SignInButton.IsEnabled = true;
        }

    }
}
