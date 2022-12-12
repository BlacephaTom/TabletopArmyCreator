using System;
using System.Collections.Generic;
using System.Text;
using TabletopArmyCreator.Views.Dialogs;
using System.Windows.Controls;

using Microsoft.Extensions.DependencyInjection;

using MahApps.Metro.SimpleChildWindow;
using TabletopArmyCreator.Interfaces;

using Prism.Commands;

namespace TabletopArmyCreator.DialogNavigation
{
    public abstract class BaseDialogNavigation : System.Windows.Input.ICommand
    {
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

        public async void OpenDialog(IDialogWindowBase dialogView,
                                        Action ConfirmationCommand,
                                        Action CancellationCommand)
        {
            var shell = App.AppHost.Services.GetRequiredService<DialogViewShell>();

            //var shell = App.AppHost.Services.GetRequiredService<DialogViewShell>();
            shell.DataContext = dialogView;

            dialogView.ConfirmationCommand = new DelegateCommand(ConfirmationCommand);
            dialogView.CancelationString = "Cancel";
            dialogView.ConfirmationString = "OK";

            dialogView.CancelCommand = new DelegateCommand(() => { shell.IsOpen = false; } );


            shell.IsOpenChanged += (sender, e) => { CancellationCommand() ; } ;


            await ChildWindowManager.ShowChildWindowAsync(App.Current.MainWindow, shell, ChildWindowManager.OverlayFillBehavior.WindowContent);
            shell.IsOpen = false;



        }
    }
}
