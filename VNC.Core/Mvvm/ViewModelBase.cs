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
        }

        public ViewModelBase(IView view)
        {
            View = view;
            View.ViewModel = this;
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

            long startTicks = Log.VIEWMODEL_LOW($"Enter ({propertyName})", Common.LOG_APPNAME);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            Log.VIEWMODEL_LOW("Exit", Common.LOG_APPNAME, startTicks);
        }
    }
}
