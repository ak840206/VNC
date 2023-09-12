using System;
using System.Reflection;

namespace SignalRCoreClient
{
    public static class Common
    {
        private static string _fileVersion = "<fileVersion>";
        private static string _productName = "<productName>";
        private static string _productVersion = "<productVersion>";
        private static string _runtimeVersion = "<RuntimeVersion>";

        public const string PROJECT_NAME = "SignalRCoreClient";
        public const string LOG_CATEGORY = "SignalRCoreClient";

        public const string cCONFIG_FILE = @"C:\temp\SignalRCoreClient_Config.xml";


        public static string RuntimeVersion
        {
            get => _runtimeVersion;
            set => _runtimeVersion = value;
        }

        public static string FileVersion
        {
            get => _fileVersion;
            set => _fileVersion = value;
        }

        public static string ProductName
        {
            get => _productName;
            set => _productName = value;
        }

        public static string ProductVersion
        {
            get => _productVersion;
            set => _productVersion = value;
        }

        public static void SetAppVersionInfo()
        { 
            var runtimeVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(typeof(int).Assembly.Location);

            Common.RuntimeVersion = runtimeVersion.FileVersion;

            //var rv = runtimeVersion.Comments;
            //var rv1 = runtimeVersion.CompanyName;
            //var rv2 = runtimeVersion.FileDescription;
            //var rv3 = runtimeVersion.FileName;
            //var rv4 = runtimeVersion.FileVersion;
            //var rv5 = runtimeVersion.ProductVersion;
            //var rv6 = runtimeVersion.ProductName;


            //var assyb = Assembly.GetExecutingAssembly();
            //var a3 = assyb.Location;
            var appVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

            var av = appVersion.Comments;
            var av1 = appVersion.CompanyName;
            var av2 = appVersion.FileDescription;
            var av3 = appVersion.FileName;
            var av4 = appVersion.FileVersion;
            var av5 = appVersion.ProductVersion;
            var av6 = appVersion.ProductName;

            Common.FileVersion = appVersion.FileVersion;
            Common.ProductName = appVersion.ProductName;
            Common.ProductVersion = appVersion.ProductVersion;

        }

    }
}
