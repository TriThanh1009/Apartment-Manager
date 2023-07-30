using AM.UI.ViewModelUI;
using Services.Implement;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.Room;

namespace AM.UI.Command
{
    public class LoadRoomCommand : AsyncCommandBase
    {
        private readonly RoomHomeVMUI _viewmodel;
        private readonly IRoom services = new RoomServices();
        private PagedResult<RoomVm> paged = new PagedResult<RoomVm>();
        public override Task ExecuteAsync(object parameter)
        {
            var request = new RequestPaging() { PageIndex = 1, PageSize = 10 };
            paged = services.GetAllPage(request);
            return Task.FromResult(paged);
        }
        
    }
}
