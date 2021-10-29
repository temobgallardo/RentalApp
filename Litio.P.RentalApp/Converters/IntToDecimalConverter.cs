using System;
using System.Globalization;
using Xamarin.Forms;

namespace Litio.P.RentalApp.Converters
{
    public class IntToDecimalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (decimal)value;
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null) return 0;
            if (!(value is string s)) return 0;

            decimal v;
            var wasParsed = decimal.TryParse(s, out v);
            if (wasParsed) return v;

            return 0;
        }
    }
}
