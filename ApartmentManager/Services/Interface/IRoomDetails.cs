using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.Room;
using ViewModel.RoomDetails;

namespace Services.Interface
{
    public interface IRoomDetails
    {

        Task<bool> Delete(int id);
        Task<PagedResult<RoomDetailsVm>> GetAllPage(RequestPaging request);
        Task<PagedResult<RoomDetailsFurniture>> GetAllFurniture(RequestPaging request,int id);
        Task<PagedResult<RoomDetailsVm>> GetAllRoom(RequestPaging request);
        Task<PagedResult<RoomDetailsImage>> GetAllImage(RequestPaging request, int id);
    }
}