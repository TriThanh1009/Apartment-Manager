using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.DepositsContract;
using ViewModel.Dtos;
using ViewModel.People;

namespace Services.Interface
{
    public interface IDepositsContract
    {
        Task<int> CreateDepositsContract(DepositsContractCreateViewModel model);

        Task<int> UpdateDepositsContract(DepositsContractUpdateViewModel model);

        Task<int> DeleteDepositsContract(int depositsId);

        PagedResult<DepositsContractVm> GetAllPage(RequestPaging request);
    }
}