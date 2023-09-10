using AM.UI.Command;
using AM.UI.Command.LoadDataBase;
using AM.UI.Command.RoomImages;
using AM.UI.Model;
using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.View.Dialog;
using AM.UI.ViewModelUI.Factory;
using Caliburn.Micro;
using Data.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
        private readonly RoomStore _apartmentStore;

        public ICommand LoadDataBase { get; }

        public ICommand RoomDetailsNav { get; }

        public ICommand DeleteImageCommand { get; }
        public ICommand DeleteImageConfirmCommand { get; }

        public ICommand ShowLargeImageNav { get; }








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


        private RoomDetailsImage _RoomImages;
        public RoomDetailsImage RoomImages
        {
            get { return _RoomImages; }
            set
            {
                _RoomImages = value;
                OnPropertyChanged(nameof(RoomImages));
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

        private int _IdDelete;
        public int IdDelete
        {
            get { return _IdDelete; }
            set
            {
                _IdDelete = value;
                OnPropertyChanged(nameof(IdDelete));
            }
        }

        

        public RoomDetailsHomeVMUI(RoomVm id, INavigator navigator, IAparmentViewModelFactory ViewModelFactory, RoomStore apartmentStore)
        {
            _navigator = navigator;
            _ViewModelFactory = ViewModelFactory;
            _apartmentStore = apartmentStore;
            _IdRoom = id;

            _roomdetails = new ObservableCollection<RoomDetailsFurniture>();
            _roomdetailsimage = new ObservableCollection<RoomDetailsImage>();
            LoadDataBase = new LoadRoomDetailsView(this, apartmentStore, id.ID);
            LoadDataBase.Execute(null);
            DeleteImageCommand = new RelayCommand(DeleteImage);
            DeleteImageConfirmCommand = new DeleleRoomImageCommand(navigator, ViewModelFactory, apartmentStore, this);
            ShowLargeImageNav = new RelayCommand(ShowLargeImage);
            RoomDetailsNav = new UpdateCurrentViewModelCommand(navigator, ViewModelFactory);
            _roomdetails.CollectionChanged += OnReservationsChanged;
            _apartmentStore.RoomImageDelete += Delete_Store;
        }

        public RoomVm _IdRoom;

        


        public void ShowLargeImage(object parameter)
        {
            MessageBox.Show("aa");
            if (parameter is RoomDetailsImage roomimage)
            {
                MessageBox.Show(roomimage.IDImage.ToString());
                _navigator.CurrentViewModel = new RoomDetailsEnlarge(_ViewModelFactory, _navigator, roomimage);
            }
        }




        public void DeleteImage(object parameter)
        {

                bool? Confirm = new MessageBoxCustom($"Do you want to delete customer :{RoomImages.IDImage} ", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
                if(Confirm == true)
                {

                    _ID = RoomImages.IDImage;
                    DeleteImageConfirmCommand.Execute(null);
                 }
        }

        public async void Delete_Store(int id)
        {
            var object1 = _roomdetailsimage.FirstOrDefault(x => x.IDImage == id);
            if(object1 != null)
            {
                _roomdetailsimage.Remove(object1);
            }
        }

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
