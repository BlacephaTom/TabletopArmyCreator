using Microsoft.Extensions.DependencyInjection;
using System;
using TabletopArmyCreator.Interfaces.FactoryInterfaces;
using TabletopArmyCreator.Factories;
using TabletopArmyCreator.Interfaces;


using Prism.Commands;

namespace TabletopArmyCreator.ServiceExtensions
{
    
    public static class AbstractFactoryServiceExtensions
    {

        public static void AddWindowFactory<TWindow>(this IServiceCollection services) where TWindow : class
        {
            services.AddTransient<TWindow>();
            services.AddSingleton<Func<TWindow>>(x => () => x.GetService<TWindow>());
            services.AddSingleton<IAbstractFactory<TWindow>, AbstractFactory<TWindow>>();
        }

        public static void AddViewModelFactory<TViewModel>(this IServiceCollection services) where TViewModel : class
        {
            services.AddTransient<TViewModel>();
            services.AddSingleton<Func<TViewModel>>(x => () => x.GetService<TViewModel>());
            services.AddSingleton<IAbstractFactory<TViewModel>, AbstractFactory<TViewModel>>();
        }

        public static void AddDialog<TDialogWindow>(this IServiceCollection services, Action confirmationAction) where TDialogWindow : BaseClasses.DialogWindowBase, IDialogWindowBase
        {
            services.AddTransient<TDialogWindow>();


            services.AddSingleton<Func<TDialogWindow>>(x => () =>

            {
                var dialogWindow = x.GetService<TDialogWindow>();
                dialogWindow.ConfirmationCommand = new DelegateCommand(confirmationAction);

                return dialogWindow;
            });


            services.AddSingleton<IAbstractFactory<TDialogWindow>, AbstractFactory<TDialogWindow>>();
        }
    }
}
