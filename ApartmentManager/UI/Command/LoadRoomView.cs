using AM.UI.ViewModelUI;
using Services.Implement;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AM.UI.Command
{
    public class LoadRoomView : AsyncCommandBase
    {
        private readonly IRoom _iroom;
        private readonly RoomHomeVMUI _roomhomevm;
        public LoadRoomView(RoomHomeVMUI roomhomevm,IRoom iroom)
        {
            _iroom = iroom;
            _roomhomevm = roomhomevm;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _roomhomevm.IsLoading = true;
            await Task.WhenAll(LoadDataBase());
            _roomhomevm.IsLoading = false;
        }
        public async Task LoadDataBase()
        {
            _roomhomevm.Room = await _iroom.GetAll();
        }
    }
}
