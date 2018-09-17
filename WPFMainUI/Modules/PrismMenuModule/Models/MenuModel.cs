using Prism.Commands;
using PrismCommonGUILib.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace PrismMenuModule.Models
{
    public class MenuModel : BaseGUIModel, IMenuModel
    {
        protected override IMenuItem GetMenuItem(string menuName = "", Style menuStyle = null, DelegateCommand<string> menuCommand = null, string menuData = "", bool menuEnable = false, bool menuChecked = false, bool menuVisibility = false, string menuImage = "", string menuImagePressed = "")
        {
            //return base.GetMenuItem(menuName, menuStyle, menuCommand, menuData, menuEnable, menuChecked, menuVisibility, menuImage, menuImagePressed);
            return new MenuButtonItem()
            {
                MenuName = menuName,
                MenuData = menuData,
                MenuImage = menuImage,
                MenuImagePressed = menuImagePressed,
                MenuEnabled = menuEnable,
                MenuChecked = menuChecked,
                MenuVisibility = menuVisibility,
                MenuStyle = menuStyle,
                MenuCommand = menuCommand
            };
        }
        public override ObservableCollection<IMenuItem> GetBaseObservableCollection()
        {
            return new ObservableCollection<IMenuItem>()
            {
                GetMenuItem("Menu 1", Application.Current.Resources["MenuButtonStyle"] as Style),
                GetMenuItem("Menu 2", Application.Current.Resources["MenuButtonStyle"] as Style),
                GetMenuItem("Menu 3", Application.Current.Resources["MenuButtonStyle"] as Style)
            };
        }
    }
}
