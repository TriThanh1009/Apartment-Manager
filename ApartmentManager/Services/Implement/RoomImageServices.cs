using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.Room;
using ViewModel.RoomImage;

namespace Services.Implement
{
    public class RoomImageServices : IRoomImage
    {
        public Task<int> CreateRoom(RoomImageCreateViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteRoom(int ImageId)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<RoomVm>> GetAllPage(RequestPaging request)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateRoom(RoomImageUpdateViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
