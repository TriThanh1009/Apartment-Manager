using AM.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.PaymentExtension;

namespace AM.UI.State.Store
{
    public class PaymentExtensionStore
    {
        private readonly Apartment _apartment;
        private readonly List<PaymentExtensionVm> _paymentextensionvm;
        private Lazy<Task> _initialLazyPayment;
        public List<PaymentExtensionVm> paymentextensionvm => _paymentextensionvm;
        public PaymentExtensionStore(Apartment apartment)
        {
            _apartment = apartment;
            _paymentextensionvm = new List<PaymentExtensionVm>();
            _initialLazyPayment = new Lazy<Task>(InitializePaymentExtension);
        }
        private async Task InitializePaymentExtension()
        {
            List<PaymentExtensionVm> payment = await _apartment.GetAllPaymentExtension();
            _paymentextensionvm.Clear();
            _paymentextensionvm.AddRange(payment);
        }
        public async Task LoadPaymentExtension()
        {
            try
            {
                await _initialLazyPayment.Value;
            }
            catch (Exception)
            {
                _initialLazyPayment = new Lazy<Task>(InitializePaymentExtension);
                throw;
            }
        }

    }
}
