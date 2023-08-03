using AM.UI.Command;
using AM.UI.Utilities;
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
        public ICommand RoomAddNavCommand { get; }

        public ICommand FurnitureNavCommand;

        public List<RoomVm> Room
        {
            get => _room;
            set { _room = value;
                OnPropertyChanged();
            }
        }

        public RoomHomeVMUI(NavigationService<RoomAddVMUI> services)
        {
            
            RoomAddNavCommand = new NavigateCommand<RoomAddVMUI>(services);
            //_iroom = iroom;
            // Room = new List<RoomVm>();

            //LoadData();
        }


        public async void LoadData()
        {
            var paged = new RequestPaging { PageIndex = 1, PageSize = 10 };
            PagedResult<RoomVm> r = _iroom.GetAllPage(paged);
            r.Items.ForEach(x => Room.Add(x));
        }
    }
}
