using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

#if NET48
using Microsoft.Owin.Hosting;
#else
using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;
#endif


namespace VNCSignalRServerHub
{
    /// <summary>
    /// WPF host for a SignalR server. The host can stop and start the SignalR
    /// server, report errors when trying to start the server on a URI where a
    /// server is already being hosted, and monitor when clients connect and disconnect. 
    /// The hub used in this server is a simple echo service, and has the same 
    /// functionality as the other hubs in the SignalR Getting Started tutorials.
    /// For simplicity, MVVM will not be used for this sample.
    /// </summary>
    public partial class MainWindow : Window
    {
#if NET48
        private string serverURI = "http://localhost:58095";

        public IDisposable SignalR { get; set; }
#else
        private string serverURI = "http://localhost:58195";

        private IHost _host;

        private IWebHost _webHost;
        
#endif

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string ServerURI { get => serverURI; set => serverURI = value; }

        public string RuntimeVersion { get => Common.RuntimeVersion; }
        public string FileVersion { get => Common.FileVersion; }
        public string ProductVersion { get => Common.ProductVersion; }
        public string ProductName { get => Common.ProductName; }

        /// <summary>
        /// Calls the StartServer method with Task.Run 
        /// So as to not block the UI thread. 
        /// </summary>
        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            WriteToConsole("Starting server...");
            ServerURI = tbServerURI.Text;
            ButtonStart.IsEnabled = false;

            Task.Run(() => StartServer());
        }

        /// <summary>
        /// Stops the server and closes the form. Restart functionality omitted
        /// for clarity.
        /// </summary>
        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
#if NET48
            SignalR.Dispose();
#else
            _webHost.StopAsync();
#endif

            WriteToConsole("Server Stopped");
            ButtonStart.IsEnabled = true;
            ButtonStop.IsEnabled = false;
        }

        /// <summary>
        /// Starts the server and checks for error thrown when another server is already 
        /// running. This method is called asynchronously from Button_Start.
        /// </summary>
        private void StartServer()
        {
            try
            {
#if NET48
                SignalR = WebApp.Start(ServerURI);
#else
                _webHost = WebHost.CreateDefaultBuilder()
                    .UseUrls(new string[] { ServerURI })
                    .UseStartup<Startup>()
                    .Build();

                _webHost.RunAsync();
#endif
            }
            catch (TargetInvocationException ex)
            {
                WriteToConsole("A server is already running at " + ServerURI);
                this.Dispatcher.InvokeAsync(() => ButtonStart.IsEnabled = true);
                return;
            }

            WriteToConsole("Server started at " + ServerURI);

            this.Dispatcher.InvokeAsync(() => ButtonStop.IsEnabled = true);
        }

        ///This method adds a line to the RichTextBoxConsole control, using Dispatcher.Invoke if used
        /// from a SignalR hub thread rather than the UI thread.
        public void WriteToConsole(String message)
        {
            if (!(rtbConsole.CheckAccess()))
            {
                this.Dispatcher.InvokeAsync(() =>
                    WriteToConsole(message)
                );
                return;
            }

            rtbConsole.AppendText(message + "\r");
        }

        private void tbServerURI_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            ServerURI = tbServerURI.Text;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            rtbConsole.Document.Blocks.Clear();
        }
    }
}

