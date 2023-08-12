using AM.UI.Command;
using AM.UI.State.Navigators;
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
        private readonly RoomVm _roomUpdateViewModel;

        public ICommand UpdateConfirm { get; }

        public ICommand RoomHomeNav { get; }






        public RoomUpdateVMUI(IRoom iroom, RoomVm model,INavigator navigator,IAparmentViewModelFactory viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
            _iroom = iroom;
            _roomUpdateViewModel = model;
            _navigator = navigator;
            UpdateConfirm = new RelayCommand(UpdateConFirm);
            RoomHomeNav = new UpdateCurrentViewModelCommand(_navigator, _viewModelFactory);
            
        }


        public async void UpdateConFirm(object parameter)
        {
            RoomUpdateViewModel view = new RoomUpdateViewModel()
            {
                ID = Room.ID,
                IDLeader = int.Parse(Room.NameLeader),
                Name = Room.Name,
                Quantity = Room.Quantity


            };
            await _iroom.Update(view.ID,view);
            RoomHomeNav.Execute(ViewType.Room);





        }



        public RoomVm Room
        {
            get => _roomUpdateViewModel;
            set
            {
                Room = value;
                OnPropertyChanged();
            }
        }
    }
}
