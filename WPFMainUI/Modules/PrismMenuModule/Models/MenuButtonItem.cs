using Prism.Commands;
using PrismCommonGUILib.Models;
using System.Collections.ObjectModel;

namespace PrismMenuModule.Models
{
    class MenuButtonItem : BaseMenuItem
    {
        /// <summary>
        /// Gets or sets the top level menu item.
        /// </summary>
        public IMenuItem TopLevelMenuItem
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the second level menu collection.
        /// </summary>
        public ObservableCollection<IMenuItem> SecondLevelMenuCollection
        {
            get;
            set;
        }

        /// <summary>
        /// TopLevelToggleCommand is the command that is executed for an action
        /// on a particular menu item 
        /// </summary>
        public DelegateCommand<string> TopLevelToggleCommand
        {
            get
            {
                if (SecondLevelMenuCollection != null)
                {
                    return SecondLevelMenuCollection.Count > 0 ? SecondLevelMenuCollection[0].MenuCommand : TopLevelMenuItem.MenuCommand;
                }

                return TopLevelMenuItem.MenuCommand;
            }
        }

        /// <summary>
        /// TopLevelToggleCommandParameter is the data associated to a particular menu item
        /// on a particular menu item 
        /// </summary>
        public string TopLevelToggleCommandParameter
        {
            get
            {
                if (SecondLevelMenuCollection != null)
                {
                    return SecondLevelMenuCollection.Count > 0 ? SecondLevelMenuCollection[0].MenuData : TopLevelMenuItem.MenuData;
                }

                return TopLevelMenuItem.MenuData;
            }
        }
    }
}
