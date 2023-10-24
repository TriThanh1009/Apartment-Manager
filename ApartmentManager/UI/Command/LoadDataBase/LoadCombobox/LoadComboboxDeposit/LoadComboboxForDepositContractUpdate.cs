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
    public class LoadComboboxForDepositContractUpdate : AsyncCommandBase
    {
        private readonly ComboboxStore _comboboxstore;
        private readonly DepositContractUpdateVMUI _depositvmui;

        public LoadComboboxForDepositContractUpdate(ComboboxStore comboboxstore, DepositContractUpdateVMUI depositvmui)
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
