using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VNC.Core.Mvvm
{
    public class INPCBase : INotifyPropertyChanged
    {
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
//            // Decide if we really want to log this.
//#if LOGGING
//            long startTicks = Log.VIEWMODEL_LOW($"Enter ({propertyName})", Common.LOG_CATEGORY);
//#endif

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

//#if LOGGING
//            Log.VIEWMODEL_LOW("Exit", Common.LOG_CATEGORY, startTicks);
//#endif
        }

        #endregion
    }
}
