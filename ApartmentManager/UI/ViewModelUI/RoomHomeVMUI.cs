using AM.UI.Command;
using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.View.Rooms;
using AM.UI.ViewModelUI.Factory;
using AM.UI.ViewModelUI.Room;
using Data.Entity;
using Microsoft.Identity.Client;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.Room;
using ViewModel.RoomDetails;
using static System.Net.Mime.MediaTypeNames;

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

        public ICommand FindingRoomCommand { get; }
        public ICommand LoadDataBase { get; }

        public bool HasData => _room.Any();

        public int _IDFind;

        public int IDFind
        {
            get { return _IDFind; }
            set
            {
                _IDFind = value;
                OnPropertyChanged(nameof(IDFind));
            }
        }

        public List<RoomVm> Room
        {
            get => _room;
            set
            {
                _room = value;
                OnPropertyChanged();
            }
        }

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

        public RoomHomeVMUI(IRoom iroom, INavigator navigator, IAparmentViewModelFactory viewModelFactory)
        {
            _iroom = iroom;
            _viewModelFactory = viewModelFactory;
            _navigator = navigator;
            Room = new List<RoomVm>();
            LoadDataBase = new LoadRoomView(this, _iroom);
            LoadDataBase.Execute(null);
            RoomNavCommand = new UpdateCurrentViewModelCommand(navigator, viewModelFactory);

            RoomUpdateNavCommand = new RelayCommand(DataRoomUpdate);
        }

        public void UpdateData(List<RoomVm> data)
        {
            foreach (RoomVm room in data)
            {
                Room.Add(room);
            }
        }

        public async Task Finding()
        {
        }

        public void DataRoomUpdate(object parameter)
        {
            if (parameter is RoomVm r)
            {
                _navigator.CurrentViewModel = new RoomUpdateVMUI(_iroom, r, _navigator, _viewModelFactory);
            }
        }

        public void LoadData()
        {
            /*var paged = new RequestPaging { PageIndex = 1, PageSize = 10 };
             PagedResult<RoomVm> r = _iroom.GetAllPage(paged);
             r.Items.ForEach(x => Room.Add(x));*/

            /*List<Data.Entity.Room> a = await phong.GetAll();
            List<RoomVm> r = new List<RoomVm>();
            foreach(Data.Entity.Room room in a)
            {
                RoomVm roo = new RoomVm()
                {
                    ID = room.ID,
                    NameLeader = room.Name,
                    Name = room.Name,
                    Quantity = room.Quantity
                };
               r.Add( roo );
            }
            r.ForEach(x=>Room.Add(x));
            */
        }
    }
}