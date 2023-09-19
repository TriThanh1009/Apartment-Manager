using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.ViewModelUI.Factory;
using AM.UI.ViewModelUI.RoomDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.Command.RoomFurniture
{
    public class AddRoomFurnitureCommand : AsyncCommandBase
    {
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _factory;
        private readonly RoomStore _apartmentStore;
        private readonly RoomDetailsAddFurnitureVMUI _roomdetailsvmui;

        public AddRoomFurnitureCommand(INavigator navigator, IAparmentViewModelFactory factory, RoomStore apartmentStore, RoomDetailsAddFurnitureVMUI roomdetailsvmui)
        {
            _navigator = navigator;
            _factory = factory;
            _apartmentStore = apartmentStore;
            _roomdetailsvmui = roomdetailsvmui;
        }

        public override Task ExecuteAsync(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}