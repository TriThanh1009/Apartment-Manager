using AM.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Bill;

namespace AM.UI.State.Store
{
    public class BillStore
    {
        private readonly Apartment _apartment;
        private readonly List<BillVm> _billvm;
        private Lazy<Task> _initializeLazyBill;
        public List<BillVm> billvm => _billvm;
        public BillStore()
        {
            _billvm = new List<BillVm>();
            _initializeLazyBill = new Lazy<Task>(InitializeBill);
        }
        private async Task InitializeBill()
        {
            List<BillVm> bill = await _apartment.GetAllBill();
            _billvm.Clear();
            _billvm.AddRange(bill);
        }

        public async Task LoadBill()
        {
            try
            {
                await _initializeLazyBill.Value;
            }
            catch (Exception)
            {
                _initializeLazyBill = new Lazy<Task>(InitializeBill);
                throw;
            }
        }

    }
}
