using AM.UI.Model;
using Data;
using Microsoft.Extensions.DependencyInjection;
using Services.Implement;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();
            Window window = serviceProvider.GetService<MainWindow>();
            window.Show();
            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<ApartmentDbContextFactory>();
            services.AddSingleton<IPeople, PeopleServices>();
            services.AddSingleton<PeopleModel>();
            services.AddScoped<MainWindow>();
            return services.BuildServiceProvider();
        }
    }
}