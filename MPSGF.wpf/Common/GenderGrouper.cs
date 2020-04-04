using System;
using System.Globalization;
using System.Windows.Data;

namespace MPSGF.wpf.Common
{
    public class GenderGrouper : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((Gender)value) == Gender.Female ? Gender.Female : Gender.Male;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
