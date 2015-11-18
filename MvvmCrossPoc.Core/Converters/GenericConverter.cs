using System;
using Cirrious.CrossCore.Converters;

namespace MvvmCrossPoc.Core.Converters
{
    public class GenericConverter<TFrom, TTo> : MvxValueConverter<TFrom, TTo>
    {
        private readonly Func<TFrom, TTo> convertFunction;
        private readonly Func<TTo, TFrom> convertBackFunction;

        public GenericConverter(Func<TFrom, TTo> convertFunction, Func<TTo, TFrom> convertBackFunction = null)
        {
            this.convertFunction = convertFunction;
            this.convertBackFunction = convertBackFunction;
        }

        protected override TTo Convert(TFrom value, System.Type targetType, object parameter, System.Globalization.CultureInfo cultureInfo)
        {
            var convertValue = convertFunction(value);
            return convertValue;
        }

        protected override TFrom ConvertBack(TTo value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if(convertBackFunction != null)
            {
                var convertValue = convertBackFunction(value);
                return convertValue;
            }

            return base.ConvertBack(value, targetType, parameter, culture);
        }
    }
}

