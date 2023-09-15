using AM.UI.Command.Home;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.View.Dialog;
using AM.UI.ViewModelUI.Factory;
using Microsoft.IdentityModel.Tokens;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ViewModel.Home;

namespace AM.UI.ViewModelUI
{
    public class HomeBillListingViewModel : ViewModelBase
    {
        private readonly IHome _Ihome;
        private readonly HomeStore _HomeStore;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _factory;

        private ObservableCollection<HomeItemVM> _listhome;

        public IEnumerable<HomeItemVM> listhome => _listhome;

        public DateTime now
        { get { return DateTime.Now; } }

        public UpdateElectricQuanlity requestUpdate { get; set; }

        public bool HasData => _listhome.Any();

        private bool _isLoading;

        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        //Command
        public ICommand LoadDatabase { get; }

        public ICommand ActiveCommand { get; }
        public ICommand AutoAddCommand { get; }
        public ICommand EditElectric { get; }
        public ICommand ConfirmUpdate { get; }

        //Command
        public HomeBillListingViewModel(IHome ihome, HomeStore homeStore, INavigator navigator, IAparmentViewModelFactory factory)
        {
            _Ihome=ihome;
            _HomeStore=homeStore;
            _navigator=navigator;
            _factory=factory;
            _listhome = new ObservableCollection<HomeItemVM>();
            _listhome.CollectionChanged += OnReservationsChanged;
            LoadDatabase = new LoadBillListingCommand(this, homeStore);
            LoadDatabase.Execute(null);
            AutoAddCommand = new AutoAddBillCommand(this, homeStore);
            ConfirmUpdate = new EditElectricCommand(this, homeStore);
            EditElectric = new RelayCommand(EditElec);
            ActiveCommand = new RelayCommand(testthu);
            _HomeStore.HomeAdd += Store_Add;
        }

        public void LoadHomeVM(List<HomeItemVM> list)
        {
            _listhome.Clear();
            foreach (var item in list)
            {
                _listhome.Add(item);
            }
        }

        public async void testthu(object parameter)
        {
            if (parameter is HomeItemVM items)
            {
                items.IsActive = items.IsActive;
                var bill = await _Ihome.updateActive(items);
                if (bill != null)
                {
                    new MessageBoxCustom("Upadate Active Successed", MessageType.Success, MessageButtons.Ok).ShowDialog();
                    var currentIndex = _listhome.ToList().FindIndex(x => x.IsActive == items.IsActive);
                    if (currentIndex != -1)
                    {
                        _listhome[currentIndex] = items;
                    }
                    else
                    {
                        _listhome.Add(items);
                    }
                }
                else MessageBox.Show("fail");
            }
        }

        public void EditElec(object parameter)
        {
            if (parameter is HomeItemVM model)
            {
                MessageBoxCustom message = new MessageBoxCustom("", MessageType.Input, MessageButtons.YesNo);
                message.ShowDialog();
                if (!message.Input.IsNullOrEmpty())
                {
                    requestUpdate = new UpdateElectricQuanlity
                    {
                        Id = model.ID,
                        ElectricMoneyDefualt = model.ElectricMoney,
                        Quality = Convert.ToInt32(message.Input),
                        RoomMoney = model.RoomMoney,
                        WaterMoney = model.WaterMoney,
                        ServiceMoney = model.ServiceMoney,
                        Active = model.Active,
                        TotalMoney = (Convert.ToInt32(message.Input) * model.ElectricMoney)+ model.RoomMoney+ model.WaterMoney+model.ServiceMoney
                    };
                    model.ElecQuality = Convert.ToInt32(message.Input);
                    model.TotalMoney = (model.ElecQuality * model.ElectricMoney)+ model.RoomMoney+ model.WaterMoney+model.ServiceMoney;
                    ConfirmUpdate.Execute(requestUpdate);
                }
            }
        }

        private void EditElectricStore(HomeItemVM Data)
        {
            var currentIndex = _listhome.ToList().FindIndex(x => x.ID == Data.ID);

            if (currentIndex != -1)
            {
                MessageBox.Show(Data.TotalMoney.ToString());

                _listhome[currentIndex] = Data;
            }
            else
            {
                _listhome.Add(Data);
            }
        }

        private void Store_Add(HomeItemVM Data)
        {
            _listhome.Add(Data);
        }

        private void OnReservationsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasData));
        }
    }
}