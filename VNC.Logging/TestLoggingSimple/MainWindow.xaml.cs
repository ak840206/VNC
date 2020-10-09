using System.Windows;

//using EaseCore;
using VNC;

namespace TestLoggingSimple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string LOG_APPNAME = "SIMPLE";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogSomething(object sender, RoutedEventArgs e)
        {
            //Log.Info("LogSomething for Me", LOG_APPNAME, 0);
            Log.Info("AppLogSomething for Me", LOG_APPNAME, 0);
        }
    }
}
