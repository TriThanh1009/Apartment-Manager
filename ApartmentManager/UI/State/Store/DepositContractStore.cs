using AM.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.DepositsContract;

namespace AM.UI.State.Store
{
    public class DepositContractStore
    {
        private readonly Apartment _apartment;
        private readonly List<DepositsContractVm> _depositsvm;
        private Lazy<Task> _initialLazyDeposits;
        public List<DepositsContractVm> depositsvm => _depositsvm;
       public DepositContractStore(Apartment apartment)
        {        
            _apartment = apartment;
            _depositsvm = new List<DepositsContractVm>();
            _initialLazyDeposits = new Lazy<Task>(InitializeDepositsContract);
        }
        private async Task InitializeDepositsContract()
        {
            List<DepositsContractVm> deposit = await _apartment.GetAllDepositContract();
            _depositsvm.Clear();
            _depositsvm.AddRange(deposit);
        }

        public async Task LoadDepositsContract()
        {
            try
            {
                await _initialLazyDeposits.Value;
            }
            catch (Exception)
            {
                _initialLazyDeposits = new Lazy<Task>(InitializeDepositsContract);
                throw;
            }
        }
    }
}
