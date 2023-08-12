using AM.UI.Command;
using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Azure.Core;
using Data.Enum;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using ViewModel.People;

namespace AM.UI.ViewModelUI.Customer
{
    public class AddCustomerVMUI : ViewModelBase
    {
        private readonly IPeople _Ipeople;

        private int _IDRoom;

        public int IDRoom
        {
            get { return _IDRoom; }
            set
            {
                _IDRoom = value;
                OnPropertyChanged(nameof(IDRoom));
            }
        }

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

        private Sex _sex;

        public Sex sex
        {
            get { return _sex; }
            set
            {
                _sex = value;
                OnPropertyChanged(nameof(sex));
            }
        }

        private DateTime _birthday;

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

        public ICommand Cancel { get; }
        public ICommand Confirm { get; }
        public ICommand Succeccd { get; }

        public AddCustomerVMUI(IPeople people, INavigator navigator, IAparmentViewModelFactory factory)
        {
            _Ipeople = people;
            Cancel = new UpdateCurrentViewModelCommand(navigator, factory);
            Succeccd = new UpdateCurrentViewModelCommand(navigator, factory);
            Confirm = new RelayAsyncCommand(Addcustomer);
        }

        public async Task Addcustomer()
        {
            PeopleCreateViewModel create = new PeopleCreateViewModel
            {
                IDroom = IDRoom,
                Name = name,
                Sex = sex,
                Birthday= birthday,
                PhoneNumber = phoneNumber,
                Email = email,
                IDCard = idcard,
                Address = address,
            };
            var result = await _Ipeople.Create(create);
            if (result == null)
            {
                MessageBox.Show("Fail");
            }
            else
            {
                MessageBox.Show("Sussecd");
                Succeccd.Execute(ViewType.Customer);
            }
        }
    }
}