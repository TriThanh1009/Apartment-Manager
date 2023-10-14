using AM.UI.State.Store;
using AM.UI.View.Bills;
using AM.UI.ViewModelUI.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.RentalContract;

namespace AM.UI.Command.LoadDataBase.LoadCombobox
{
    public class LoadComboboxForBillAdd : AsyncCommandBase
    {
        private readonly BillAddVMUI _billvm;
        private readonly ComboboxStore _comboboxStore;

        public LoadComboboxForBillAdd(BillAddVMUI billvm, ComboboxStore comboboxStore)
        {
            _billvm = billvm;
            _comboboxStore = comboboxStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            List<RentalContractForCombobox> rental = new List<RentalContractForCombobox>();
            rental = await _comboboxStore.LoadRentalForCombobox();
            _billvm.UpdateRentalForCombobox(rental);
        }
    }
}
