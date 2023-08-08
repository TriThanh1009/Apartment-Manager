using AM.UI.Utilities;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.DepositsContract;
using ViewModel.Dtos;
using ViewModel.People;

namespace AM.UI.ViewModelUI.DepositContract
{
    public class DepositContractHomeVMUI : ViewModelBase
    {
        private readonly IDepositsContract _ideposit;
        private List<DepositsContractVm> _deposit;
        public List<DepositsContractVm> Deposit
        {
            get => _deposit;
            set
            {
                _deposit = value;
                OnPropertyChanged();
            }
        }
        public DepositContractHomeVMUI(IDepositsContract ideposit)
        {
            _ideposit = ideposit;
            Deposit = new List<DepositsContractVm>();
            LoadData();  
        }
        public void LoadData()
        {
            var paged = new RequestPaging { PageIndex = 1, PageSize = 10 };
            PagedResult<DepositsContractVm> d = _ideposit.GetAllPage(paged);
            d.Items.ForEach(x=> Deposit.Add(x));
        }
    }
    
}
