using System;
using System.Windows.Input;

using Microsoft.Extensions.DependencyInjection;

using TabletopArmyCreator.Interfaces.Dialogs;
using TabletopArmyCreator.DialogNavigation;
using TabletopArmyCreator.Views.Dialogs;
using TabletopArmyCreator.Payloads;

namespace TabletopArmyCreator.Commands.DialogCommands
{
    public class OpenUserSettingsDialog : DialogService, ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object param)
        {
            var dialogView = App.AppHost.Services.GetDialogViewWithDataContext<UserSettingsDialogView2, IUserSettingsDialogViewModel>(new UserSettingsDialogParameters(1));

            await this.OpenConfirmCancelDialogAsync(dialogView, "User Settings");
        }
    }
}
