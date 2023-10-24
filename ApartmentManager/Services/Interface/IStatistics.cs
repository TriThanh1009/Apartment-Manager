using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.Statistic;

namespace Services.Interface
{
    public interface IStatistics
    {
        Task<PagedResult<StatisticsVm>> GetAllPage(RequestPaging request, int Month);

        Task<List<StatisticTotalMoney>> GetElectricAndWater(int Month);
    }
}