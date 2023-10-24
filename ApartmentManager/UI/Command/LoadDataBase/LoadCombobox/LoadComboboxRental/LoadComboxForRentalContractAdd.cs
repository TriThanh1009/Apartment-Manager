using AM.UI.State.Store;
using AM.UI.ViewModelUI.Customer;
using AM.UI.ViewModelUI.RentalContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.People;
using ViewModel.RentalContract;
using ViewModel.Room;

namespace AM.UI.Command.LoadDataBase.LoadCombobox
{
    public class LoadComboxForRentalContractAdd : AsyncCommandBase
    {
        private readonly RentalContractAddVMUI _rentalvmui;
        private readonly AddCustomerVMUI _Customervm;
        private readonly ComboboxStore _Store;
        private int flag;

        public LoadComboxForRentalContractAdd(RentalContractAddVMUI rentalvmui, ComboboxStore store)
        {
            _rentalvmui = rentalvmui;
            _Store = store;
            flag=0;
        }

        public LoadComboxForRentalContractAdd(AddCustomerVMUI rentalvmui, ComboboxStore store)
        {
            _Customervm = rentalvmui;
            _Store = store;
            flag=1;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            if (flag==0)
            {
                List<CustomerForCombobox> customer = new List<CustomerForCombobox>();
                List<RoomForCombobox> room = new List<RoomForCombobox>();
                customer = await _Store.LoadCustomerForCombobox();
                room = await _Store.LoadRoomForCombobox();
                _rentalvmui.UpdateDataForCustomerCombobox(customer);
                _rentalvmui.UpdateDataForRoomCombobox(room);
            }
            if (flag==1)
            {
                await Task.Run(ComboboxForCustomer);
            }
        }

        public async Task ComboboxForCustomer()
        {
            List<RentalContractForCombobox> requst = new List<RentalContractForCombobox>();
            requst = await _Store.LoadRentalForCombobox();
            _Customervm.AddCombobox(requst);
        }
    }
}