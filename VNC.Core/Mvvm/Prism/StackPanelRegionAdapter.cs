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
            
        }

        protected override IRegion CreateRegion()
        {
            // Used for Content Controls.  One Active View.
            //return SingleActiveRegion();

            // Used for ItemControls.  All Views Active.  Cannot disable views.
            return new AllActiveRegion();

            // Used for SelectorClass.  Multiple Active Views
            //return new Region();
        }

        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
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
        }
    }
}
