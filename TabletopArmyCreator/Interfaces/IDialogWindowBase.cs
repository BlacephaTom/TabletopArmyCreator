using System.Windows.Input;

namespace TabletopArmyCreator.Interfaces
{
    public interface IDialogWindowBase :  IBaseViewModel
    {
        bool ShowConfirmationOnly { get; set; }

        ICommand ConfirmationCommand { get; set; }

        ICommand CancelCommand { get; set; }

        object Parameters { get; set; }
    }
}
