using AM.UI.Utilities;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.RentalContract;

namespace AM.UI.ViewModelUI
{
    public class RentalContractHomeVMUI : ViewModelBase
    {
        private List<RentalContractVm> _rental;
        private readonly IRentalContract _irental;

        public List<RentalContractVm> Rental
        {
            get => _rental;
            set
            {
                _rental = value;
                OnPropertyChanged();
            }
        }

        public RentalContractHomeVMUI(IRentalContract irental)
        {
            _irental = irental;
            Rental = new List<RentalContractVm>();
            LoadData();
        }

        public void LoadData()
        {
            
        }
    }
}