using TabletopArmyCreator.BaseClasses;
using System;

using Prism.Commands;

namespace TabletopArmyCreator.ViewModels.Dialogs
{
   public class UserSettingsDialogViewModel : DialogWindowBase
   {
        public UserSettingsDialogViewModel()
        {
            this.CancelCommand = new DelegateCommand(this.CancelImplementation);
            this.ConfirmationCommand = new DelegateCommand(this.ConfirmationImplementation);
        }

        public void CancelImplementation()
        {

        }

        public void ConfirmationImplementation()
        {

        }

        public string Username { get; set; }

    }
}
