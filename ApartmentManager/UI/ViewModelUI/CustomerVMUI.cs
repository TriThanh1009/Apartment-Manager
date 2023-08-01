using AM.UI.Utilities;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public CustomerVMUI(IPeople people)
        {
            _people = people;
            test = new List<CustomerVM>();
            Load();
        }

        public async void Load()
        {
            RequestPaging a = new RequestPaging();
            a.Keyword=null;
            a.PageSize=7;
            a.PageIndex=1;
            PagedResult<CustomerVM> tes = await _people.GetAllPage(a);
            tes.Items.ForEach(x => test.Add(x));
        }
    }
}