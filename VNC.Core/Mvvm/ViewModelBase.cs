using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace VNC.Core.Mvvm
{
    public class ViewModelBase : IViewModel, INotifyPropertyChanged
    {

        [Display(AutoGenerateField = false)]
        public IView View
        {
            get;
            set;
        }

        public ViewModelBase()
        {
        }

        public ViewModelBase(IView view)
        {
            View = view;
            View.ViewModel = this;
        }

        private bool _isBusy;

        [Display(AutoGenerateField = false)]
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        private bool _logOnPropertyChanged = false;

        [Display(AutoGenerateField = false)]
        public bool LogOnPropertyChanged
        {
            get => _logOnPropertyChanged;
            set
            {
                if (_logOnPropertyChanged == value)
                    return;
                _logOnPropertyChanged = value;
                OnPropertyChanged();
            }
        }

        public string AssemblyVersion { get => Common.InformationApplication.AssemblyInformation.Version; }
        public string AssemblyName { get => Common.InformationApplication.AssemblyInformation.Name; }
        public string AssemblyFullName { get => Common.InformationApplication.AssemblyInformation.FullName; }
        public string AssemblyTitle { get => Common.InformationApplication.AssemblyInformation.AssemblyTitle; }
        //public string AssemblyAssemblyVersion { get => Common.InformationApplication.AssemblyInformation.AssemblyVersion; }
        public string AssemblyCompany { get => Common.InformationApplication.AssemblyInformation.Company; }
        public string AssemblyConfiguration { get => Common.InformationApplication.AssemblyInformation.Configuration; }
        public string AssemblyCopyright { get => Common.InformationApplication.AssemblyInformation.Copyright; }
        public string AssemblyDescription { get => Common.InformationApplication.AssemblyInformation.Description; }


        public string AssemblyVersionVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Version; }
        public string AssemblyNameVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Name; }
        public string AssemblyFullNameVNCCore { get => Common.InformationVNCCore.AssemblyInformation.FullName; }
        public string AssemblyTitleVNCCore { get => Common.InformationVNCCore.AssemblyInformation.AssemblyTitle; }
        //public string AssemblyAssemblyVersionVNCCore { get => Common.InformationVNCCore.AssemblyInformation.AssemblyVersion; }
        public string AssemblyCompanyVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Company; }
        public string AssemblyConfigurationVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Configuration; }
        public string AssemblyCopyrightVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Copyright; }
        public string AssemblyDescriptionVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Description; }


        public string FileVersion { get => Common.InformationApplication.FileInformation.FileVersion; }
        public string FileDescription { get => Common.InformationApplication.FileInformation.FileDescription; }
        public string ProductName { get => Common.InformationApplication.FileInformation.ProductName; }
        public string InternalName { get => Common.InformationApplication.FileInformation.InternalName; }
        public string ProductVersion { get => Common.InformationApplication.FileInformation.ProductVersion; }
        public string ProductMajorPart { get => Common.InformationApplication.FileInformation.ProductMajorPart; }
        public string ProductMinorPart { get => Common.InformationApplication.FileInformation.ProductMinorPart; }
        public string ProductBuildPart { get => Common.InformationApplication.FileInformation.ProductBuildPart; }
        public string ProductPrivatePart { get => Common.InformationApplication.FileInformation.ProductPrivatePart; }
        public string Comments { get => Common.InformationApplication.FileInformation.Comments; }
        public string IsDebug { get => Common.InformationApplication.FileInformation.IsDebug.ToString(); }
        public string IsPatched { get => Common.InformationApplication.FileInformation.IsPatched.ToString(); }
        public string IsPreRelease { get => Common.InformationApplication.FileInformation.IsPreRelease.ToString(); }
        public string IsPrivateBuild { get => Common.InformationApplication.FileInformation.IsPrivateBuild.ToString(); }
        public string IsSpecialBuild { get => Common.InformationApplication.FileInformation.IsSpecialBuild.ToString(); }

        public string FileVersionVNCCore { get => Common.InformationVNCCore.FileInformation.FileVersion; }
        public string FileDescriptionVNCCore { get => Common.InformationVNCCore.FileInformation.FileDescription; }
        public string ProductNameVNCCore { get => Common.InformationVNCCore.FileInformation.ProductName; }
        public string InternalNameVNCCore { get => Common.InformationVNCCore.FileInformation.InternalName; }
        public string ProductVersionVNCCore { get => Common.InformationVNCCore.FileInformation.ProductVersion; }
        public string ProductMajorPartVNCCore { get => Common.InformationVNCCore.FileInformation.ProductMajorPart; }
        public string ProductMinorPartVNCCore { get => Common.InformationVNCCore.FileInformation.ProductMinorPart; }
        public string ProductBuildPartVNCCore { get => Common.InformationVNCCore.FileInformation.ProductBuildPart; }
        public string ProductPrivatePartVNCCore { get => Common.InformationVNCCore.FileInformation.ProductPrivatePart; }
        public string CommentsVNCCore { get => Common.InformationVNCCore.FileInformation.Comments; }
        public string IsDebugVNCCore { get => Common.InformationVNCCore.FileInformation.IsDebug.ToString(); }
        public string IsPatchedVNCCore { get => Common.InformationVNCCore.FileInformation.IsPatched.ToString(); }
        public string IsPreReleaseVNCCore { get => Common.InformationVNCCore.FileInformation.IsPreRelease.ToString(); }
        public string IsPrivateBuildVNCCore { get => Common.InformationVNCCore.FileInformation.IsPrivateBuild.ToString(); }
        public string IsSpecialBuildVNCCore { get => Common.InformationVNCCore.FileInformation.IsSpecialBuild.ToString(); }

        public string RuntimeVersion { get => Common.InformationVNCCore.RuntimeVersion; }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        // This is the traditional approach - requires string name to be passed in

        //private void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            long startTicks = 0;
#if LOGGING
            if (LogOnPropertyChanged)
            {
                startTicks = Log.VIEWMODEL_LOW($"Enter ({propertyName})", Common.LOG_CATEGORY);
            }
#endif
            // This is the new CompilerServices attribute!

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
#if LOGGING
            if (LogOnPropertyChanged)
            {
                Log.VIEWMODEL_LOW("Exit", Common.LOG_CATEGORY, startTicks);
            }
#endif
        }

        #endregion
    }
}
