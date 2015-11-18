using System;
using Cirrious.CrossCore.Converters;

namespace MvvmCrossPoc.Core.Converters
{
    public class ToUpperValueConverter : MvxValueConverter<string, string>
    {
        protected override string Convert(string value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value.ToLower();
        }

        protected override string ConvertBack(string value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value.ToUpper();
        }
    }
}