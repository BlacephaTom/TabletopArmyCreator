using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;

using TabletopArmyCreator.DialogNavigation;

namespace TabletopArmyCreator.Commands.DialogCommands
{
    public class OpenUserSettingsDialog : BaseDialogNavigation
    {


        public override void Execute(object param)
        {


            //Need to open the dialog from somewhere
            this.OpenDialog(new Views.Dialogs.UserSettingsDialogView());
        }
    }
}
