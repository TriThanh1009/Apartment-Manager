using AM.UI.Command.LoadDataBase.LoadCombobox;
using AM.UI.Command.RentalContract;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using ViewModel.People;
using ViewModel.RentalContract;
using ViewModel.Room;

namespace AM.UI.ViewModelUI.RentalContract
{
    public class RentalContractAddVMUI : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _viewModelFactory;
        private readonly RentalContractStore _apartmentStore;
        private readonly RentalContractCreateViewModel _rental;
        private readonly ComboboxStore _comboboxStore;
        private ObservableCollection<RentalContractVm> _rentalforColection;
        public IEnumerable<RentalContractVm> rentalforColection => _rentalforColection;


        public ICommand CreateSuccess { get; }

        public ICommand CreateConFirm { get; }

        public ICommand LoadDataForCombobox { get; }

        //Properties



        private DateTime _ReceiveDate = DateTime.Now;
        public DateTime ReceiveDate
        {
            get { return _ReceiveDate; }
            set { _ReceiveDate = value; OnPropertyChanged(nameof(ReceiveDate)); }
        }

        private DateTime _CheckOutDate = DateTime.Now;
        public DateTime CheckOutDate
        {
            get { return _CheckOutDate; }
            set { _ReceiveDate = value; OnPropertyChanged(nameof(CheckOutDate)); }
        }


        private int _RoomMoney;

        public int RoomMoney
        {
            get { return _RoomMoney; }
            set
            { _RoomMoney = value; OnPropertyChanged(nameof(RoomMoney)); }
        }

        private int _ELectricMoney;

        public int ELectricMoney
        {
            get { return _ELectricMoney; }
            set
            { _ELectricMoney = value; OnPropertyChanged(nameof(ELectricMoney)); }
        }

        private int _WaterMoney;

        public int WaterMoney
        {
            get { return _WaterMoney; }
            set
            { _WaterMoney = value; OnPropertyChanged(nameof(WaterMoney)); }
        }


        private int _ServiceMoney;

        public int ServiceMoney
        {
            get { return _ServiceMoney; }
            set
            { _ServiceMoney = value; OnPropertyChanged(nameof(ServiceMoney)); }
        }

        public bool HasData => _rentalforColection.Any();


        public ObservableCollection<CustomerForCombobox> _comboboxforCustomer;
        public IEnumerable<CustomerForCombobox> comboboxforCustomer => _comboboxforCustomer;


        private CustomerForCombobox _SelectCustomer;
        public CustomerForCombobox SelectCustomer
        {
            get { return _SelectCustomer; }
            set
            {

                _SelectCustomer = value;
                OnPropertyChanged(nameof(SelectCustomer));
            }
        }


        public ObservableCollection<RoomForCombobox> _comboboxforRoom;
        public IEnumerable<RoomForCombobox> comboboxforRoom => _comboboxforRoom;


        private RoomForCombobox _SelectRoom;
        public RoomForCombobox SelectRoom
        {
            get { return _SelectRoom; }
            set
            {

                _SelectRoom = value;
                OnPropertyChanged(nameof(SelectRoom));
            }
        }


        public RentalContractAddVMUI(INavigator navigator, IAparmentViewModelFactory viewModelFactory, RentalContractStore apartmentStore, ComboboxStore comboboxStore)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
            _apartmentStore = apartmentStore;
            _comboboxStore = comboboxStore;
            _comboboxforCustomer = new ObservableCollection<CustomerForCombobox>();
            _comboboxforRoom = new ObservableCollection<RoomForCombobox>();
            CreateConFirm = new RelayCommand(AddRentalContract);
            CreateSuccess = new AddRentalContractCommand(this, _apartmentStore, _navigator, _viewModelFactory);
            
            LoadDataForCombobox = new LoadComboxForRentalContractAdd(this, _comboboxStore);
            LoadDataForCombobox.Execute(null);
            _comboboxforRoom.CollectionChanged += OnReservationsChanged;
            _comboboxforCustomer.CollectionChanged += OnReservationsChanged;

        }

        public void AddRentalContract(object parameter)
        {
            CreateSuccess.Execute(null);
        }

        public void UpdateDataForCustomerCombobox(List<CustomerForCombobox> data)
        {
            data.ForEach(x => _comboboxforCustomer.Add(x));
        }

        public void UpdateDataForRoomCombobox(List<RoomForCombobox> data)
        {
            data.ForEach(x => _comboboxforRoom.Add(x));
        }

        private void OnReservationsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasData));
        }

    }
}