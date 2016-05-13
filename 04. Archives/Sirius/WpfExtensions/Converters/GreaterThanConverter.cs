using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace WpfExtensions.Converters
{
    public class GreaterThanConverter : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool result = false;
            double param = 0;
            if (Double.TryParse(parameter.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out param))
            {
                result = Double.Parse(value.ToString()) > param;
            }
            else
            {
                result = Double.Parse(value.ToString()) > 0;
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
