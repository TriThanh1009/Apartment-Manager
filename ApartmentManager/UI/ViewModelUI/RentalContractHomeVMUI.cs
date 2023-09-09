using AM.UI.Command;
using AM.UI.Command.LoadDataBase;
using AM.UI.State;
using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.ViewModelUI.Factory;
using Data.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel.Dtos;
using ViewModel.People;
using ViewModel.RentalContract;

namespace AM.UI.ViewModelUI
{
    public class RentalContractHomeVMUI : ViewModelBase
    {
        private readonly IRentalContract _irental;
        private ObservableCollection<RentalContractVm> _rental;
        private readonly INavigator _navigator;
        private readonly IAparmentViewModelFactory _ViewModel;
        private readonly ApartmentStore _apartmentStore;
        public IEnumerable<RentalContractVm> Rental => _rental;


        public ICommand LoadDataBase { get; }


        private bool _IsLoading;
        public bool IsLoading
        {
            get { return _IsLoading; }
            set
            {
                _IsLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public bool HasData => _rental.Any();

        private string _ErrorMessage;
        public string ErrorMessage
        {
            get { return _ErrorMessage; }
            set
            {
                _ErrorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
                OnPropertyChanged(nameof(HasMessageEroor));
            }
        }
        public bool HasMessageEroor => !string.IsNullOrEmpty(ErrorMessage);

        public RentalContractHomeVMUI(IRentalContract irental,INavigator navigator, IAparmentViewModelFactory ViewModel,ApartmentStore apartmentStore)
        {
            _irental = irental;
            _rental = new ObservableCollection<RentalContractVm>();
        }

        public void UpdateData(List<RentalContractVm> data)
        {
            foreach(var rental in data)
            {
                _rental.Add(rental);
            }
        }

        
    }
}