using AM.UI.Command;
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ViewModel.Room;

namespace AM.UI.ViewModelUI.Room
{
    public class RoomUpdateVMUI : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _viewModelFactory;
        private readonly IRoom _iroom;
        private readonly RoomStore _apartmentStore;
        private readonly RoomVm _roomUpdateViewModel;

        public ICommand UpdateConfirm { get; }

        public ICommand RoomHomeNav { get; }

        public ICommand UpdateSuccess { get; }






        public RoomUpdateVMUI(IRoom iroom, RoomVm model,INavigator navigator,IAparmentViewModelFactory viewModelFactory, RoomStore apartmentStore)
        {
            _viewModelFactory = viewModelFactory;
            _iroom = iroom;
            _roomUpdateViewModel = model;
            _navigator = navigator;
            _apartmentStore = apartmentStore;
            UpdateConfirm = new RelayCommand(UpdateConFirm);
            UpdateSuccess = new UpdateRoomCommand(this, navigator, viewModelFactory, apartmentStore);
            RoomHomeNav = new UpdateCurrentViewModelCommand(_navigator, _viewModelFactory);
            
        }


        public async void UpdateConFirm(object parameter)
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
    }
}
