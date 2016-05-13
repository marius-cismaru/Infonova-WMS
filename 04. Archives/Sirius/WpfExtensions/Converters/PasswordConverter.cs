using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
//using Matcap.Infrastructure.Attributes;
//using Matcap.Infrastructure.Services;
//using Matcap.Infrastructure.BaseClasses;
//using Microsoft.Practices.Unity;
using System.Windows;

namespace WpfExtensions.Converters
{
    public class PasswordConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //var container = Application.Current.Resources["Unity"] as UnityContainer;
            //var loginSvc = container.Resolve<ILoginSvc>();

            //return loginSvc.CanSeePasswords ? value : "********";
            return "********";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
