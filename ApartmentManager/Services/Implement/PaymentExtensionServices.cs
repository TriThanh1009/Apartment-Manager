using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.PaymentExtension;
using ViewModel.People;

namespace Services.Implement
{
    public class PaymentExtensionServices : IPaymentExtension
    {
        public Task<int> CreatePaymentExtension(PaymentExtensionCreateViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeletePaymentExtension(int PeID)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<PaymentExtensionVm>> GetAllPage(RequestPaging request)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePaymentExtension(PaymentExtensionUpdateViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}