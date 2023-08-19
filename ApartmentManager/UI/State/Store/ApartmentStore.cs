using AM.UI.Model;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.People;

namespace AM.UI.State
{
    public class ApartmentStore
    {
        private readonly Apartment _apartment;
        private readonly List<CustomerVM> _customervm;
        private Lazy<Task> _initializeLazy;
        public List<CustomerVM> customervm => _customervm;

        public ApartmentStore(Apartment apartment)
        {
            _apartment = apartment;
            _initializeLazy = new Lazy<Task>(Initialize);
            _customervm = new List<CustomerVM>();
        }

        public async Task Load()
        {
            try
            {
                await _initializeLazy.Value;
            }
            catch (Exception)
            {
                _initializeLazy = new Lazy<Task>(Initialize);
                throw;
            }
        }

        private async Task Initialize()
        {
            List<CustomerVM> customer = await _apartment.GetAllcustomer();

            _customervm.Clear();
            _customervm.AddRange(customer);
        }
    }
}