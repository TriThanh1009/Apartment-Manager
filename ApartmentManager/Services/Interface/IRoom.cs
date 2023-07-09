using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.Room;
using ViewModel.RoomImage;

namespace Services.Interface
{
    public interface IRoomImage
    {
        Task<int> CreateRoom(RoomImageCreateViewModel model);

        Task<int> UpdateRoom(RoomImageUpdateViewModel model);

        Task<int> DeleteRoom(int ImageId);

        Task<PagedResult<RoomVm>> GetAllPage(RequestPaging request);
    }
}