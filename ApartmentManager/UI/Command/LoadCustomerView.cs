using AM.UI.ViewModelUI;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModel.Dtos;
using ViewModel.People;

namespace AM.UI.Command
{
    public class LoadCustomerView : AsyncCommandBase
    {
        private readonly CustomerVMUI _customer;
        private readonly IPeople _people;

        public LoadCustomerView(CustomerVMUI customer, IPeople people)
        {
            _customer=customer;
            _people=people;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _customer.IsLoading =true;
            await Task.WhenAll(LoadDatabase());
            _customer.IsLoading =false;
        }

        private async Task LoadDatabase()
        {
            RequestPaging a = new RequestPaging();
            a.Keyword=null;
            a.PageSize=7;
            a.PageIndex=1;
            //  PagedResult<CustomerVM> tes = await _people.GetAllPage(a);

            // _customer.test = tes.Items;
            _customer.test = await _people.GetAll();
        }
    }
}