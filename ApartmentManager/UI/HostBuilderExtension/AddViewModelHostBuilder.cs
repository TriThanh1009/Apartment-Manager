using AM.UI.Utilities;
using AM.UI.ViewModelUI;
using AM.UI.ViewModelUI.DepositContract;
using AM.UI.ViewModelUI.Room;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.HostBuilderExtension
{
    public static class AddViewModelHostBuilder
    {
        public static IHostBuilder AddViewModels(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices(services =>
            {
                //   services.AddTransient((s) => CreateReservationListingViewModel(s));
                services.AddSingleton<Func<HomeVM>>((s) => () => s.GetRequiredService<HomeVM>());
                services.AddSingleton<NavigationService<HomeVM>>();
                services.AddTransient<HomeVM>();

                services.AddTransient<CustomerVMUI>();
                services.AddSingleton<Func<CustomerVMUI>>((s) => () => s.GetRequiredService<CustomerVMUI>());
                services.AddSingleton<NavigationService<CustomerVMUI>>();

                services.AddTransient<RoomHomeVMUI>();
                services.AddSingleton<Func<RoomHomeVMUI>>((s) => () => s.GetRequiredService<RoomHomeVMUI>());
                services.AddSingleton<NavigationService<RoomHomeVMUI>>();

                services.AddTransient<RoomAddVMUI>();
                services.AddSingleton<Func<RoomAddVMUI>>((s) => () => s.GetRequiredService<RoomAddVMUI>());
                services.AddSingleton<NavigationService<RoomAddVMUI>>();

                services.AddTransient<FurnitureHomeVMUI>();
                services.AddSingleton<Func<FurnitureHomeVMUI>>((s) => () => s.GetRequiredService<FurnitureHomeVMUI>());
                services.AddSingleton<NavigationService<FurnitureHomeVMUI>>();


                services.AddTransient<RoomUpdateVMUI>();
                services.AddSingleton<Func<RoomUpdateVMUI>>((s) => () => s.GetRequiredService<RoomUpdateVMUI>());
                services.AddSingleton<NavigationService<RoomUpdateVMUI>>();

                services.AddTransient<RentalContractHomeVMUI>();
                services.AddSingleton<Func<RentalContractHomeVMUI>>((s) => () => s.GetRequiredService<RentalContractHomeVMUI>());
                services.AddSingleton<NavigationService<RentalContractHomeVMUI>>();

                services.AddTransient<DepositContractHomeVMUI>();
                services.AddSingleton<Func<DepositContractHomeVMUI>>((s) => () => s.GetRequiredService<DepositContractHomeVMUI>());
                services.AddSingleton<NavigationService<DepositContractHomeVMUI>>();


                services.AddSingleton<NavigationVM>();
            });

            return hostBuilder;
        }

        /*  private static NavigationVM CreateReservationListingViewModel(IServiceProvider services)
          {
              return NavigationVM.LoadViewModel(services.GetRequiredService<Navigation>(),
                  services.GetRequiredService<NavigationService<HomeVM>>(),
                  services.GetRequiredService<NavigationService<CustomerVMUI>>(),
                  services.GetRequiredService<NavigationService<RoomHomeVMUI>>(),
                  services.GetRequiredService<NavigationService<RoomAddVMUI>>());
          }*/
    }
}