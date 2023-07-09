using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Bill;
using ViewModel.Dtos;
using ViewModel.People;

namespace Services.Implement
{
    public class BillServices : IBill
    {
        public Task<int> CreateBill(BillCreateViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteBill(int BillID)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<BillVm>> GetAllPage(RequestPaging request)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateBill(BillUpdateViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}