using System;
using System.Globalization;
using Xamarin.Forms;

namespace AppShortcutsSample.Converters
{
    public class IsFavoritedTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isFavourited = System.Convert.ToBoolean(value);

            if (isFavourited)
                return "Unfavorite";
            else
                return "Favourite";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
