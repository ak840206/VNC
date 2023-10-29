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
        public string AssemblyTile { get => Common.InformationApplication.AssemblyInformation.AssemblyTitle; }
        public string AssemblyAssemblyVersion { get => Common.InformationApplication.AssemblyInformation.AssemblyVerison; }
        public string AssemblyCompany { get => Common.InformationApplication.AssemblyInformation.Company; }
        public string AssemblyConfiguration { get => Common.InformationApplication.AssemblyInformation.Configuration; }
        public string AssemblyCopyright { get => Common.InformationApplication.AssemblyInformation.Copyright; }
        public string AssemblyDescription { get => Common.InformationApplication.AssemblyInformation.Description; }


        public string AssemblyVersionVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Version; }
        public string AssemblyNameVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Name; }
        public string AssemblyFullNameVNCCore { get => Common.InformationVNCCore.AssemblyInformation.FullName; }
        public string AssemblyTileVNCCore { get => Common.InformationVNCCore.AssemblyInformation.AssemblyTitle; }
        public string AssemblyAssemblyVersionVNCCore { get => Common.InformationVNCCore.AssemblyInformation.AssemblyVerison; }
        public string AssemblyCompanyVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Company; }
        public string AssemblyConfigurationVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Configuration; }
        public string AssemblyCopyrightVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Copyright; }
        public string AssemblyDescriptionVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Description; }

        public string FileInformationFileVersion { get => Common.InformationApplication.AssemblyInformation.FileVersion; }
        public string AssemlbyInformationalVersion { get => Common.InformationApplication.AssemblyInformation.InformationalVersion; }
        public string AssemblyProduct { get => Common.InformationApplication.AssemblyInformation.Product; }

        public string AssemblyFileVersionVNCCore { get => Common.InformationVNCCore.AssemblyInformation.FileVersion; }
        public string AssemlbyInformationalVersionVNCCore { get => Common.InformationVNCCore.AssemblyInformation.InformationalVersion; }
        public string AssemblyProductVNCCore { get => Common.InformationVNCCore.AssemblyInformation.Product; }

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
