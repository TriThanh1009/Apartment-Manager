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
        Customer, CustomerAdd,
        Room, RoomAdd, RoomUpdate,
        RoomDetails,
        Furnitures, FurnituresAdd, FurnitureUpdate,
        RentalContract, RentalContractAdd, RentalContractUpdate,
        Bill, BillAdd, BillUpdate,
        DepositContract,
        RoomImagesAdd
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }

        event Action StateChanged;
    }
}