using AM.UI.Model;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModel.Bill;
using ViewModel.DepositsContract;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.PaymentExtension;
using ViewModel.People;
using ViewModel.RentalContract;
using ViewModel.Room;
using ViewModel.RoomDetails;

namespace AM.UI.State
{
    public class ApartmentStore
    {
        private readonly Apartment _apartment;
        private readonly List<CustomerVM> _customervm;
        private readonly List<RoomVm> _roomvm;
        private readonly List<BillVm> _billvm;
        private readonly List<DepositsContractVm> _depositsvm;
        private readonly List<FurnitureVm> _furniturevm;
        private readonly List<PaymentExtensionVm> _paymentextensionvm;
        private readonly List<RentalContractVm> _rentalvm;
        private readonly List<RoomDetailsFurniture> _roomdetailsvmfur;

        private Lazy<Task> _initializeLazy;
        private Lazy<Task> _initializeLazyRoom;
        private Lazy<Task> _initializeLazyBill;
        private Lazy<Task> _initialLazyDeposits;
        private Lazy<Task> _initialLazyFurniture;
        private Lazy<Task> _initialLazyPayment;
        private Lazy<Task> _initialLazyRental;
        private Lazy<Task> _initialLazyRoomDetails;


        public List<CustomerVM> customervm => _customervm;
        public List<RoomVm> roomvm => _roomvm;
        public List<BillVm > billvm => _billvm;
        public List<DepositsContractVm> depositsvm => _depositsvm;
        public List<FurnitureVm> fuuniturevm => _furniturevm;
        public List<PaymentExtensionVm > paymentextensionvm => _paymentextensionvm;
        public List<RentalContractVm> rentalvm => _rentalvm;
        public List<RoomDetailsFurniture> roomdetailsvmfur => _roomdetailsvmfur;

        public ApartmentStore(Apartment apartment)
        {
            _apartment = apartment;
            _initializeLazy = new Lazy<Task>(Initialize);
            _initializeLazyRoom = new Lazy<Task>(InitializeRoom);
            _initializeLazyBill = new Lazy<Task>(InitializeBill);
            _initialLazyDeposits = new Lazy<Task>(InitializeDepositsContract);
            _initialLazyFurniture = new Lazy<Task>(InitializeFurniture);
            _initialLazyPayment = new Lazy<Task>(InitializePaymentExtension);
            _initialLazyRental = new Lazy<Task>(InitializeRentalContract);
            //_initialLazyRoomDetails = new Lazy<Task>(InitializeRoomDetails(id));
            _customervm = new List<CustomerVM>();
            _roomvm = new List<RoomVm>();
            _billvm = new List<BillVm>();
            _depositsvm = new List<DepositsContractVm>();
            _furniturevm = new List<FurnitureVm>();
            _paymentextensionvm = new List<PaymentExtensionVm>();
            _rentalvm = new List<RentalContractVm>();
            _roomdetailsvmfur = new List<RoomDetailsFurniture>();
        }

        //----------------------------------------RentalContract

        private async Task InitializeRentalContract()
        {
            List<RentalContractVm> rental = await _apartment.GetAllRentalContract();
            _rentalvm.Clear();
            _rentalvm.AddRange(rental);
        }
        public async Task LoadeRentalContract()
        {
            try
            {
                await _initialLazyRental.Value;
            }
            catch (Exception)
            {
                _initialLazyRental = new Lazy<Task>(InitializeRentalContract);
                throw;
            }
        }


        //----------------------------------------PaymentExtension

        private async Task InitializePaymentExtension()
        {
            List<PaymentExtensionVm> payment = await _apartment.GetAllPaymentExtension();
            _paymentextensionvm.Clear();
            _paymentextensionvm.AddRange(payment);
        }
        public async Task LoadPaymentExtension()
        {
            try
            {
                await _initialLazyPayment.Value;
            }
            catch (Exception)
            {
                _initialLazyPayment = new Lazy<Task>(InitializePaymentExtension);
                throw;
            }
        }


        //----------------------------------------Furniture

        private async Task InitializeFurniture()
        {
            List<FurnitureVm> furniture = await _apartment.GetAllFurniture();
            _furniturevm.Clear();
            _furniturevm.AddRange(furniture);
        }

        public async Task LoadFurniture()
        {
            try
            {
                await _initialLazyFurniture.Value;
            }
            catch (Exception)
            {
                _initialLazyFurniture = new Lazy<Task>(InitializeFurniture);
                throw;
            }
        }



        //----------------------------------------DepositsContract

        private async Task InitializeDepositsContract()
        {
            List<DepositsContractVm> deposit = await _apartment.GetAllDepositContract();
            _depositsvm.Clear();
            _depositsvm.AddRange(deposit);
        }

        public async Task LoadDepositsContract()
        {
            try
            {
                await _initialLazyDeposits.Value;
            }
            catch (Exception)
            {
                _initialLazyDeposits = new Lazy<Task>(InitializeDepositsContract);
                throw;
            }
        }




        //----------------------------------------Bill

        private async Task InitializeBill()
        {
            List<BillVm> bill = await _apartment.GetAllBill();
            _billvm.Clear();
            _billvm.AddRange(bill);
        }

        public async Task LoadBill()
        {
            try
            {
                await _initializeLazyBill.Value;
            }catch (Exception) {
                _initializeLazyBill = new Lazy<Task>(InitializeBill);
                throw;
            }
        }


        //----------------------------------------RoomDetails

        /*public async Task LoadRoomDetails(int id)
        {

                await _initialLazyRoomDetails.Value;

        }

        private async Task InitializeRoomDetails(int id)
        {
            List<RoomDetailsFurniture> roomdetails = await _apartment.GetAllRoomDetailsFurniture(_id);
            _roomdetailsvmfur.Clear();
            _roomdetailsvmfur.AddRange(roomdetails);
        }*/

        public async Task<List<RoomDetailsImage>> LoadRoomDetailsImage(int id)
        {
            List<RoomDetailsImage> roomdetailsImage = await _apartment.GetAllRoomDetailsImage(id);
            return roomdetailsImage;
        }


        public async Task<List<RoomDetailsFurniture>> LoadRoomDetailsFurniture(int id)
        {
            List<RoomDetailsFurniture> roomdetails = await _apartment.GetAllRoomDetailsFurniture(id);
            return roomdetails;
        }


        //----------------------------------------Room
        public async Task LoadRoom()
        {
            try
            {
                await _initializeLazyRoom.Value;
            }
            catch (Exception) {
                _initializeLazyRoom = new Lazy<Task> (InitializeRoom);
                throw;
            }
        }

        private async Task InitializeRoom()
        {
            List<RoomVm> room = await _apartment.GettAllRoom();
            _roomvm.Clear();
            _roomvm.AddRange(room);
        }



        //----------------------------------------Customer
        public async Task Load()
        {
            try
            {
                await _initializeLazy.Value;
            }
            catch (Exception)
            {
                _initializeLazy = new Lazy<Task>(Initialize);
                throw;
            }
        }



        private async Task Initialize()
        {
            
            List<CustomerVM> customer = await _apartment.GetAllcustomer();
            _customervm.Clear();
            _customervm.AddRange(customer);
        }
    }
}