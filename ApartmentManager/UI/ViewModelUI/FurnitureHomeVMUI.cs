using AM.UI.Command;
using AM.UI.Command.Furniture;
using AM.UI.Command.LoadDataBase;
using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.View.Dialog;
using AM.UI.ViewModelUI.Factory;
using AM.UI.ViewModelUI.Furnitures;
using Data.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.People;
using ViewModel.Room;

namespace AM.UI.ViewModelUI
{
    public class FurnitureHomeVMUI : Utilities.ViewModelBase
    {
        private ObservableCollection<FurnitureVm> _fur;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _ViewModelFactory;
        private readonly FurnitureStore _apartmentStore;
        public IFurniture _ifur;
        public IEnumerable<FurnitureVm> Fur => _fur;




        public ICommand LoadDataBase { get; }

        public ICommand FurnitureNav { get; }

        public ICommand FurnitureUpdateNav { get; }

        public ICommand DeleteSuccess { get; }
        public ICommand DeleteConFirm { get; }


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

        public bool HasData => _fur.Any();

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



        public int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        public string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }



        public bool HasMessageError => !string.IsNullOrEmpty(MessageError);

        public FurnitureHomeVMUI(IFurniture ifur, INavigator navigator, IAparmentViewModelFactory ViewModelFactory, FurnitureStore apartmentStore)
        {
            _ifur = ifur;
            _navigator = navigator;
            _ViewModelFactory = ViewModelFactory;
            _apartmentStore = apartmentStore;
            _fur = new ObservableCollection<FurnitureVm>();
            LoadDataBase = new LoadFurnitureView(this, apartmentStore);
            LoadDataBase.Execute(null);
            FurnitureNav = new UpdateCurrentViewModelCommand(navigator, ViewModelFactory);
            FurnitureUpdateNav = new RelayCommand(FurnitureUpdateNavDef);
            DeleteSuccess = new FurnitureDeleteCommand(this, apartmentStore, navigator, ViewModelFactory);
            DeleteConFirm = new RelayCommand(DeleteFurniture);
            _apartmentStore.FurnitureAdd += Store_Add;


        }


        public void DeleteFurniture(object parameter)
        {
            if (parameter is FurnitureVm furniture)
            {
                bool? Confirm = new MessageBoxCustom($"Do you want to delete customer :{furniture.ID} ", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
                if (Confirm == true)
                {
                    _ID = furniture.ID;
                    DeleteSuccess.Execute(null);
                }
            }
        }

        public void FurnitureUpdateNavDef(object parameter)
        {
            if (parameter is FurnitureVm fur)
            {
                _navigator.CurrentViewModel = new FurnitureUpdateVMUI(_ifur, fur, _navigator, _ViewModelFactory, _apartmentStore);
            }
        }


        public void UpdateData(List<FurnitureVm> data)
        {
            foreach (var furvm in data)
            {
                _fur.Add(furvm);
            }
        }

        private void Store_Add(FurnitureVm data)
        {
            _fur.Add(data);
        }

    }
}