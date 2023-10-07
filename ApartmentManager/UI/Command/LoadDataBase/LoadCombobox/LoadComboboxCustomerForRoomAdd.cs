using AM.UI.State.Store;
using AM.UI.ViewModelUI.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.People;

namespace AM.UI.Command.LoadDataBase.LoadCombobox
{
    public class LoadComboboxCustomerForRoomAdd : AsyncCommandBase
    {
        private readonly RoomAddVMUI _roomaddVMUI;
        private readonly RoomStore _Store;

        public LoadComboboxCustomerForRoomAdd(RoomAddVMUI roomaddVMUI, RoomStore store)
        {
            _roomaddVMUI = roomaddVMUI;
            _Store = store;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            List<CustomerForCombobox> customer = new List<CustomerForCombobox>();
            customer = await _Store.LoadCustomerForCombobox();
            _roomaddVMUI.LoadCustomerCombobox(customer);
        }
    }
}
