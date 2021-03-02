using System.Windows;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Logging;

using VNC;

namespace TestLoggingSimple
{
    public partial class MainWindow : Window
    {
        const string LOG_APPNAME = "SIMPLE";

        public MainWindow()
        {
            InitializeComponent();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory(), false);
            //Logger.SetLogWriter(new LogWriterFactory().Create(), false);
        }

        private void btnLogSomething(object sender, RoutedEventArgs e)
        {
            Log.Info("Log Something for Me", LOG_APPNAME, 0);
            Log.EVENT_HANDLER("Log Something for Me", LOG_APPNAME, 0);
        }
    }
}
