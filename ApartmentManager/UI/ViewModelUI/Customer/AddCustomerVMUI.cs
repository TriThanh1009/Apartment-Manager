using AM.UI.Command;
using AM.UI.Command.LoadDataBase.LoadCombobox;
using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Azure.Core;
using Data.Enum;
using Services.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using ViewModel.People;
using ViewModel.RentalContract;

namespace AM.UI.ViewModelUI.Customer
{
    public class AddCustomerVMUI : ViewModelBase
    {
        private readonly IPeople _Ipeople;

        private int _IDRT;

        public int IDRT
        {
            get { return _IDRT; }
            set
            {
                _IDRT = value;
                OnPropertyChanged(nameof(IDRT));
            }
        }

        private ObservableCollection<Sex> _combosex;

        public IEnumerable<Sex> ComboSex => _combosex;

        private ObservableCollection<RentalContractForCombobox> _ListRT;

        public IEnumerable<RentalContractForCombobox> ListRT => _ListRT;
        private string _name;

        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
                ClearErrors(nameof(name));
                if (!Hasname)
                {
                    AddError("Name cannot empty", nameof(name));
                }
                OnPropertyChanged(nameof(name));
            }
        }

        private Sex _sex = Sex.Male;

        public Sex sex
        {
            get { return _sex; }
            set
            {
                _sex = value;
                OnPropertyChanged(nameof(sex));
            }
        }

        private DateTime _birthday = DateTime.Now;

        public DateTime birthday
        {
            get { return _birthday; }
            set
            {
                _birthday = value;
                OnPropertyChanged(nameof(birthday));
            }
        }

        private string _phoneNumber;

        public string phoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(phoneNumber));
            }
        }

        private string _email;

        public string email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(email));
            }
        }

        private string _idcard;

        public string idcard
        {
            get { return _idcard; }
            set
            {
                _idcard = value;
                OnPropertyChanged(nameof(idcard));
            }
        }

        private string _address;

        public string address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged(nameof(address));
            }
        }

        private bool Hasname => !string.IsNullOrEmpty(name);
        private bool Hasemail => !string.IsNullOrEmpty(email);
        private bool Hasphone => !string.IsNullOrEmpty(phoneNumber);
        private bool Hasidcard => !string.IsNullOrEmpty(idcard);
        private bool Hasaddress => !string.IsNullOrEmpty(address);

        public ICommand Cancel { get; }
        public ICommand Confirm { get; }
        public ICommand Succeccd { get; }
        public ICommand LoadComboboxRental { get; }

        private readonly Dictionary<string, List<string>> _propertyNameToErrorsDictionary;

        public bool HasErrors => _propertyNameToErrorsDictionary.Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public AddCustomerVMUI(IPeople people, INavigator navigator, IAparmentViewModelFactory factory, ApartmentStore apartmentStore, ComboboxStore comboboxStore)
        {
            _propertyNameToErrorsDictionary = new Dictionary<string, List<string>>();
            _ListRT =new ObservableCollection<RentalContractForCombobox>();
            _combosex = new ObservableCollection<Sex> { Sex.Male, Sex.Female };
            _Ipeople = people;
            LoadComboboxRental = new LoadComboxForRentalContractAdd(this, comboboxStore);
            LoadComboboxRental.Execute(null);
            Cancel = new UpdateCurrentViewModelCommand(navigator, factory);
            Succeccd = new AddCusomerCommand(this, apartmentStore, navigator, factory);
            Confirm = new RelayAsyncCommand(Addcustomer);
        }

        public IEnumerable GetErrors(string propertyName)
        {
            return _propertyNameToErrorsDictionary.GetValueOrDefault(propertyName, new List<string>());
        }

        private void AddError(string errorMessage, string propertyName)
        {
            if (!_propertyNameToErrorsDictionary.ContainsKey(propertyName))
            {
                _propertyNameToErrorsDictionary.Add(propertyName, new List<string>());
            }

            _propertyNameToErrorsDictionary[propertyName].Add(errorMessage);

            OnErrorsChanged(propertyName);
        }

        public async Task Addcustomer()
        {
            Succeccd.Execute(null);
        }

        public void AddCombobox(List<RentalContractForCombobox> data)
        {
            data.ForEach(x => _ListRT.Add(x));
        }

        private void ClearErrors(string propertyName)
        {
            _propertyNameToErrorsDictionary.Remove(propertyName);

            OnErrorsChanged(propertyName);
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}