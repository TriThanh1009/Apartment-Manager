using AM.UI.State.Store;
using AM.UI.ViewModelUI.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModel.Statistic;

namespace AM.UI.Command.LoadDataBase
{
    public class LoadStatisticsView : AsyncCommandBase
    {
        private readonly StatisticsHomeVMUI _StatisticsVM;
        private readonly StatisticsStore _StatisticsStore;

        public LoadStatisticsView(StatisticsHomeVMUI statisticsVM, StatisticsStore statisticsStore)
        {
            _StatisticsVM = statisticsVM;
            _StatisticsStore = statisticsStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                List<StatisticsVm> statistics = new List<StatisticsVm>();
                statistics = await _StatisticsStore.LoadStatistics((int)_StatisticsVM.MonthForStatistics);
                _StatisticsVM.UpdateDataStatistics(statistics);
            }
            catch (Exception)
            {
                _StatisticsVM.MessageError = "Error to load Statistics Data";
            }
        }
    }
}