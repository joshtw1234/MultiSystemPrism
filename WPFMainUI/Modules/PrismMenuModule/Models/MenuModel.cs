using PrismCommonGUILib.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace PrismMenuModule.Models
{
    public class MenuModel : BaseGUIModel, IMenuModel
    {
        public override ObservableCollection<IMenuItem> GetObservableCollection()
        {
            return new ObservableCollection<IMenuItem>()
            {
                new BaseMenuItem()
                {
                    MenuName = "Menu 1",
                    MenuStyle = Application.Current.Resources["MenuButtonStyle"] as Style
                },
                new BaseMenuItem()
                {
                    MenuName = "Menu 2 adsfabadfasdfasdf",
                    MenuStyle = Application.Current.Resources["MenuButtonStyle"] as Style
                },
                new BaseMenuItem()
                {
                    MenuName = "Menu 3 adsfabfasdf",
                    MenuStyle = Application.Current.Resources["MenuButtonStyle"] as Style
                }
            };
        }
    }
}
