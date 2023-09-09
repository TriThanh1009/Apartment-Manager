using AM.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.RentalContract;

namespace AM.UI.State.Store
{
    public class RentalContractStore
    {
        private readonly Apartment _apartment;
        private readonly List<RentalContractVm> _rentalvm;
        public List<RentalContractVm> rentalvm => _rentalvm;

        private Lazy<Task> _initialLazyRental;
        public RentalContractStore(Apartment apartment)
        {
            _apartment = apartment;
            _rentalvm = new List<RentalContractVm>();
            _initialLazyRental = new Lazy<Task>(InitializeRentalContract);
        }
        private async Task InitializeRentalContract()
        {
            List<RentalContractVm> rental = await _apartment.GetAllRentalContract();
            _rentalvm.Clear();
            _rentalvm.AddRange(rental);
        }
        public async Task LoadeRentalContract()
        {
            try
            {
                await _initialLazyRental.Value;
            }
            catch (Exception)
            {
                _initialLazyRental = new Lazy<Task>(InitializeRentalContract);
                throw;
            }
        }
    }
}
