using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using Unity;

namespace VNC.Core.Mvvm.Prism
{
    public abstract class ModuleBase : IModule
    {
        protected IRegionManager RegionManager { get; private set; }
        protected IUnityContainer Container { get; private set; }

        public ModuleBase(IUnityContainer container, IRegionManager regionManager)
        {
            Container = container;
            RegionManager = regionManager;
        }

        public void Initialize()
        {
            RegisterTypes();
            InitializeModule();
        }

        protected abstract void InitializeModule();

        protected abstract void RegisterTypes();

        //These are in 7 not 6.3
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        public void OnInitialized(IContainerProvider containerProvider)
        {

        }
    }
}
