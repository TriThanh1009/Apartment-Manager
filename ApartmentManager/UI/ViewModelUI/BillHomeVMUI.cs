using AM.UI.Command.LoadDataBase;
using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.State.Store;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Data.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel.Bill;
using ViewModel.Dtos;
using ViewModel.People;

namespace AM.UI.ViewModelUI
{
    public class BillHomeVMUI : ViewModelBase
    {
        private readonly IBill _ibill;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _ViewModelFactory;
        private readonly BillStore _apartmentStore;
        private ObservableCollection<BillVm> _bill;
        public IEnumerable<BillVm> Bill => _bill;

        public ICommand LoadDataBase { get; }

        public bool HasData => _bill.Any();

        private string _MessageError;
        public string MessageError
        {
            get { return _MessageError; }
            set
            {
                _MessageError = value;
                OnPropertyChanged(nameof(MessageError));
                OnPropertyChanged(nameof(HasMessageError));
            }
        }

        public bool _Isloading;
        public bool Isloading
        {
            get { return _Isloading; }
            set
            {
                _Isloading = value;
                OnPropertyChanged(nameof(Isloading));
            }
        }


        public bool HasMessageError => !string.IsNullOrEmpty(MessageError);

        public BillHomeVMUI(IBill ibill,INavigator navigator,IAparmentViewModelFactory ViewModelFactory, BillStore apartmentStore)
        {
            _ibill = ibill;
            _navigator = navigator;
            _ViewModelFactory = ViewModelFactory;
            _apartmentStore = apartmentStore;
            
            _bill = new ObservableCollection<BillVm>();
            LoadDataBase = new LoadBillView(this, apartmentStore);
            LoadDataBase.Execute(null);
            _bill.CollectionChanged += OnReservationsChanged;
        }
        public static BillHomeVMUI BillHomeViewModel(IBill ibill, INavigator navigator, IAparmentViewModelFactory ViewModelFactory, BillStore apartmentStore)
        {
            BillHomeVMUI bill = new BillHomeVMUI(ibill, navigator, ViewModelFactory, apartmentStore);
            bill.LoadDataBase.Execute(null);
            return bill;
        }
        public void UpdateData(List<BillVm> data)
        {
            foreach(var bill in data)
            {
                _bill.Add(bill);
            }
        }

        private void OnReservationsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasData));
        }


    }
}
