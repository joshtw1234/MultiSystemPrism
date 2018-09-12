using Prism.Mvvm;
using PrismCommonGUILib.Models;
using PrismMenuModule.Models;
using System.Collections.ObjectModel;

namespace PrismMenuModule.ViewModels
{
    class MenuControlViewModel : BindableBase
    {
        IMenuModel _menuModel;

        public MenuControlViewModel(IMenuModel menuModel)
        {
            _menuModel = menuModel;
            MenuButtonItems = (_menuModel as BaseGUIModel).GetObservableCollection();
        }

        public ObservableCollection<IMenuItem> MenuButtonItems { get; set; }
    }
}
