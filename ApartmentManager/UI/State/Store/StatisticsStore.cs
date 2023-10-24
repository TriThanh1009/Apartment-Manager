using AM.UI.Model;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Bill;
using ViewModel.Furniture;
using ViewModel.Statistic;

namespace AM.UI.State.Store
{
    public class StatisticsStore
    {
        private readonly Apartment _Apartment;

        private readonly IStatistics _IStatistics;

        private Lazy<Task> _InitializeStatistics;

        private List<BillVm> _billVM;
        public List<BillVm> BillVM => _billVM;

        private List<StatisticsVm> _StatisticsVM;
        public List<StatisticsVm> StatisticsVM => _StatisticsVM;

        public StatisticsStore(Apartment Apartment, IStatistics IStatistics)
        {
            _Apartment = Apartment;
            _StatisticsVM = new List<StatisticsVm>();
            _IStatistics = IStatistics;
        }

        public async Task<List<StatisticsVm>> LoadStatistics(int Month)
        {
            List<StatisticsVm> statistics = await _Apartment.GetAllStaticstis(Month);
            return statistics;
        }

        public async Task<List<StatisticTotalMoney>> GetTotalMoney(int Month)
        {
            return await _IStatistics.GetElectricAndWater(Month);
            //int GetAllTotalMoney = _billVM.Where(x => x.PayDate.Month == Month).Sum(x=>x.TotalMoney);
        }
    }
}