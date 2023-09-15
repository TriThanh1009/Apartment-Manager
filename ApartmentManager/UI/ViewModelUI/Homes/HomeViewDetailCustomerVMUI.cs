using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.People;

namespace AM.UI.ViewModelUI.Homes
{
    public class HomeViewDetailCustomerVMUI : ViewModelBase
    {
        private readonly HomeStore _HomeStore;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _factory;

        private ObservableCollection<CustomerVM> _ListCustomer;
        public IEnumerable<CustomerVM> ListCustomer => _ListCustomer;

        private bool _isLoading;

        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public HomeViewDetailCustomerVMUI(HomeStore homeStore, INavigator navigator, IAparmentViewModelFactory aparmentViewModelFactory)
        {
            _HomeStore = homeStore;
            _navigator = navigator;
            _factory = aparmentViewModelFactory;
            _ListCustomer = new ObservableCollection<CustomerVM>();
        }

        public void UpdateData(List<CustomerVM> data)
        {
            _ListCustomer.Clear();
            foreach (var item in data)
            {
                _ListCustomer.Add(item);
            }
        }
    }
}