using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
namespace OsmanAlisarIdesse.Converters
{
    internal class ItemAppearingEventArgConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is ItemVisibilityEventArgs eventArgs))
                throw new ArgumentException("Expected TextChangedEventArgs as value", "value");
            return eventArgs.ItemIndex;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
