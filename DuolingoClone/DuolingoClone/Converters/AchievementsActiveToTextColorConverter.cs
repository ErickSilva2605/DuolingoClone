using System;
using System.Globalization;
using Xamarin.Forms;

namespace DuolingoClone.Converters
{
    public class AchievementsActiveToTextColorConverter : IValueConverter
    {
        private readonly Color _finishColor = Color.FromHex("#CC7700");
        private readonly Color _activeColor = Color.White;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isActive)
            {
                if (isActive)
                    return _activeColor;

                return _finishColor;
            }

            return _activeColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
