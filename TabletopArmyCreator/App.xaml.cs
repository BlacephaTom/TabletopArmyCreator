
using System.Windows;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

using TabletopArmyCreator;

using TabletopArmyCreator.Interfaces.FactoryInterfaces;
using TabletopArmyCreator.Factories;

using TabletopArmyCreator.Interfaces.TabInterfaces;
using TabletopArmyCreator.Interfaces;
using TabletopArmyCreator.ServiceExtensions;
using TabletopArmyCreator.ViewModels.TabViewModels;
using TabletopArmyCreator.ViewModels;
using TabletopArmyCreator.Views;
using System;

//Transient objects are always different; a new instance is provided to every controller and every service.

//Scoped objects are the same within a request, but different across different requests

//Singleton objects are the same for every object and every request (regardless of whether an instance is provided in ConfigureServices)

namespace TabletopArmyCreator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<MainWindow>();
                    services.AddScoped<IMainWindowViewModel, MainWindowViewModel>();
                    
                    services.AddScoped<IHqTabViewModel, HqTabViewModel>();
                    services.AddScoped<ITroopTabViewModel, TroopTabViewModel>();
                })
                .Build();
        }

        /// <summary>
        /// 
        /// </summary>
        public static IHost AppHost { get; private set; }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost.StartAsync();

            var startupWindow = AppHost.Services.GetRequiredService<MainWindow>();
            startupWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost.StopAsync();
            base.OnExit(e);
        }
    }
}
