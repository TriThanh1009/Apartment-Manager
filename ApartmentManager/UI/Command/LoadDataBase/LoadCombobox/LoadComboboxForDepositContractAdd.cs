using AM.UI.State.Store;
using AM.UI.ViewModelUI.DepositContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Room;

namespace AM.UI.Command.LoadDataBase.LoadCombobox
{
    public class LoadComboboxForDepositContractAdd : AsyncCommandBase
    {
        private readonly ComboboxStore _comboboxstore;
        private readonly DepositContractAddVMUI _depositvmui;

        public LoadComboboxForDepositContractAdd(ComboboxStore comboboxstore, DepositContractAddVMUI depositvmui)
        {
            _comboboxstore = comboboxstore;
            _depositvmui = depositvmui;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            List<RoomForCombobox> room = new List<RoomForCombobox>();
            room = await _comboboxstore.LoadRoomForCombobox();
            _depositvmui.UpdateDataForRoomCombobox(room);
        }
    }
}
