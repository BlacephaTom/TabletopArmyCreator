using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TabletopArmyCreator.PropertyChangedImplementation
{
    public class NotifyPropertyChangedEvents : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
