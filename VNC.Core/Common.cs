using System.Diagnostics;
using System.Reflection;

namespace VNC.Core
{
    public class AssemblyInformation
    {
        public string Version { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }

        public string AssemblyTitle { get; set; }
        public string AssemblyVerison { get; set; }
        public string Company { get; set; }
        public string Configuration { get; set; }
        public string Copyright { get; set; }
        public string Description { get; set; }
        public string FileVersion { get; set; }
        public string InformationalVersion { get; set; }
        public string Product { get; set; }

        //public bool IsDebug { get; set; }
        //public bool IsPrivateBuild { get; set; }
        //public bool IsSpecialBuild { get; set; }

    }

    public class FileInformation
    {
        public string FileVersion { get; set; }
        public string FileDescription { get; set; }

        public string ProductName { get; set; }
        public string InternalName { get; set; }
        public string ProductVersion { get; set; }

        public string ProductMajorPart { get; set; }
        public string ProductMinorPart { get; set; }
        public string ProductBuildPart { get; set; }

        public string Comments { get; set; }

        public bool IsDebug { get; set; }
        public bool IsPatched { get; set; }
        public bool IsPreRelease { get; set; }
        public bool IsPrivateBuild { get; set; }
        public bool IsSpecialBuild { get; set; }
    }

    public class Information
    {
        public AssemblyInformation AssemblyInformation = new AssemblyInformation();
        public FileInformation FileInformation = new FileInformation();
        public string RuntimeVersion { get; set; }
    }

    public class Common
    {
        public static Information InformationApplication = new Information();
        public static Information InformationVNCCore = new Information();

        public const string APPNAME = "VNCCore";
        public const string LOG_CATEGORY = "VNCCore";

        private static void SetInformation(Information information, Assembly assembly, FileVersionInfo fileVersionInfo)
        {
            // Information in Assembly
            AssemblyName assemblyName = assembly.GetName();

            information.AssemblyInformation.Version = assemblyName.Version.ToString();
            information.AssemblyInformation.Name = assemblyName.Name;
            information.AssemblyInformation.FullName = assemblyName.FullName;

            information.AssemblyInformation.AssemblyTitle = assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
            // NOTE(crhodes)
            // Throws Exception
            information.AssemblyInformation.AssemblyVerison = assembly.GetCustomAttribute<AssemblyVersionAttribute>()?.Version;
            information.AssemblyInformation.Company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company;
            information.AssemblyInformation.Configuration = assembly.GetCustomAttribute<AssemblyConfigurationAttribute>().Configuration;
            information.AssemblyInformation.Copyright = assembly.GetCustomAttribute<AssemblyCopyrightAttribute>()?.Copyright;
            information.AssemblyInformation.Description = assembly.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description;
            information.AssemblyInformation.FileVersion = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version;
            information.AssemblyInformation.InformationalVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
            information.AssemblyInformation.Product = assembly.GetCustomAttribute<AssemblyProductAttribute>().Product;

            // Information in FileVesionInfo

            information.FileInformation.FileVersion = fileVersionInfo.FileVersion;
            information.FileInformation.FileDescription = fileVersionInfo.FileDescription;

            information.FileInformation.ProductName = fileVersionInfo.ProductName;
            information.FileInformation.InternalName = fileVersionInfo.InternalName;
            information.FileInformation.ProductVersion = fileVersionInfo.ProductVersion;

            information.FileInformation.ProductMajorPart = fileVersionInfo.ProductMajorPart.ToString();
            information.FileInformation.ProductMinorPart = fileVersionInfo.ProductMajorPart.ToString();
            information.FileInformation.ProductBuildPart = fileVersionInfo.ProductBuildPart.ToString();

            information.FileInformation.Comments = fileVersionInfo.Comments;

            information.FileInformation.IsDebug = fileVersionInfo.IsDebug;
            information.FileInformation.IsPatched = fileVersionInfo.IsPatched;
            information.FileInformation.IsPreRelease = fileVersionInfo.IsPreRelease;
            information.FileInformation.IsPrivateBuild = fileVersionInfo.IsPrivateBuild;
            information.FileInformation.IsSpecialBuild = fileVersionInfo.IsSpecialBuild;

            // Runtime Information

            information.RuntimeVersion = FileVersionInfo.GetVersionInfo(typeof(int).Assembly.Location).FileVersion;
        }

        public static Information GetInformation(Assembly assembly, FileVersionInfo fileVersionInfo)
        {
            Information information = new Information();

            // Information in Assembly
            AssemblyName assemblyName = assembly.GetName();

            information.AssemblyInformation.Version = assemblyName.Version.ToString();
            information.AssemblyInformation.Name = assemblyName.Name;
            information.AssemblyInformation.FullName = assemblyName.FullName;

            information.AssemblyInformation.AssemblyTitle = assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
            information.AssemblyInformation.AssemblyVerison = assembly.GetCustomAttribute<AssemblyVersionAttribute>().Version;
            information.AssemblyInformation.Company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company;
            information.AssemblyInformation.Configuration = assembly.GetCustomAttribute<AssemblyConfigurationAttribute>().Configuration;
            information.AssemblyInformation.Copyright = assembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
            information.AssemblyInformation.Description = assembly.GetCustomAttribute<AssemblyDescriptionAttribute>().Description;
            information.AssemblyInformation.FileVersion = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version;
            information.AssemblyInformation.InformationalVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
            information.AssemblyInformation.Product = assembly.GetCustomAttribute<AssemblyProductAttribute>().Product;

            // Information in FileVesionInfo

            information.FileInformation.FileVersion = fileVersionInfo.FileVersion;
            information.FileInformation.FileDescription = fileVersionInfo.FileDescription;

            information.FileInformation.ProductName = fileVersionInfo.ProductName;
            information.FileInformation.InternalName = fileVersionInfo.InternalName;
            information.FileInformation.ProductVersion = fileVersionInfo.ProductVersion;

            information.FileInformation.ProductMajorPart = fileVersionInfo.ProductMajorPart.ToString();
            information.FileInformation.ProductMinorPart = fileVersionInfo.ProductMinorPart.ToString();
            information.FileInformation.ProductBuildPart = fileVersionInfo.ProductBuildPart.ToString();

            information.FileInformation.Comments = fileVersionInfo.Comments;

            information.FileInformation.IsDebug = fileVersionInfo.IsDebug;
            information.FileInformation.IsPatched = fileVersionInfo.IsPatched;
            information.FileInformation.IsPreRelease = fileVersionInfo.IsPreRelease;
            information.FileInformation.IsPrivateBuild = fileVersionInfo.IsPrivateBuild;
            information.FileInformation.IsSpecialBuild = fileVersionInfo.IsSpecialBuild;

            return information;
        }

        public static void SetVersionInfoApplication(Assembly appAssembly, FileVersionInfo appFileVersionInfo)
        {
            SetInformation(InformationApplication, 
                appAssembly, 
                appFileVersionInfo);
        }

        public static void SetVersionInfoVNCCore()
        {
            SetInformation(InformationVNCCore, 
                Assembly.GetExecutingAssembly(), 
                FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location));
        }
    }
}
