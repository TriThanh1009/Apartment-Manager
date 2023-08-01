using AM.UI.State.Navigators;
using AM.UI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.ViewModelUI.Factory
{
    public class AparmentViewModelFactory : IAparmentViewModelFactory
    {
        private readonly CreateViewModel<HomeVM> _createHomeVM;
        private readonly CreateViewModel<CustomerVMUI> _createCustomerVM;
        private readonly CreateViewModel<RoomHomeVMUI> _createRoomVM;

        public AparmentViewModelFactory(CreateViewModel<HomeVM> createhomeVM, CreateViewModel<CustomerVMUI> createCustomerVM, CreateViewModel<RoomHomeVMUI> createRoomVM)
        {
            _createCustomerVM = createCustomerVM;
            _createHomeVM = createhomeVM;
            _createRoomVM=createRoomVM;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Home:
                    return _createHomeVM();

                case ViewType.Customer:
                    return _createCustomerVM();

                case ViewType.Room:
                    return _createRoomVM();

                default:
                    throw new ArgumentException("The ViewType does not have a ViewModel.", "viewType");
            }
        }
    }
}