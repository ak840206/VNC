using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VNC.Core.Mvvm
{
    public class ViewModelBase : IViewModel, INotifyPropertyChanged
    {
        public IView View
        {
            get;
            set;
        }

        public ViewModelBase() 
        {
#if LOGGING
            long startTicks = Log.CONSTRUCTOR($"Enter()", Common.LOG_APPNAME);
#endif

#if LOGGING
            Log.CONSTRUCTOR($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        public ViewModelBase(IView view)
        {
#if LOGGING
            long startTicks = Log.CONSTRUCTOR($"Enter({view.GetType()})", Common.LOG_APPNAME);
#endif
            View = view;
            View.ViewModel = this;

#if LOGGING
            Log.CONSTRUCTOR($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This is the traditional approach - requires string name to be passed in

        //private void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        // This is the new CompilerServices attribute!

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
