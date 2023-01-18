using System.Windows.Input;

using TabletopArmyCreator.Payloads;
using TabletopArmyCreator.Interfaces.Dialogs;
using TabletopArmyCreator.Interfaces.FactoryInterfaces;

using Prism.Commands;

using TabletopArmyCreator.PropertyChangedImplementation;
using TabletopArmyCreator.DatabaseRequests.Requests;

namespace TabletopArmyCreator.ViewModels.Dialogs
{
    public class UserSettingsDialogViewModel : NotifyPropertyChangedEvents, IUserSettingsDialogViewModel
    {
        public UserSettingsDialogViewModel()
        {
            this.CancelCommand = new DelegateCommand(this.CancelImplementation);
            this.ConfirmationCommand = new DelegateCommand(this.ConfirmationImplementation);

            this.ShowConfirmationOnly = false;

            this.RegisterOnPropertyChanged(nameof(this.Parameters),
                () =>
                {
                    this.userSettingsDialogParameters = Parameters as UserSettingsDialogParameters;
                    this.UserId = userSettingsDialogParameters.UserId;
                    this.GetUserDetails();
                });

            
        }

        private async void GetUserDetails()
        {
            if (this.UserId <= 0)
                return;

            var request = new GetUserDetailsRequest(this.UserId);

            DatabaseRequests.SqlDatasbaseInterractionService
                .SendRequestAsync(request, string.Empty);

        }

        public void CancelImplementation()
        {
        }

        public void ConfirmationImplementation()
        {

        }

        public long UserId { get; set; }

        public string Username { get; set; }

        public bool ShowConfirmationOnly { get; set; }

        /// <summary>
        /// Command called when the user click the confirmation button in the dialog
        /// </summary>
        public ICommand ConfirmationCommand { get; set; }

        /// <summary>
        /// Command called when the user click the cancellation button, 
        /// or the close button (top right X) in the dialog
        /// </summary>
        public ICommand CancelCommand { get; set; }

        private UserSettingsDialogParameters userSettingsDialogParameters { get; set; }

        private object _parameters;

        public object Parameters
        {
            get
            {
                return this._parameters;
            }
            set
            {
                if (this._parameters == value)
                    return;

                this._parameters = value;
                this.NotifyPropertyChanged();
            }
        }
    }
}
