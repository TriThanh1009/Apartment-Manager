using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.People;
using ViewModel.Room;
using ViewModel.RoomDetails;
using ViewModel.RoomImage;

namespace Services.Interface
{
    public interface IRoomDetails
    {

        Task<DeleteImageViewModel> Delete(int id);

        Task<bool> CreateImage(RoomImageCreateViewModel request, string NameFile);
        Task<bool> CreateFurniture(FurnitureCreateViewModel request);

        Task<PagedResult<RoomDetailsVm>> GetAllPage(RequestPaging request);
        Task<PagedResult<RoomDetailsFurniture>> GetAllFurniture(RequestPaging request, int id);
        Task<PagedResult<RoomDetailsVm>> GetAllRoom(RequestPaging request);
        Task<PagedResult<RoomDetailsImage>> GetAllImage(RequestPaging request, int id);
    }
}