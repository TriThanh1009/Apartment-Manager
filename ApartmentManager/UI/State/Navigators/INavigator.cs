using AM.UI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.State.Navigators
{
    public enum ViewType
    {
        Home,
        Customer,
        Room,RoomAdd,RoomUpdate,
        RoomDetails,
        Furnitures,
        RentalContract,RentalContractAdd,RentalContractUpdate,
        Bill,BillAdd,BillUpdate,
        DepositContract
        
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }

        event Action StateChanged;
    }
}