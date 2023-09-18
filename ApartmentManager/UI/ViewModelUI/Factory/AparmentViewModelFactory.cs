using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Customer;
using AM.UI.ViewModelUI.DepositContract;
using AM.UI.ViewModelUI.Furnitures;
using AM.UI.ViewModelUI.Room;
using AM.UI.ViewModelUI.RoomDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Bill;

namespace AM.UI.ViewModelUI.Factory
{
    public class AparmentViewModelFactory : IAparmentViewModelFactory
    {
        private readonly CreateViewModel<HomeVM> _createHomeVM;
        private readonly CreateViewModel<CustomerVMUI> _createCustomerVM;
        private readonly CreateViewModel<RoomHomeVMUI> _createRoomVM;
        private readonly CreateViewModel<RoomAddVMUI> _createRoomAddVM;
        private readonly CreateViewModel<RoomUpdateVMUI> _createRoomUpdateVM;
        private readonly CreateViewModel<RoomDetailsHomeVMUI> _createRoomDetailsVM;
        private readonly CreateViewModel<FurnitureHomeVMUI> _createFurnitureVM;
        private readonly CreateViewModel<RentalContractHomeVMUI> _createRentalContractVM;
        private readonly CreateViewModel<BillHomeVMUI> _createBillVM;
        private readonly CreateViewModel<DepositContractHomeVMUI> _createDepositContractVM;
        private readonly CreateViewModel<AddCustomerVMUI> _createAddCustomerVM;
        private readonly CreateViewModel<RoomDetailsAddImageVMUI> _createRoomDeatailsAddImageVM;
        private readonly CreateViewModel<FurnitureAddVMUI> _createFurnitureAddVM;
        private readonly CreateViewModel<FurnitureUpdateVMUI> _createFurnitureUpdateVM;

        public AparmentViewModelFactory(CreateViewModel<HomeVM> createhomeVM, CreateViewModel<CustomerVMUI> createCustomerVM,
                                        CreateViewModel<RoomHomeVMUI> createRoomVM, CreateViewModel<RoomAddVMUI> createRoomAddVM,
                                        CreateViewModel<RoomUpdateVMUI> createRoomUpdateVM, CreateViewModel<RoomDetailsHomeVMUI> createRoomDetailsVM,
                                        CreateViewModel<FurnitureHomeVMUI> createFurnitureVM, CreateViewModel<RentalContractHomeVMUI> createRentalContractVM,
                                        CreateViewModel<BillHomeVMUI> createBillVM, CreateViewModel<DepositContractHomeVMUI> createDepositContractVM,
                                        CreateViewModel<AddCustomerVMUI> createAddCustomerVM, CreateViewModel<RoomDetailsAddImageVMUI> createRoomDeatailsAddImageVM,
                                        CreateViewModel<FurnitureAddVMUI> createFurnitureAddVM, CreateViewModel<FurnitureUpdateVMUI> createFurnitureUpdateVM)
        {
            _createCustomerVM = createCustomerVM;
            _createHomeVM = createhomeVM;
            _createRoomVM = createRoomVM;
            _createRoomAddVM = createRoomAddVM;
            _createRoomUpdateVM = createRoomUpdateVM;
            _createRoomDetailsVM = createRoomDetailsVM;
            _createFurnitureVM = createFurnitureVM;
            _createRentalContractVM = createRentalContractVM;
            _createBillVM = createBillVM;
            _createDepositContractVM = createDepositContractVM;
            _createAddCustomerVM = createAddCustomerVM;
            _createRoomDeatailsAddImageVM = createRoomDeatailsAddImageVM;
            _createFurnitureAddVM = createFurnitureAddVM;
            _createFurnitureUpdateVM = createFurnitureUpdateVM;
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

                case ViewType.RoomAdd:
                    return _createRoomAddVM();

                case ViewType.RoomUpdate:
                    return _createRoomUpdateVM();

                case ViewType.RoomDetails:
                    return _createRoomDetailsVM();

                case ViewType.Furnitures:
                    return _createFurnitureVM();

                case ViewType.RentalContract:
                    return _createRentalContractVM();

                case ViewType.Bill:
                    return _createBillVM();

                case ViewType.DepositContract:
                    return _createDepositContractVM();

                case ViewType.CustomerAdd:
                    return _createAddCustomerVM();

                case ViewType.RoomImagesAdd:
                    return _createRoomDeatailsAddImageVM();

                case ViewType.FurnituresAdd:
                    return _createFurnitureAddVM();

                case ViewType.FurnitureUpdate:
                    return _createFurnitureUpdateVM();
                default:
                    throw new ArgumentException("The ViewType does not have a ViewModel.", "viewType");
            }
        }
    }
}