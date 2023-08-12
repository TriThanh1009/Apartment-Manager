using AM.UI.Command;
using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata;
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
    public class RoomAddVMUI : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _viewModelFactory;
        private readonly IRoom _iroom;
        private readonly RoomCreateViewModel _room;

        public ICommand RoomCreateConFirm { get; }

        public ICommand RoomHomeNav { get; }

        private int _iD;
        public int iD
        {
            get { return _iD; }
            set
            {
                _iD = value;
                OnPropertyChanged(nameof(iD));
            }
        }
        public int _iDLeader;
        public int iDLeader
        {
            get { return _iDLeader; }
            set
            {
                _iDLeader = value;
                OnPropertyChanged(nameof(iDLeader));
            }
        }
        public string _name;
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
            }
        }
        public int _quantity;
        public int quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(quantity));
            }
        }



         
        public RoomAddVMUI(IRoom iroom ,INavigator navigator,IAparmentViewModelFactory viewModelFactory) {
            _iroom = iroom;
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
            RoomCreateConFirm = new RelayAsyncCommand(CreateRoom);
            
            RoomHomeNav = new UpdateCurrentViewModelCommand(_navigator, _viewModelFactory);
            
        }

        public async Task CreateRoom()
        {
            RoomCreateViewModel r = new RoomCreateViewModel()
            {
                ID = iD,
                IDLeader = iDLeader,
                Name = name,
                Quantity = quantity

            };
            await _iroom.Create(r);
            RoomHomeNav.Execute(ViewType.Room);
            
        }
        public RoomCreateViewModel Room
        {
            get => _room;
            set
            {
                Room = value;
                OnPropertyChanged();
            }
        }
    }
}
