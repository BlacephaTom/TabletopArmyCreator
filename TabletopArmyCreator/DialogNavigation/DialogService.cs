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
    public abstract class DialogService
    {     
        //https://mahapps.com/docs/controls/metrowindow
       
        /// <summary>
        /// Open a dialog containing 
        /// </summary>
        /// <param name="dialogView"></param>
        /// <param name="dialogTitle"></param>
        /// <returns></returns>
        public async Task OpenConfirmCancelDialogAsync(UserControl dialogView, string dialogTitle)
        {
            if (dialogView == null)
                return;

            var shell = App.AppHost.Services.GetRequiredService<DialogViewShell>();
            shell.viewPresenter.Content = dialogView;
            shell.Title = dialogTitle;
            await ChildWindowManager.ShowChildWindowAsync(App.Current.MainWindow, shell, ChildWindowManager.OverlayFillBehavior.WindowContent);
        }

        //public async Task OpenMessageDialog(IDialogWindowBase dialogView)
        //{
        //    var shell = App.AppHost.Services.GetRequiredService<DialogViewShell>();

        //    shell.DataContext = dialogView;

        //    dialogView.ShowConfirmationOnly = true;

        //    await ChildWindowManager.ShowChildWindowAsync(App.Current.MainWindow, shell, ChildWindowManager.OverlayFillBehavior.WindowContent);
        //}
    }
}
