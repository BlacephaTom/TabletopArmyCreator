using System;
using System.Collections.Generic;
using System.Text;

using MahApps.Metro.SimpleChildWindow;

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

        public async void OpenDialog(ChildWindow dialog)
        {
            //https://mahapps.com/docs/controls/metrowindow
            await ChildWindowManager.ShowChildWindowAsync(App.Current.MainWindow, dialog);
            
        }
    }
}
