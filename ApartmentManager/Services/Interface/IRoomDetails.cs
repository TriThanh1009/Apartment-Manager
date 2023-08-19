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
        PagedResult<RoomDetailsVm> GetAllPage(RequestPaging request);
    }
}