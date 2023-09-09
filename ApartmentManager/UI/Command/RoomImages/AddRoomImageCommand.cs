using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.View.Dialog;
using AM.UI.ViewModelUI.Factory;
using AM.UI.ViewModelUI.RoomDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using ViewModel.RoomImage;

namespace AM.UI.Command.RoomImages
{
    public class AddRoomImageCommand :AsyncCommandBase
    {
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _factory;
        private readonly ApartmentStore _apartmentStore;
        private readonly RoomDetailsAddImageVMUI _roomdetailsvmui;

        public AddRoomImageCommand(RoomDetailsAddImageVMUI roomdetailsvmui, INavigator navigator, IAparmentViewModelFactory factory, ApartmentStore apartmentStore)
        {
            _roomdetailsvmui = roomdetailsvmui;
            _navigator = navigator;
            _factory = factory;
            _apartmentStore = apartmentStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            RoomImageCreateViewModel create = new RoomImageCreateViewModel
            {
                ID = _roomdetailsvmui.ID,
                IDroom = _roomdetailsvmui.IDRoom,
                Name = _roomdetailsvmui.Name,
                Url = _roomdetailsvmui.Url
            };
            var result = await _apartmentStore.CreateImage(create);
            if (result != null)
            {
                new MessageBoxCustom("Add Successed", MessageType.Success, MessageButtons.Ok).ShowDialog();
                _navigator.CurrentViewModel = _factory.CreateViewModel(ViewType.RoomDetails);
            }
            else
            {
                new MessageBoxCustom("Fail", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }
    }
}
