using AM.UI.Utilities;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Bill;
using ViewModel.Dtos;
using ViewModel.People;

namespace AM.UI.ViewModelUI
{
    public class BillHomeVMUI : ViewModelBase
    {
        private IBill _ibill;
        private List<BillVm> _bill;
        public List<BillVm> Bill
        {
            get => _bill;
            set
            {
                _bill = value;
                OnPropertyChanged();
            }
        }



        public BillHomeVMUI(IBill bill)
        {
            _ibill = bill;
            Bill = new List<BillVm>();
            LoadData();
        }

        public void LoadData()
        {
            var paged = new RequestPaging { PageIndex = 1, PageSize = 10 };
            PagedResult<BillVm> b = _ibill.GetAllPage(paged);
            b.Items.ForEach(x => Bill.Add(x));
        }



    }
}
