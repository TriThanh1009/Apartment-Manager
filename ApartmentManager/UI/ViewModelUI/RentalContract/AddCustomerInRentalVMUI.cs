using AM.UI.Command.RentalContract;
using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.View.Dialog;
using AM.UI.ViewModelUI.Factory;
using Data.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel.People;
using ViewModel.RentalContract;
using ViewModel.Room;

namespace AM.UI.ViewModelUI
{
    public class AddCustomerInRentalVMUI : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _viewModelFactory;
        private ObservableCollection<PeopleCreateViewModel> _peoples;

        public ObservableCollection<PeopleCreateViewModel> peoples
        {
            get { return _peoples; }
            set { _peoples =value; OnPropertyChanged(nameof(peoples)); }
        }

        private PeopleCreateViewModel _SelectedPeople;

        public PeopleCreateViewModel SelectedPeople
        {
            get { return _SelectedPeople; }
            set
            {
                _SelectedPeople = value;

                OnPeopleChanged(nameof(SelectedPeople));
            }
        }

        private int _IDP;

        public int IDP
        {
            get { return _IDP; }
            set
            {
                _IDP = value;
                OnPropertyChanged(nameof(IDP));
            }
        }

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

        private string _name;

        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
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
        private readonly Dictionary<string, List<string>> _propertyNameToErrorsDictionary;

        public bool HasErrors => _propertyNameToErrorsDictionary.Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public ICommand AddList { get; }
        public ICommand DeleteCustomerCommand { get; }
        public ICommand Confirm { get; }

        public AddCustomerInRentalVMUI(int IDrt, int IDpeople, INavigator navigator, IAparmentViewModelFactory viewModelFactory, RentalContractStore apartmentStore)
        {
            _peoples= new ObservableCollection<PeopleCreateViewModel>();
            _combosex = new ObservableCollection<Sex> { Sex.Male, Sex.Female };
            _IDP = IDpeople+1;
            _IDRT = IDrt;
            _navigator =navigator;
            _viewModelFactory=viewModelFactory;
            AddList = new RelayCommand(AddlistCommand);
            DeleteCustomerCommand = new RelayCommand(DeleteList);
            Confirm = new AddCustomerInRentalCommand(apartmentStore, this, navigator, viewModelFactory);
            _peoples.CollectionChanged+= ONchanged;
        }

        private void AddlistCommand(object parameter)
        {
            PeopleCreateViewModel newobject = new PeopleCreateViewModel
            {
                IDRental = IDRT,
                Name = name,
                Sex = sex,
                Birthday= birthday,
                PhoneNumber = phoneNumber,
                Email = email,
                IDCard = idcard,
                Address = address,
            };
            _peoples.Add(newobject);
        }

        private void DeleteList(object parameter)
        {
            var message = new MessageBoxCustom("Do You Wanna To Delete", MessageType.Confirmation, MessageButtons.YesNo);
            message.ShowDialog();
            if (message.DialogResult==true)
                _peoples.Remove(SelectedPeople);
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

        private void ClearErrors(string propertyName)
        {
            _propertyNameToErrorsDictionary.Remove(propertyName);

            OnErrorsChanged(propertyName);
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        private void OnPeopleChanged(string propertyName)
        {
            OnPropertyChanged(propertyName);
        }

        private void ONchanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(peoples));
        }
    }
}