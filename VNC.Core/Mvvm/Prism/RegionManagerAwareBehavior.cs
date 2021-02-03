using System;
using System.Collections.Specialized;
using System.Windows;
using Prism.Regions;

namespace VNC.Core.Mvvm.Prism
{
    public class RegionManagerAwareBehavior : RegionBehavior
    {
        // Every behavior needs a key

        public const string BehaviorKey = "RegionManagerAwareBehavior";

        protected override void OnAttach()
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            // Attach to all regions.  But, can also pick and choose

            Region.ActiveViews.CollectionChanged += ActiveViews_CollectionChanged;

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        void ActiveViews_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    IRegionManager regionManager = Region.RegionManager;

                    FrameworkElement element = item as FrameworkElement;

                    if (element != null)
                    {
                        IRegionManager scopedRegionManager =
                            element.GetValue(RegionManager.RegionManagerProperty) as IRegionManager;

                        if (scopedRegionManager != null)
                        {
                            regionManager = scopedRegionManager;
                        }
                    }

                    InvokeOnRegionManagerAwareElement(item, x => x.RegionManager = regionManager);
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (var item in e.OldItems)
                {
                    InvokeOnRegionManagerAwareElement(item, x => x.RegionManager = null);
                }
            }

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        static void InvokeOnRegionManagerAwareElement(object item, Action<IRegionManagerAware> invocation)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif

            // Want to support View and/or ViewModel first approaches

            var rmAwareItem = item as IRegionManagerAware;

            // ViewModel first approach

            // Check if supports IRegionManagerAware

            if (rmAwareItem != null)
            {
                invocation(rmAwareItem);
            }

            // View first approach

            // If we get a View it will be a FrameworkElement in WPF

            var frameworkElement = item as FrameworkElement;

            if (frameworkElement != null)
            {
                IRegionManagerAware rmAwareDataContext = frameworkElement.DataContext as IRegionManagerAware;

                if (rmAwareDataContext != null)
                {
                    var frameworkElementParent = frameworkElement.Parent as FrameworkElement;

                    // If a view does not have a DataContext, i.e. a ViewModel, it will inherit DataContext of parent view
                    // Avoid setting RegionManager of parent view

                    if (frameworkElementParent != null)
                    {
                        var rmAwareDataContextParent = frameworkElementParent.DataContext as IRegionManagerAware;

                        if (rmAwareDataContextParent != null)
                        {
                            if (rmAwareDataContext == rmAwareDataContextParent)
                            {
                                // This View doesn't have a ViewModel.  
                                // It is using ViewModel of Visible parent.  Do not set.

                                return;
                            }
                        }
                    }

                    invocation(rmAwareDataContext);
                }
            }
#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }
    }
}
