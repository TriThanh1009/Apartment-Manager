using AM.UI.Command;
using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.View.Rooms;
using AM.UI.ViewModelUI.Factory;
using AM.UI.ViewModelUI.Room;
using Microsoft.Identity.Client;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.Room;
using ViewModel.RoomDetails;

namespace AM.UI.ViewModelUI
{
    public class RoomHomeVMUI : ViewModelBase
    {
        private readonly IRoom _iroom;
        private List<RoomVm> _room;
        private readonly IAparmentViewModelFactory _viewModelFactory;
        private readonly INavigator _navigator;
        public ICommand RoomNavCommand { get; }
        public ICommand RoomUpdateNavCommand { get; }


        public List<RoomVm> Room
        {
            get => _room;
            set { _room = value;
                OnPropertyChanged();
            }
        }

        public RoomHomeVMUI(IRoom iroom,INavigator navigator,IAparmentViewModelFactory viewModelFactory )
        {
            _viewModelFactory = viewModelFactory;
            _navigator = navigator;
            RoomNavCommand = new UpdateCurrentViewModelCommand(navigator, viewModelFactory);

            _iroom = iroom;
             Room = new List<RoomVm>();

            LoadData();
        }
      

 
        public async void LoadData()
        {
            var paged = new RequestPaging { PageIndex = 1, PageSize = 10 };
            PagedResult<RoomVm> r = _iroom.GetAllPage(paged);
            r.Items.ForEach(x => Room.Add(x));
        }
    }
}
