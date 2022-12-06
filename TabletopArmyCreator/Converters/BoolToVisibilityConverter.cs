using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TabletopArmyCreator.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Value if the bool result is False. Can allow for Hidden or Collapsed
        /// </summary>
        public Visibility ValueIfFalse { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = value as bool?;

            if (!boolValue.HasValue)
                return Visibility.Hidden;

            return boolValue.Value ? Visibility.Visible : ValueIfFalse;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
