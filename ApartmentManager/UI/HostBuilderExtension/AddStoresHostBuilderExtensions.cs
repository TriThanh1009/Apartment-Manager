using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.View.RoomDetails;
using AM.UI.ViewModelUI;
using AM.UI.ViewModelUI.DepositContract;
using AM.UI.ViewModelUI.Factory;
using AM.UI.ViewModelUI.Room;
using AM.UI.ViewModelUI.RoomDetails;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.HostBuilderExtension
{
    public static class AddStoresHostBuilderExtensions
    {
        public static IHostBuilder AddStores(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddTransient<HomeVM>();
                services.AddTransient<CustomerVMUI>();
                services.AddTransient<RoomHomeVMUI>();
                services.AddTransient<RoomAddVMUI>();
                services.AddTransient<RoomUpdateVMUI>();
                services.AddTransient<RoomDetailsHomeVMUI>();
                services.AddTransient<FurnitureHomeVMUI>();
                services.AddTransient<RentalContractHomeVMUI>();
                services.AddTransient<BillHomeVMUI>();
                services.AddTransient<DepositContractHomeVMUI>();


                services.AddSingleton<INavigator, Navigator>();
                services.AddSingleton<IAparmentViewModelFactory, AparmentViewModelFactory>();
                services.AddSingleton<CreateViewModel<HomeVM>>(services => () => services.GetRequiredService<HomeVM>());
                services.AddSingleton<CreateViewModel<CustomerVMUI>>(services => () => services.GetRequiredService<CustomerVMUI>());
                services.AddSingleton<CreateViewModel<RoomHomeVMUI>>(services => () => services.GetRequiredService<RoomHomeVMUI>());
                services.AddSingleton<CreateViewModel<RoomAddVMUI>>(services => () => services.GetRequiredService<RoomAddVMUI>());
                services.AddSingleton<CreateViewModel<RoomUpdateVMUI>>(services => () => services.GetRequiredService<RoomUpdateVMUI>());
                services.AddSingleton<CreateViewModel<RoomDetailsHomeVMUI>>(services => () => services.GetRequiredService<RoomDetailsHomeVMUI>());
                services.AddSingleton<CreateViewModel<FurnitureHomeVMUI>>(services => () => services.GetRequiredService<FurnitureHomeVMUI>());
                services.AddSingleton<CreateViewModel<RentalContractHomeVMUI>>(services => () => services.GetRequiredService<RentalContractHomeVMUI>());
                services.AddSingleton<CreateViewModel<BillHomeVMUI>>(services => () => services.GetRequiredService<BillHomeVMUI>());
                services.AddSingleton<CreateViewModel<DepositContractHomeVMUI>>(services => () => services.GetRequiredService<DepositContractHomeVMUI>());


                services.AddSingleton<ViewModelDelegateRenavigator<RoomHomeVMUI>>();
                services.AddSingleton<ViewModelDelegateRenavigator<HomeVM>>();
                services.AddSingleton<ViewModelDelegateRenavigator<CustomerVMUI>>();
                services.AddSingleton<ViewModelDelegateRenavigator<RoomAddVMUI>>();
                services.AddSingleton<ViewModelDelegateRenavigator<RoomUpdateVMUI>>();
                services.AddSingleton<ViewModelDelegateRenavigator<RoomDetailsHomeVMUI>>();
                services.AddSingleton<ViewModelDelegateRenavigator<FurnitureHomeVMUI>>();
                services.AddSingleton<ViewModelDelegateRenavigator<RentalContractHomeVMUI>>();
                services.AddSingleton<ViewModelDelegateRenavigator<BillHomeVMUI>>();
                services.AddSingleton<ViewModelDelegateRenavigator<DepositContractHomeVMUI>>();
            });

            return host;
        }
    }
}