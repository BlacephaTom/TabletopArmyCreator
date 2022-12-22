using System;
using System.Collections.Generic;
using System.Text;

namespace TabletopArmyCreator.Interfaces.Dialogs
{
    public interface IDialogService
    {
        System.Threading.Tasks.Task OpenConfirmCancelDialogAsync(IDialogWindowBase dialogView, Action ConfirmationCommand, Action CancellationCommand);
    }
}
