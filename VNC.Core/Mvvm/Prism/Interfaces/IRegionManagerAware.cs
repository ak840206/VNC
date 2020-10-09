using Prism.Regions;

namespace VNC.Core.Mvvm.Prism
{
    public interface IRegionManagerAware
    {
        IRegionManager RegionManager { get; set; }
    }
}
