using AM.UI.ViewModelUI;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.Command
{
    public class LoadHomeCommand : AsyncCommandBase
    {
        private readonly IHome _Ihome;
        private readonly HomeVM _homeVM;

        public LoadHomeCommand(IHome home, HomeVM homeVM)
        {
            _homeVM = homeVM;
            _Ihome = home;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _homeVM.IsLoading =true;
            await Task.WhenAll(LoadNumber(), LoadDataBase());
            _homeVM.IsLoading = false;
        }

        private async Task LoadNumber()
        {
            _homeVM.NumberOfHomeVM = await _Ihome.GetNumberOfHomeVM(_homeVM.now);
        }

        private async Task LoadDataBase()
        {
            var item = await _Ihome.GetDataBase(_homeVM.now);
            _homeVM.LoadHomeVM(item);
        }
    }
}