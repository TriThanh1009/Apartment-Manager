using AM.UI.Command;
using AM.UI.Command.Home;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using Data.Enum;
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
using ViewModel.People;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using ViewModel.Room;
using AM.UI.View.Dialog;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using MaterialDesignThemes.Wpf;
using Microsoft.IdentityModel.Abstractions;
using AM.UI.ViewModelUI.Factory;
using AM.UI.ViewModelUI.Homes;

namespace AM.UI.ViewModelUI
{
    public class HomeVM : ViewModelBase
    {
        //readonly
        private readonly INavigator _navigator;

        private readonly IAparmentViewModelFactory _factory;
        private readonly IHome _Ihome;
        private readonly HomeStore _HomeStore;
        public ViewModelBase CurrentHomeViewModel { get; set; }
        //readonly

        //object
        public DateTime now
        { get { return DateTime.Now; } }

        //object
        //command

        public ICommand Loaddata { get; }
        public ICommand ViewDetailCustomer { get; }

        //command
        //viewmodel
        private NumberOfHomeVM _NumberOfHomeVM;

        public NumberOfHomeVM NumberOfHomeVM
        {
            get { return _NumberOfHomeVM; }
            set
            {
                _NumberOfHomeVM = value;
                OnPropertyChanged(nameof(NumberOfHomeVM));
            }
        }

        //viewmodel

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

        public bool IsConfirm { get; set; }

        public HomeVM(INavigator navigator, IHome home, HomeStore homeStore, IAparmentViewModelFactory aparmentViewModelFactory)
        {
            _HomeStore = homeStore;
            _navigator = navigator;
            _Ihome = home;
            _factory = aparmentViewModelFactory;
            Loaddata = new LoadHomeCommand(home, this);
            CurrentHomeViewModel = new HomeBillListingViewModel(home, homeStore, navigator, aparmentViewModelFactory);
            ViewDetailCustomer = new RelayCommand(ConfirmViewDetailCustomerCommand);
            Loaddata.Execute(null);
        }

        public void ConfirmViewDetailCustomerCommand(object sender)
        {
            _navigator.CurrentViewModel = new HomeViewDetailCustomerVMUI(_HomeStore, _navigator, _factory);
        }
    }
}