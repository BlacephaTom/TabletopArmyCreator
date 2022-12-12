
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

using TabletopArmyCreator.Views.Dialogs;
using TabletopArmyCreator.Interfaces.Dialogs;

using System;
using TabletopArmyCreator.Enums;

using TabletopArmyCreator.ViewModels.Dialogs;



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

                    services.AddScoped<HqTabView>();
                    services.AddScoped<IHqTabViewModel, HqTabViewModel>();

                    services.AddScoped<ITroopTabViewModel, TroopTabViewModel>();
                    services.AddScoped<TroopTabView>();

                    services.AddScoped<UserSettingsDialogView2>();
                    //services.AddScoped<IUserSettingsDialogView2, UserSettingsDialogView2>();

                    services.AddScoped<MahApps.Metro.SimpleChildWindow.ChildWindow>();
                    services.AddScoped<UserSettingsDialogViewModel>();
                    services.AddScoped<DialogViewShell>();


                    //services.AddDialog<UserSettingsDialogViewModel>();
                    

                    services.AddScoped<UserSettingsDialogView2>();

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
