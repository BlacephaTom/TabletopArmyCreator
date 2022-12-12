using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;


namespace TabletopArmyCreator.Interfaces
{
    public interface IDialogWindowBase
    {
        string ConfirmationString { get; set; }

        string CancelationString { get; set; }

        bool ShowConfirmationOnly { get; set; }

        string DialogWindowTitle { get; set; }

        ICommand ConfirmationCommand { get; set; }

        ICommand CancelCommand { get; set; }

    }
}
