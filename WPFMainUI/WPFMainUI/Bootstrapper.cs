using System.Windows;
using Prism.Modularity;
using Prism.Unity;
using WPFMainUI.Views;

namespace WPFMainUI
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            var moduleCatalog = this.ModuleCatalog as ModuleCatalog;

            // Register the UI modules here.
            // TODO:  Look into loading modules based on a package manifest.
            if (moduleCatalog != null)
            {
                moduleCatalog.AddModule(typeof(PrismMenuModule.PrismMenuModule));
                moduleCatalog.AddModule(typeof(PrismMVVMDemo.PrismMVVMModule));
            }
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            //this.Container.RegisterType<SplashScreenModule.IShell, MainWindow>(new ContainerControlledLifetimeManager());
        }
    }
}
