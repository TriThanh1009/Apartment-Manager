using AM.UI.Command.LoadDataBase;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Data.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ViewModel.Statistic;

namespace AM.UI.ViewModelUI.Statistics
{
    public class StatisticsHomeVMUI : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _viewModelFactory;
        private readonly StatisticsStore _StatisticsStore;

        private ObservableCollection<StatisticsVm> _Statistics;
        public ObservableCollection<StatisticsVm> Statistics => _Statistics;

        private ObservableCollection<Month> _ComboboxForMonth;
        public ObservableCollection<Month> ComboboxForMonth => _ComboboxForMonth;

        private List<StatisticTotalMoney> _totalMoneyList;

        public List<StatisticTotalMoney> TotalMoneyList => _totalMoneyList;

        public ICommand ContentButton { get; }

        public ICommand LoadDataBase { get; }

        private string _Content;

        public string Content
        {
            get { return _Content; }
            set
            {
                _Content = value;
                OnPropertyChanged(nameof(Content));
            }
        }

        public bool HasData => _Statistics.Any();
        private Month _MonthForStatistics = Month.October;

        public Month MonthForStatistics
        {
            get { return _MonthForStatistics; }

            set
            {
                _MonthForStatistics = value;
                OnPropertyChanged(nameof(MonthForStatistics));
                _Statistics.Clear();
                LoadDataBase.Execute(null);
            }
        }

        private int _TotalElectric;

        public int TotalElectric
        {
            get { return _TotalElectric; }
            set
            {
                _TotalElectric = value;
                OnPropertyChanged(nameof(TotalElectric));
            }
        }

        private int _TotalWater;

        public int TotalWater
        {
            get { return _TotalWater; }
            set
            {
                _TotalElectric = value;
                OnPropertyChanged(nameof(TotalWater));
            }
        }

        public string _MessageError;

        public string MessageError
        {
            get { return _MessageError; }
            set
            {
                _MessageError = value;
                OnPropertyChanged(nameof(MessageError));
            }
        }

        public StatisticsHomeVMUI(INavigator navigator, IAparmentViewModelFactory viewModelFactory, StatisticsStore StatisticsStore)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
            _StatisticsStore = StatisticsStore;
            GetTotal();
            _Statistics = new ObservableCollection<StatisticsVm>();
            LoadDataBase = new LoadStatisticsView(this, _StatisticsStore);
            LoadDataBase.Execute(null);
            _ComboboxForMonth = new ObservableCollection<Month>();

            foreach (Month month in Enum.GetValues(typeof(Month)))
            {
                _ComboboxForMonth.Add(month);
            }
            _Statistics.CollectionChanged += OnReservationsChanged;
        }

        public async void GetTotal()
        {
            _totalMoneyList = await _StatisticsStore.GetTotalMoney((int)_MonthForStatistics);

            _TotalElectric = _totalMoneyList.Sum(x => x.ElectricMoney);
            _TotalWater = _totalMoneyList.Sum(x => x.WaterMoney);
        }

        public void UpdateDataStatistics(List<StatisticsVm> data)
        {
            data.ForEach(x => _Statistics.Add(x));
        }

        private void OnReservationsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasData));
        }
    }
}