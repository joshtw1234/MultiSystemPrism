using System.Collections.ObjectModel;
using System.Windows;

namespace PrismCommonGUILib.Models
{
    public abstract class BaseGUIModel
    {
        public virtual ObservableCollection<IMenuItem> GetObservableCollection()
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
                }
            };
        }
    }
}
