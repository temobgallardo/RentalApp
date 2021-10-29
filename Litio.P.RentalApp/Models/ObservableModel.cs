using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Litio.P.RentalApp.Models
{
    public class ObservableModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool SetProperty<T>(ref T property, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (Equals(newValue, property)) return false;

            property = newValue;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            return true;
        }
    }
}
