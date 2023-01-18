using Microsoft.Extensions.DependencyInjection;

using System;

using TabletopArmyCreator.Interfaces.FactoryInterfaces;
using TabletopArmyCreator.Factories;

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

        //public static void AddDialog<TName, TDialogWindow, IDialogViewModel>(this IServiceCollection services) where TDialogWindow : System.Windows.Controls.UserControl
        //    where IDialogViewModel : IDialogWindowBase
            
        //{
        //    //services.AddTransient<TName>();

        //    //services.AddSingleton<Func<TDialogWindow>>(x => () =>
        //    //{
        //    //    var dialogWindow = x.GetService<TDialogWindow>();
        //    //    return dialogWindow;
        //    //});
        //}

        //    services.AddSingleton<IAbstractFactory<TDialogWindow>, AbstractFactory<TDialogWindow>>();
        //}

        ////https://stackoverflow.com/questions/25366291/how-to-handle-dependency-injection-in-a-wpf-mvvm-application

        //public static void AddDialog2<TDialogWindow>(this IServiceCollection services, IDialogWindowBase IDialogViewModel) where TDialogWindow : System.Windows.Controls.UserControl
        //    //where IDialogViewModel : IDialogWindowBase
        //{
        //    services.AddTransient<TDialogWindow>();

        //    services.AddSingleton<Func<IDialogWindowBase, TDialogWindow>>(x => (IDialogWindowBase) =>
        //    {
        //        var dialogWindow = x.GetService<TDialogWindow>();
        //        return dialogWindow;
        //    });


        //    services.AddSingleton<IAbstractFactory<TDialogWindow>, AbstractFactory<TDialogWindow>>();
        //}

        //public static void AddDialog3<IDialogViewModel, TDialogWindow>(this IServiceCollection services) where TDialogWindow : System.Windows.Controls.UserControl
        //            where IDialogViewModel : class
        //{
        //    services.AddTransient<IDialogViewModel>();

        //    services.AddSingleton<Func<TDialogWindow>>(x => () =>
        //    {
        //        var dialogWindow = x.GetService<TDialogWindow>();
        //        return dialogWindow;
        //    });


        //    services.AddSingleton<IAbstractFactory<IDialogViewModel>, AbstractFactory<IDialogViewModel>>();
        //}
        }
}
