using Litio.P.RentalApp.Contracts;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace Litio.P.RentalApp.Converters
{
    public class TimeTypeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is TimeType v)) return string.Empty;

            return v.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
