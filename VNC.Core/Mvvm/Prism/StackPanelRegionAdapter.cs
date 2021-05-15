using System.Windows.Controls;
using System.Windows;
using Prism.Regions;

namespace VNC.Core.Mvvm.Prism
{
    public class StackPanelRegionAdapter : RegionAdapterBase<StackPanel>
    {
        public StackPanelRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory)
            : base(regionBehaviorFactory)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_CATEGORY);
#endif

#if LOGGING
            Log.Trace($"Exit", Common.LOG_CATEGORY, startTicks);
#endif

        }

        protected override IRegion CreateRegion()
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_CATEGORY);
#endif

#if LOGGING
            Log.Trace($"Exit", Common.LOG_CATEGORY, startTicks);
#endif
            // Used for Content Controls.  One Active View.
            //return SingleActiveRegion();

            // Used for ItemControls.  All Views Active.  Cannot disable views.
            return new AllActiveRegion();

            // Used for SelectorClass.  Multiple Active Views
            //return new Region();
        }

        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_CATEGORY);
#endif
            region.Views.CollectionChanged += (s, e) =>
                {
                    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                    {
                        foreach (FrameworkElement element in e.NewItems)
                        {
                            regionTarget.Children.Add(element);
                        }
                    }

                    //handle remove
                };

#if LOGGING
            Log.Trace($"Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }
    }
}
