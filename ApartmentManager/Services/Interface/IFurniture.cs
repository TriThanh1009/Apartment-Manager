using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.People;

namespace Services.Interface
{
    public interface IFurniture
    {
        Task<int> CreateFurniture(FurnitureCreateViewModel model);
        Task<int> UpdateFurniture(FurnitureUpdateViewModel model);
        Task<int> DeleteFurniture(int FurnitureId);
        Task<PagedResult<FurnitureVm>> GetAllPage(RequestPaging request)
    }
}