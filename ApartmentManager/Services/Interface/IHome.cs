using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Home;

namespace Services.Interface
{
    public interface IHome
    {
        Task<NumberOfHomeVM> GetNumberOfHomeVM(DateTime date);

        Task<List<HomeItemVM>> GetDataBase(DateTime date);

        Task<ResultAutoAddVM> AutoAdd(AutoAddHomeVM request);

        Task<bool> updateElectric(UpdateElectricQuanlity request);

        Task<Bill> updateActive(HomeItemVM request);
    }
}