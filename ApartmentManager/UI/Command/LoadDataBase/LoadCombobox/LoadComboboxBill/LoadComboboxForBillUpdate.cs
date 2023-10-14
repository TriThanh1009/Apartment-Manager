using AM.UI.State.Store;
using AM.UI.ViewModelUI.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.RentalContract;

namespace AM.UI.Command.LoadDataBase.LoadCombobox
{
    public class LoadComboboxForBillUpdate : AsyncCommandBase
    { 
        private readonly BillUpdateVMUI _billvm;
        private readonly ComboboxStore _comboboxstore;
        public LoadComboboxForBillUpdate(BillUpdateVMUI billvm, ComboboxStore comboboxstore)
        {
            _billvm = billvm;
            _comboboxstore = comboboxstore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            List<RentalContractForCombobox> rental = new List<RentalContractForCombobox>();
            rental = await _comboboxstore.LoadRentalForCombobox();
            _billvm.LoadRentalForCombobox(rental);
        }
    }
}
