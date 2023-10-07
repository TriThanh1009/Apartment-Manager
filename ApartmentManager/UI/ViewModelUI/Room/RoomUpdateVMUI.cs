using AM.UI.Command;
using AM.UI.Command.LoadDataBase;
using AM.UI.Command.LoadDataBase.LoadCombobox;
using AM.UI.Command.Room;
using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Caliburn.Micro;
using Data.Entity;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;
using ViewModel.People;
using ViewModel.RentalContract;
using ViewModel.Room;
using ViewModel.RoomDetails;

namespace AM.UI.ViewModelUI.Room
{
    public class RoomUpdateVMUI : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _viewModelFactory;
        private readonly IRoom _iroom;
        private readonly RoomStore _apartmentStore;
        private readonly RoomVm _roomUpdateViewModel;
        private readonly RentalContractHomeVMUI rental;
        private ObservableCollection<CustomerVM> _room;
        public IEnumerable<CustomerVM> Roomm => _room;


        public ICommand LoadCustomerData { get; }
        public ICommand UpdateConfirm { get; }

        public ICommand RoomHomeNav { get; }

        public ICommand UpdateSuccess { get; }

        public ICommand Checkcombo { get; }

        public bool HasData => _room.Any();

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



        public RoomUpdateVMUI(IRoom iroom, RoomVm model,INavigator navigator,IAparmentViewModelFactory viewModelFactory, RoomStore apartmentStore)
        {
            _viewModelFactory = viewModelFactory;
            _iroom = iroom;
            _roomUpdateViewModel = model;
            _navigator = navigator;
            _apartmentStore = apartmentStore;
            LoadCustomerData = new LoadComboboxRoomForRoomUpdate(this, _apartmentStore);
            LoadCustomerData.Execute(null);
            _comboboxforCustomer = new ObservableCollection<CustomerForCombobox>();
            UpdateSuccess = new UpdateRoomCommand(this, navigator, viewModelFactory, apartmentStore);
            UpdateConfirm = new RelayCommand(UpdateRoom);
            RoomHomeNav = new UpdateCurrentViewModelCommand(_navigator, _viewModelFactory);
             _comboboxforCustomer.CollectionChanged += OnReservationsChanged;

        }




        public void UpdateDataCustomer(List<CustomerForCombobox> data)
        {
            data.ForEach(x => _comboboxforCustomer.Add(x));
        }

        public void UpdateRoom(object parameter)
        {
            UpdateSuccess.Execute(null);
        }


        public RoomVm Room
        {
            get => _roomUpdateViewModel;
            set
            {
                Room = value;
                OnPropertyChanged(nameof(RoomVm));
            }
        }

        private void OnReservationsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasData));
        }
    }
}
