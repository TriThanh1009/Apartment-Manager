using AM.UI.State.Navigators;
using AM.UI.State;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.ViewModelUI.RoomDetails
{
    public class RoomDetailsAddImageVMUI : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _viewModelFactory;
        private readonly ApartmentStore _apartmentStore;

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

        private int _IDroom;
        public int IDRoom
        {
            get { return _ID; }
            set
            {
                _ID = value;
                OnPropertyChanged(nameof(IDRoom));
            }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _Url;
        public string Url
        {
            get { return _Url; }
            set
            {
                _Url = value;
                OnPropertyChanged(nameof(Url));
            }
        }


        public RoomDetailsAddImageVMUI(INavigator navigator, IAparmentViewModelFactory viewModelFactory, ApartmentStore apartmentStore)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
            _apartmentStore = apartmentStore;
        }

    }
}
