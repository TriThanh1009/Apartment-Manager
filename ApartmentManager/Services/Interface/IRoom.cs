using Data.Entity;
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
    public interface IRoom
    {
        PagedResult<RoomVm> GetAllPage(RequestPaging request);

        Task<List<RoomVm>> GetAll();

        Task<Room> Create(RoomCreateViewModel model);

        Task<Room> Update(int id, RoomUpdateViewModel model);

        Task<bool> Delete(int id);

        Task<Room> GetById(int id);


    }
}