using AM.UI.State.Store;
using AM.UI.ViewModelUI.RentalContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.People;
using ViewModel.Room;

namespace AM.UI.Command.LoadDataBase.LoadCombobox
{
    public class LoadComboxForRentalContractAdd : AsyncCommandBase
    {

        private readonly RentalContractAddVMUI _rentalvmui;
        private readonly ComboboxStore _Store;

        public LoadComboxForRentalContractAdd(RentalContractAddVMUI rentalvmui, ComboboxStore store)
        {
            _rentalvmui = rentalvmui;
            _Store = store;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            List<CustomerForCombobox> customer = new List<CustomerForCombobox>();
            List<RoomForCombobox> room = new List<RoomForCombobox>();
            customer = await _Store.LoadCustomerForCombobox();
            room = await _Store.LoadRoomForCombobox();
            _rentalvmui.UpdateDataForCustomerCombobox(customer);
            _rentalvmui.UpdateDataForRoomCombobox(room);
        }
    }
}
