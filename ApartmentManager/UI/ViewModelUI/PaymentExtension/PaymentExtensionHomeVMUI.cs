using AM.UI.State.Navigators;
using AM.UI.State;
using AM.UI.ViewModelUI.Factory;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.DepositsContract;
using ViewModel.PaymentExtension;
using AM.UI.Utilities;

namespace AM.UI.ViewModelUI.PaymentExtension
{
    public class PaymentExtensionHomeVMUI : ViewModelBase
    {
        private readonly IPaymentExtension _ipayment;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _ViewModelFactory;
        private readonly ApartmentStore _apartmentStore;
        private ObservableCollection<PaymentExtensionVm> _payment;

        public IEnumerable<PaymentExtensionVm> Payment => _payment;

        public bool _IsLoading;
        public bool IsLoading
        {
            get { return _IsLoading; }
            set
            {
                _IsLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public string _MessageError;
        public string MessageError
        {
            get { return _MessageError; }
            set
            {
                _MessageError = value;
                OnPropertyChanged(nameof(MessageError));
            }
        }
        public bool HasMessageError => !string.IsNullOrEmpty(MessageError);


        public PaymentExtensionHomeVMUI(IPaymentExtension ipayment, INavigator navigator, IAparmentViewModelFactory ViewModelFactory, ApartmentStore apartmentStore)
        {
            _ipayment = ipayment;
            _navigator = navigator;
            _ViewModelFactory = ViewModelFactory;
            _apartmentStore = apartmentStore;
            _payment = new ObservableCollection<PaymentExtensionVm>();
        }
        public void UpdateData(List<PaymentExtensionVm> data)
        {
            foreach (var payment in data)
            {
                _payment.Add(payment);
            }
        }

    }
}

