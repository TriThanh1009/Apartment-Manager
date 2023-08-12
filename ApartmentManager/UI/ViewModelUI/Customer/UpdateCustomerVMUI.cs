using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Data.Enum;
using Microsoft.EntityFrameworkCore.Metadata;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModel.People;

namespace AM.UI.ViewModelUI.Customer
{
    public class UpdateCustomerVMUI : ViewModelBase
    {
        private readonly IPeople _people;
        public string a = "";
        private CustomerVM _customerVM;

        public CustomerVM customerVM
        {
            get { return _customerVM; }
            set
            {
                _customerVM = value;
                OnPropertyChanged(nameof(CustomerVM));
            }
        }

        public UpdateCustomerVMUI(IPeople people, CustomerVM customer, INavigator navigator, IAparmentViewModelFactory factory)
        {
            _people = people;
            customerVM = customer;
        }
    }
}