using Prism.Modularity;
using Prism.Regions;
using PrismMenuModule.Views;

namespace PrismMenuModule
{
    public class PrismMenuModule : IModule
    {
        /// <summary>
        /// The _region manager.
        /// </summary>
        private readonly IRegionManager _regionManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuModule"/> class.
        /// </summary>
        /// <param name="regionManager">
        /// The region manager.
        /// </param>
        public PrismMenuModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MenuRegion", typeof(MenuControl));
        }
    }
}
