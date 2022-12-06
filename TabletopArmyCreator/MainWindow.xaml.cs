using System.Windows;

using TabletopArmyCreator.ViewModels;
using TabletopArmyCreator.Interfaces;

using TabletopArmyCreator.Interfaces.FactoryInterfaces;

using TabletopArmyCreator.ViewModels.TabViewModels;

namespace TabletopArmyCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IMainWindowViewModel dataContext)
        {
            InitializeComponent();
            this.DataContext = dataContext;
        }
    }
}
