using AM.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Furniture;

namespace AM.UI.State.Store
{
    public class FurnitureStore
    {
        private readonly Apartment _apartment;
        private readonly List<FurnitureVm> _furniturevm;
        private Lazy<Task> _initialLazyFurniture;
        public List<FurnitureVm> fuuniturevm => _furniturevm;
        public FurnitureStore(Apartment apartment)
        {
            _apartment = apartment;
            _furniturevm = new List<FurnitureVm>();
            _initialLazyFurniture = new Lazy<Task>(InitializeFurniture);
        }
        private async Task InitializeFurniture()
        {
            List<FurnitureVm> furniture = await _apartment.GetAllFurniture();
            _furniturevm.Clear();
            _furniturevm.AddRange(furniture);
        }

        public async Task LoadFurniture()
        {
            try
            {
                await _initialLazyFurniture.Value;
            }
            catch (Exception)
            {
                _initialLazyFurniture = new Lazy<Task>(InitializeFurniture);
                throw;
            }
        }
    }
}
