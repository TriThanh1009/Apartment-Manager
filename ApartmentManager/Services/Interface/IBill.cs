using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Bill;

namespace Services.Interface
{
    public interface IBill
    {
        Task<int> CreateBill(BillCreateViewModel model);
    }
}