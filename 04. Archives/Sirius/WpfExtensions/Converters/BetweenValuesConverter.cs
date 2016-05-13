using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace WpfExtensions.Converters
{
    public class BetweenValuesConverter : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool result = false;
            string stringvalue = parameter.ToString();
            double lowvalue = 0;
            double highvalue = 0;

            if (Double.TryParse(stringvalue.Substring(0, stringvalue.IndexOf(';')), NumberStyles.Any, CultureInfo.InvariantCulture, out lowvalue)
                && Double.TryParse(stringvalue.Substring(stringvalue.IndexOf(';') + 1), NumberStyles.Any, CultureInfo.InvariantCulture, out highvalue))
            {
                result = Double.Parse(value.ToString()) >= lowvalue && Double.Parse(value.ToString()) < highvalue;
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
