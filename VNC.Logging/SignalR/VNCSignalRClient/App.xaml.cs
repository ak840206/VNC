using System;
using System.Threading;
using System.Windows;

using VNC;

namespace VNCSignalRClient
{
    public partial class App : Application
    {
        public App()
        {
            // HACK(crhodes)
            // If don't delay a bit here, the SignarlR logging infrastructure
            // does not initialize quickly enough
            // and the first few log messages are missed.
            // NB.  All are properly recorded in the log file.

            Int64 startTicks = Log.APPLICATION_START("Initialize SignalR", Common.LOG_CATEGORY);

            Thread.Sleep(150);

            Log.APPLICATION_START("App()", Common.LOG_CATEGORY, startTicks);

            //Directory.SetCurrentDirectory("jsonUIConfig");
            Common.SetAppVersionInfo();

            Log.APPLICATION_START("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}
