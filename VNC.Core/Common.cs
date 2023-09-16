using System.Diagnostics;
using System.Reflection;

namespace VNC.Core
{
    public class Common
    {
        public const string LOG_CATEGORY = "VNCCore";
        public const string APPNAME = "VNCCore";

        private static string _runtimeVersion = "<RuntimeVersion>";
        private static string _fileVersion = "<fileVersion>";
        private static string _productName = "<productName>";
        private static string _productVersion = "<productVersion>";


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


        private static string _runtimeVersionVNCCore = "<RuntimeVersionVNCCore>";
        private static string _fileVersionVNCCore = "<fileVersionVNCCOre>";
        private static string _productNameVNCCore = "<productNameVNCCore>";
        private static string _productVersionVNCCore = "<productVersionVNCCore>";


        public static string RuntimeVersionVNCCore
        {
            get => _runtimeVersionVNCCore;
            set => _runtimeVersionVNCCore = value;
        }

        public static string FileVersionVNCCore
        {
            get => _fileVersionVNCCore;
            set => _fileVersionVNCCore = value;
        }

        public static string ProductNameVNCCore
        {
            get => _productNameVNCCore;
            set => _productNameVNCCore = value;
        }

        public static string ProductVersionVNCCore
        {
            get => _productVersionVNCCore;
            set => _productVersionVNCCore = value;
        }

        public static void SetVersionInfoVNCCore()
        {
            var runtimeVersion = FileVersionInfo.GetVersionInfo(typeof(int).Assembly.Location);

            Common.RuntimeVersionVNCCore = runtimeVersion.FileVersion;

            //var rv = runtimeVersion.Comments;
            //var rv1 = runtimeVersion.CompanyName;
            //var rv2 = runtimeVersion.FileDescription;
            //var rv3 = runtimeVersion.FileName;
            //var rv4 = runtimeVersion.FileVersion;
            //var rv5 = runtimeVersion.ProductVersion;
            //var rv6 = runtimeVersion.ProductName;


            //var assyb = Assembly.GetExecutingAssembly();
            //var a3 = assyb.Location;
            var appVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

            var av = appVersion.Comments;
            var av1 = appVersion.CompanyName;
            var av2 = appVersion.FileDescription;
            var av3 = appVersion.FileName;
            var av4 = appVersion.FileVersion;
            var av5 = appVersion.ProductVersion;
            var av6 = appVersion.ProductName;

            Common.FileVersionVNCCore = appVersion.FileVersion;
            Common.ProductNameVNCCore = appVersion.ProductName;
            Common.ProductVersionVNCCore = appVersion.ProductVersion;

        }

        public static void SetVersionInfoApplication(FileVersionInfo runtimeVersion, FileVersionInfo appVersion)
        {
            //var runtimeVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(typeof(int).Assembly.Location);

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
            //var appVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

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
