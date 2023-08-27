using AM.UI.Command;
using AM.UI.Model;
using Data;
using Data.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel.People;

namespace AM.UI.State
{
    public class ApartmentStore
    {
        private readonly Apartment _apartment;
        private readonly List<CustomerVM> _customervm;
        private Lazy<Task> _initializeLazy;
        private readonly IPeople _people;
        public List<CustomerVM> customervm => _customervm;

        public event Action<int> YouTubeViewerDeleted;

        public event Action<CustomerVM> CustomerAdd;

        public event Action<CustomerVM> CustomerUpdate;

        public ApartmentStore(Apartment apartment, IPeople people)
        {
            _apartment = apartment;
            _people = people;
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

        public async Task<People> AddCustomer(PeopleCreateViewModel request)
        {
            var result = await _people.Create(request);
            CustomerVM create = new CustomerVM
            {
                ID = result.ID,
                IDroom = request.IDroom,
                Name = request.Name,
                Sex = request.Sex,
                Birthday= request.Birthday,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                IDCard = request.IDCard,
                Address = request.Address,
            };
            _customervm.Add(create);
            CustomerAdd?.Invoke(create);
            return result;
        }

        public async Task<People> UpdateCustomer(PeopleUpdateViewModel request)
        {
            var result = await _people.Edit(request.ID, request);
            CustomerVM create = new CustomerVM
            {
                ID = result.ID,
                IDroom = request.IDroom,
                Name = request.Name,
                Sex = request.Sex,
                Birthday= request.Birthday,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                IDCard = request.IDCard,
                Address = request.Address,
            };
            int currentIndex = _customervm.FindIndex(y => y.ID == create.ID);

            if (currentIndex != -1)
            {
                _customervm[currentIndex] = create;
            }
            else
            {
                _customervm.Add(create);
            }
            CustomerUpdate?.Invoke(create);
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _people.Delete(id);

            _customervm.RemoveAll(y => y.ID == id);

            YouTubeViewerDeleted?.Invoke(id);
            return result;
        }
    }
}