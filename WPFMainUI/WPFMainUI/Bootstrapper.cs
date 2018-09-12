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
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            //this.Container.RegisterType<SplashScreenModule.IShell, MainWindow>(new ContainerControlledLifetimeManager());
        }
    }
}
