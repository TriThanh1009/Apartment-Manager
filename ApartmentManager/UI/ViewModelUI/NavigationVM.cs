using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.UI.Utilities;
using System.Windows.Input;
using ViewModel.People;
using ViewModel.Room;
using System.Windows.Navigation;
using AM.UI.Command;

namespace AM.UI.ViewModelUI
{
    internal class NavigationVM : ViewModelBase
    {
        private readonly Navigation _navigation;

        public ViewModelBase CurrentViewModel => _navigation.CurrentViewModel;
        public ICommand HomeCommand { get; }

        public NavigationVM(Navigation navigation, NavigationService<HomeVM> HomeVMNagvigation, NavigationService<CustomerVMUI> CustomerVMNagvigation)
        {
            _navigation = navigation;
            HomeCommand = new NavigateCommand<HomeVM>(HomeVMNagvigation);

            _navigation.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        public static NavigationVM LoadViewModel(Navigation navigation, NavigationService<HomeVM> HomeVMNagvigation, NavigationService<CustomerVMUI> CustomerVMNagvigation)
        {
            NavigationVM navigationVM = new NavigationVM(navigation, HomeVMNagvigation, CustomerVMNagvigation);
            return navigationVM;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}