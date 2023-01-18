namespace TabletopArmyCreator.Interfaces.Dialogs
{
    public interface IUserSettingsDialogViewModel : IDialogWindowBase
    {
        long UserId { get; set; }

        string Username { get; set; }
    }
}
