﻿using AM.UI.Command;
using AM.UI.Command.Room;
using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.View.Dialog;
using AM.UI.View.RoomDetails;
using AM.UI.View.Rooms;
using AM.UI.ViewModelUI.Factory;
using AM.UI.ViewModelUI.Room;
using AM.UI.ViewModelUI.RoomDetails;
using Data;
using Data.Entity;
using Data.Relationships;
using MaterialDesignColors;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Identity.Client;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Xml.Linq;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.People;
using ViewModel.Room;
using ViewModel.RoomDetails;
using static System.Net.Mime.MediaTypeNames;

namespace AM.UI.ViewModelUI
{
    public class RoomHomeVMUI : ViewModelBase
    {
        private readonly IRoom _iroom;
        private ObservableCollection<RoomVm> _room;

        private readonly IAparmentViewModelFactory _viewModelFactory;
        private readonly RoomVm _RoomViewModel;
        private readonly ApartmentDbContextFactory _factory;
        private readonly RoomDetailsHomeVMUI _roomDetailsHomeVMUI;
        private readonly RoomStore _apartmentStore;
        


        private readonly INavigator _navigator;
        public ICommand RoomNavCommand { get; }
        public ICommand RoomUpdateNavCommand { get; }

        public ICommand RoomDetailsCommand { get; }

        public ICommand RoomDeleteCommand { get; }

        public ICommand RoomDeleteCommandConfirm { get; }

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

        

        
        private string _messageError;

        public string MessageError
        {
            get { return _messageError; }
            set
            {
                _messageError = value;
                OnPropertyChanged(nameof(MessageError));
                OnPropertyChanged(nameof(HasErrorMessage));
            }
        }
        public bool HasErrorMessage => !string.IsNullOrEmpty(MessageError);

        private bool _isText;

        public bool IsText
        {
            get
            {
                return _isText;
            }
            set
            {
                _isText = value;
                OnPropertyChanged(nameof(IsText));
            }
        }

        public IEnumerable<RoomVm> Room => _room;

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

        private int _ID;

        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                OnPropertyChanged(nameof(ID));
            }
        }



        public RoomHomeVMUI(IRoom iroom, INavigator navigator, IAparmentViewModelFactory viewModelFactory, RoomStore apartmentStore,ApartmentDbContextFactory factory)
        {
            _iroom = iroom;
            _viewModelFactory = viewModelFactory;
            _navigator = navigator;
            _room = new ObservableCollection<RoomVm>();
            _factory = factory;
            LoadDataBase = new LoadRoomView(this, apartmentStore);
            LoadDataBase.Execute(null);
            RoomNavCommand = new UpdateCurrentViewModelCommand(navigator, viewModelFactory);
            _apartmentStore = apartmentStore;
            RoomUpdateNavCommand = new RelayCommand(DataRoomUpdate);
            RoomDeleteCommandConfirm = new RoomDeleteCommand(this, apartmentStore, navigator, viewModelFactory);
            RoomDetailsCommand = new RelayCommand(ShowRoomDetails);
            _room.CollectionChanged += OnReservationsChanged;
            _apartmentStore.RoomAdd += Store_Add;
            _apartmentStore.RoomDelete += Delete_Store;



        }


        private void Store_Add(RoomVm data)
        {
            _room.Add(data);
        }


        public void ShowRoomDetails(object parameter)
        {

            if(parameter is RoomVm room)
            {
                _navigator.CurrentViewModel = new RoomDetailsHomeVMUI(room, _navigator, _viewModelFactory, _apartmentStore);
            }


            


        }

        public void DeleteRoom(object parameter)
        {
            if(parameter is RoomVm room)
            {
                bool? Confirm = new MessageBoxCustom($"Do you want to delete customer :{room.ID} ", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
                if(Confirm == true)
                {
                    _ID = room.ID;
                    RoomDeleteCommandConfirm.Execute(null);
                }
            }
        }

        public async void Delete_Store(int id)
        {
            var object1 = _room.FirstOrDefault(x => x.ID == id);
            if (object1 != null)
            {
                _room.Remove(object1);
            }
        }

        public void UpdateData(List<RoomVm> data)
        {
            data.ForEach(x => _room.Add(x));
        }

        public void DataRoomUpdate(object parameter)
        {
            if (parameter is RoomVm r)
            {
                _navigator.CurrentViewModel = new RoomUpdateVMUI(_iroom, r, _navigator, _viewModelFactory, _apartmentStore);
            }
        }

        private void ChangedString(string _Search)
        {
           

        }

        private void OnReservationsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasData));
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
    }
}