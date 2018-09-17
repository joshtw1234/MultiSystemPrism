using Prism.Commands;
using System.Collections.ObjectModel;
using System.Windows;

namespace PrismCommonGUILib.Models
{
    public abstract class AbstractGUIFuns
    {
        /// <summary>
        /// Abstract function for get MenuItem
        /// </summary>
        /// <param name="menuName"></param>
        /// <param name="menuStyle"></param>
        /// <param name="menuCommand"></param>
        /// <param name="menuData"></param>
        /// <param name="menuEnable"></param>
        /// <param name="menuChecked"></param>
        /// <param name="menuVisibility"></param>
        /// <param name="menuImage"></param>
        /// <param name="menuImagePressed"></param>
        /// <returns></returns>
        protected abstract IMenuItem GetMenuItem(string menuName = "", Style menuStyle = null, DelegateCommand<string> menuCommand = null,
                                                 string menuData = "", bool menuEnable = false, bool menuChecked = false,
                                                 bool menuVisibility = false, string menuImage = "", string menuImagePressed = "");

        /// <summary>
        /// Abstract function for get base Observable collection
        /// </summary>
        /// <returns></returns>
        public abstract ObservableCollection<IMenuItem> GetBaseObservableCollection();
    }


    public class BaseGUIModel : AbstractGUIFuns
    {
        protected override IMenuItem GetMenuItem(string menuName = "", Style menuStyle = null, DelegateCommand<string> menuCommand = null, string menuData = "", bool menuEnable = false, bool menuChecked = false, bool menuVisibility = false, string menuImage = "", string menuImagePressed = "")
        {
            return new BaseMenuItem()
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
