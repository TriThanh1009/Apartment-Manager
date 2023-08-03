using AM.UI.State.Navigators;
using AM.UI.Utilities;
using AM.UI.ViewModelUI;
using AM.UI.ViewModelUI.Factory;
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
    public static class AddStoresHostBuilderExtensions
    {
        public static IHostBuilder AddStores(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddTransient<HomeVM>();
                services.AddTransient<CustomerVMUI>();
                services.AddTransient<RoomHomeVMUI>();
                services.AddSingleton<INavigator, Navigator>();
                services.AddSingleton<IAparmentViewModelFactory, AparmentViewModelFactory>();
                services.AddSingleton<CreateViewModel<HomeVM>>(services => () => services.GetRequiredService<HomeVM>());
                services.AddSingleton<CreateViewModel<CustomerVMUI>>(services => () => services.GetRequiredService<CustomerVMUI>());
                services.AddSingleton<CreateViewModel<RoomHomeVMUI>>(services => () => services.GetRequiredService<RoomHomeVMUI>());
                services.AddSingleton<ViewModelDelegateRenavigator<RoomHomeVMUI>>();
                services.AddSingleton<ViewModelDelegateRenavigator<HomeVM>>();
                services.AddSingleton<ViewModelDelegateRenavigator<CustomerVMUI>>();
            });

            return host;
        }
    }
}