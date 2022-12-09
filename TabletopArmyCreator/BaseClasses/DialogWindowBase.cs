using System;
using System.Collections.Generic;
using System.Text;

using TabletopArmyCreator.Interfaces;

namespace TabletopArmyCreator.BaseClasses
{
    public class DialogWindowBase : IDialogWindowBase
    {


        public string ConfirmationString { get; set; }

        public string CancelationString { get; set; }

        public bool ShowConfirmationOnly { get; set; }






    }
}
