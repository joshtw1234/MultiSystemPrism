using System.Windows;
using Prism.Commands;

namespace PrismCommonGUILib.Models
{
    public class BaseMenuItem : IMenuItem
    {
        public string MenuName { get; set; }
        public string MenuImage { get; set; }
        public string MenuImagePressed { get; set; }
        public string MenuData { get; set; }
        public DelegateCommand<string> MenuCommand { get; set; }
        public Style MenuStyle { get; set; }
        public bool MenuEnabled { get; set; }
        public bool MenuChecked { get; set; }
        public bool MenuVisibility { get; set; }
    }
}
