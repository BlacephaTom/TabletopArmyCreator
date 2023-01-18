using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;

namespace TabletopArmyCreator.PropertyChangedImplementation
{
    public class NotifyPropertyChangedEvents : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// NotifyPropertyChanged implementation
        /// </summary>
        /// <param name="propertyName">The Property that has changed</param>
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Register a single Property and an action to invoke when the property changes
        /// </summary>
        /// <param name="property">The Property being registered</param>
        /// <param name="action">The Action to invoke when the property is changedc</param>
        public void RegisterOnPropertyChanged(string property, Action action)
        {
            this.PropertyChanged +=
                (sender, e) =>
                {
                    if(e.PropertyName == property)
                    {
                        action.Invoke();
                    }
                };
        }

        /// <summary>
        /// Register a single Property and an array of actions to invoke when the property changes
        /// </summary>
        /// <param name="property">The Property being registered</param>
        /// <param name="actions">The actions to invoke when the property changes</param>
        public void RegisterOnPropertyChanged(string property, Action[] actions)
        {
            this.PropertyChanged +=
                (sender, e) =>
                {
                    if (e.PropertyName == property)
                    {
                        foreach (var action in actions)
                        {
                            action.Invoke();
                        }
                    }
                };
        }
    }
}
