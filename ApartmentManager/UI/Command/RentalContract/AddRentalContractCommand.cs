using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.View.Dialog;
using AM.UI.ViewModelUI.Factory;
using AM.UI.ViewModelUI.RentalContract;
using AM.UI.ViewModelUI.Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.RentalContract;

namespace AM.UI.Command.RentalContract
{
    public class AddRentalContractCommand : AsyncCommandBase
    {
        private readonly RentalContractAddVMUI _rentalvmui;
        private readonly RentalContractStore _Store;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _viewModelFactory;

        public AddRentalContractCommand(RentalContractAddVMUI rentalvmui, RentalContractStore store, INavigator navigator, IAparmentViewModelFactory viewModelFactory)
        {
            _rentalvmui = rentalvmui;
            _Store = store;
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
            _rentalvmui.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            RentalContractCreateViewModel create = new RentalContractCreateViewModel
            {
                RoomCombobox = _rentalvmui.SelectRoom,
                CustomerCombobox = _rentalvmui.SelectCustomer,
                ReceiveDate = _rentalvmui.ReceiveDate,
                CheckOutDate = _rentalvmui.CheckOutDate,
                RoomMoney = _rentalvmui.RoomMoney,
                ElectricMoney = _rentalvmui.ELectricMoney,
                WaterMoney = _rentalvmui.WaterMoney,
                ServiceMoney = _rentalvmui.ServiceMoney
            };
            var result = await _Store.CreateRentalContract(create);
            if (result != null)
            {
                new MessageBoxCustom("Add Successed", MessageType.Success, MessageButtons.Ok).ShowDialog();
                _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(ViewType.RentalContract);
            }
            else
            {
                new MessageBoxCustom("Fail", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }
        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }
    }
}
