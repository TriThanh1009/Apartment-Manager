using AM.UI.Command.LoadDataBase;
using AM.UI.State;
using AM.UI.State.Navigators;
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
using ViewModel.DepositsContract;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.People;

namespace AM.UI.ViewModelUI.DepositContract
{
    public class DepositContractHomeVMUI : ViewModelBase
    {
        private readonly IDepositsContract _ideposit;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _ViewModelFactory;
        private readonly ApartmentStore _apartmentStore;
        private ObservableCollection<DepositsContractVm> _deposit;
        
        public ICommand LoadDataBase { get; }
        public IEnumerable<DepositsContractVm> Deposit => _deposit;



        public bool HasData => _deposit.Any();

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


        public DepositContractHomeVMUI(IDepositsContract ideposit, INavigator navigator, IAparmentViewModelFactory ViewModelFactory, ApartmentStore apartmentStore)
        {
            _ideposit = ideposit;
            _navigator = navigator;
            _ViewModelFactory = ViewModelFactory;
            _apartmentStore = apartmentStore;
            _deposit = new ObservableCollection<DepositsContractVm>();
            LoadDataBase = new LoadDepositContractview(this, apartmentStore);
            LoadDataBase.Execute(null);
            _deposit.CollectionChanged += OnReservationsChanged;
        }

        public static DepositContractHomeVMUI DepositsContractViewModel(IDepositsContract ideposit, INavigator navigator, IAparmentViewModelFactory ViewModelFactory, ApartmentStore apartmentStore)
        {
            DepositContractHomeVMUI deposit = new DepositContractHomeVMUI(ideposit, navigator, ViewModelFactory, apartmentStore);
            deposit.LoadDataBase.Execute(null);
            return deposit;
        }


        public void UpdateData(List<DepositsContractVm> data)
        {
            foreach (DepositsContractVm deposit in data)
            {
                _deposit.Add(deposit);
            }
        }

        private void OnReservationsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasData));
        }

    }
    
}
