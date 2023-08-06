using AM.UI.Utilities;
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
        private readonly CustomerVM _customerVM;

        public UpdateCustomerVMUI(IPeople people, CustomerVM customerVM)
        {
            _people = people;
            _customerVM = customerVM;
            MessageBox.Show(_customerVM.Name);
        }
    }
}