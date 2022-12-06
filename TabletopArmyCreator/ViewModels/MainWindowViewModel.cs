using TabletopArmyCreator.Interfaces;
using TabletopArmyCreator.PropertyChangedImplementation;
using TabletopArmyCreator.BaseClasses;
using TabletopArmyCreator.Views;

using TabletopArmyCreator.Enums;

using System.Windows.Input;

using Prism.Commands;

using TabletopArmyCreator.ServiceExtensions;
using TabletopArmyCreator.Interfaces.FactoryInterfaces;
using TabletopArmyCreator.Interfaces.TabInterfaces;
using TabletopArmyCreator.ViewModels.TabViewModels;
using Microsoft.Extensions.DependencyInjection;
using TabletopArmyCreator.Factories;

namespace TabletopArmyCreator.ViewModels
{
    public class MainWindowViewModel : MainWindowViewModelBaseClass, IMainWindowViewModel
    {
        public MainWindowViewModel(IAbstractFactory<HqTabViewModel> test)
        {
            this.MoveTabCommand = new DelegateCommand<object>(this.MoveTab);
            this.TabViewModelFactory = test;
            
        }
        

        private IAbstractFactory<HqTabViewModel> TabViewModelFactory { get; set; }

        /// <summary>
        /// Switch tab
        /// </summary>
        public ICommand MoveTabCommand { get; set; }


        private object _selectedTabView { get; set; }
        public object SelectedTabView
        {
            get { return _selectedTabView; }
            set
            {
                if(_selectedTabView != value)
                {
                    this._selectedTabView = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private void MoveTab(object tab)
        {

            switch ((UnitType)tab)
            {
                case UnitType.Hq:
                    //this.SelectedTabView = TabViewModelFactory.Create();
                    this.SelectedTabView = App.AppHost.Services.GetRequiredService<HqTabViewModel>();
                    break;
                case UnitType.Troop:
                    this.SelectedTabView = App.AppHost.Services.GetRequiredService<TroopTabViewModel>();
                    break;
            }

        }

    }
}
