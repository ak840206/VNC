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

        public string RuntimeVersion { get => Common.RuntimeVersion; }
        public string FileVersion { get => Common.FileVersion; }
        public string ProductVersion { get => Common.ProductVersion; }
        public string ProductName { get => Common.ProductName; }

        public string RuntimeVersionVNCCore { get => Common.RuntimeVersionVNCCore; }
        public string FileVersionVNCCore { get => Common.FileVersionVNCCore; }
        public string ProductVersionVNCCore { get => Common.ProductVersionVNCCore; }
        public string ProductNameVNCCore { get => Common.ProductNameVNCCore; }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        // This is the traditional approach - requires string name to be passed in

        //private void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        // This is the new CompilerServices attribute!

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            // TODO(crhodes)
            // Decide if we really want to log this.
#if LOGGING
            long startTicks = Log.VIEWMODEL_LOW($"Enter ({propertyName})", Common.LOG_CATEGORY);
#endif

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
#if LOGGING
            Log.VIEWMODEL_LOW("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion
    }
}
