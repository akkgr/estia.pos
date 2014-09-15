using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace estia.pos.Helpers
{
    public class GreaterThanZeroValueConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (null == value)
            {
                return false;
            }
            int intValue = 0;
            if (value is string)
            {
                if (!Int32.TryParse((string)value, out intValue))
                {
                    return false;
                }
            }
            else if (value is int)
            {
                intValue = (int)value;
            }
            else
            {
                return false;
            }
            return intValue > 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
