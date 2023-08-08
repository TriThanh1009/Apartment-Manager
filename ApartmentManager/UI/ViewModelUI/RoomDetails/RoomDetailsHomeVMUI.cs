using AM.UI.Utilities;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.RoomDetails;

namespace AM.UI.ViewModelUI.RoomDetails
{
    public class RoomDetailsHomeVMUI : ViewModelBase
    {
        public IRoomDetails _iroomdetails;
        private List<RoomDetailsVm> _roomdetails;
        public List<RoomDetailsVm> RoomDetails
        {
            get => _roomdetails;
            set
            {
                _roomdetails = value;
                OnPropertyChanged();
            }
        }
        public RoomDetailsHomeVMUI(IRoomDetails iroomdetails)
        {
            _iroomdetails = iroomdetails;
            RoomDetails = new List<RoomDetailsVm>();
            LoadData();
        }
        public void LoadData()
        {
            var paged = new RequestPaging { PageIndex = 1, PageSize = 10 };
            PagedResult<RoomDetailsVm> roomdetails = _iroomdetails.GetAllPage(paged);
            roomdetails.Items.ForEach(x => RoomDetails.Add(x));
        }
    }
}
