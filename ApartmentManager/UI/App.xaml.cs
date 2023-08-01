using AM.UI.Model;
using AM.UI.Utilities;
using Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Implement;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;
using System.Windows;
using AM.UI.ViewModelUI;
using AM.UI.HostBuilderExtension;
using Microsoft.EntityFrameworkCore;

namespace AM.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .AddStores()
                .AddViewModels()
                .AddDbContext()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddSingleton<Navigation>();
                   services.AddSingleton(s => new MainWindow()
                   {
                       DataContext = s.GetRequiredService<NavigationVM>()
                   });
               }).Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();
            ApartmentDbContextFactory contextFactory = _host.Services.GetRequiredService<ApartmentDbContextFactory>();
            using (AparmentDbContext context = contextFactory.CreateDbContext())
            {
                context.Database.Migrate();
            }
            // NavigationService<HomeVM> navigationService = _host.Services.GetRequiredService<NavigationService<HomeVM>>();
            // navigationService.Navigate();
            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}