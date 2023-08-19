using AM.UI.Command;
using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Customer;
using AM.UI.ViewModelUI.Factory;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
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
        private ObservableCollection<CustomerVM> _test;
        private readonly IPeople _people;
        private readonly IAparmentViewModelFactory _factory;
        private readonly ApartmentStore _apartmentStore;

        private string _search;
        public bool HasData => _test.Any();
        private bool _isText;

        public bool IsText
        {
            get
            {
                return _isText;
            }
            set
            {
                _isText = value;
                OnPropertyChanged(nameof(IsText));
            }
        }

        public string search
        {
            get { return _search; }
            set
            {
                _search = value;// OnPropertyChanged(nameof(search));
                ChangedString(nameof(search));
            }
        }

        public IEnumerable<CustomerVM> test => _test;

        private string _errorMessage;

        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));

                OnPropertyChanged(nameof(HasErrorMessage));
            }
        }

        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);
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

        public CustomerVMUI(INavigator navigator, IPeople people, IAparmentViewModelFactory aparmentViewModelFactory, ApartmentStore apartmentStore)
        {
            UpdateNavCustomer = new RelayCommand(Test1);
            _test = new ObservableCollection<CustomerVM>();
            _isText = true;
            LoadDatabase = new LoadCustomerView(this, apartmentStore);
            LoadDatabase.Execute(null);
            _people = people;
            _apartmentStore = apartmentStore;

            AddNavCustomer = new UpdateCurrentViewModelCommand(navigator, aparmentViewModelFactory);
            _navigator =navigator;
            _factory = aparmentViewModelFactory;
            _test.CollectionChanged += OnReservationsChanged;
        }

        public static CustomerVMUI LoadCustomerViewModel(INavigator navigator, IPeople people, IAparmentViewModelFactory aparmentViewModelFactory, ApartmentStore apartmentStore)
        {
            CustomerVMUI customer = new CustomerVMUI(navigator, people, aparmentViewModelFactory, apartmentStore);
            customer.LoadDatabase.Execute(null);
            return customer;
        }

        private void Test1(object parameter)
        {
            if (parameter is CustomerVM person)
            {
                _navigator.CurrentViewModel = new UpdateCustomerVMUI(_people, person, _navigator, _factory);
            }
        }

        private void ChangedString(string _search)
        {
            IsText =false;

            if (search.Equals(""))
            {
                if (test.Any())
                    _test.Clear();
                LoadDatabase.Execute(null);
                IsText = true;
            }
            else
            {
                if (int.TryParse(search, out int intValue))
                {
                    IsLoading = true;
                    if (_test.Any())
                        _test.Clear();
                    LoadDatabase.Execute(null);
                    ObservableCollection<CustomerVM> find = new ObservableCollection<CustomerVM>();
                    foreach (CustomerVM item in _test)
                        if (item.ID==intValue)
                            find.Add(item);
                    if (_test.Any())
                        _test.Clear();
                    foreach (CustomerVM item in find)
                    {
                        _test.Add(item);
                    }

                    IsLoading = false;
                }
                else if (test.Any()) _test.Clear();
            }
            OnPropertyChanged(nameof(search));
        }

        public void UpdateData(List<CustomerVM> data)
        {
            foreach (var item in data)
            {
                _test.Add(item);
            }
        }

        private void OnReservationsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasData));
        }
    }
}