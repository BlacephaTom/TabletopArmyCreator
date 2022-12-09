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
        public MainWindowViewModel()
        {
            this.MoveTabCommand = new DelegateCommand<object>(this.MoveTab);
        }
    
        /// <summary>
        /// Switch tab
        /// </summary>
        public ICommand MoveTabCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object _selectedTab { get; set; }
        public object SelectedTab
        {
            get
            {

                return this._selectedTab;

            }
            set
            {
                if (_selectedTab != value)
                {
                    this._selectedTab = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private object _hqTabViewModel { get; set; }
        public object HqTabViewModel
        {
            get 
            { 
               
                    return this._hqTabViewModel;
               
            }
            set
            {
                if(_hqTabViewModel != value)
                {
                    this._hqTabViewModel = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private object _troopTabViewModel { get; set; }
        public object TroopTabViewModel
        {
            get
            {
                return this._troopTabViewModel;
            }
            set
            {
                if(this._troopTabViewModel != value)
                {
                    this._troopTabViewModel = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private void MoveTab(object tab)
        {

            switch ((UnitType)tab)
            {
                //Tab will always be null
                case UnitType.Hq:
                    this.SelectedTab = this.HqTabViewModel ?? App.AppHost.Services.GetRequiredService<HqTabView>();
                    break;
                case UnitType.Troop:
                    this.SelectedTab = this.TroopTabViewModel ?? App.AppHost.Services.GetRequiredService<TroopTabView>();
                    break;
            }

        }

    }
}
