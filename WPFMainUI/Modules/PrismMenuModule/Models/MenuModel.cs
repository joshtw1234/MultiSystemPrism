﻿using PrismCommonGUILib.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    MenuName = "Menu 3 adsfabadfasdfasdf",
                    MenuStyle = Application.Current.Resources["MenuButtonStyle"] as Style
                }
            };
        }
    }
}
