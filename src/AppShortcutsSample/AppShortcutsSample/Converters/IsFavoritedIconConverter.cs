using System;
using System.Globalization;
using Xamarin.Forms;

namespace AppShortcutsSample.Converters
{
    public class IsFavoritedIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Device.RuntimePlatform != Device.UWP)
                return default(FileImageSource);

            var isFavorited = System.Convert.ToBoolean(value);
            if (isFavorited)
                return ImageSource.FromFile("Favorited.png");
            else
                return ImageSource.FromFile("NotFavorited.png");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
