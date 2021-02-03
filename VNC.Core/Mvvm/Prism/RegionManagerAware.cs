using System.Windows;

using Prism.Regions;

namespace VNC.Core.Mvvm.Prism
{
    public static class RegionManagerAware
    {
        public static void SetRegionManagerAware(object viewOrViewModel, IRegionManager regionManager)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            // Want to support View and/or ViewModel first approaches so
            // Perhaps this could become an extension method on RegionManager!

            var viewModelIsRegionManagerAware = viewOrViewModel as IRegionManagerAware;

            // ViewModel first approach

            // Check if supports IRegionManagerAware

            if (viewModelIsRegionManagerAware != null)
            {
                viewModelIsRegionManagerAware.RegionManager = regionManager;
            }

            // View first approach

            // If we get a View it will be a FrameworkElement in WPF

            var viewIsRegionManagerAware = viewOrViewModel as FrameworkElement;

            if (viewIsRegionManagerAware != null)
            {
                // Verify the View implements the IRegionManagerAware interface

                var isRegionManagerAwareDataContext = viewIsRegionManagerAware.DataContext as IRegionManagerAware;

                if (isRegionManagerAwareDataContext != null)
                {
                    isRegionManagerAwareDataContext.RegionManager = regionManager;
                }
            }
#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }
    }
}
