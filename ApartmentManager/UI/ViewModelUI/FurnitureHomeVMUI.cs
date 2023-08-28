using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.ViewModelUI.Factory;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.People;

namespace AM.UI.ViewModelUI
{
    public class FurnitureHomeVMUI : Utilities.ViewModelBase
    {
        private ObservableCollection<FurnitureVm> _fur;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _ViewModelFactory;
        private readonly ApartmentStore _apartmentStore;
        public IFurniture _ifur;
        public IEnumerable<FurnitureVm> Fur => _fur;

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

        public FurnitureHomeVMUI(IFurniture ifur,INavigator navigator,IAparmentViewModelFactory ViewModelFactory,ApartmentStore apartmentStore)
        {
            _ifur = ifur;
            _navigator = navigator;
            _ViewModelFactory = ViewModelFactory;
            _apartmentStore = apartmentStore;
            _fur = new ObservableCollection<FurnitureVm>();

        }
        
        public void UpdateData(List<FurnitureVm> data) {
            foreach(var furvm in data)
            {
                _fur.Add(furvm);
            }
        }
 
    }
}