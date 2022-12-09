using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;

namespace TabletopArmyCreator.Commands
{
    public abstract class BaseCommandClass : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }
}
