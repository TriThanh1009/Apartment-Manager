using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Home;
using ViewModel.People;

namespace AM.UI.State.Store
{
    public class HomeStore
    {
        private readonly List<HomeItemVM> homeItemVMs;
        private readonly IHome _Ihome;

        public event Action<HomeItemVM> HomeAdd;

        public event Action<HomeItemVM> HomeUpdate;

        public HomeStore(IHome home)
        {
            _Ihome = home;
            homeItemVMs = new List<HomeItemVM>();
        }

        public async Task<int> AutoAddBill(AutoAddHomeVM request)
        {
            var result = await _Ihome.AutoAdd(request);
            if (result.items!=null)
            {
                foreach (var itemVM in result.items)
                {
                    homeItemVMs.Add(itemVM);
                    HomeAdd?.Invoke(itemVM);
                }
            }
            return result.result;
        }

        public async Task<bool> UpdateElectric(UpdateElectricQuanlity request)
        {
            var result = await _Ihome.updateElectric(request);

            return result;
        }
    }
}