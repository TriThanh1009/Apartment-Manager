using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.RentalContract;

namespace Services.Interface
{
    public interface IRentalContract
    {
        Task<int> CreateRentalContract(RentalContractCreateViewModel model);

        Task<int> UpdateRentalContract(RentalContractUpdateViewModel model);

        Task<int> DeleteRentalContract(int RcID);

        Task<PagedResult<RentalContractVm>> GetAllPage(RequestPaging request);
    }
}