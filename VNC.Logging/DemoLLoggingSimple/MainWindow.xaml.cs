using System.Threading;
using System.Windows;

//using Microsoft.Practices.EnterpriseLibrary.Data;

using VNC;

namespace TestLoggingSimple
{
    public partial class MainWindow : Window
    {
        const string LOG_APPNAME = "SIMPLE";

        public MainWindow()
        {
            InitializeComponent();
            //DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory(), false);
            //Logger.SetLogWriter(new LogWriterFactory().Create(), false);
        }

        private void btnLogSomething(object sender, RoutedEventArgs e)
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
