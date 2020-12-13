﻿using System.ComponentModel;
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
<<<<<<< HEAD
            long startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);
#endif

#if LOGGING
            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
=======
            long startTicks = Log.CONSTRUCTOR($"Enter()", Common.LOG_APPNAME);
#endif

#if LOGGING
            Log.CONSTRUCTOR($"Exit", Common.LOG_APPNAME, startTicks);
>>>>>>> 0578b93940613b246fac34e87b2166564e3d755f
#endif
        }

        public ViewModelBase(IView view)
        {
#if LOGGING
<<<<<<< HEAD
            long startTicks = Log.CONSTRUCTOR($"Enter ({view.GetType()})", Common.LOG_APPNAME);
=======
            long startTicks = Log.CONSTRUCTOR($"Enter({view.GetType()})", Common.LOG_APPNAME);
>>>>>>> 0578b93940613b246fac34e87b2166564e3d755f
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
            // TODO(crhodes)
            // Decide if we really want to log this.
#if LOGGING
            long startTicks = Log.VIEWMODEL_LOW("Enter", Common.LOG_APPNAME);
#endif
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
#if LOGGING
            Log.VIEWMODEL_LOW("Exit", Common.LOG_APPNAME, startTicks);
#endif
        }
    }
}
