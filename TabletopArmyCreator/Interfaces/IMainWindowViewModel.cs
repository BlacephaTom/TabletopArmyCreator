using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;


namespace TabletopArmyCreator.Interfaces
{
    public interface IMainWindowViewModel
    {

        ICommand MoveTabCommand { get; set; }

        object SelectedTab { get; set; }

    }
}
