using AM.UI.Command;
using AM.UI.Command.Customer;
using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.View.Dialog;
using AM.UI.View.People;
using AM.UI.ViewModelUI.Factory;
using Data.Enum;
using Microsoft.EntityFrameworkCore.Metadata;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ViewModel.People;

namespace AM.UI.ViewModelUI.Customer
{
    public class UpdateCustomerVMUI : ViewModelBase
    {
        private readonly ApartmentStore _people;
        public string a = "";
        private CustomerVM _customerVM;
        private ObservableCollection<Sex> _combosex;

        public IEnumerable<Sex> ComboSex => _combosex;

        public CustomerVM customerVM
        {
            get { return _customerVM; }
            set
            {
                _customerVM = value;
                OnPropertyChanged(nameof(CustomerVM));
            }
        }

        public ICommand Confirm { get; }
        public ICommand Cancel { get; }
        public ICommand Succeccd { get; }

        public UpdateCustomerVMUI(ApartmentStore people, CustomerVM customer, INavigator navigator, IAparmentViewModelFactory factory)
        {
            _combosex = new ObservableCollection<Sex> { Sex.Male, Sex.Female };
            customerVM = customer;
            _people = people;
            Cancel = new UpdateCurrentViewModelCommand(navigator, factory);
            Succeccd = new UpdateCustomerCommand(this, people, navigator, factory);
            Confirm = new RelayAsyncCommand(Updatecustomer);
        }

        public async Task Updatecustomer()
        {
            bool? Confirm = new MessageBoxCustom($"Do you want to Upate customer : {customerVM.ID} ", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (Confirm == true)
            {
                Succeccd.Execute(null);
            }
        }
    }
}