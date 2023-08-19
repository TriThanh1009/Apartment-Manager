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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
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
        private readonly RoomVm _RoomViewModel;
        private readonly INavigator _navigator;
        public ICommand RoomNavCommand { get; }
        public ICommand RoomUpdateNavCommand { get; }

        public ICommand RoomDeleteCommand { get; }

        public ICommand FindingRoomCommand { get; }

        public ICommand LoadDataBase { get; }




        public string _Search = "...";
        public string Search
        {
            get { return _Search; }
            set
            {
                _Search = value;
                ChangedString(nameof(Search));
            }
        }


        public List<RoomVm> Room
        {
            get => _room;
            set { _room = value;
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





        public RoomHomeVMUI(IRoom iroom,INavigator navigator,IAparmentViewModelFactory viewModelFactory )
        {
            _iroom = iroom; 
            _viewModelFactory = viewModelFactory;
            _navigator = navigator;
            Room = new List<RoomVm>();
            LoadDataBase = new LoadRoomView(this, _iroom);
            LoadDataBase.Execute(null);
            RoomNavCommand = new UpdateCurrentViewModelCommand(navigator, viewModelFactory);
            RoomUpdateNavCommand = new RelayCommand(DataRoomUpdate);
            RoomDeleteCommand = new RelayCommand(DataRoomDelete);




        }

      

        public async void DataRoomDelete(object parameter)
        {
            if (parameter is RoomVm r)
            {
                await _iroom.Delete(r.ID);
                RoomNavCommand.Execute(ViewType.Room);
            }
        }

        private void ChangedString(string _Search)
        {
           if (Search.Equals(""))
           { 
                LoadDataBase.Execute(null);
                
           }
           else
            { 
            Room = Room.FindAll(x=>x.ID == Convert.ToInt32(Search));
           
            }
            OnPropertyChanged();

        }

        public RoomVm RoomV
        {
            get => _RoomViewModel;
            set
            {
                RoomV = value;
                OnPropertyChanged();
            }
        }

        public void DataRoomUpdate(object parameter)
        {
            if(parameter is RoomVm r)
            {
               
                _navigator.CurrentViewModel = new RoomUpdateVMUI(_iroom,r,_navigator,_viewModelFactory);
            }
        }
        
      

    }
}
