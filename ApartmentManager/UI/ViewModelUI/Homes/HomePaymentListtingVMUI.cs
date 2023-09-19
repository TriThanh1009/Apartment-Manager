using AM.UI.Command.Home;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel.PaymentExtension;
using ViewModel.Room;

namespace AM.UI.ViewModelUI
{
    public class HomePaymentListtingVMUI : ViewModelBase
    {
        private readonly HomeStore _HomeStore;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _factory;
        private ObservableCollection<PaymentExtensionVm> _Listpayment;

        public IEnumerable<PaymentExtensionVm> ListPE => _Listpayment;
        public bool HasData => _Listpayment.Any();

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

        public ICommand ReturnBillHomeVM { get; }
        public ICommand LoadDataCommand { get; }

        public HomePaymentListtingVMUI(IHome home, HomeStore homeStore, INavigator navigator, IAparmentViewModelFactory factory)
        {
            _HomeStore=homeStore;
            _navigator=navigator;
            _factory=factory;
            _Listpayment = new ObservableCollection<PaymentExtensionVm>();
            ReturnBillHomeVM = new UpdateCurrentHomeViewModelCommand(home, homeStore, navigator, factory);
            LoadDataCommand = new LoadPaymentEListingCommand(this, homeStore);
            LoadDataCommand.Execute(null);
        }

        public void UpdateData(List<PaymentExtensionVm> data)
        {
            _Listpayment.Clear();
            data.ForEach(x => _Listpayment.Add(x));
        }

        private void OnReservationsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasData));
        }
    }
}