using System;
using System.Collections.Generic;
using System.Text;

using TabletopArmyCreator.Interfaces;

namespace TabletopArmyCreator.DialogNavigation
{
    public interface IDialogService
    {
        System.Threading.Tasks.Task OpenConfirmCancelDialogAsync(IDialogWindowBase dialogView, Action ConfirmationCommand, Action CancellationCommand);

    }
}
