using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Bill;
using ViewModel.Dtos;
using ViewModel.People;

namespace Services.Interface
{
    public interface IBill
    {
        Task<int> CreateBill(BillCreateViewModel model);
        Task<int> UpdateBill(BillUpdateViewModel model);
        Task<int> DeleteBill(int BillID);
        Task<PagedResult<BillVm>> GetAllPage(RequestPaging request)
    }
}