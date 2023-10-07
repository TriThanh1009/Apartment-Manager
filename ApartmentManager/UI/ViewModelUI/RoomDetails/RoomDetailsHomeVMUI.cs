using AM.UI.Command;
using AM.UI.Command.LoadDataBase;
using AM.UI.Command.RoomImages;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.View.Dialog;
using AM.UI.ViewModelUI.Factory;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ViewModel.Furniture;
using ViewModel.Room;
using ViewModel.RoomDetails;
using System.Drawing;
using System.Windows.Controls;
using AM.UI.View.RoomDetails;

namespace AM.UI.ViewModelUI.RoomDetails
{
    public class RoomDetailsHomeVMUI : ViewModelBase
    {



        private readonly RoomVm _LoadInformationRoom;
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

        public ICommand AddFurnitureSuccess { get; }
        public ICommand AddFurnitureConFirm { get; }

        public ICommand DeleteFurnitureSuccess { get; }
        public ICommand DeleteFurnitureConFirm { get; }

        //Properties

        public RoomVm LoadInformationRoom
        {
            get { return _LoadInformationRoom; }
            set
            {
                LoadInformationRoom = value;
                OnPropertyChanged(nameof(RoomVm));

            }
        }



        public bool HasData => _roomdetailsimage.Any();

        private bool _FlagImage = false;
        public bool FlagImage
        {
            get { return _FlagImage; }
            set
            {

                _FlagImage = value;
                OnPropertyChanged(nameof(FlagImage));
            }
        }



        private bool _FlagFurniture = false;
        public bool FlagFurniture
        {
            get { return _FlagFurniture; }
            set
            {

                _FlagFurniture = value;
                OnPropertyChanged(nameof(FlagFurniture));
            }
        }

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
            _LoadInformationRoom = id;

            _roomdetails = new ObservableCollection<RoomDetailsFurniture>();
            _roomdetailsimage = new ObservableCollection<RoomDetailsImage>();
            _comboBoxfurniture = new ObservableCollection<FurnitureVm>();
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
            new RoomDetailsShowLargeImage(BitmapImageFromFile(RoomImages.Url)).Show();
        }



        public static BitmapSource BitmapImageFromFile(string filepath)
        {
            BitmapImage bi = new BitmapImage();

            bi.BeginInit();
            bi.CacheOption = BitmapCacheOption.OnLoad; //here
            bi.CreateOptions = BitmapCreateOptions.IgnoreImageCache; //and here
            bi.UriSource = new Uri(filepath, UriKind.RelativeOrAbsolute);
            bi.EndInit();

            return bi;
        }
        public void DeleteImage(object parameter)
        {

            bool? Confirm = new MessageBoxCustom($"Do you want to delete customer :{RoomImages.IDImage} ", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (Confirm == true)
            {
                _ID = RoomImages.IDImage;

                if (File.Exists(_RoomImages.Url))
                {

                    File.Delete(_RoomImages.Url);

                }
                DeleteImageConfirmCommand.Execute(null);
                LoadDataBase.Execute(null);
            }
        }

        public async void Delete_Store(int id)
        {
                _navigator.CurrentViewModel = new RoomDetailsAddImageVMUI(_navigator, _ViewModelFactory, _apartmentStore, _RoomImages);
        }

        public void DeleteFurniture(object parameter)
        {
            bool? Confirm = new MessageBoxCustom($"Do you want to delete Furniture :{SelectListViewFurniture.IdFur} ", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if(Confirm == true) {

                DeleteFurnitureSuccess.Execute(null);
            }
        }

        public void UpdateDataFurniture(List<RoomDetailsFurniture> data)
        {
            foreach (var roomdetail in data)
            {
                _roomdetails.Add(roomdetail);
            }
        }

        public void UpdateDataImage(List<RoomDetailsImage> data)
        {
            _roomdetailsimage.Clear();
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