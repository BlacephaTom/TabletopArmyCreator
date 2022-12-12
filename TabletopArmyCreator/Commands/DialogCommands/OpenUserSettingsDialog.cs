using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;

using Microsoft.Extensions.DependencyInjection;
using TabletopArmyCreator.ViewModels.Dialogs;

using TabletopArmyCreator.DialogNavigation;

namespace TabletopArmyCreator.Commands.DialogCommands
{
    public class OpenUserSettingsDialog : BaseDialogNavigation
    {
        public override void Execute(object param)
        {


            //Need to open the dialog from somewhere
            //this.OpenDialog(new Views.Dialogs.UserSettingsDialogView());

            var dialogView = App.AppHost.Services.GetRequiredService<UserSettingsDialogViewModel>();
            dialogView.DialogWindowTitle = "this is test";
            



            this.OpenDialog(dialogView,
                            ConfirmationCommand: () => { },
                            CancellationCommand: () => { this.TheCancelationCommand() ; }
                            );

            

        }

        public void TheCancelationCommand()
        {
            
        }
    }
}
