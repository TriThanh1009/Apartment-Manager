using AM.UI.Command;
using AM.UI.Command.LoadDataBase;
using AM.UI.Model;
using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Data.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.People;
using ViewModel.Room;
using ViewModel.RoomDetails;

namespace AM.UI.ViewModelUI.RoomDetails
{
    public class RoomDetailsHomeVMUI : ViewModelBase
    {
        private ObservableCollection<RoomDetailsFurniture> _roomdetails;
        private ObservableCollection<RoomDetailsImage> _roomdetailsimage;
        private ObservableCollection<FurnitureVm> _fur;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _ViewModelFactory;
        private readonly ApartmentStore _apartmentStore;

        public ICommand LoadDataBase { get; }

        public ICommand RoomDetailsNav { get; }







        public bool HasData => _roomdetails.Any();
        public bool _IsLoading;
        public bool IsLoading
        {
            get { return _IsLoading; }
            set
            {
                _IsLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public string _MessageError;
        public string MessageError
        {
            get { return _MessageError; }
            set
            {
                _MessageError = value;
                OnPropertyChanged(nameof(MessageError));
            }
        }
        public bool HasMessageError => !string.IsNullOrEmpty(MessageError);
        public ObservableCollection<RoomDetailsFurniture> RoomDetails => _roomdetails;


        public ObservableCollection<RoomDetailsImage> RoomDetailsImage => _roomdetailsimage;


        public RoomDetailsHomeVMUI(RoomVm id, INavigator navigator, IAparmentViewModelFactory ViewModelFactory, ApartmentStore apartmentStore)
        {
            _navigator = navigator;
            _ViewModelFactory = ViewModelFactory;
            _apartmentStore = apartmentStore;
            _IdRoom = id;

            _roomdetails = new ObservableCollection<RoomDetailsFurniture>();
            _roomdetailsimage = new ObservableCollection<RoomDetailsImage>();
            LoadDataBase = new LoadRoomDetailsView(this, apartmentStore, id.ID);
            LoadDataBase.Execute(null);
            RoomDetailsNav = new UpdateCurrentViewModelCommand(navigator, ViewModelFactory);
            _roomdetails.CollectionChanged += OnReservationsChanged;

        }

        public RoomVm _IdRoom;



        public void UpdateDataFurniture(List<RoomDetailsFurniture> data)
        {
            foreach(var roomdetail in data)
            {
                
                 _roomdetails.Add(roomdetail);
            }
        }
        public void UpdateDataImage(List<RoomDetailsImage> data)
        {
            foreach (var roomdetail in data)
            {
                _roomdetailsimage.Add(roomdetail);
            }
        }

        private void OnReservationsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasData));
        }





    }
}
