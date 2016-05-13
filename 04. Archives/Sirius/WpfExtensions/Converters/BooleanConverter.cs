using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace WpfExtensions.Converters
{
    public class BooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool result = false;
            int intResult = 0;
            if (Int32.TryParse(value.ToString(), out intResult) || Boolean.TryParse(value.ToString(), out result))
            {
                result = result | intResult == 1;

                switch (parameter.ToString())
                {
                    case "ro":
                        return result ? "Da" : "Nu";
                    case "en":
                        return result ? "Yes" : "No";
                    default:
                        return result ? Boolean.TrueString : Boolean.FalseString;
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
