﻿using AM.UI.Command.DepositContract;
using AM.UI.Command.LoadDataBase.LoadCombobox;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ViewModel.Room;

namespace AM.UI.ViewModelUI.DepositContract
{
    public class DepositContractAddVMUI : ViewModelBase
    {
        private readonly DepositContractStore _store;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _viewModelFactory;
        private readonly ComboboxStore _comboboxStore;

        public ICommand AddConFirm { get; }
        public ICommand AddSuccess { get; }

        public ICommand LoadDataForCombobox { get; }





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

        private DateTime _DepositsDate;

        public DateTime DepositDate
        {
            get { return _DepositsDate; }
            set
            {
                _DepositsDate = value;
                OnPropertyChanged(nameof(DepositDate));
            }
        }

        private DateTime _ReceiveDate = DateTime.Now;

        public DateTime ReceiveDate
        {
            get { return _ReceiveDate; }
            set
            {
                _DepositsDate = value;
                OnPropertyChanged(nameof(ReceiveDate));
            }
        }



        private DateTime _CheckOutDate = DateTime.Now;

        public DateTime CheckOutDate
        {
            get { return _CheckOutDate; }
            set
            {
                _DepositsDate = value;
                OnPropertyChanged(nameof(CheckOutDate));
            }
        }




        private int _Money;
        public int Money
        {
            get { return _Money; }
            set
            {
                _Money = value;
                OnPropertyChanged(nameof(Money));
            }
        }



        public DepositContractAddVMUI(DepositContractStore store, INavigator navigator, IAparmentViewModelFactory viewModelFactory, ComboboxStore comboboxStore)
        {
            _store = store;
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
            _comboboxStore = comboboxStore;
            _comboboxforRoom = new ObservableCollection<RoomForCombobox>();
            LoadDataForCombobox = new LoadComboboxForDepositContractAdd(_comboboxStore, this);
            LoadDataForCombobox.Execute(null);
            AddSuccess = new DepositContractAddCommand(_store, this,_navigator,_viewModelFactory);
            AddConFirm = new RelayCommand(AddDeposit);
        }



        public void AddDeposit(object parameter)
        {

            AddSuccess.Execute(null);
        }


        public void UpdateDataForRoomCombobox(List<RoomForCombobox> data)
        {
            data.ForEach(x=> _comboboxforRoom.Add(x));
        }
    }
}
