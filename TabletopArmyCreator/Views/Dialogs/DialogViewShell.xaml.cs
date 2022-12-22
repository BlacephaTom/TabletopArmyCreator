using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using TabletopArmyCreator.Attributes;

namespace TabletopArmyCreator.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for DialogViewShell.xaml
    /// </summary>
    [ContainerRegistration(RegistrationName = Enums.RegistrationNames.UserSettingsDialogView)]
    public partial class DialogViewShell : MahApps.Metro.SimpleChildWindow.ChildWindow
    {
        public DialogViewShell()
        {
            InitializeComponent();
        }

        public override void EndInit()
        {
            base.EndInit();
            this.ConfirmButton.Click += (sender, e) => { this.IsOpen = false; };
            this.CancelButton.Click += (sender, e) => { this.IsOpen = false; };
        }
    }
}
