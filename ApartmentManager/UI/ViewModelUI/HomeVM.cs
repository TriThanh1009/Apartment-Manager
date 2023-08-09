using AM.UI.State.Navigators;
using AM.UI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.ViewModelUI
{
    public class HomeVM : ViewModelBase
    {
        private readonly INavigator _navigator;

        public HomeVM(INavigator navigator)
        {
            _navigator = navigator;
        }
    }
}