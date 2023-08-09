using AM.UI.State.Navigators;
using AM.UI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.Command
{
    public class NavigateCommand<TViewModel> : CommandBase where TViewModel : ViewModelBase
    {
        private readonly NavigationService<TViewModel> _navigationService;
        private readonly INavigator _navigator;

        public NavigateCommand(NavigationService<TViewModel> navigationService, INavigator navigator)
        {
            _navigationService = navigationService;
            _navigator = navigator;
        }

        public override void Execute(object parameter)
        {
            _navigator.CurrentViewModel = _navigationService.Navigate();
        }
    }
}