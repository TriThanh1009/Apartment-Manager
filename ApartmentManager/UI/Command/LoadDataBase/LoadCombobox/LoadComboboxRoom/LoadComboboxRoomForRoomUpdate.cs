using AM.UI.State.Store;
using AM.UI.ViewModelUI.Room;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViewModel.People;

namespace AM.UI.Command.LoadDataBase.LoadCombobox
{
    public class LoadComboboxRoomForRoomUpdate : AsyncCommandBase
    {
        private readonly RoomUpdateVMUI _roomupdatevmui;
        private readonly RoomStore _Store;

        public LoadComboboxRoomForRoomUpdate(RoomUpdateVMUI roomupdatevmui, RoomStore Store)
        {
            _roomupdatevmui = roomupdatevmui;
            _Store = Store;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            List<CustomerForCombobox> customer = new List<CustomerForCombobox>();
            customer = await _Store.LoadCustomerForCombobox();
            _roomupdatevmui.UpdateDataCustomer(customer);
        }
    }
}