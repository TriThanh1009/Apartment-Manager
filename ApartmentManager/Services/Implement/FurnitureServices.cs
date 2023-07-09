using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.People;

namespace Services.Implement
{
    public class FurnitureServices : IFurniture
    {
        public Task<int> CreateFurniture(FurnitureCreateViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteFurniture(int FurnitureId)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<FurnitureVm>> GetAllPage(RequestPaging request)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateFurniture(FurnitureUpdateViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
