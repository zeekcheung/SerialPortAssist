using System;
using System.Globalization;
using Avalonia.Data.Converters;
using SerialPortAssist.Helpers;

namespace SerialPortAssist.Converters
{
    public class BytesToHexStringConverter : IValueConverter
    {
        public object? Convert(
            object? value,
            Type targetType,
            object? parameter,
            CultureInfo culture
        )
        {
            return value is byte[] bytes ? bytes.ToHexString() : null;
        }

        public object? ConvertBack(
            object? value,
            Type targetType,
            object? parameter,
            CultureInfo culture
        )
        {
            return value is string hexString ? hexString.ToBytes() : null;
        }
    }
}
