using AM.UI.ViewModelUI;
using Services.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.Command.LoadDataBase
{
    public class LoadRentalContractView : AsyncCommandBase
    {
        private readonly RentalContractHomeVMUI _rentalcontracthome;
        private readonly RentalContractServices _irental;
        public LoadRentalContractView(RentalContractHomeVMUI rentalcontracthome, RentalContractServices irental)
        {
            _rentalcontracthome = rentalcontracthome;
            _irental = irental;
        }
        public override Task ExecuteAsync(object parameter)
        {
            throw new NotImplementedException();
        }
        public void LoadDataBase()
        {
            throw new NotImplementedException();
        }
    }
}
