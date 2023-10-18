using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace VNC.Core.Mvvm
{
    public class INPCBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

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

        public event PropertyChangedEventHandler PropertyChanged;

        // This is the traditional approach - requires string name to be passed in

        //private void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
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
