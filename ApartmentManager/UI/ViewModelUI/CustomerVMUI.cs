using AM.UI.Command;
using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ViewModel.Dtos;
using ViewModel.People;

namespace AM.UI.ViewModelUI
{
    public class CustomerVMUI : ViewModelBase
    {
        private List<CustomerVM> _test;
        private readonly IPeople _people;

        public List<CustomerVM> test
        {
            get => _test;
            set
            {
                _test = value;
                OnPropertyChanged();
            }
        }

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

        private readonly INavigator _navigator;
        public ICommand UpdateNavCustomer { get; }
        public ICommand AddNavCustomer { get; }

        public ICommand LoadDatabase { get; }

        public CustomerVMUI(INavigator navigator, IPeople people, IAparmentViewModelFactory aparmentViewModelFactory)
        {
            _people = people;
            test = new List<CustomerVM>();
            UpdateNavCustomer = new RelayCommand(Test1);
            LoadDatabase = new LoadCustomerView(this, _people);
            LoadDatabase.Execute(null);
            AddNavCustomer = new UpdateCurrentViewModelCommand(navigator, aparmentViewModelFactory);
            _navigator =navigator;
        }

        private void Test1(object parameter)
        {
            if (parameter is CustomerVM person)
            {
                MessageBox.Show(person.Email);
            }
        }
    }
}