using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.DepositsContract;
using ViewModel.Dtos;
using ViewModel.People;

namespace Services.Implement
{
    public class DepositsContractServices : IDepositsContract
    {
        public Task<int> CreateDepositsContract(DepositsContractCreateViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteDepositsContract(int depositsId)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<DepositsContractVm>> GetAllPage(RequestPaging request)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateDepositsContract(DepositsContractUpdateViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
