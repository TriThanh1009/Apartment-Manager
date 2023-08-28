using AM.UI.State;
using AM.UI.ViewModelUI;
using AM.UI.ViewModelUI.RoomDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModel.RoomDetails;

namespace AM.UI.Command.LoadDataBase
{
    public class LoadRoomDetailsView : AsyncCommandBase
    {
        private readonly RoomDetailsHomeVMUI _roomdetailhomevm;
        private readonly ApartmentStore _roomdetails;
        public int _id;

        public LoadRoomDetailsView(RoomDetailsHomeVMUI roomdetailhomevm, ApartmentStore roomdetails,int id)
        {
            _roomdetailhomevm = roomdetailhomevm;
            _roomdetails = roomdetails;
            _id = id;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _roomdetailhomevm.IsLoading = true;
            try
            {
                List<RoomDetailsImage> roomimage = new List<RoomDetailsImage>();
                 List<RoomDetailsFurniture> room = new List<RoomDetailsFurniture>();
                room = await _roomdetails.LoadRoomDetailsFurniture(_id);
                roomimage = await _roomdetails.LoadRoomDetailsImage(_id);
                _roomdetailhomevm.UpdateDataFurniture(room);
                _roomdetailhomevm.UpdateDataImage(roomimage);

            }
            catch (Exception)
            {
                _roomdetailhomevm.MessageError = "Error to Load Room Details Database";
            }
            _roomdetailhomevm.IsLoading = false;
        }
    }
}
