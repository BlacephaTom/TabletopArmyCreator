using System;
using System.Collections.Generic;
using System.Text;
using TabletopArmyCreator.Views.Dialogs;
using System.Windows.Controls;

using Microsoft.Extensions.DependencyInjection;

using MahApps.Metro.SimpleChildWindow;
using TabletopArmyCreator.Interfaces;

using System.Threading.Tasks;

using Prism.Commands;

namespace TabletopArmyCreator.DialogNavigation
{
    public abstract class BaseDialogNavigation : System.Windows.Input.ICommand
    {
        const string DefaultConfirmationString = "Ok";
        const string DefaultCancellationString = "Cancel";

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);

        //public async void OpenDialog(ChildWindow dialog)
        //{
            
        //    //https://mahapps.com/docs/controls/metrowindow
        //    await ChildWindowManager.ShowChildWindowAsync(App.Current.MainWindow, dialog, ChildWindowManager.OverlayFillBehavior.WindowContent);
            
        //}

        public async Task OpenMessageDialog(IDialogWindowBase dialogView)
        {
            var shell = App.AppHost.Services.GetRequiredService<DialogViewShell>();

            shell.DataContext = dialogView;

            dialogView.ConfirmationString = DefaultConfirmationString;
            dialogView.ShowConfirmationOnly = true;
            dialogView.ConfirmationCommand = new DelegateCommand(() => { shell.IsOpen = false; });

            await ChildWindowManager.ShowChildWindowAsync(App.Current.MainWindow, shell, ChildWindowManager.OverlayFillBehavior.WindowContent);
        }

        public async Task OpenConfirmCancelDialogAsync(IDialogWindowBase dialogView)
        {
            if (dialogView == null)
                return;

            var shell = App.AppHost.Services.GetRequiredService<DialogViewShell>();
            shell.DataContext = dialogView;


            if (string.IsNullOrEmpty(dialogView.ConfirmationString))
                dialogView.ConfirmationString = DefaultConfirmationString;

            if (string.IsNullOrEmpty(dialogView.CancelationString))
                dialogView.CancelationString = DefaultCancellationString;
            
            await ChildWindowManager.ShowChildWindowAsync(App.Current.MainWindow, shell, ChildWindowManager.OverlayFillBehavior.WindowContent);
        }
    }
}
