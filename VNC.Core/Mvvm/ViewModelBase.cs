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

        public string AssemblyVersion { get => Common.AssemblyVersion; }
        public string FileVersion { get => Common.FileVersion; }
        public string ProductVersion { get => Common.ProductVersion; }
        public string ProductName { get => Common.ProductName; }
        public string RuntimeVersion { get => Common.RuntimeVersion; }

        public string AssemblyVersionVNCCore { get => Common.AssemblyVersionVNCCore; }
        public string FileVersionVNCCore { get => Common.FileVersionVNCCore; }
        public string ProductVersionVNCCore { get => Common.ProductVersionVNCCore; }
        public string ProductNameVNCCore { get => Common.ProductNameVNCCore; }
        public string RuntimeVersionVNCCore { get => Common.RuntimeVersionVNCCore; }

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
