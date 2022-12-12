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

using TabletopArmyCreator.BaseClasses;
using TabletopArmyCreator.Interfaces;
using TabletopArmyCreator.Interfaces.Dialogs;

namespace TabletopArmyCreator.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for UserSettingsDialogView2.xaml
    /// </summary>
    public partial class UserSettingsDialogView2 : UserControl
    {
        public UserSettingsDialogView2(IDialogWindowBase dataContext)
        {
            InitializeComponent();
            this.DataContext = dataContext;
        }
    }
}
