using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace WpfExtensions.Converters
{
    public class CultureLanguageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string languageCulture = value.ToString();

            var c = CultureInfo.GetCultureInfo(languageCulture);
            if (c != null)
            {
                return c.DisplayName;
            }
            return languageCulture;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
