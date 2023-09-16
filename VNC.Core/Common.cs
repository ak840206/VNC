namespace VNC.Core
{
    public class Common
    {
        public const string LOG_CATEGORY = "VNCCore";
        public const string APPNAME = "VNCCore";

        private static string _fileVersion = "<fileVersion>";
        private static string _productName = "<productName>";
        private static string _productVersion = "<productVersion>";
        private static string _runtimeVersion = "<RuntimeVersion>";

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
    }
}
