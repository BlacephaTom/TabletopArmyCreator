using System;
using System.Collections.Generic;
using System.Text;

namespace TabletopArmyCreator.Interfaces
{
    public interface IDialogWindowBase
    {
        string ConfirmationString { get; set; }

        string CancelationString { get; set; }

        bool ShowConfirmationOnly { get; set; }




    }
}
