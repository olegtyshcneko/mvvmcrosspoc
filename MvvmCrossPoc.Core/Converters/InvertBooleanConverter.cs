using System;
using Cirrious.CrossCore.Converters;

namespace MvvmCrossPoc.Core.Converters
{
    public class InvertBooleanConverter : MvxValueConverter<bool, bool>
    {
        //vm -> [converter] -> view
        protected override bool Convert(bool value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !value;
        }

        //vm <- [converter] <- view
        protected override bool ConvertBack(bool value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !value;
        }
    }
}

