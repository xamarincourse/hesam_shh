using System;
using System.Globalization;
using Xamarin.Forms;

namespace Expedia
{
    class StatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (FlightStatus)value;
            switch (status)
            {
                case FlightStatus.onTime:
                    return Color.Green;
                case FlightStatus.delayed:
                    return Color.Red;
                default:
                    return Color.Black;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
