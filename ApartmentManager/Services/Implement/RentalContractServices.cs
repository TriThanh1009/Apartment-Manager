using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.RentalContract;

namespace Services.Implement
{
    public class RentalContractServices : IRentalContract
    {
        public Task<int> CreateRentalContract(RentalContractCreateViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteRentalContract(int RcID)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<RentalContractVm>> GetAllPage(RequestPaging request)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateRentalContract(RentalContractUpdateViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}